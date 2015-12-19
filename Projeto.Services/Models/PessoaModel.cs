using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; //mapeamento..

namespace Projeto.Services.Models
{
    //classe de modelo para os dados de entrada do cadastro
    [DataContract(Name = "pessoaModelCadastro")]
    public class PessoaServiceModelCadastro
    {
        [DataMember(Name = "nomePessoa", IsRequired = true)]
        public string Nome { get; set; }

        [DataMember(Name = "sobrenomePessoa", IsRequired = true)]
        public string Sobrenome { get; set; }
    }

    //classe de modelo para os dados de entrada da edição
    [DataContract(Name = "pessoaModelEdicao")]
    public class PessoaServiceModelEdicao
    {
        [DataMember(Name = "idPessoa", IsRequired = true)]
        public int IdPessoa { get; set; }

        [DataMember(Name = "nomePessoa", IsRequired = true)]
        public string Nome { get; set; }

        [DataMember(Name = "sobrenomePessoa", IsRequired = true)]
        public string Sobrenome { get; set; }
    }

    //classe de modelo para os dados de saida da consulta
    [DataContract(Name = "pessoaModelConsulta")]
    public class PessoaServiceModelConsulta
    {
        [DataMember(Name = "idPessoa", IsRequired = true)]
        public int IdPessoa { get; set; }

        [DataMember(Name = "nomePessoa", IsRequired = true)]
        public string Nome { get; set; }

        [DataMember(Name = "sobrenomePessoa", IsRequired = true)]
        public string Sobrenome { get; set; }
    }
}