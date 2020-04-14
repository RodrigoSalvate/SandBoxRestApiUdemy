using SandBoxRestApiUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SandBoxRestApiUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(int id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(int id);
    }
}
