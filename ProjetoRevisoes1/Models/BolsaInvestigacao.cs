using System.ComponentModel.DataAnnotations;

namespace ProjetoRevisoes1.Models
{
    public class BolsaInvestigacao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [Display(Name = "Área Científica")]
        public string Area { get; set; }
        [Display(Name = "Duração (meses)")]
        public int Duracao { get; set; }
        [Display(Name = "Valor da Mensalidade (euros)")]
        public int Remuneracao { get; set; }
    }
}
