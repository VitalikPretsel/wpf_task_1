using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTask.Models;

namespace WpfTask.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public BaseViewModel CurrentViewModel { get; }

        public MainViewModel(PersonModel person)
        {
            CurrentViewModel = new ProfileViewModel(person);
        }
    }
}
