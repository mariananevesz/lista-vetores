/*using System;
using System.Collections.Specialized;

namespace variaveisEstruturda{
   class ex7{
        static void Main(string[] args){
        int n, soma, mult, qtdNums;
        soma = 0;
        mult = 1;
        qtdNums = 0;

            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 

            for(int i = 0; i < vetor.Length; i++){ 
                Console.WriteLine("Digite um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i<vetor.Length; i++){
                if (vetor[i] % 2 == 0){
                    soma = soma + vetor[i];
                    mult = mult * vetor[i];
                    qtdNums++;
                }
            }
            Console.WriteLine("A soma dos valores pares dentro do Vetor é: "+soma);
            Console.WriteLine("A multiplicação dos valores pares dentro do Vetor é: "+mult);
            Console.WriteLine("A quantidade de números pares dentro do Vetor é: "+qtdNums);
        }
    }
}*/