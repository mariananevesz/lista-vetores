using System;

namespace variaveisEstruturda{
   class ex12{
        static void Main(string[] args){
        int n, numElevado; 
        double soma,MQR;
        soma = 0;

     
            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 

            for(int i = 0; i < vetor.Length; i++){ 
                Console.WriteLine("Digite um número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i<vetor.Length; i++){
                    numElevado = vetor[i]*vetor[i];
                    soma = soma+numElevado;
                    Console.WriteLine("Vetor["+i+"] "+vetor[i]);
                    Console.WriteLine("Vetor Elevado["+i+"] "+numElevado);
                }
            MQR = Math.Sqrt(soma/vetor.Length);
            Console.WriteLine("A Média da Raiz Quadrada é: "+MQR);
        }    
    }
}