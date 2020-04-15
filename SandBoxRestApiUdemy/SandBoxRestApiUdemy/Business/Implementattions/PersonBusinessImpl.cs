using SandBoxRestApiUdemy.Model;
using SandBoxRestApiUdemy.Model.Context;
using SandBoxRestApiUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBoxRestApiUdemy.Business.Implementattions
{
    /// <summary>
    /// Responsable for business logic
    /// </summary>
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repositoy)
        {
            _repository = repositoy;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
