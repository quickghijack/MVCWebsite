using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace MVCWebsite.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60,MinimumLength =3,ErrorMessage ="长度不对")]
        public string Title { get; set; }
        [Display(Name ="Release Data")]
        [DataType(DataType.Date,ErrorMessage ="不符合规范啦")]
        [Required(ErrorMessage ="测试通知")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
                
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1,100)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$",ErrorMessage ="不符合规范")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}