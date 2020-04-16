using SandBoxRestApiUdemy.Data.Converters;
using SandBoxRestApiUdemy.Data.VO;
using SandBoxRestApiUdemy.Model;
using SandBoxRestApiUdemy.Repository.Generic;
using System.Collections.Generic;

namespace SandBoxRestApiUdemy.Business.Implementattions
{
    /// <summary>
    /// Responsable for business logic
    /// </summary>
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IRepository<Person> repositoy)
        {
            _repository = repositoy;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO PersonVO)
        {
            var personEntity = _repository.Create(_converter.Parse(PersonVO));

            return _converter.Parse(personEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO PersonVO)
        {
            var personEntity = _repository.Update(_converter.Parse(PersonVO));

            return _converter.Parse(personEntity);
        }
    }
}
