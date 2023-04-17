

namespace FilmSitesi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class film
    {
        public int id { get; set; }
        [Display(Name = "Film Ýsmi")]
        [Required(ErrorMessage = "Film Ýsmi Unuttun La!")]
        public string name { get; set; }
        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Aynen Kategorisiz Film Olur Ya!")]
        public string category { get; set; }
        [Display(Name = "Süre")]
        [Required(ErrorMessage = "2 Saatten Fazlaysa Ýzlemem, Yaz Þunu!")]
        public string length { get; set; }
        [Display(Name = "Çýkýþ Tarihi")]
        [Required(ErrorMessage = "2000 Altý Filmi ASLA ÝZLEMEM!")]
        public int releaseDate { get; set; }
        [Display(Name = "Açýklama")]
        [Required(ErrorMessage = "Copy-Paste Unuttun Knk?")]
        public string description { get; set; }
        [Display(Name = "Yorumum")]
        [Required(ErrorMessage = "DEHÞET YORUMUN OLMADAN HAYAT MI GEÇER BE?")]
        public string comment { get; set; }
        [Display(Name = "IMDB")]
        [Required(ErrorMessage = "Ne Vermiþ Gevurlar?")]
        public string imdbScore { get; set; }
        [Display(Name = "MYMDB")]
        [Required(ErrorMessage = "Gözlem Yeteneði BEST Olan Kaç Veriyon Puan?")]
        public string myScore { get; set; }

        public Nullable<int> image_id { get; set; }
    
        public virtual image image { get; set; }

        public string ImageFile { get; set; }
    }
}
