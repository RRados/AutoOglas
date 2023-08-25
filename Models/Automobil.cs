using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppOglas.Models
{
    public partial class Automobil
    {
        [Key]
        public int IdAutomobil { get; set; }

        [Display(Name = "Marka")]
        [Required(ErrorMessage = "*")]
        public string Marka { get; set; }

        [Display(Name = "Godiste:")]
        [Required(ErrorMessage = "*")]
        public int? Godiste { get; set; }

        [Display(Name = "Zapremina Motora:")]
        [Required(ErrorMessage = "*")]
        public int ZapreminaMotora { get; set; }

        [Display(Name = "Snaga:")]
        [Required(ErrorMessage = "*")]
        public int Snaga { get; set; }

        [Display(Name = "Gorivo:")]
        [Required(ErrorMessage = "*")]
        public string Gorivo { get; set; }

        [Display(Name = "Karoserija:")]
        [Required(ErrorMessage = "*")]
        public string Karoserija { get; set; }

        [Display(Name = "Fotografija:")]
        public string Fotografija { get; set; }

        [Display(Name = "Opis:")]
        [Required(ErrorMessage = "*")]
        public string Opis { get; set; }

        [Display(Name = "Cena:")]
        [Required(ErrorMessage = "*")]
        public int Cena { get; set; }

        [Display(Name = "Kontakt:")]
        [Required(ErrorMessage = "*")]
        public int Kontakt { get; set; }

    }
}
