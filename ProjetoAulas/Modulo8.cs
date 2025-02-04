using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Produto
    {
        public string Descricao { get; set; }

        public void ImprimirDescricao()
        {
            Descricao = "Fita";
            Console.WriteLine($"O valor de produto.Descricao dentro do método é : {Descricao}");
        }

    }
}
