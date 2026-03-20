using System;

namespace variaveisEstruturda{
   class ex8{
        static void Main(string[] args){
        int n;
        double  mult, numConstante;
        mult = 1;

            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 

            Console.WriteLine("Digite um número real constante: "); 
            numConstante = Convert.ToDouble(Console.ReadLine());

            for(int i = 0; i < vetor.Length; i++){ 
                Console.WriteLine("Digite um elemento do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i<vetor.Length; i++){
                mult = vetor[i] * numConstante;
                 Console.WriteLine("Vetor["+i+"]"+vetor[i]+" x "+numConstante+" = "+mult);
            }
        }
    }
}