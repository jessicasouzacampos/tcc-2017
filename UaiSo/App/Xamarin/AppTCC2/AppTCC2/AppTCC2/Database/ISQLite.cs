using SQLite;

namespace AppTCC2.Database
{
    public interface ISQLite
    {
      SQLiteConnection GetConnection();
    }
}
