using Maracanema.Base;
using System;
using SQLite;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(Maracanema.iOS.DatabaseConnection))]
namespace Maracanema.iOS
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public SQLiteConnection DBConnection()
        {
            var dbName = "maracanema.db3";
            var diretorio = System.Environment.
                            GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder =
                    Path.Combine(diretorio, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);

            return new SQLiteConnection(diretorio);
        }

    }


}