/*using System;
using System.Collections.Specialized;

namespace variaveisEstruturda{
   class ex4{
        static void Main(string[] args){
        int n, maiorNum1, maiorNum2, posicaoNum1, posicaoNum2;
        posicaoNum1 = 0;
        posicaoNum2 = -1;

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

             maiorNum1 = vetor[0];
             maiorNum2 = int.MinValue;

            for(int i = 0; i<vetor.Length; i++){ 
               if(vetor[i]>maiorNum1){
                maiorNum2 = maiorNum1;
                posicaoNum2 = posicaoNum1;
                maiorNum1 = vetor[i];
                posicaoNum1 = i;
               }
                else if(vetor[i]>maiorNum2 && i != posicaoNum1)
                {
                    maiorNum2 = vetor[i];
                    posicaoNum2 = i;
                }
            }
            Console.WriteLine("Os maiores números pertencem a:");
            Console.WriteLine("Vetor["+posicaoNum1+"] = " + maiorNum1);
            Console.WriteLine("Vetor["+posicaoNum2+"] = " + maiorNum2);
        }
    }
}*/