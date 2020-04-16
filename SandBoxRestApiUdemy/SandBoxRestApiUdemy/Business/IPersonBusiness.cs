using SandBoxRestApiUdemy.Data.VO;
using System.Collections.Generic;


namespace SandBoxRestApiUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO personVO);
        PersonVO FindById(int id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO personVO);
        void Delete(int id);
    }
}
