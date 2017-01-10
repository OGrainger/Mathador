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

            SQLiteDatabase db = new SQLiteDatabase();
            db.LaunchDatabase();
            if (db.CheckIfUserAlreadyExists("oihjohoh"))
            {
                Console.WriteLine("TRUE");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("FALSE");
                Console.ReadKey();
            }
            db.CloseDatabase();
        }   
    }

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
            string sql = "create table if not exists users (username text, password text, minScore int, maxScore int, totalScorePoints int, totalGameTime float, gameCount int, roundCount int, addCount int, subCount int, multCount int, divCount int)";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            commande.ExecuteNonQuery();
            return;
        }

        //Ferme la connexion à la table
        public void CloseDatabase ()
        {
            connexion.Close();
            return;
        }

        //Insert un nouvel utilisateur
        public void CreateANewUser (string username, string password)
        {
            string sql = "insert into users (username, password) values ('" + username + "', '" + password + "')";
            SQLiteCommand commandeInsert = new SQLiteCommand(sql, connexion);
            commandeInsert.ExecuteNonQuery();
            return;
        }

        //Vérifie si l'utilisateur existe déjà - Retourne true si c'est le cas
        public bool CheckIfUserAlreadyExists (string username)
        {
            string sql = "select username from users where username = '" + username + "'";
            SQLiteCommand commande = new SQLiteCommand(sql, connexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
