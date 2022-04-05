using System;
using System.ComponentModel.DataAnnotations;

namespace API_Placas.Models
{
    public class Placa
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "É preciso nomear a placa")]
        public String Nome_Placa { get; set; }
        [Required(ErrorMessage = "É preciso informar o operador")]
        public String Nome_Operador { get; set; }
        [StringLength(50, ErrorMessage = "o meio não pode ter mais que 50 caracteres")]
        public String Meio { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "é preciso informar o tamanho da placa")]
        public int Tamanho { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "é preciso informar a quantidade de colonias, sendo um numero positivo")]
        public int Quantidade_Colonias { get; set; }
    }
}
