using SandBoxRestApiUdemy.Data.Converter;
using SandBoxRestApiUdemy.Data.VO;
using SandBoxRestApiUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace SandBoxRestApiUdemy.Data.Converters
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return new Person();

            return new Person()
            {
                Id = origin.Id,
                Address = origin.Address,
                FirstName = origin.FirstName,
                Gender = origin.Gender,
                LastName = origin.LastName
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return new PersonVO();

            return new PersonVO()
            {
                Id = origin.Id,
                Address = origin.Address,
                FirstName = origin.FirstName,
                Gender = origin.Gender,
                LastName = origin.LastName
            };
        }

        public List<Person> ParseList(List<PersonVO> origin)
        {
            if (origin == null) return new List<Person>();

            return origin.Select(s => Parse(s)).ToList();
        }

        public List<PersonVO> ParseList(List<Person> origin)
        {

            if (origin == null) return new List<PersonVO>();

            return origin.Select(s => Parse(s)).ToList();
        }
    }
}
