using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.ViewModel
{
    public class News
    {
        [Required(ErrorMessage = "Заполните поле пж")]
        [Display(Name = "Содержимое")]
        public string Message { get; set; }
        [Required(ErrorMessage = "Заполните поле пж")]
        [Display(Name = "Имя статьи")]
        public string NameArticle { get; set; }
        public int Id { get; set; }
    }
}
