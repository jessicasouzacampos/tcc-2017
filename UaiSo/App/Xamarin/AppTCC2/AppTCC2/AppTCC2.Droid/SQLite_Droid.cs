using System;
using System.IO;
using AppTCC2.Database;
using AppTCC2.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Droid))]
namespace AppTCC2.Droid
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqLiteFileName = "MobileDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
           
            var path = Path.Combine(documentsPath, sqLiteFileName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}