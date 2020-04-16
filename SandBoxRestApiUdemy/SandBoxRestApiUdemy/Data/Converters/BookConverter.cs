using SandBoxRestApiUdemy.Data.Converter;
using SandBoxRestApiUdemy.Data.VO;
using SandBoxRestApiUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace SandBoxRestApiUdemy.Data.Converters
{
    public class BookConverter : IParser<Book, BookVO>, IParser<BookVO, Book>
    {
        public BookVO Parse(Book origin)
        {
            if (origin == null) return new BookVO();

            return new BookVO()
            {
                Author = origin.Author,
                Id = origin.Id,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public Book Parse(BookVO origin)
        {
            if (origin == null) return new Book();

            return new Book()
            {
                Author = origin.Author,
                Id = origin.Id,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public List<BookVO> ParseList(List<Book> origin)
        {
            if (origin == null) return new List<BookVO>();

            return origin.Select(s => Parse(s)).ToList();
        }

        public List<Book> ParseList(List<BookVO> origin)
        {
            if (origin == null) return new List<Book>();

            return origin.Select(s => Parse(s)).ToList();
        }
    }
}
