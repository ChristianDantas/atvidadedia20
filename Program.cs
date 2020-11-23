using System;

namespace atvidadedia20
{
    class Program
    {
        static void Main(string[] args)
        {
          
        Media();
        void Media(){ 
           string[] nomesa= new string[10];
            int[] nota1= new int[10];
            int[] nota2= new int[10];
            int[] nota3= new int[10];
            int[] nota4= new int[10];
            int[] media= new int[10];

            for (var i = 0; i <10; i++)
            {
                Console.WriteLine("Digite o nome");
                nomesa[i]=Console.ReadLine();
                Console.WriteLine("Digite a primeira nota");
                nota1[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota");
                nota2[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota");
                nota3[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota");
                nota4[i]=int.Parse(Console.ReadLine());
                media[i]=(nota1[i]+nota2[i]+nota3[i]+nota4[i])/2;
                 if(media[i] < 7){
                     Console.WriteLine($"o aluno {nomesa[i]} tem media {media[i]}");
                     Console.WriteLine($"o {nomesa[i]} está reprovado "); 
                 }
                 else{
                    Console.WriteLine($"o aluno {nomesa[i]} tem media {media[i]}");
                     Console.WriteLine($"o {nomesa[i]} está aprovado"); 
                 }
            }
        }
        }
    }
}
