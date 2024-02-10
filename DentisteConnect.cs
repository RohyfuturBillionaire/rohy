using System.Data;
using Npgsql;
namespace Dentisterie.baseDeDonnees
{
    public class DentisterieConnect{
        private static NpgsqlConnection? connect;
        public static NpgsqlConnection? Connect{get {return connect;} set{connect=value;}}
       
        public static NpgsqlConnection Dbconnect(string dbname)
            {
                 String connString = "Host=localhost;Username=postgres;"+$"Database={dbname}"+";Port=5432;Password=Goldroger12";
                 Connect= new NpgsqlConnection(connString);
                 return Connect; 
            }

    }      
}