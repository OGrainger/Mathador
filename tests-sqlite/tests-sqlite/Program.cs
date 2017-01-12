using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace tests_sqlite
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //TESTS
            SQLiteDatabase db = new SQLiteDatabase();
            db.LaunchDatabase();

            //db.CreateANewUser("oscar", "hehe");

            Dictionary<string, int> gameData = new Dictionary<string, int>();
            gameData.Add("gameScore", 60);
            gameData.Add("gameTime", 180);
            gameData.Add("roundCount", 3);
            gameData.Add("addCount", 0);
            gameData.Add("subCount", 50);
            gameData.Add("multCount", 0);
            gameData.Add("divCount", 2);
            db.UpdateData("oscar", gameData);


            foreach (KeyValuePair<string, int> data in db.GetData("oscar"))
            {
                Console.WriteLine("Key = {0}, Value = {1}", data.Key, data.Value);
            }
            db.CloseDatabase();
            Console.ReadKey();
        }   
    }

    //LaunchDatabase() - void
    //CloseDatabase() - void
    //CreateANewUser(string username, string password) - void
    //CheckIfUserAlreadyExists(string username) - bool
    //CheckIfPasswordMatches(string username, string password) - bool
    //GetData(string username) - dictionary(minScore, maxScore, totalScorePoints, totalGameTimeInSeconds, gameCount, roundCount, addCount, subCount, multCount, divCount)
    //UpdateData(string username, dictionary(gameScore, gameTime, roundCount, addCount, subCount, multCount, divCount))
    
    class SQLiteDatabase
    {
        
        private SQLiteConnection connexion = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
        
        //Crée le fichier s'il n'existe pas et génère la table si elle n'existe pas
        public void LaunchDatabase ()
        {
            if (!File.Exists("db.sqlite"))
            {
                SQLiteConnection.CreateFile("db.sqlite");
            }
            connexion.Open();
            string sql = "create table if not exists users (username text, password text, minScore int, maxScore int, totalScorePoints int, totalGameTimeInSeconds int, gameCount int, roundCount int, addCount int, subCount int, multCount int, divCount int)";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            commande.ExecuteNonQuery();
            Console.WriteLine("db ouverte / créée avec succès");
            return;
        }

        //Ferme la connexion à la table
        public void CloseDatabase ()
        {
            connexion.Close();
            Console.WriteLine("db fermée avec succès");
            return;
        }

        //Insert un nouvel utilisateur
        public void CreateANewUser (string username, string password)
        {
            string sql = "insert into users values ('" + username + "', '" + password + "', 0, 0 ,0 ,0 ,0 ,0, 0, 0, 0, 0)";
            SQLiteCommand commandeInsert = new SQLiteCommand(sql, connexion);
            commandeInsert.ExecuteNonQuery();
            return;
        }

        //Vérifie si l'utilisateur existe déjà - Retourne true si c'est le cas
        public bool CheckIfUserAlreadyExists (string username)
        {
            string sql = "SELECT username FROM users WHERE username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Utilisateur existant");
                return true;
            }
            Console.WriteLine("L'utilisateur n'existe pas");
            return false;
        }

        //Vérifie si l'utilisateur existe déjà - Retourne true si c'est le cas
        public bool CheckIfPasswordMatch(string username, string password)
        {
            string sql = "SELECT password FROM users WHERE username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                if (reader[ "password"].ToString() == password)
                {
                    Console.WriteLine("Le mot de passe correspond");
                    return true;
                }
            }
            Console.WriteLine("Le mot de passe ne correspond pas");
            return false;
        }

        //Récupère toutes les données statistiques d'un utilisateur
        public Dictionary<string, int> GetData(string username)
        {
            Dictionary<string, int> userData = new Dictionary<string, int>();

            string sql = "SELECT * FROM users WHERE username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                //subCount int, multCount int, divCount int)";
                userData.Add("minScore",reader.GetInt32(2));
                userData.Add("maxScore", reader.GetInt32(3));
                userData.Add("totalScorePoints", reader.GetInt32(4));
                userData.Add("totalGameTimeInSeconds", reader.GetInt32(5));
                userData.Add("gameCount", reader.GetInt32(6));
                userData.Add("roundCount", reader.GetInt32(7));
                userData.Add("addCount", reader.GetInt32(8));
                userData.Add("subCount", reader.GetInt32(9));
                userData.Add("multCount", reader.GetInt32(10));
                userData.Add("divCount", reader.GetInt32(11));
            }
            return userData;
        }

        //Incrémenter la data d'un utilisateur (update) à la fin d'une partie
        public void UpdateData(string username, Dictionary<string, int> gameData)
        {
            string sql = "SELECT minScore, maxScore, gameCount FROM users WHERE username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(2) == 0)
                {
                    sql = "UPDATE users SET minScore = " + gameData["gameScore"] + ", maxScore = " + gameData["gameScore"] + ",  totalScorePoints = " + gameData["gameScore"] + ", totalGameTimeInSeconds = " + gameData["gameTime"] + ", gameCount = 1, roundCount = " + gameData["roundCount"] + ", addCount = " + gameData["addCount"] + ", subCount = " + gameData["subCount"] + ", multCount = " + gameData["multCount"] + ", divCount = " + gameData["divCount"] + " WHERE username = '" + username +"'";
                }
                else
                {
                    int minScore = (reader.GetInt32(0) > gameData["gameScore"] ? gameData["gameScore"] : reader.GetInt32(0));
                    int maxScore = (reader.GetInt32(1) < gameData["gameScore"] ? gameData["gameScore"] : reader.GetInt32(1));
                    sql = "UPDATE users SET minScore = " + minScore + ", maxScore = " + maxScore + ", totalScorePoints = totalScorePoints + " + gameData["gameScore"] + ", totalGameTimeInSeconds = totalGameTimeInSeconds + " + gameData["gameTime"] + ", gameCount = gameCount + 1, roundCount = roundCount + " + gameData["roundCount"] + ", addCount = addCount + " + gameData["addCount"] + ", subCount = subCount + " + gameData["subCount"] + ", multCount = multCount + " + gameData["multCount"] + ", divCount = divCount + " + gameData["divCount"] + " WHERE username = '" + username + "'";
                }
            }
            SQLiteCommand commandeInsert = new SQLiteCommand(sql, connexion);
            commandeInsert.ExecuteNonQuery();
            return;
        }
    }
}
