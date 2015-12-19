using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //connectionstring
using System.Data.Entity; //entityframework
using Projeto.DAL.Entities; //entidades

namespace Projeto.DAL.DataSource
{
    //Regra 1) Classe de conexão HERDA DbContext
    public class Conexao : DbContext
    {
        //Regra 2) Construtor para enviar a connectionstring para o DbContext
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["aula"].ConnectionString)
        {

        }

        //Regra 3) Declarar um DbSet para cada entidade
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
