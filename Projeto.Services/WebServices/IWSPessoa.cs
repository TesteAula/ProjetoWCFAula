using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Services.Models; //camada de modelo..

namespace Projeto.Services.WebServices
{    
    [ServiceContract(Name = "servicePessoa")]
    public interface IWSPessoa
    {
        [OperationContract(Name = "cadastrarPessoa")]
        string Cadastrar(PessoaServiceModelCadastro model);

        [OperationContract(Name = "atualizarPessoa")]
        string Atualizar(PessoaServiceModelEdicao model);

        [OperationContract(Name = "excluirPessoa")]
        string Excluir(int idPessoa);

        [OperationContract(Name = "consultarPessoa")]
        List<PessoaServiceModelConsulta> Listar();

        [OperationContract(Name = "obterPessoa")]
        PessoaServiceModelConsulta Obter(int idPessoa);
    }
}


