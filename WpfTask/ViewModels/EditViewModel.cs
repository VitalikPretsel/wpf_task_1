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
    internal class EditViewModel : BaseViewModel
    {
        public PersonModel Person { get; set; }
        public bool Saved;

        public Profession[] Professions { get; set; } = 
            Enum.GetValues(typeof(Profession)).Cast<Profession>().ToArray();

        public EditViewModel(PersonModel person)
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
                        param => this.Save()
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

        public void Save()
        {
            Saved = true;
            CloseEditView();
            CloseEditView();

        }

        public void Cancel()
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
