using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto
    {

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 书籍类型
        /// </summary>
        [Required]
        public BookType BookType { get; set; } = BookType.Undefined;

        /// <summary>
        /// 出版日期
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        /// <summary>
        /// 价格
        /// </summary>
        [Required]
        public float Price { get; set; }

    }
}
