using SandBoxRestApiUdemy.Model;
using System;
using System.Collections.Generic;


namespace SandBoxRestApiUdemy.Services.Implementattions
{
    public class PersonServiceImpl : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                persons.Add(new Person()
                {
                    Id = i,
                    FirstName = "Rodrigo - " + i,
                    LastName = "Salvate Brasil",
                    Address = "Rio de Janeiro/RJ",
                    Gender = "Male"
                });
            }

            return persons;
        }

        public Person FindById(long id)
        {
            return new Person()
            {
                Id = 1,
                FirstName = "Rodrigo",
                LastName = "Salvate Brasil",
                Address = "Rio de Janeiro/RJ",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
