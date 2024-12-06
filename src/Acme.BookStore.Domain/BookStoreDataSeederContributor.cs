using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace Acme.BookStore
{
    public class BookStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {

        private readonly IRepository<Book, Guid> _repository;

        public BookStoreDataSeederContributor(IRepository<Book, Guid> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() > 0)
            {
                return;
            }

            await _repository.InsertAsync(
                new Book
                {
                    Name = "1984",
                    Type = BookType.Dystopia,
                    PublishDate = new DateTime(1949, 6, 8),
                    Price = 19.84f
                },
                autoSave: true
            );

            await _repository.InsertAsync(
                new Book
                {
                    Name = "The Hobbit",
                    Type = BookType.ScienceFiction,
                    PublishDate = new DateTime(1937, 9, 21),
                    Price = 25.99f
                },
                autoSave: true
            );
        }
    }
}
