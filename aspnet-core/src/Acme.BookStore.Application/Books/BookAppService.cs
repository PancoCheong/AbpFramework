// Acme.BookStore.Application\Books\BookAppService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    //
    public class BookAppService :
        CrudAppService<
            Book,       // book entity
            BookDto,    // used to show books
            Guid,       // Primary key of the book entity
            PagedAndSortedResultRequestDto, // used for paging or sorting
            CreateUpdateBookDto>,           // used to create/update a book
        IBookAppService
    {
        //IRepository is the default respository of Book Entity

        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }
    }
}
