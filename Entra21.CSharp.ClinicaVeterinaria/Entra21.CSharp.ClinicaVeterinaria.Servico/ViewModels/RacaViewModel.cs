using System.ComponentModel.DataAnnotations;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels
{
    public class RacaViewModel
    {
        //[Display(Name = "Nome")]
        [Display(Name = nameof(Nome))]
        [Required(ErrorMessage = "Preencha o campo {0}.")]
        [MinLength(3, ErrorMessage = "{0} deve conter no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} caracteres.")]
        public string Nome { get; set; }


        [Display(Name = "Espécie")]
        [Required(ErrorMessage = "Selecione uma {0}.")]
        public string Especie { get; set; }
    }
}