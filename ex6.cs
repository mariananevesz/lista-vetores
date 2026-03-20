using System;
using System.Collections.Specialized;

namespace variaveisEstruturda{
   class ex6{
        static void Main(string[] args){
        int n;
    
            Console.WriteLine("Digite o tamanho do vetor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[n]; 

            for(int i = 0; i < vetor.Length; i++){ 
                Console.WriteLine("Digite uma idade dentro do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i=0; i<vetor.Length; i++){
                if(vetor[i]>= 1 && vetor[i] <= 9){
                    Console.WriteLine("Vetor["+i+"]" + " Idade = "+vetor[i]+" = Criança");
                }

                else if(vetor[i]>=10 && vetor[i]<=12){
                    Console.WriteLine("Vetor["+i+"]" + " Idade = "+vetor[i]+" = Pré-adolescente");

                }

                else if (vetor[i]>=13 && vetor[i]<=17){
                    Console.WriteLine("Vetor["+i+"]" + " Idade = "+vetor[i]+" = Adolescente");
                }

                else if(vetor[i]>=18 && vetor[i]<=59){
                    Console.WriteLine("Vetor["+i+"]" + " Idade = "+vetor[i]+" = Adulto");
                }
                else
                {
                    Console.WriteLine("Vetor["+i+"]" + " Idade = "+vetor[i]+" = Idoso");

                }
            }

            }
        }
    }
