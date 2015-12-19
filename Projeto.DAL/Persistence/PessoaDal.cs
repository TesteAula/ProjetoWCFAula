using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //entityframework
using Projeto.DAL.Entities; //entidades
using Projeto.DAL.DataSource; //conexão

namespace Projeto.DAL.Persistence
{
    public class PessoaDal
    {
        //método para inserir um registro na tabela Pessoa..
        public void Insert(Pessoa p)
        {
            using(Conexao Con = new Conexao())
            {
                //iniciando uma transação no entityframework..
                DbContextTransaction t = Con.Database.BeginTransaction();

                try
                {
                    Con.Entry(p).State = EntityState.Added; //inserindo..
                    Con.SaveChanges(); //salvando..

                    t.Commit(); //executa e finaliza a transação..
                }
                catch(Exception e)
                {
                    t.Rollback(); //desfazer a transação..
                    throw new Exception(e.Message);
                }
                finally
                {
                    t.Dispose();
                }
            }
        }

        //método para excluir um registro na tabela Pessoa..
        public void Delete(Pessoa p)
        {
            using (Conexao Con = new Conexao())
            {
                //iniciando uma transação no entityframework..
                DbContextTransaction t = Con.Database.BeginTransaction();

                try
                {
                    Con.Entry(p).State = EntityState.Deleted; //excluindo..
                    Con.SaveChanges(); 

                    t.Commit(); //executa e finaliza a transação..
                }
                catch (Exception e)
                {
                    t.Rollback(); //desfazer a transação..
                    throw new Exception(e.Message);
                }
                finally
                {
                    t.Dispose();
                }
            }
        }

        //método para atualizar um registro na tabela Pessoa..
        public void Update(Pessoa p)
        {
            using (Conexao Con = new Conexao())
            {
                //iniciando uma transação no entityframework..
                DbContextTransaction t = Con.Database.BeginTransaction();

                try
                {
                    Con.Entry(p).State = EntityState.Modified; //atualizando..
                    Con.SaveChanges();

                    t.Commit(); //executa e finaliza a transação..
                }
                catch (Exception e)
                {
                    t.Rollback(); //desfazer a transação..
                    throw new Exception(e.Message);
                }
                finally
                {
                    t.Dispose();
                }
            }
        }

        //método para listar todos os registros de pessoa..
        public List<Pessoa> FindAll()
        {
            using(Conexao Con = new Conexao())
            {
                return Con.Pessoa.ToList(); //todos os registros..
            }
        }

        //método para obter 1 pessoa pelo id..
        public Pessoa FindById(int idPessoa)
        {
            using(Conexao Con = new Conexao())
            {
                return Con.Pessoa.Find(idPessoa);
            }
        }

    }
}
