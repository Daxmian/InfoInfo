using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Info.Models
{
    public class Category
    {
        [Key]
        [Display(Name="Identyfikator kategorii:")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Prosze podac nazwe kategorii:")]
        [Display(Name="Nazwa kategorii: ")]
        [MaxLength(50, ErrorMessage = "Nazwa kategorii nie moze przekraczać 50 znaków")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Prosze podac opis kategorii:")]
        [Display(Name = "Opis kategorii: ")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę ikony:")]
        [Display(Name = "Ikona kategorii:")]
        [MaxLength(30, ErrorMessage = "Nazwa ikony kategorii nie może być dłuższa niż 30 znaków")]
        public string? Icon { get; set; }

        [Required]
        [Display(Name = "Czy aktywna? ")]
        [DefaultValue(true)]

        public bool Active { get; set; }

        [Required]
        [Display(Name = "Czy wyswietlać? ")]
        [DefaultValue(true)]
        public bool Display { get; set; }

        //lista wszystkich tekstów z danej kategorii
        public virtual List<Text>? Texts { get; set; }

    }
}
