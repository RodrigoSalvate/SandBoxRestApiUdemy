using SandBoxRestApiUdemy.Data.Converters;
using SandBoxRestApiUdemy.Data.VO;
using SandBoxRestApiUdemy.Model;
using SandBoxRestApiUdemy.Repository.Generic;
using System.Collections.Generic;

namespace SandBoxRestApiUdemy.Business.Implementattions
{
    public class BookBusinessImpl : IBookBusiness
    {

        private IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImpl(IRepository<Book> repositoy)
        {
            _repository = repositoy;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _repository.Create(_converter.Parse(book));

            return _converter.Parse(bookEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<BookVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public BookVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _repository.Update(_converter.Parse(book));

            return _converter.Parse(bookEntity);
        }
    }
}
