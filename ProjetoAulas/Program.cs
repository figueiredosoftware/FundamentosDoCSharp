using System;
using System.Collections;
using Cadastro;


class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu de operações em DOT.NET C#:");
            Console.WriteLine("1. Tipos");
            Console.WriteLine("2. Cálculos Aritméticos");
            Console.WriteLine("3. Operadores Relacionais");
            Console.WriteLine("4. Operadores Lógicos");
            Console.WriteLine("5. Funções");
            Console.WriteLine("6. Array List");
            Console.WriteLine("7. ARRAY TIPADO - vetor");
            Console.WriteLine("8. LISTA GENÉRICA");
            Console.WriteLine("9. DICIONÁRIO DE DADOS");
            Console.WriteLine("10. QUEUE - Fila");
            Console.WriteLine("11. STACK - Pilha");
            Console.WriteLine("12. If / Else / Else If");
            Console.WriteLine("13. Switch");
            Console.WriteLine("14. For");
            Console.WriteLine("15. ForEach");
            Console.WriteLine("16. While / Do While");
            Console.WriteLine("17. Break / Continue");
            Console.WriteLine("18. POO - Programação orientada a objeto");
            Console.WriteLine("30. Sair");
            Console.Write("Escolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ExecutarOpcao1();
                    break;
                case "2":
                    ExecutarOpcao2();
                    break;
                case "3":
                    ExecutarOpcao3();
                    break;
                case "4":
                    ExecutarOpcao4();
                    break;
                case "5":
                    ExecutarOpcao5();
                    break;
                case "6":
                    ExecutarOpcao6();
                    break;
                case "7":
                    ExecutarOpcao7();
                    break;
                case "8":
                    ExecutarOpcao8();
                    break;
                case "9":
                    ExecutarOpcao9();
                    break;
                case "10":
                    ExecutarOpcao10();
                    break;
                case "11":
                    ExecutarOpcao11();
                    break;
                case "12":
                    ExecutarOpcao12();
                    break;
                case "13":
                    ExecutarOpcao13();
                    break;
                case "14":
                    ExecutarOpcao14();
                    break;
                case "15":
                    ExecutarOpcao15();
                    break;
                case "16":
                    ExecutarOpcao16();
                    break;
                case "17":
                    ExecutarOpcao17();
                    break;
                case "18":
                    ExecutarOpcao18();
                    break;
                case "30":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void ExecutarOpcao1()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 1 - TIPOS");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 1

        //tipos
        Console.WriteLine("Primeiro Programa");

        int idade = 33;
        Console.WriteLine("Valor da variável idade: " + idade);

        String nomePessoa = "Jesus";
        Console.WriteLine("Valor da variável nomePessoa: {0} ", nomePessoa);

        Decimal valor = 200.99m; //por padrão, quando atribuimos direto um valor fracionado o C# pensa que é double, só que valor é decimal, logo pra forçar o Cast usar m depois do valor, dai 200.99 vira decimal.
        Console.WriteLine("Valor da variável valor: " + valor);

        double valorDouble = 200.99; //como é double não precisa de letra depois do valor porque o padrão é double
        Console.WriteLine("Valor da variável valorDouble: " + valorDouble);

        float valorFloat = 299.99f; //por padrão, quando atribuimos direto um valor fracionado o C# pensa que é double, só que valor é float, logo pra forçar o Cast usar f depois do valor, dai 200.99 vira float.
        Console.WriteLine("Valor da variável valorFloat: " + valorFloat);

        var idadeNova = 34;
        Console.WriteLine("Valor da variável idadeNova: " + idadeNova);

        char flag = 'Y';
        Console.WriteLine("Valor da variável flag: " + flag);

        bool ativo = true;
        Console.WriteLine("Valor da variável ativo: " + ativo);

        const string descricao = "Curso CSHARP";
        Console.WriteLine("O valor da variável descricao que é uma constante é : " + descricao);

        //descricao = "outro valor"; //não posso colocar outro valor porque é constante

        Console.WriteLine("\n\n Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao2()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 2 - Cálculos Aritméticos");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 2

        //Calculos Aritméticos

        var soma = 1 + 2;
        Console.WriteLine("O valor de soma é : " + soma);

        int numero1 = 10;
        var numero2 = 2;
        soma = numero1 + numero2;
        Console.WriteLine("O valor de soma é : " + soma);

        int soma2 = numero1 + numero2;
        Console.WriteLine("O valor de soma2 é : " + soma2);

        int subtracao = numero1 - numero2;
        Console.WriteLine("O valor de subtracao é : " + subtracao);

        int multiplicacao = numero1 * numero2;
        Console.WriteLine("O valor de multiplicacao é : " + multiplicacao);

        int multiplicacao2 = (numero1 * numero2) * 3;
        Console.WriteLine("O valor de multiplicacao2 é : " + multiplicacao2);

        decimal divisao = (decimal)numero2 / (decimal)numero1;
        Console.WriteLine("O valor de divisao é : " + divisao);



        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao3()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 3. Operadores Relacionais");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 3

        //Operadores Relacionais (==, >, <, <=, >=, !=)

        int numero1 = 0;
        var numero2 = 0;

        numero1 = 2;
        numero2 = 2;
        Console.WriteLine("O valor de numero1 é : " + numero1 + " e o valor de numero2 é : " + numero2);
        Boolean igual1 = numero1 == numero2;
        Console.WriteLine("O valor de igual1 é : " + igual1);

        numero1 = 2;
        numero2 = 5;
        bool igual2 = numero1 == numero2;
        Console.WriteLine("O valor de igual2 é : " + igual2);

        numero1 = 2;
        numero2 = 5;
        igual2 = numero1 > numero2;
        Console.WriteLine("O valor de igual2 para (numero1 > numero2) é : " + igual2);

        numero1 = 2;
        numero2 = 5;
        igual2 = numero1 < numero2;
        Console.WriteLine("O valor de igual2 para (numero1 < numero2) é : " + igual2);

        numero1 = 2;
        numero2 = 5;
        igual2 = numero1 >= numero2;
        Console.WriteLine("O valor de igual2 para (numero1 >= numero2) é : " + igual2);

        numero1 = 2;
        numero2 = 5;
        igual2 = numero1 <= numero2;
        Console.WriteLine("O valor de igual2 para (numero1 <= numero2) é : " + igual2);

        numero1 = 2;
        numero2 = 5;
        igual2 = numero1 != numero2; //diferente
        Console.WriteLine("O valor de igual2 para (numero1 != numero2) é : " + igual2);




        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao4()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 4. Operadores Lógicos");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 4

        //Operadores Lógicos (&&, ||, !)

        int numero1 = 2;
        var numero2 = 5;

        bool valido = numero2 > numero1 && 8 > 7;
        Console.WriteLine("O valor de valido para ( numero2 > numero1 && 8 > 7) é : " + valido);

        bool valido2 = numero2 > numero1 || 8 > 7;
        Console.WriteLine("O valor de valido2 para ( numero2 > numero1 || 8 > 7) é : " + valido2);

        bool valido3 = !(numero2 > 10);
        Console.WriteLine("O valor de valido3 para ( !(numero2 > 10) ) é : " + valido3);

        bool valido4 = !(numero2 > 1);
        Console.WriteLine("O valor de valido4 para ( !(numero2 > 1) ) é : " + valido4);

        //Operador Ternário

        bool ativo2 = true;
        string status = ativo2 == true ? "Cadastro Ativo" : "Cadastro Inativo";
        Console.WriteLine("O valor de status é : " + status);

        ativo2 = false;
        status = ativo2 ? "Cadastro Ativo" : "Cadastro Inativo";
        Console.WriteLine("O valor de status é : " + status);

        ativo2 = false;
        status = !ativo2 ? "Cadastro Ativo" : "Cadastro Inativo";
        Console.WriteLine("O valor de status é : " + status);




        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao5()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 5. Funções");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 5

        //FUNÇÕES

        EscreverNome();


        string NomeCompleto()
        {
            string primeiroNome = "Alessandro";
            string segundoNome = "Figueiredo";

            return primeiroNome + " " + segundoNome + " é dono da Figueiredo Software";
        }

        int SomaValores()
        {
            return 8 + 2;
        }

        void EscreverNome()
        {
            var nome = NomeCompleto();
            Console.WriteLine(nome);

            var soma3 = SomaValores();
            Console.WriteLine(soma3);
        }

        int SomaValores2(int a, int b)
        {
            return a + b;
        }

        var soma5 = SomaValores2(6, 4);
        Console.WriteLine("O valor da soma é : {0}", soma5);



        string NomeEIdade(string nome, int idade)
        {
            return "Meu nome é " + nome + " e tenho " + idade + " anos de idade !!!";
        }

        var nome5 = NomeEIdade("Alessandro", 53);
        Console.WriteLine(nome5);


        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao6()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 6. Array List ");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 6

        //===================================================
        //Array List 
        //===================================================

        //criando os Arraylist
        ArrayList testeArrayList = new ArrayList(); //criando os Arraylist

        //adicionando itens no Arraylist
        testeArrayList.Add(1);
        testeArrayList.Add("Ale");
        testeArrayList.Add("Computador");
        testeArrayList.Add(true);

        //mostranto o item de índice 1 do arraylist
        Console.WriteLine("Acessandro índice 1 do ArrayList testeArrayList que tem valor : " + testeArrayList[1]);

        //fazendo um looping e mostranto todos elementos do arraylist
        foreach (var item in testeArrayList)
        {
            Console.WriteLine(item);
        }

        //removendo o item de indice 1 do arraylist
        testeArrayList.RemoveAt(1);

        //fazendo um looping e mostranto todos elementos do arraylist
        foreach (var item in testeArrayList)
        {
            Console.WriteLine(item);
        }

        //limpando todo arraylist
        testeArrayList.Clear();

        Console.WriteLine("\n Mostrando todo arraylist depois de limpá-lo");
        //fazendo um looping e mostranto todos elementos do arraylist
        foreach (var item in testeArrayList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao7()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 7. ARRAY TIPADO - vetor");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 7

        ////===================================================
        ////ARRAY TIPADO - vetor
        ////===================================================

        var arrayTipadoNumero = new int[3] { 1, 2, 3 }; //vetor

        var arrayTipadoNumero2 = new int[3]; //vetor
        arrayTipadoNumero2[0] = 5;
        arrayTipadoNumero2[1] = 9;
        arrayTipadoNumero2[2] = 1;

        var matriz = new int[3, 5]; //matriz

        var arrayTipadoString = new string[5];


        Console.WriteLine("\n\n Mostrando todo ARRAY TIPADO arrayTipadoNumero :");

        foreach (var item in arrayTipadoNumero)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("\n\n Mostrando indice 1 do ARRAY TIPADO :");
        Console.WriteLine(arrayTipadoNumero[1]);


        Console.WriteLine("\n\n Alterando e Mostrando indice 2 do ARRAY TIPADO :");
        arrayTipadoNumero[2] = 10;
        Console.WriteLine(arrayTipadoNumero[2]);


        Console.WriteLine("\n\n Mostrando todo ARRAY TIPADO arrayTipadoNumero2 :");

        foreach (var item in arrayTipadoNumero2)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("\n\n Mostrando todo ARRAY TIPADO arrayTipadoNumero depois de redefinido seu tamanho :");

        Array.Resize(ref arrayTipadoNumero, 20);
        arrayTipadoNumero[3] = 3;
        arrayTipadoNumero[4] = 23;
        arrayTipadoNumero[5] = 67;
        arrayTipadoNumero[6] = 345;
        arrayTipadoNumero[7] = 345456;

        foreach (var item in arrayTipadoNumero)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n\n Mostrando todo ARRAY TIPADO arrayTipadoString :");

        Array.Resize(ref arrayTipadoString, 20);
        arrayTipadoString[0] = "Ale";
        arrayTipadoString[1] = "Computador";
        arrayTipadoString[2] = "Hacker";
        arrayTipadoString[3] = "Umbanda";
        arrayTipadoString[4] = "Defumação";
        arrayTipadoString[5] = "Benzimento";
        arrayTipadoString[6] = "Axé";
        arrayTipadoString[7] = "Fé";


        foreach (var item in arrayTipadoString)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao8()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 8. LISTA GENÉRICA");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 8

        //===================================================
        // LISTA GENÉRICA
        //===================================================
        //cria uma lista do tipo string com tamanho de 10 elementos mais se colocarmos mais elementos a lista se auto dimensiona,
        //se auto ajusta para o novo tamanho
        //é uma lista genérica de strings
        var lista = new List<string>(10);
        lista.Add("Ale");
        lista.Add("Caboblo");
        lista.Add("Preto Velho");


        Console.WriteLine("\n\n Mostrando toda Lista Genérica lista :");
        foreach (var item in lista)
        {
            Console.WriteLine("Item da lista : {0}", item);
        }

        Console.WriteLine("\n\n Mostrando item de índice 0 da Lista Genérica lista : {0}", lista[0]);

        //posso criar uma lista já com valores
        var lista2 = new List<string>(10)
        {
            "Ale",
            "Oxalá",
            "Omolú"
        };

        Console.WriteLine("\n\n Mostrando toda Lista Genérica lista2 :");
        foreach (var item in lista2)
        {
            Console.WriteLine("Item da lista : {0}", item);
        }

        //removendo um item da lista2
        lista2.RemoveAt(1);

        Console.WriteLine("\n\n Mostrando toda Lista Genérica lista2 depois de remover item de índice 1 :");
        foreach (var item in lista2)
        {
            Console.WriteLine("Item da lista : {0}", item);
        }

        //procura na lista2 a paravra "Omolú", se achar em algum item da lista devolve true
        bool n = lista2.Contains("Omolú");
        Console.WriteLine("\n valor de n : " + n);

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao9()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 9. DICIONÁRIO DE DADOS");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 9

        //===================================================
        // DICIONÁRIO DE DADOS
        //===================================================
        // trabalha com chave valor, não permite duplicidade de chave

        //adicionando chaves e valores para o dicionario
        var dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Maria");
        dicionario.Add(2, "Leonardo");
        dicionario.Add(3, "Pedro");
        dicionario.Add(100, "Rebecca");

        string nome6 = dicionario[2]; //estou atribuindo para o nome6 o conteúdo do dicionario cujo valor da chave é 2 (2 não é incide)
        Console.WriteLine("\n\n Mostrando valor da variável nome6 que recebeu chave 2 de dicionario :" + nome6);

        Console.WriteLine("\n\n Mostrando chave 100 de dicionario :" + dicionario[100]);

        //adicionando a chave 50 e valor "Curso" de outra forma
        dicionario[50] = "Curso";
        Console.WriteLine("\n\n Mostrando chave 50 de dicionario :" + dicionario[50]);

        //Criando outro dicionario e inserindo valores no momento da criação
        var dicionario2 = new Dictionary<int, string>()
        {
            {1, "Caboblo"},
            {2, "Preto Velho"},
            {3, "Baiana" }
        };

        //Adicionando mais valores no dicionario2
        dicionario2[4] = "Ciagana";

        //Adicionando mais valores no dicionario2
        dicionario2.Add(5,"Pomba Gira");

        Console.WriteLine("\n\n Mostrando todos elementos de dicionario2 :");
        foreach (var item in dicionario2) 
        {
            Console.WriteLine($"Chave :  {item.Key}, Valor : {item.Value}" );
        }


        //Criando outro dicionario e inserindo valores no momento da criação
        var dicionario3 = new Dictionary<string, string>()
        {
            {"1", "Caboblo"},
            {"2", "Preto Velho"},
            {"3", "Baiana" }
        };

        //Adicionando mais valores no dicionario2
        dicionario3["4"] = "Ciagana";

        //Adicionando mais valores no dicionario2
        dicionario3.Add("5", "Pomba Gira");

        Console.WriteLine("\n\n Mostrando todos elementos de dicionario3 :");
        foreach (var item in dicionario3)
        {
            Console.WriteLine($"Chave :  {item.Key}, Valor : {item.Value}");
        }

        //movendo para variável nome10 o valor do dicionario chave 3
        var nome10 = dicionario[3];

        Console.WriteLine($"O valor de nome10 é : {nome10}");

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao10()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 10. QUEUE - Fila");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 10

        //===================================================
        // QUEUE - Fila - FIFO - first in first out
        //===================================================
        // 
        //Criando uma fila para guardar todos tipos
        var queue1 = new Queue();
        queue1.Enqueue(3.14);
        queue1.Enqueue("Pastor");
        queue1.Enqueue(new DateTime(2024, 12, 24));
        queue1.Enqueue(2);
        queue1.Enqueue("Gato");

        //mostranto todos elementos da fila queue1
        Console.WriteLine("\n\nMostranto todos elementos da fila queue1 ");

        foreach(var item in queue1)
        {
            Console.WriteLine($"Item da fila queue1 : {item}");
        }

        //Para saber o valor corrente ou seja, o próximo item que tem que sair da fila
        var nome1 = queue1.Peek();
        Console.WriteLine($"\nItem que está para sair da fila : {nome1}");

        //Para tirar da fila o próximo item que tem que sair da fila
        nome1 = queue1.Dequeue();
        Console.WriteLine($"\nItem que saiu da fila : {nome1}");

        //mostranto todos elementos da fila queue2 depois que tirou o próximo elemento da fila
        Console.WriteLine("\n\nMostranto todos elementos da fila queue1 ");
        foreach (var item in queue1)
        {
            Console.WriteLine($"Item da fila queue1 : {item}");
        }

        //Para tirar da fila o próximo item que tem que sair da fila
        nome1 = queue1.Dequeue();
        Console.WriteLine($"\nItem que saiu da fila : {nome1}");

        //mostranto todos elementos da fila queue2 depois que tirou o próximo elemento da fila
        Console.WriteLine("\n\nMostranto todos elementos da fila queue1 ");
        foreach (var item in queue1)
        {
            Console.WriteLine($"Item da fila queue1 : {item}");
        }



        //Criando uma fila para guardar strings
        var queue2 = new Queue<string>();
        queue2.Enqueue("1");
        queue2.Enqueue("Xango");
        queue2.Enqueue("Oxossi");
        queue2.Enqueue("Exu");

        //mostranto todos elementos da fila queue2
        Console.WriteLine("\n\nMostranto todos elementos da fila queue2 ");
        foreach (var item in queue2)
        {
            Console.WriteLine($"Item da fila queue2 : {item}");
        }

        //Para saber o valor corrente ou seja, o próximo item que tem que sair da fila
        var nome2 = queue2.Peek();
        Console.WriteLine($"\nItem que está para sair da fila : {nome2}");

        //Para tirar da fila o próximo item que tem que sair da fila
        nome2 = queue2.Dequeue();
        Console.WriteLine($"\nItem que saiu da fila : {nome2}");

        //mostranto todos elementos da fila queue2 depois que tirou o próximo elemento da fila
        Console.WriteLine("\n\nMostranto todos elementos da fila queue2 ");
        foreach (var item in queue2)
        {
            Console.WriteLine($"Item da fila queue2 : {item}");
        }

        //Para tirar da fila o próximo item que tem que sair da fila
        nome2 = queue2.Dequeue();
        Console.WriteLine($"\nItem que saiu da fila : {nome2}");

        //mostranto todos elementos da fila queue2 depois que tirou o próximo elemento da fila
        Console.WriteLine("\n\nMostranto todos elementos da fila queue2 ");
        foreach (var item in queue2)
        {
            Console.WriteLine($"Item da fila queue2 : {item}");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao11()
    {
        Console.WriteLine("\n======================================================================");
        Console.WriteLine("\n\n 11. STACK - Pilha");
        Console.WriteLine("\n======================================================================");
        // Código específico para a opção 11

        //===================================================
        // STAK - Pilha - LIFO - last in first out
        //===================================================
        // 

        //Criando uma pilha para guardar todos tipos
        var pilha1 = new Stack();
        pilha1.Push(3.14);
        pilha1.Push("Pastor");
        pilha1.Push(new DateTime(2024, 12, 24));
        pilha1.Push(2);
        pilha1.Push("Gato");

        //mostranto todos elementos da pilha pilha1
        Console.WriteLine("\n\nMostranto todos elementos da pilha pilha1 ");

        foreach (var item in pilha1)
        {
            Console.WriteLine($"Item da pilha pilha1 : {item}");
        }

        //Para saber o valor corrente ou seja, o próximo item que tem que sair da pilha
        var nome1 = pilha1.Peek();
        Console.WriteLine($"\nItem que está para sair da pilha : {nome1}");

        //Para tirar da pilha o próximo item que tem que sair da fila
        nome1 = pilha1.Pop();
        Console.WriteLine($"\nItem que saiu da pilha : {nome1}");

        //mostranto todos elementos da pilha pilha1 depois que tirou o próximo elemento da pilha
        Console.WriteLine("\n\nMostranto todos elementos da pilha pilha1 ");
        foreach (var item in pilha1)
        {
            Console.WriteLine($"Item da pilha pilha1 : {item}");
        }

        //Para tirar da fila o próximo item que tem que sair da pilha
        nome1 = pilha1.Pop();
        Console.WriteLine($"\nItem que saiu da pilha : {nome1}");

        //mostranto todos elementos da pilha pilha1 depois que tirou o próximo elemento da pilha
        Console.WriteLine("\n\nMostranto todos elementos da pilha pilha1 ");
        foreach (var item in pilha1)
        {
            Console.WriteLine($"Item da pilha pilha1 : {item}");
        }



        //Criando uma pilha para guardar strings
        var pilha2 = new Stack<string>();
        pilha2.Push("1");
        pilha2.Push("Xango");
        pilha2.Push("Oxossi");
        pilha2.Push("Exu");

        //mostranto todos elementos da pilha pilha2
        Console.WriteLine("\n\nMostranto todos elementos da fila pilha2 ");
        foreach (var item in pilha2)
        {
            Console.WriteLine($"Item da pilha pilha2 : {item}");
        }

        //Para saber o valor corrente ou seja, o próximo item que tem que sair da pilha
        var nome2 = pilha2.Peek();
        Console.WriteLine($"\nItem que está para sair da pilha : {nome2}");

        //Para tirar da pilha o próximo item que tem que sair da pilha
        nome2 = pilha2.Pop();
        Console.WriteLine($"\nItem que saiu da pilha : {nome2}");

        //mostranto todos elementos da pilha pilha2 depois que tirou o próximo elemento da fila
        Console.WriteLine("\n\nMostranto todos elementos da pilha pilha2 ");
        foreach (var item in pilha2)
        {
            Console.WriteLine($"Item da pilha pilha2 : {item}");
        }

        //Para tirar da pilha o próximo item que tem que sair da pilha
        nome2 = pilha2.Pop();
        Console.WriteLine($"\nItem que saiu da pilha : {nome2}");

        //mostranto todos elementos da pilha pilha2 depois que tirou o próximo elemento da pilha
        Console.WriteLine("\n\nMostranto todos elementos da pilha pilha2 ");
        foreach (var item in pilha2)
        {
            Console.WriteLine($"Item da pilha pilha2 : {item}");
        }


        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao12()
    {
        // IF //Else If // Else
        Console.WriteLine("\n\n Estrutura de controle IF");

        var diaDaSemana = 0;
        var diaDeTrabalho = false;

        if ( diaDaSemana == 0 && diaDeTrabalho)
        {
            Console.WriteLine("\nHoje é domingo");
        }
        else if(diaDaSemana == 0 && !diaDeTrabalho)
        {
            Console.WriteLine("\nHoje é domingo, mas não é dia de trabalho");
        }
        else
        {
            Console.WriteLine("\nHoje não é domingo");
        }


        diaDaSemana = 1;

        if (diaDaSemana == 4)
        {
            Console.WriteLine("\nHoje é domingo");
        }
        else if (diaDaSemana == 2)
        {
            Console.WriteLine("\nHoje é segunda");
        }
        else if (diaDaSemana == 3)
        {
            Console.WriteLine("\nHoje é terça");
        }
        else if (diaDaSemana == 4)
        {
            Console.WriteLine("\nHoje é quarta");
        }
        else if (diaDaSemana == 5)
        {
            Console.WriteLine("\nHoje é quinta");
        }
        else if (diaDaSemana == 6)
        {
            Console.WriteLine("\nHoje é sexta");
        }
        else if (diaDaSemana == 7)
        {
            Console.WriteLine("\nHoje é sabado");
        }
        else
        {
            Console.WriteLine("\nDia da semana inválido");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }


    static void ExecutarOpcao13()
    {
        // Switch
        Console.WriteLine("\n\n Estrutura de controle Switch");

        var diaDaSemana = 0;

        switch (diaDaSemana)
        {
            case 1:
                Console.WriteLine("Hoje é domingo");
                break;
            case 2:
                Console.WriteLine("Hoje é segunda");
                break;
            case 3:
                Console.WriteLine("Hoje é terça");
                break;
            case 4:
                Console.WriteLine("Hoje é quarta");
                break;
            case 5:
                Console.WriteLine("Hoje é quinta");
                break;
            case 6:
                Console.WriteLine("Hoje é sexta");
                break;
            case 7:
                Console.WriteLine("Hoje é sábado");
                break;
            default:
                Console.WriteLine("Dia inválido");
                break;
        }

        switch(diaDaSemana < 1)
        {
            case true:
                Console.WriteLine("Dia da semana inválido");
                break;
            case false:
                Console.WriteLine("Dia válido");
                break;
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao14()
    {
        // Switch
        Console.WriteLine("\n\n Estrutura de controle FoR");

        var lista = new List<string>() { "Rafael", "Curso", "Csharp" };
        var quantidadeItensLista = lista.Count;

        Console.WriteLine($"\nQuantidade de itens da lista : {quantidadeItensLista} \n\n");
        
        for(int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao15()
    {
        // ForEach
        Console.WriteLine("\n\n Estrutura de controle ForEach");

        var lista1 = new List<string>() { "Rafael", "Curso", "Csharp" };

        //Percorrendo e mostrando Itens da lista lista1
        Console.WriteLine("\n\n Percorrendo e mostrando Itens da lista lista1");
        foreach (var item in lista1)
        {
            Console.WriteLine($"{item}");
        }

        //Percorrendo e mostrando caracteres de uma cadeia de caracteres
        Console.WriteLine("\n\n Percorrendo e mostrando caracteres de uma cadeia de caracteres \"Alessandro Figueiredo\"");
        foreach (var letra in "Alessandro Figueiredo")
        {
            Console.WriteLine($"{letra}");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao16()
    {
        // While / Do While
        Console.WriteLine("\n\n Estrutura de controle While / Do While");

        Console.WriteLine("\n Estrutura de controle While");
        var i = 0;
        while (i < 5)
        {
            Console.WriteLine($"O valor de i é : {i}");
            //i += 1;
            i++;
        }


        Console.WriteLine("\n Estrutura de controle Do");
        var j = 0;
        do
        {
            Console.WriteLine($"O valor de j é : {j}");
            //i += 1;
            j++;
        } while (j < 5);


        Console.WriteLine("\n\n Testando novamente iniciando com 5 - Estrutura de controle While / Do While");

        //primeiro checa depois faz
        Console.WriteLine("\n Estrutura de controle While");
        i = 5;
        while (i < 5)
        {
            Console.WriteLine($"O valor de i é : {i}");
            //i += 1;
            i++;
        }

        //primeiro faz depois checa
        Console.WriteLine("\n Estrutura de controle Do");
        j = 5;
        do
        {
            Console.WriteLine($"O valor de j é : {j}");
            //i += 1;
            j++;
        } while (j < 5);



        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }


    static void ExecutarOpcao17()
    {
        // While / Do While
        Console.WriteLine("\n\n Estrutura de controle Break / Continue");

        var i = 0;
        while (i < 5)
        {
            if(i < 2)
            {
                Console.WriteLine("Continuando...");
                i++;
                continue;
            }

            Console.WriteLine($"O valor de i é : {i}");

            if (i == 2)
            {
                Console.WriteLine("Valor de i é igual a 2 (dois)");
                break;
            }
        }


        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExecutarOpcao18()
    {
        // POO - Programação orientada a objeto
        Console.WriteLine("\n\n POO = Programação orientada a objeto");

        
        Produto produto = new Produto(); //instanciando classe Produto
        produto.SetId(13);
        produto.Descricao = "Durex";
        produto.ImprimirDescricao();



        var resultado = Calculos.SomarNumeros(4,3); //classe cálculos não precisa instanciar porque ela é estática
        Console.WriteLine($"O resultado da soma é : {resultado}");



        


        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}


