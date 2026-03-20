using System;

namespace variaveisEstruturda{
   class ex10{
        static void Main(string[] args){
        int n, media, soma;
        soma = 0;
     
            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 

            for(int i = 0; i < vetor.Length; i++){ 
                Console.WriteLine("Digite uma temperatura: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i<vetor.Length; i++){
                    soma = soma + vetor[i];
                    Console.WriteLine("Vetor["+i+"]"+vetor[i]);
                }
            media = soma/n;

            Console.WriteLine("A soma dos salários dentro dos Vetores é: "+soma);
        }    
    }
}
