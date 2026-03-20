/*using System;
using System.Collections.Specialized;

namespace variaveisEstruturda{
   class ex5{
        static void Main(string[] args){
        int n, maiorNum, menorNum, posicaoMaior, posicaoMenor;
        posicaoMaior = 0;
        posicaoMenor = 0;

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

             maiorNum = vetor[0];
             menorNum = vetor[0];
            for(int i = 0; i<vetor.Length; i++){ 
               if(vetor[i]>maiorNum){
                maiorNum = vetor[i];
                posicaoMaior = i;
               }
                else if(vetor[i]<menorNum)
                {
                    menorNum = vetor[i];
                    posicaoMenor = i;
                }
            }
            Console.WriteLine("Os maior e o menor número pertencem respectivamente a:");
            Console.WriteLine("Vetor["+posicaoMaior+"] = " + maiorNum);
            Console.WriteLine("Vetor["+posicaoMenor+"] = " + menorNum);
        }
    }
}*/