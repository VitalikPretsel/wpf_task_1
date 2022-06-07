using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfTask.Enums;
using WpfTask.Models;
using WpfTask.Services;
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
            _person = PersonService.GetPerson();
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
