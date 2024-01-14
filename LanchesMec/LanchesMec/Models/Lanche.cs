using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMec.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required]
        [StringLength(100), ]
        [Display(Name = "Nome do lanche")]
        public string Nome { get; set; }

        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        //Nao usara na classe, apenas para definir o relacionamento com a classe Categoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }    

    }
}
