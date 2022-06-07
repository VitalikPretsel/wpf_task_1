using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTask.Enums;
using WpfTask.Models;

namespace WpfTask.Services
{
    internal static class PersonService
    {
        public static PersonModel GetPerson()
        {
            return new PersonModel()
            {
                FirstName = "Vitalik",
                LastName = "Pretsel",
                Age = 21,
                Profession = Profession.Developer
            };
        } 
    }
}
