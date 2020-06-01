using BuildYourPC.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BuildYourPC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        DatabaseLists _databaseLists;
        //MainWindow _mainWindow;
        protected override void OnStartup(StartupEventArgs e)
        {
            Task.Factory.StartNew(async () =>
            {
                _databaseLists = DatabaseLists.GetDatabaseLists();
            }).Wait();

            //_mainWindow = new MainWindow();
            //_mainWindow.Show();
        }
    }
}
