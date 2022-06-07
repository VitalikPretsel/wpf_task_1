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

namespace WpfTask.ViewModels
{
    internal class EditProfileViewModel : BaseViewModel
    {
        public PersonModel Person { get; set; }
        public bool Saved;

        public EditProfileViewModel(PersonModel person)
        {
            Person = (PersonModel)person.Clone();
        }

        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(
                        ex => this.Save(), canex => this.SaveCanExecute()
                    );
                }
                return _saveCommand;
            }
        }

        private ICommand _cancelCommand;

        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(
                        param => this.Cancel()
                    );
                }
                return _cancelCommand;
            }
        }

        private bool SaveCanExecute()
        {
            if (string.IsNullOrEmpty(Person.FirstName) || string.IsNullOrEmpty(Person.LastName))
                return false;
            else
                return true;
        }

        private void Save()
        {
            Saved = true;
            CloseEditView();
            CloseEditView();
        }

        private void Cancel()
        {
            CloseEditView();
            CloseEditView();
        }

        private void CloseEditView()
        {
            var editWindow = Application.Current.Windows[1];
            editWindow.Close();
        }
    }
}
