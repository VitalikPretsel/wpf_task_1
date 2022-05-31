using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfTask.Enums;
using WpfTask.Models;
using WpfTask.Views;

namespace WpfTask.ViewModels
{
    internal class MainViewModel : Screen
    {
        public PersonModel Person { get; set; }

        public MainViewModel()
        {
            Person = new PersonModel()
            {
                FirstName = "Vitalik",
                LastName = "Pretsel",
                Age = 21,
                Profession = Profession.Developer
            };
        }

        public void OpenEditView()
        {
            var mainWindow = Application.Current.Windows[0];
            var editViewModel = new EditViewModel(Person);
            EditView editView = new EditView
            {
                DataContext = editViewModel,
            };
            mainWindow.Hide();
            editView.ShowDialog();
            if (editViewModel.Saved)
            {
                Person = (PersonModel)editViewModel.Person.Clone();
                NotifyOfPropertyChange(() => Person);
            }
            mainWindow.Show();
        }

    }
}
