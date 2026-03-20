using System;

namespace variaveisEstruturdas{
   class Program{
        static void Main(string[] args){
            int n, soma;
            Console.WriteLine("Digite o tamanho do vetor: "); //usuario digita o tamnho do vetor que quer
            n = Convert.ToInt32(Console.ReadLine());
            soma = 0;
            int[] vetor = new int[n]; //declarando o vetor tamanho de n

            for(int i = 0; i < vetor.Length; i++){  //for pra pessoa poder digitar o n° do vetor, até a qtd que ele digitou
                Console.WriteLine("Digite um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<vetor.Length; i++){ //for pra mostrar os nms do vetor bonitinho
                Console.WriteLine("Vetor["+i+"]" + vetor[i]);
            }

            for(int i = 0; i<vetor.Length; i++){ // for pra fazer a soma dos vetores
                soma = soma + vetor [i];
            }
            Console.WriteLine("A soma dos vetores é: "+soma);
        }
    }
}