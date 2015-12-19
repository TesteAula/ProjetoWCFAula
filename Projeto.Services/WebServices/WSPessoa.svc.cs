using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Services.Models;
using Projeto.DAL.Entities;
using Projeto.DAL.Persistence;

namespace Projeto.Services.WebServices
{    
    public class WSPessoa : IWSPessoa
    {

        public string Cadastrar(PessoaServiceModelCadastro model)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Nome = model.Nome;
                p.Sobrenome = model.Sobrenome;

                PessoaDal d = new PessoaDal();
                d.Insert(p);

                return "Pessoa " + p.Nome + ", cadastrado com sucesso.";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public string Atualizar(PessoaServiceModelEdicao model)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.IdPessoa = model.IdPessoa;
                p.Nome = model.Nome;
                p.Sobrenome = model.Sobrenome;

                PessoaDal d = new PessoaDal(); //persistencia
                d.Update(p);

                return "Pessoa " + p.Nome + ", atualizado com sucesso.";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public string Excluir(int idPessoa)
        {
            try
            {
                PessoaDal d = new PessoaDal();
                //buscando pessoa pelo id..
                Pessoa p = d.FindById(idPessoa);

                if(p != null) //se pessoa foi encontrado..
                {
                    d.Delete(p); //excluindo..
                    
                    return "Pessoa " + p.Nome + ", excluido com sucesso.";
                }
                else
                {
                    throw new Exception("Pessoa não encontrado.");
                }
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public List<PessoaServiceModelConsulta> Listar()
        {
            try
            {
                var lista = new List<PessoaServiceModelConsulta>();

                PessoaDal d = new PessoaDal(); //persistencia..
                foreach(Pessoa p in d.FindAll()) //varrendo os dados da busca..
                {
                    var model = new PessoaServiceModelConsulta();
                    model.IdPessoa = p.IdPessoa;
                    model.Nome = p.Nome;
                    model.Sobrenome = p.Sobrenome;

                    lista.Add(model); //adicionar na lista..
                }

                return lista; //retornar a lista..
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public PessoaServiceModelConsulta Obter(int idPessoa)
        {
            try
            {
                var model = new PessoaServiceModelConsulta();

                PessoaDal d = new PessoaDal(); //persistencia..
                Pessoa p = d.FindById(idPessoa); //buscando pelo id..

                model.IdPessoa = p.IdPessoa;
                model.Nome = p.Nome;
                model.Sobrenome = p.Sobrenome;

                return model;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
