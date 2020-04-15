using SandBoxRestApiUdemy.Model;
using SandBoxRestApiUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxRestApiUdemy.Business.Implementattions
{
    public class BookBusinessImpl : IBookBusiness
    {

        private IRepository<Book> _repository;

        public BookBusinessImpl(IRepository<Book> repositoy)
        {
            _repository = repositoy;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
