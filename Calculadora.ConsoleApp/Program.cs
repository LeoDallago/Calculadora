namespace Calculadora.ConsoleApp
{
    //Requesito 01 (OK)
    //Pegar dois numeros

    //Requesito 02 (OK)
    //Somar mais de uma vez

    //Requesito 03 (OK)
    //Realizar varias operações de soma e subtração

    //Requesito 04 (OK)
    //Quatro Operacoes Basicas

    //Requesito 05 (OK)
    //Operacoes com 0

    //Requesito 06 (OK)
    //Validar menu

    //Requesito 07 (OK)
    //Casas decimais

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                string operacao = MostrarMenu();

                if (OpcaoInvalida(operacao))
                {
                    Console.WriteLine("Opção invalida");
                    Console.ReadLine();
                    continue;
                }

                if (OpcaoSair(operacao))
                {
                    break;
                }

                //input (declaração e atribuição)
                Console.WriteLine("Por favor, Digite o primeiro numero:");
                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.WriteLine("Por favor, Digite o segundo numero::");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                //Verificacao de divisao
                if (operacao == "3" && segundoNumeroString == "0")
                {
                    Console.WriteLine("Numero invalido");
                    Console.ReadLine();
                    continue;
                }

                //calculo
                string nomeOperacao = "";
                decimal resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    nomeOperacao = "Adição";
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    nomeOperacao = "Subtração";
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero / segundoNumero;
                    nomeOperacao = "Divisão";
                }

                else if (operacao == "4")
                {
                    resultado = primeiroNumero * segundoNumero;
                    nomeOperacao = "Multiplicação";
                }


                //output(saida das informacoes)
                Console.WriteLine($"O resultado da sua {nomeOperacao} é: {resultado}");


                //Não remover esta linha (manter console aberto)
                Console.ReadLine();
            }

            //PROCEDIMENTO = conjunto de instrucoes que executam em sequencia
            // FUNCAO = um PROCEDIMENTO que retorna um valor

            //PROCEDIMENTO DE MENU
            static string MostrarMenu()
            {
                Console.Clear();

                Console.WriteLine("Bem-Vindo a Calculadora!\n");

                Console.WriteLine("Digite 1 para Adição");
                Console.WriteLine("Digite 2 para Subtração");
                Console.WriteLine("Digite 3 para Divisão");
                Console.WriteLine("Digite 4 para Multiplicação");
                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                return operacao;
            }

            // funcao com argumento
            static bool OpcaoSair(string opcao)
            {
                bool opcaoSair = opcao == "S" || opcao == "s";

                return opcaoSair;
            }

            static bool OpcaoInvalida(string opcao)
            {
                bool opcaoInvalida = !(opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "S" || opcao == "s");

                return opcaoInvalida;
            }

        }
    }
}