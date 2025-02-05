using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }

        private static void AulaClasses()
        {

        }
    }

    public class Produto
    {
        private int Id;
        public string Descricao { get; set; }

        public void ImprimirDescricao()
        {
            Console.WriteLine($"O produto é  : " + GetId() + " - " + Descricao);
        }

        public void SetId( int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

    }
}
