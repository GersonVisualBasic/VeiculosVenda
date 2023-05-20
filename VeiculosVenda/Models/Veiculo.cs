using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeiculosVenda.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Marca")]
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Marca é obrigatório!")]
        public string? Marca { get; set; }

        [Column("Modelo")]
        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "Modelo é obrigatório!")]
        public string? Modelo { get; set; }

        [Column("Ano")]
        [Display(Name = "Ano")]
        [Required(ErrorMessage = "Ano é obrigatório!")]
        public string? Ano { get; set; }

        [Column("Placa")]
        [Display(Name = "Placa")]
        [Required(ErrorMessage = "Placa é obrigatório!")]
        public string? Placa { get; set; }

        [Column("Km")]
        [Display(Name = "Km")]
        public string? Km { get; set; }

        [Column("Cor")]
        [Display(Name = "Cor")]
        [Required(ErrorMessage = "Cor é obrigatório!")]
        public string? Cor { get; set; }

        [Column("Opcional")]
        [Display(Name = "Opcional")]
        public string? Opcional { get; set; }

    }

}
