﻿using System;

namespace DevIO.Business.Models
{
    public class Produto : Entidade
    {
        public Guid FornecedorId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        
        public string Imagem { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /* Relacionamento Entity Framework*/
        public Fornecedor Fornecedor { get; set; }
    }
    
}
