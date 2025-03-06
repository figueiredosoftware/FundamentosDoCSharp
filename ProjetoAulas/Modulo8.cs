using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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

    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Código: " + Endereco);
            Console.WriteLine("Código: " + Cidade);
            Console.WriteLine("Código: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine("Cpf: " + Cpf);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }


    //Classe selada não pode ser herdada mas pode ser instanciada por qualquer método
    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    //public sealed class ConfiguracaoLocal : Configuracao
    //{
    //    public string Host { get; set; }
    //}

    //Classe abstrata : não pode ser instanciada por nenhum outro método, apenas herdada
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();
        public void ImprimirDados()
        {
            Console.WriteLine("Nome animal : " + Nome);
            Console.WriteLine("Informacoes : " + GetInformacoes());
        }
    }

    public class Cachorro : Animal
    {
        
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }




}
