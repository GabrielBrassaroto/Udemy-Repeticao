using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //// SWITCH
            ////int diaSemana = int.Parse(Console.ReadLine());

            ////switch (diaSemana) { 
            ////    case 1:
            ////        Console.WriteLine("hoje é segunda feira");
            ////        break;
            ////    case 2:
            ////        Console.WriteLine("hoje é terca feira");
            ////        break;
            ////    case 3:
            ////        Console.WriteLine("hoje é quarta feira");
            ////        break;
            ////    case 4:
            ////        Console.WriteLine("hoje é quinta feira");
            ////        break;
            ////    case 5:
            ////        Console.WriteLine("hoje é sexta feira");
            ////        break;
            ////    default:
            ////        Console.WriteLine("voce não inseriu um valor valido");
            ////        break;

            ////}


            /// WHILE
            ////int x,soma;
            ////x = int.Parse(Console.ReadLine());
            ////soma = 0;

            ////while (x != 0)
            ////{
            ////    soma += x;
            ////    x = int.Parse(Console.ReadLine());
            ////}

            ////Console.WriteLine(soma);

            ///FOR
            ////int Numero,x;///numero seria a quantidade de numeros que vou digitar

            ////Numero = int.Parse(Console.ReadLine());
            ///cria a variavel i para ser a contagem
            ///e inicia essa variavel como 1 porque é inicio do intervalo
            ///condicao vai ate que o i seja menor ou igual ao N
            ///incrementar seria o i receber mais um valor toda a vez que passa no for
            ///

            ////int soma = 0;

            ////for (int i=1;i<=Numero;i++)
            ////{
            ////    x = int.Parse(Console.ReadLine());
            ////    soma = soma + x;

            ////}

            ////Console.WriteLine(soma);

            ////int Numero;

            ////Numero = int.Parse(Console.ReadLine());

            ////for(int i= 1; i<= 10; i++)
            ////{
            ////    int resultado = i * Numero;
            ////    Console.WriteLine(i + "X" + Numero + "=" + resultado);
            ////}


            //int x = 4;
            //int y = x + 2;

            //for(int i = 0; i<x; i++)
            //{
            //    Console.WriteLine(x + "     " + y);
            //    y = y + i;
            //}

            //int x = 8;
            //int y = 3;
            //for(int i = 0; y < x; i++)
            //{
            //    x = x - 2;
            //    y = y + 1;
            //    Console.WriteLine(i);
            //}
            ////DO WHILE
            //double C, F;
            //char resposta;

            //do
            //{

            //    Console.Write("Digite a temperatura em celsus");
            //    C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    F = 9.0 * C / 5.0 + 32.0;
            //    Console.WriteLine("A temperatura equivalente em Fahrenheit" + F);
            //    Console.WriteLine("Deseja Repetir?s/n");
            //    resposta = char.Parse(Console.ReadLine());

            //} while (resposta == 's');

            // VETOR
            ////double[] b;
            ////b = new double[5];
            ////for(int i = 0; i < 5; i++)
            ////{
            ////    b[i] = i + 10;
            ////    Console.WriteLine(i);
            ////}

            /// exercicio 1 vetor
            ////int N;
            ////int[] vet;// cria um vetor de int

            ////N = int.Parse(Console.ReadLine()); /// ler o valor que vai ser inserido
            ////vet = new int[N];//instanciar o vetor
            ////string[] s = Console.ReadLine().Split(' '); // coloca cada numero com espaco dentro de vetor

            ////for (int i = 0; i < N; i++)
            ////{
            ////    vet[i] = int.Parse(s[i]);
            ////}

            ////for (int i = 0; i < N; i++)
            ////{
            ////    if(vet[i] < 0) {
            ////        Console.WriteLine(vet[i]);
            ////    }
            ////}


            ////exercicio 2

            //int N; //quantidade de numeros
            //double[] vetor; //criacao do vetor 

            //N = int.Parse(Console.ReadLine());//leitura da quantidade de numeros

            //vetor = new double[N]; // instancia e cria o vetor com tamanho dos numeros

            //string[] s = Console.ReadLine().Split(' ');//cria um vetor de string para ler os dados inseridos 


            //for (int i = 0; i < N; i++)
            //{

            //    vetor[i] = double.Parse(s[i],CultureInfo.InvariantCulture); //converter e coloca o s[i]  no vetor e converte de string para vetor de double
            //}

            //for(int i = 0; i < N; i++)
            //{
            //    Console.Write(vetor[i] + " ");
            //}

            //Console.WriteLine();//qubera  a linha

            //double soma = 0.0; //cria a soma 

            //for (int i = 0;i<N;i++)
            //{
            //    soma = soma + vetor[i];//soma cada vez que passa no for
            //}



            //double media = soma / N;

            //Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture)); //mostra a soma
            //Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));//mostra a 

            ////exercicio 3

            //int N;
            //N = int.Parse(Console.ReadLine());//leitura da quantidade de pessoas

            //int[] idade = new int[N]; //cria os vetores e instancia com o valor de N
            //string[] nomes = new string[N];//cria os vetores e instancia com o valor de N
            //double[] altura = new double[N];//cria os vetores e instancia com o valor de N

            ////leitura do dados
            //for (int i = 0; i < N; i++)
            //{
            //    string[] s = Console.ReadLine().Split(' ');
            //    nomes[i] = s[0]; // passa o campo do vetor 0 para a variavel
            //    idade[i] = int.Parse(s[1]);// passa o campo do vetor 1 para a variavel
            //    altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture); //converter e coloca o s[i]  no vetor e converte de string para vetor de double
            //}

            ////calculo da altura media das pessoas
            //double soma = 0.0;

            //for (int i = 0; i < N; i++)
            //{
            //    soma = soma + altura[i];
            //}
            //double media = soma / N;


            //Console.WriteLine("Media as pessoas: " + media.ToString("F2",CultureInfo.InvariantCulture));

            /////porcentagem de pessoas 

            //int cont = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    if(idade[i]< 16) //pessoa menor de 16 coloca na lista de contagem e dps faz a porcentagem
            //    {
            //        cont++;
            //    }
            //}

            //double porcentagem =(double) cont / N * 100.0; //(DOUBLE) para forca que seja em casa decimal o retorno e faz a porcetagem com numero da lista e regra de 3

            //Console.WriteLine("PEssoas com menor de 16 anos:" + porcentagem.ToString("F2",CultureInfo.InvariantCulture) + "%");


            //foreache

            //int N;
            //N = int.Parse(Console.ReadLine());
            //string[] vet = new string[N];

            //for (int i = 0; i < N; i++)
            //{
            //    vet[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Nomes Lidos: ");

            //foreach (string elemento in vet)///coloco como nome o item que vai percorrer o vet 
            //{
            //    Console.WriteLine(elemento);//nome que foi criado para percorrer
            //}


            //exercicio propostos vetores

            //int N;
            //N = int.Parse(Console.ReadLine());
            //double[] vet = new double[N];

            //for (int i = 0; i < N; i++)
            //{
            //    string[] s = Console.ReadLine().Split(' ');
            //    vet[i] = double.Parse(s[i]);
            //    if (vet[0] > vet[1])
            //    {
            //        Console.WriteLine();
            //    }
            //}

            //double num = 0.0;
            //foreach (double num1 in vet)
            //{
            //    vet[]
            //}


            //Matrizes

            //double[,] A; //criando uma matriz
            //A = new double[3, 4]; // instanciando a matriz

            //int[,] A; //cria a matriz 
            //int M, N; //variavel que vai armazwnar os campos

            //string[] s1 = Console.ReadLine().Split(' ');
            //M = int.Parse(s1[0]); //letura dos campos 
            //N = int.Parse(s1[1]);

            //A = new int[M,N]; //instanciacao dos campos

            //for (int i = 0; i < M; i++) /// FOR PARA VER O TAMANHO DAS LINHAS 
            //{
            //    string[] s = Console.ReadLine().Split(' ');//pega os valores por espaço
            //    for (int j = 0; j < N; j++)///cada  colunha da matriz vai criar  um 
            //    {
            //        A[i, j] = int.Parse(s[j]);
            //    }

            //    Console.WriteLine();

            //}

            ////MOSTRAR NA TELA   
            //for (int i = 0; i < M; i++)//percorre todas as linhas do M
            //{
            //    for (int j = 0; j < N; j++)//percorre todas as linhas do N
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Exercicio corrigido 1

            //int[,] A;
            //int M;

            //string[] s1 = Console.ReadLine().Split(' ');
            //M = int.Parse(s1[0]); //letura dos campos 

            //A = new int[M, M];

            //for (int i = 0; i < M; i++) /// FOR PARA VER O TAMANHO DAS LINHAS 
            //{
            //    string[] s = Console.ReadLine().Split(' ');//pega os valores por espaço
            //    for (int j = 0; j < M; j++)///cada  colunha da matriz vai criar  um 
            //    {
            //        A[i, j] = int.Parse(s[j]);
            //    }

            //}

            //Console.WriteLine("Diagonal Principal: ");

            //for (int i = 0; i < M; i++)
            //{
            //    Console.WriteLine(A[i, i]);
            //}

            //Console.WriteLine();

            //int count = 0;

            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
            //        if (A[i, j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("quantidade de negativos" + count);


            //Exercicio 2 

            int[,] A;
            int M, N;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            A = new int [M,N];

            for (int i = 0; i < M; i++) //ler a linha
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)//percorre as colunas
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[M];//cria um vetor com quantidade de linha 

            for (int i = 0; i < M; i++) //for para somar 
            {
                int soma = 0;//cria var coloca int soma

                for (int j = 0; j< N; j++)//for para somar 
                {
                    soma = soma + A[i, j];

                }
                vet[i] = soma;
            }

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }



            Console.ReadLine();
        }
    }
}
