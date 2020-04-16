using SandBoxRestApiUdemy.Data.VO;
using System.Collections.Generic;

namespace SandBoxRestApiUdemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO person);
        BookVO FindById(int id);
        List<BookVO> FindAll();
        BookVO Update(BookVO person);
        void Delete(int id);
    }
}
