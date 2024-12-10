using Acme.BookStore.Books;
using Acme.BookStore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Services
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>,
    IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository) : base(repository)
        {
            
        }

        public Task<Book> CreateAsync(PagedAndSortedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(BookDto id)
        {
            throw new NotImplementedException();
        }
 
        public Task<Book> GetAsync(BookDto id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<Book>> GetListAsync(Guid input)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateAsync(BookDto id, CreateUpdateBookDto input)
        {
            throw new NotImplementedException();
        }

       
    }
}
