using SandBoxRestApiUdemy.Data.Converters;
using SandBoxRestApiUdemy.Data.VO;
using SandBoxRestApiUdemy.Model;
using SandBoxRestApiUdemy.Repository;
using SandBoxRestApiUdemy.Repository.Generic;
using System.Collections.Generic;
using Tapioca.HATEOAS.Utils;

namespace SandBoxRestApiUdemy.Business.Implementattions
{
    /// <summary>
    /// Responsable for business logic
    /// </summary>
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IPersonRepository repositoy)
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
        public List<PersonVO> FindByName(string firstName, string lastName)
        {
            return _converter.ParseList(_repository.FindByName(firstName, lastName));
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

        public PagedSearchDTO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page)
        {
            page = page > 0 ? page - 1 : page;

            var countQuery = "select * from persons ";
            if (!string.IsNullOrEmpty(name)) countQuery = countQuery + $" where FirstName like '%{name}%'";

            var totalResults = _repository.GetCount(countQuery);

            string query = "select * from persons p where 1 = 1";
            if (!string.IsNullOrEmpty(name)) query = query + $" and p.FirstName like '%{name}%'";
            query = query + $" order by p.FirstName {sortDirection} offset {page} rows fetch next {pageSize} rows only";

            var persons = _converter.ParseList(_repository.FindWithPagedSearch(query));

            return new PagedSearchDTO<PersonVO>()
            {
                CurrentPage = page,
                List = persons,
                PageSize = pageSize,
                SortDirections = sortDirection,
                TotalResults = totalResults
            };
        }
    }
}
