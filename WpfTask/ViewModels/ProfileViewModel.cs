using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfTask.Enums;
using WpfTask.Helpers;
using WpfTask.Models;
using WpfTask.Views;

namespace WpfTask.ViewModels
{
    internal class ProfileViewModel : BaseViewModel
    {
        public PersonModel Person { get; set; }

        public ProfileViewModel(PersonModel person)
        {
            Person = person;
        }

        private ICommand _openEditViewCommand;

        public ICommand OpenEditViewCommand
        {
            get
            {
                if (_openEditViewCommand == null)
                {
                    _openEditViewCommand = new RelayCommand(
                        param => this.OpenEditView()
                    );
                }
                return _openEditViewCommand;
            }
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
                OnPropertyChanged(nameof(Person));
            }
            mainWindow.Show();
        }

    }
}
