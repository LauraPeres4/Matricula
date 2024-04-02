using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Matricula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string res = "S";
            int adm = 0;
            int meca = 0;
            int ds = 0;
            int edf = 0;
            while (res == "S")
            {
                Console.Clear();
                Console.WriteLine("Qual curso deseja se matricular? Digite 1 para Administração; 2 para Mecatrônica; 3 para Desenvolvimento de Sistemas ou 4 para Edificações.");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        if (adm < 5)
                        {
                            Console.WriteLine("Você foi matriculado.");
                            adm++;
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente não há vagas.");
                        }
                        break;

                    case 2:
                        if (meca < 5)
                        {
                            Console.WriteLine("Você foi matriculado.");
                            meca++;
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente não há vagas.");
                        }
                        break;

                    case 3:
                        if (ds < 5)
                        {
                            Console.WriteLine("Você foi matriculado.");
                            ds++;
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente não há vagas.");
                        }
                        break;

                    case 4:
                        if (edf < 5)
                        {
                            Console.WriteLine("Você foi matriculado.");
                            edf++;
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente não há vagas.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
                }
                Console.WriteLine("Vagas ocupadas em Administração: " + adm);
                Console.WriteLine("Vagas ocupadas em Mecatrônica: " + meca);
                Console.WriteLine("Vagas ocupadas em Desenvolvimento de Sistemas: " + ds);
                Console.WriteLine("Vagas ocupadas em Edificações: " + edf);

                Console.WriteLine("Deseja continuar? [S/N]");
                res = Console.ReadLine();

                


                

            }
        }
    }
}
