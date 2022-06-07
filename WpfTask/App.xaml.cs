using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfTask.Enums;
using WpfTask.Models;
using WpfTask.ViewModels;

namespace WpfTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly PersonModel _person;

        public App()
        {
            _person = new PersonModel()
            {
                FirstName = "Vitalik",
                LastName = "Pretsel",
                Age = 21,
                Profession = Profession.Developer
            };
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_person)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
