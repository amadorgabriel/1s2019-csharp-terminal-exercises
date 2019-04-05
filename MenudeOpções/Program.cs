using System;
using System.Threading;

namespace MenudeOpções
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine("INSTRUÇÃO:");
            System.Console.WriteLine("Cada opção tem um numero, para selecionar a função digite o número");
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine("");


            bool continuar = true;

            while (continuar != false)
            {

                Console.WriteLine("Bora lá para o menu de opções!");
                Thread.Sleep(3000);
                System.Console.WriteLine("As opções são..");
                System.Console.WriteLine("");
                System.Console.WriteLine("1 - Efetuar Login");
                System.Console.WriteLine("2 - Contato");
                System.Console.WriteLine("3 - Listar Comentários");
                System.Console.WriteLine("9 - Sair");
                System.Console.WriteLine("");
                System.Console.Write("Eai, qual número deseja acessar? ");
                int NumDecisao = int.Parse(Console.ReadLine());
                switch (NumDecisao)
                {
                    case 1:
                        System.Console.WriteLine("Entrando para efetuar login...");
                        Thread.Sleep(2000);
                        System.Console.WriteLine("Digite seu nome ou nome de usuário: ");
                        string nomeUsuário = Console.ReadLine();
                        System.Console.WriteLine("Digite sua Senha: ");
                        string senhaUsuário = Console.ReadLine();
                        System.Console.WriteLine("Perfeito, você logou!");

                        System.Console.WriteLine("Deseja uma outra função?");
                        string resposta = Console.ReadLine().ToLower();
                        System.Console.WriteLine("");
                        if ("sim".Equals(resposta))
                        {
                            continuar = true;

                            //---------------------------------------------------------------------------------------------------------------------------

                            bool continuarA = true;

                            while (continuarA != false)
                            {

                            System.Console.WriteLine("Bem Vindo(a) {0}", nomeUsuário);
                                Console.WriteLine("Bora lá para o menu de opções!");
                                Thread.Sleep(3000);
                                System.Console.WriteLine("As opções são..");
                                System.Console.WriteLine("");
                                System.Console.WriteLine("1 - Efetuar Login");
                                System.Console.WriteLine("2 - Contato");
                                System.Console.WriteLine("3 - Listar Comentários");
                                System.Console.WriteLine("9 - Sair");
                                System.Console.WriteLine("");
                                System.Console.Write("Eai, qual número deseja acessar? ");
                                int NumDecisaoB = int.Parse(Console.ReadLine());
                                switch (NumDecisaoB)
                                {
                                    case 1:
                                        System.Console.WriteLine("Entrando para efetuar login...");
                                        Thread.Sleep(2000);
                                        System.Console.WriteLine("Digite seu nome ou nome de usuário: ");
                                        string nomeUsuárioC = Console.ReadLine();
                                        System.Console.WriteLine("Digite sua Senha: ");
                                        string senhaUsuárioD = Console.ReadLine();
                                        System.Console.WriteLine("Perfeito, você logou!");

                                        System.Console.WriteLine("Deseja uma outra função?");
                                        string respostaE = Console.ReadLine().ToLower();
                                        System.Console.WriteLine("");
                                        if ("sim".Equals(respostaE))
                                        {
                                            continuarA = true;
                                            System.Console.WriteLine("Bem vindo(a) {0}", nomeUsuárioC);
                                        }
                                        else
                                        {
                                            continuarA = false;
                                        }
                                        break;

                                    case 2:
                                        bool reEmailF = true;

                                        while (reEmailF != false)
                                        {

                                            System.Console.WriteLine("Entrando para Contatar-nos...");
                                            Thread.Sleep(2000);
                                            System.Console.Write("Digite seu nome ou nome de usuário:");
                                            string nomeUsuário2 = Console.ReadLine();

                                            System.Console.WriteLine("Digite seu E-mail: ");
                                            string emailUsuário = Console.ReadLine();

                                            if (emailUsuário.Contains("@") && emailUsuário.Contains(".com"))
                                            {
                                                reEmailF = false;

                                                System.Console.WriteLine("Perfeito, agora digite sua mensagem:");
                                                string mensagemUsuário = Console.ReadLine();
                                                System.Console.WriteLine("Espere processarmos..");
                                                System.Console.WriteLine("");
                                                Thread.Sleep(2000);
                                                System.Console.WriteLine("Perfeito!");
                                                System.Console.WriteLine("Deseja uma outra função?");
                                                string resposta2E = Console.ReadLine().ToLower();
                                                System.Console.WriteLine("");
                                                if ("sim".Equals(resposta2E))
                                                {
                                                    continuarA = true;
                                                }
                                                else
                                                {
                                                    continuarA = false;
                                                }

                                            }
                                            else
                                            {
                                                System.Console.WriteLine("Faz a boa e digite um email válido campeão");
                                                Thread.Sleep(2000);
                                                reEmailF = true;
                                            }

                                        }


                                        break;

                                    case 3:
                                        System.Console.WriteLine("Entrando para as listas de comentários...");
                                        Thread.Sleep(3000);
                                        System.Console.WriteLine("");
                                        System.Console.WriteLine("  Segue abaixo os comentários em tópicos:");
                                        System.Console.WriteLine("* Meo Deos, A ponto digital me salvoou!");
                                        System.Console.WriteLine("* Quem curtiu o Software dá like");
                                        System.Console.WriteLine("* O software abriu novas portas para minha empresa de pequeno porte, maximinizando os trabalhos em um menor tempo possível, obrigado");
                                        System.Console.WriteLine("* Escrevi saí correndo..");
                                        System.Console.WriteLine("* avbwiourvgosdhgvpds0hcvdcacadcjpc");
                                        System.Console.WriteLine("* De acordo com o filósofo Piton tudo depende do quanto você quer !censored! alguém");
                                        System.Console.WriteLine("* Sensacional");
                                        System.Console.WriteLine("");
                                        System.Console.WriteLine("Deseja uma outra função?");
                                        string resposta3E = Console.ReadLine().ToLower();
                                        System.Console.WriteLine("");
                                        if ("sim".Equals(resposta3E))
                                        {
                                            continuarA = true;
                                        }
                                        else
                                        {
                                            continuarA = false;
                                        }
                                        break;

                                    case 9:
                                        System.Console.WriteLine("C-C-CeRTEza ? QQqUueer SaiR?");
                                        string SairG = Console.ReadLine().ToLower();

                                        if ("sim".Equals(SairG))
                                        {
                                            System.Console.WriteLine("Ok, você manda. Adeus.. ");
                                            continuarA = false;
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Que ótimo, então...");
                                            Thread.Sleep(1000);
                                            continuarA = true;
                                        }
                                        break;

                                    default:
                                        System.Console.WriteLine("Se decida, o que deseja? HEM!?!?1? {0} não é válido", NumDecisao);
                                        Thread.Sleep(3500);
                                        System.Console.WriteLine("Deseja ainda uma outra função?");
                                        string resposta1E = Console.ReadLine().ToLower();
                                        System.Console.WriteLine("");
                                        if ("sim".Equals(resposta1E))
                                        {
                                            continuarA = true;
                                        }
                                        else
                                        {
                                            continuarA = false;
                                        }
                                        break;

                                }

                            }


                            //----------------------------------------------------------------------------------------------------------------------------
                        }
                        else
                        {
                            continuar = false;
                        }
                        break;

                    case 2:
                        bool reEmail = true;

                        while (reEmail != false)
                        {

                            System.Console.WriteLine("Entrando para Contatar-nos...");
                            Thread.Sleep(2000);
                            System.Console.Write("Digite seu nome ou nome de usuário:");
                            string nomeUsuário2 = Console.ReadLine();

                            System.Console.WriteLine("Digite seu E-mail: ");
                            string emailUsuário = Console.ReadLine();

                            if (emailUsuário.Contains("@") && emailUsuário.Contains(".com"))
                            {
                                reEmail = false;

                                System.Console.WriteLine("Perfeito, agora digite sua mensagem:");
                                string mensagemUsuário = Console.ReadLine();
                                System.Console.WriteLine("Espere processarmos..");
                                System.Console.WriteLine("");
                                Thread.Sleep(2000);
                                System.Console.WriteLine("Perfeito!");
                                System.Console.WriteLine("Deseja uma outra função?");
                                string resposta2 = Console.ReadLine().ToLower();
                                System.Console.WriteLine("");
                                if ("sim".Equals(resposta2))
                                {
                                    continuar = true;
                                }
                                else
                                {
                                    continuar = false;
                                }

                            }
                            else
                            {
                                System.Console.WriteLine("Faz a boa e digite um email válido campeão");
                                Thread.Sleep(2000);
                                reEmail = true;
                            }

                        }


                        break;

                    case 3:
                        System.Console.WriteLine("Entrando para as listas de comentários...");
                        Thread.Sleep(3000);
                        System.Console.WriteLine("");
                        System.Console.WriteLine("  Segue abaixo os comentários em tópicos:");
                        System.Console.WriteLine("* Meo Deos, A ponto digital me salvoou!");
                        System.Console.WriteLine("* Quem curtiu o Software dá like");
                        System.Console.WriteLine("* O software abriu novas portas para minha empresa de pequeno porte, maximinizando os trabalhos em um menor tempo possível, obrigado");
                        System.Console.WriteLine("* Escrevi saí correndo..");
                        System.Console.WriteLine("* avbwiourvgosdhgvpds0hcvdcacadcjpc");
                        System.Console.WriteLine("* De acordo com o filósofo Piton tudo depende do quanto você quer !censored! alguém");
                        System.Console.WriteLine("* Sensacional");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("Deseja uma outra função?");
                        string resposta3 = Console.ReadLine().ToLower();
                        System.Console.WriteLine("");
                        if ("sim".Equals(resposta3))
                        {
                            continuar = true;
                        }
                        else
                        {
                            continuar = false;
                        }
                        break;

                    case 9:
                        System.Console.WriteLine("C-C-CeRTEza ? QQqUueer SaiR?");
                        string Sair = Console.ReadLine().ToLower();

                        if ("sim".Equals(Sair))
                        {
                            System.Console.WriteLine("Ok, você manda. Adeus.. ");
                            continuar = false;
                        }
                        else
                        {
                            System.Console.WriteLine("Que ótimo, então...");
                            Thread.Sleep(1000);
                            continuar = true;
                        }
                        break;

                    default:
                        System.Console.WriteLine("Se decida, o que deseja? HEM!?!?1? {0} não é válido", NumDecisao);
                        Thread.Sleep(3500);
                        System.Console.WriteLine("Deseja ainda uma outra função?");
                        string resposta1 = Console.ReadLine().ToLower();
                        System.Console.WriteLine("");
                        if ("sim".Equals(resposta1))
                        {
                            continuar = true;
                        }
                        else
                        {
                            continuar = false;
                        }
                        break;

                }

            }
        }
    }
}