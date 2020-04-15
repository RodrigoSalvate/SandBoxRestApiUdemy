using SandBoxRestApiUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxRestApiUdemy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book person);
        Book FindById(int id);
        List<Book> FindAll();
        Book Update(Book person);
        void Delete(int id);
    }
}
