using Maracanema.Base;
using SQLite;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Maracanema.Windows.DatabaseConnection))]
namespace Maracanema.Windows
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public SQLiteConnection DBConnection()
        {
            var dbName = "maracanema.db3";
            var diretorio = Path.Combine(ApplicationData.
                                         Current.LocalFolder.Path, dbName);
            return new SQLiteConnection(diretorio);
        }
    }
}
