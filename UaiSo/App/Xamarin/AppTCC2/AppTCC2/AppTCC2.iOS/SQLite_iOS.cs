using System;
using System.IO;
using AppTCC2.Database;
using AppTCC2.iOS;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_iOS))]
namespace AppTCC2.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqLiteFileName = "MobileDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);            
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqLiteFileName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}
