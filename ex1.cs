using System;

namespace variaveisEstruturdas{
   class ex1{
        static void Main(string[] args){
        int n;
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

            for(int i = n-1; i>=0; --i){ 
                Console.WriteLine("Vetor Reverso["+i+"]"+vetor[i]);
            }
            
        }
    }
}

