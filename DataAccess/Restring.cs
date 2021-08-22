using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestringApp.DataAccess
{
    public class Restring
    {
        public int RestringId { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        public string RacketBrand { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string RacketModel { get; set; }

        [Required(ErrorMessage = "String Type is required")]
        public string String { get; set; }

        [Required(ErrorMessage = "Tension is required")]
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? TensionCrosses { get; set; }

        [Required(ErrorMessage = "Tension is required")]
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? TensionMains { get; set; }

        public DateTime? DateStrung { get; set; }
        public string Notes { get; set; }
        public DateTime? PaymentDate { get; set; }

        [Column(TypeName = "decimal(4, 2)")]
        public decimal? PaymentAmount { get; set; }
        public string PaymentNotes { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}