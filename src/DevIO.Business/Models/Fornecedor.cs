using System.Collections.Generic;

namespace DevIO.Business.Models
{
    public partial class Fornecedor : Entidade
    {
        
        public string Nome { get; set; }

        public string Documento { get; set; }

        public TipoFornecedor Tipo { get; set; }

        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }

        /*Entity Framework Relacionamentos*/

        public IEnumerable<Produto> Produtos { get; set; }

    }
}
