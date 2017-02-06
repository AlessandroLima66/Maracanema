using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Maracanema.Base;
using SQLite;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(Maracanema.Droid.DatabaseConnection))]
namespace Maracanema.Droid
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public SQLiteConnection DBConnection()
        {
            var dbName = "maracanema.db3";
            var diretorio = Path.Combine(System.Environment
                                               .GetFolderPath(System.Environment
                                                                    .SpecialFolder.Personal), dbName);
            return new SQLiteConnection(diretorio);
        }

    }


}