﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Mathador
{
    //LaunchDatabase() - void
    //CreateANewUser(string username, string password) - void
    //CheckIfUserAlreadyExists(string username) - bool
    //CheckIfPasswordMatches(string username, string password) - bool
    //GetData(string username) - dictionary(minScore, maxScore, totalScorePoints, totalGameTimeInSeconds, gameCount, roundCount, mathadorCount, addCount, subCount, multCount, divCount)
    //UpdateData(string username, dictionary(gameScore, gameTime, roundCount, mathadorCount, addCount, subCount, multCount, divCount))

    public class SQLiteDatabase
    {

        private SQLiteConnection connexion = new SQLiteConnection("Data Source=db.sqlite;Version=3;");

        //Crée le fichier s'il n'existe pas et génère la table si elle n'existe pas
        public void LaunchDatabase()
        {
            if (!File.Exists("db.sqlite"))
            {
                SQLiteConnection.CreateFile("db.sqlite");
            }
            connexion.Open();
            string sql = "create table if not exists users (username text, password text, minScore int, maxScore int, totalScorePoints int, totalGameTimeInSeconds int, gameCount int, roundCount int, mathadorCount int, addCount int, subCount int, multCount int, divCount int)";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            commande.ExecuteNonQuery();
            sql = "create table if not exists scores (username text, score int)";
            commande = new SQLiteCommand(sql, connexion);
            commande.ExecuteNonQuery();
            connexion.Close();
            return;
        }

        //Insert un nouvel utilisateur
        public void CreateANewUser(string username, string password)
        {
            connexion.Open();
            string sql = "insert into users values ('" + username + "', '" + password + "', 0, 0 ,0 ,0 ,0, 0, 0, 0, 0, 0, 0)";
            SQLiteCommand commandInsert = new SQLiteCommand(sql, connexion);
            commandInsert.ExecuteNonQuery();
            connexion.Close();
            return;
        }

        //Vérifie si l'utilisateur existe déjà - Retourne true si c'est le cas
        public bool CheckIfUserAlreadyExists(string username)
        {
            connexion.Open();
            bool userExistBool;
            string sql = "SELECT username FROM users WHERE username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            int userExist = Convert.ToInt32(commande.ExecuteScalar());
            if (userExist > 0) {
                Console.WriteLine("Utilisateur existant");
                userExistBool = true;
            }
            else
            {
                Console.WriteLine("L'utilisateur n'existe pas");
                userExistBool = false;
            }
            connexion.Close();
            return userExistBool;
        }

        //Vérifie si le mdp correspond
        public bool CheckIfPasswordMatch(string username, string password)
        {
            connexion.Open();
            string sql = "SELECT password FROM users WHERE username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                if (reader["password"].ToString() == password)
                {
                    Console.WriteLine("Le mot de passe correspond");
                    connexion.Close();
                    return true;
                }
            }
            Console.WriteLine("Le mot de passe ne correspond pas");
            connexion.Close();
            return false;
        }

        //Récupère toutes les données statistiques d'un utilisateur
        public Dictionary<string, int> GetData(string username)
        {
            Dictionary<string, int> userData = new Dictionary<string, int>();

            connexion.Open();
            string sql = "SELECT * FROM users WHERE username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                //subCount int, multCount int, divCount int)";
                userData.Add("minScore", reader.GetInt32(2));
                userData.Add("maxScore", reader.GetInt32(3));
                userData.Add("totalScorePoints", reader.GetInt32(4));
                userData.Add("totalGameTimeInSeconds", reader.GetInt32(5));
                userData.Add("gameCount", reader.GetInt32(6));
                userData.Add("roundCount", reader.GetInt32(7));
                userData.Add("mathadorCount", reader.GetInt32(8));
                userData.Add("addCount", reader.GetInt32(9));
                userData.Add("subCount", reader.GetInt32(10));
                userData.Add("multCount", reader.GetInt32(11));
                userData.Add("divCount", reader.GetInt32(12));
            }
            connexion.Close();
            return userData;
        }

        //Incrémente la data d'un utilisateur (update) à la fin d'une partie
        public void UpdateData(string username, Dictionary<string, int> gameData)
        {
            Dictionary<string, int> dataFromDatabase = GetData(username);

            connexion.Open();
            string sql;

            if (dataFromDatabase["gameCount"] == 0)
            {
                sql = "UPDATE users SET minScore = " + gameData["gameScore"] + ", maxScore = " + gameData["gameScore"] + ",  totalScorePoints = " + gameData["gameScore"] + ", totalGameTimeInSeconds = " + gameData["gameTime"] + ", gameCount = 1, roundCount = " + gameData["roundCount"] + ", mathadorCount = " + gameData["mathadorCount"] + ", addCount = " + gameData["addCount"] + ", subCount = " + gameData["subCount"] + ", multCount = " + gameData["multCount"] + ", divCount = " + gameData["divCount"] + " WHERE username = '" + username + "'";
            }
            else
            {
                int minScore = (dataFromDatabase["minScore"] > gameData["gameScore"] ? gameData["gameScore"] : dataFromDatabase["minScore"]);
                int maxScore = (dataFromDatabase["maxScore"] < gameData["gameScore"] ? gameData["gameScore"] : dataFromDatabase["maxScore"]);
                sql = "UPDATE users SET minScore = " + minScore + ", maxScore = " + maxScore + ", totalScorePoints = totalScorePoints + " + gameData["gameScore"] + ", totalGameTimeInSeconds = totalGameTimeInSeconds + " + gameData["gameTime"] + ", gameCount = gameCount + 1, roundCount = roundCount + " + gameData["roundCount"] + ", mathadorCount = mathadorCount + " + gameData["mathadorCount"] + ", addCount = addCount + " + gameData["addCount"] + ", subCount = subCount + " + gameData["subCount"] + ", multCount = multCount + " + gameData["multCount"] + ", divCount = divCount + " + gameData["divCount"] + " WHERE username = '" + username + "'";
            }

            SQLiteCommand commandUpdate = new SQLiteCommand(sql, connexion);
            commandUpdate.ExecuteNonQuery();
            connexion.Close();
            return;
        }

        //Ajoute le score de fin de partie au tableau des scores
        public void AddScore(string username, int score)
        {
            connexion.Open();
            string sql = "insert into scores values ('" + username + "', " + score + ")";
            SQLiteCommand commandInsert = new SQLiteCommand(sql, connexion);
            commandInsert.ExecuteNonQuery();
            connexion.Close();
            return;
        }

        //Lis le tableau des scores et récupère le top 10
        public List<ScorePair> ReadScoreTable()
        {
            List<ScorePair> listOfScores = new List<ScorePair>();
            connexion.Open();
            string sql = "SELECT * FROM scores ORDER BY score DESC LIMIT 10";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                ScorePair scoreTemp = new ScorePair();
                scoreTemp.score = Convert.ToInt32(reader["score"]);
                scoreTemp.username = Convert.ToString(reader["username"]);
                listOfScores.Add(scoreTemp);
            }
            connexion.Close();
            return listOfScores;
        }
    }

    public class ScorePair
    {
        public int score { get; set; }
        public string username { get; set; }
        public string labelForTop3()
        {
            return score + " - " + username;
        }
        public List<string> labelForRest()
        {
            List<string> scorePair = new List<string>();
            scorePair.Add(username);
            scorePair.Add(score.ToString());
            return scorePair;
        }
    }
}
