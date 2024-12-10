using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    /// <summary>
    /// BookDto
    /// </summary>
    public class BookDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public BookType BookType { get; set; }

        /// <summary>
        /// 出版日期
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public float Price { get; set; }
    }
}
