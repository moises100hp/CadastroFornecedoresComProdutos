﻿using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        //[Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Imagem { get; set; } = "";

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public bool Ativo { get; set; }

        /* EF Relation */
        //Produto com relação 1 x N com Fornecedor.
        public Fornecedor Fornecedor { get; set; }

    }
}
