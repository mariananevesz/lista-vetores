using System;
using System.Collections.Specialized;

namespace variaveisEstruturdas{
   class ex2{
        static void Main(string[] args){
        int n, menorNum, posicao;
        posicao = 0;

            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 

            for(int i = 0; i < vetor.Length; i++){ 
                Console.WriteLine("Digite um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<vetor.Length; i++){ 
                Console.WriteLine("Vetor["+i+"]" + vetor[i]);
            }

             menorNum = vetor[0];
            for(int i = 0; i<vetor.Length; i++){ 
               if(vetor[i]<menorNum){
                menorNum = vetor[i];
                posicao = i;
               }
            }
            Console.WriteLine("O menor número pertence ao Vetor["+posicao+"] = " + menorNum);
        }
    }
}

