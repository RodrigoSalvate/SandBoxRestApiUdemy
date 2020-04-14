using SandBoxRestApiUdemy.Model;
using SandBoxRestApiUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBoxRestApiUdemy.Services.Implementattions
{
    public class PersonServiceImpl : IPersonService
    {
        private SqlServerContext _context;

        public PersonServiceImpl(SqlServerContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public void Delete(int id)
        {
            var result = _context.Persons.SingleOrDefault(s => s.Id.Equals(id));

            try
            {
                if (result != null) _context.Persons.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(int id)
        {
            return _context.Persons.SingleOrDefault(s => s.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Exist(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(s => s.Id.Equals(person.Id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return person;
        }

        private bool Exist(int? id)
        {
            return _context.Persons.Any(a => a.Id == id);
        }
    }
}
