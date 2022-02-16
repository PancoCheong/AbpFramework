// Acme.BookStore.Application.Contracts\Books\IBookAppService.cs
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookAppService 
        : ICrudAppService<  //defines CRUD methods
            BookDto,        //used to show books
            Guid,           //Primary key of the book entity
            PagedAndSortedResultRequestDto, //used for paging/sorting
            CreateUpdateBookDto>            //used to create/update a book
    {
    }
}
