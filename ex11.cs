using System;

namespace variaveisEstruturda{
   class ex11{
        static void Main(string[] args){
        int n, numElevado, numCubo; 

            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 
            int[] resultadoQuadrado = new int[n];
            int[] resultadoCubos = new int[n]; 

            for(int i = 0; i < vetor.Length; i++){ 
                Console.WriteLine("Digite um número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i<vetor.Length; i++){
                    numElevado = vetor[i]*vetor[i];
                    numCubo = vetor[i]*vetor[i]*vetor[i];
                    resultadoQuadrado[i] = numElevado;
                    resultadoCubos[i] = numCubo;
                    Console.WriteLine("Vetor["+i+"] "+vetor[i]);
                }

            Console.WriteLine("\nQuadrados:");
            for (int i = 0; i < resultadoQuadrado.Length; i++)
            {
                Console.WriteLine("Vetor["+i+"] = " + resultadoQuadrado[i]);
            }    

            Console.WriteLine("\nCubos:");
            for (int i = 0; i < resultadoCubos.Length; i++)
            {
                Console.WriteLine("Vetor["+i+"] = " + resultadoCubos[i]);
            }
            
        }    
    }
}