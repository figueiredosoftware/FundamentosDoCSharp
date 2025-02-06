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
        public int Estoque1 { get;} //como tem somente o Get, então essa propriedade é somente leitura
        public readonly int Estoque2;  //como tem somente o Get, então essa propriedade é somente leitura

        public Produto()
        {
            Estoque2 = 1;
        }

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

        public void AulaPropriedadeSomenteLeitura()
        {
            Descricao = "Mouse";

            Console.WriteLine($"O produto {Descricao} tem {Estoque2} de estoque");
        }



    }
}
