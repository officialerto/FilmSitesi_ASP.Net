

namespace FilmSitesi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class film
    {
        public int id { get; set; }
        [Display(Name = "Film �smi")]
        [Required(ErrorMessage = "Film �smi Unuttun La!")]
        public string name { get; set; }
        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Aynen Kategorisiz Film Olur Ya!")]
        public string category { get; set; }
        [Display(Name = "S�re")]
        [Required(ErrorMessage = "2 Saatten Fazlaysa �zlemem, Yaz �unu!")]
        public string length { get; set; }
        [Display(Name = "��k�� Tarihi")]
        [Required(ErrorMessage = "2000 Alt� Filmi ASLA �ZLEMEM!")]
        public int releaseDate { get; set; }
        [Display(Name = "A��klama")]
        [Required(ErrorMessage = "Copy-Paste Unuttun Knk?")]
        public string description { get; set; }
        [Display(Name = "Yorumum")]
        [Required(ErrorMessage = "DEH�ET YORUMUN OLMADAN HAYAT MI GE�ER BE?")]
        public string comment { get; set; }
        [Display(Name = "IMDB")]
        [Required(ErrorMessage = "Ne Vermi� Gevurlar?")]
        public string imdbScore { get; set; }
        [Display(Name = "MYMDB")]
        [Required(ErrorMessage = "G�zlem Yetene�i BEST Olan Ka� Veriyon Puan?")]
        public string myScore { get; set; }

        public Nullable<int> image_id { get; set; }
    
        public virtual image image { get; set; }

        public string ImageFile { get; set; }
    }
}
