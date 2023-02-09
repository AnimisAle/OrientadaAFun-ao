using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Curso
{
    internal class Program
    {
          public int CalcularSoma2()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;   
        }
          static int CalcularSoma()
          {
              int a = 1;
              int b = 2;
              int c = a + b;
              return c;

          }
          public static void tabuada(int numero)
          {
            Console.WriteLine("=============== Calculo da tabuada do "+ numero + " ======================");
             for(int i = 1; i <= 10; i++) {
                  Console.WriteLine(numero + "X" + i + "=" + (numero * i)); 
              }
            Console.WriteLine("=====================================");
        }
        
        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Hello World");
        }

        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("===============================================");
            if(File.Exists(arquivoComCaminho)) {

                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                    Console.WriteLine("===============================================");
                }
            }
            string arquivosComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if(File.Exists(arquivosComCaminho2)) {
                LerArquivo(numeroArquivo + 1); 
            }
        }

        public static void calcularMediaAlunos()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            int qtdNotas = 3; 
            Console.WriteLine("\nDigite as " + qtdNotas + " notas do aluno:  " + nome);
           
            List<double> notas = new List<double>();
            double mediaAluno = 0;
          
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                double nota = double.Parse(Console.ReadLine());
                mediaAluno+= nota/3;
                notas.Add(nota);
            }
            double totalNota = notas.Count;

            Console.WriteLine("A média do aluno " + nome + " é: " + mediaAluno);
            Console.WriteLine(" Suas notas são: \n");
            foreach (double nota in notas) 
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
                }
        private static void Menu()
        {
            while (true)
            {
                string Mensagem = "Olá, seja bem vindo ao programa, utilizando programação funcional... +" +
                    "\n Digite uma das opções abaixo: \n" +
                    "\n 0 - Sair do programa" +
                    "\n 1 - Para ler arquivos" +
                    "\n 2 - Para executar a tabuada" +
                    "\n 3 - Calcular media de alunos";

                Console.WriteLine(Mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("======= Opção de ler arquivos ======= \n");
                    LerArquivo(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("======= Opção tabuada ======= \n");
                    Console.WriteLine("Digire o número que deseja na tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    tabuada(numero);
                    Console.WriteLine("============================ \n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("============================ \n");
                    calcularMediaAlunos();
                }
                else
                {
                    Console.WriteLine("============================ \n");
                    Console.WriteLine("Opção inválida, digite uma das opções válidas...");
                    Console.WriteLine("============================ \n");
                }

            }
        }

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        static void Main(string[] args)
        {
            Menu();
        }
   
    }

    
 }

