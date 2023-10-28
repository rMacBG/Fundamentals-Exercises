using ProjectSomethingLoL.Core;
using ProjectSomethingLoL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSomethingLoL.Models
{
    public class Person : IPerson
    {
        public Person(string name, string phone)
        {
            Id = Identity.Id.ToString();

            Name = name;
            Phone = phone;

        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
