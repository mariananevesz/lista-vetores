using System;
using System.Collections.Specialized;

namespace variaveisEstruturdas{
   class ex2{
        static void Main(string[] args){
        int n, maiorNum, posicao;
        posicao = 0;

            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 

            for(int i = 0; i < vetor.Length; i++){  //for pra pessoa poder digitar o n° do vetor, até a qtd que ele digitou
                Console.WriteLine("Digite um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<vetor.Length; i++){ //for pra mostrar os nms do vetor bonitinho
                Console.WriteLine("Vetor["+i+"]" + vetor[i]);
            }

             maiorNum = vetor[0];
            for(int i = 0; i<vetor.Length; i++){ 
               if(vetor[i]>maiorNum){
                maiorNum = vetor[i];
                posicao = i;
               }
            }
            Console.WriteLine("O maior número pertence ao Vetor["+posicao+"] = " + maiorNum);
        }
    }
}

