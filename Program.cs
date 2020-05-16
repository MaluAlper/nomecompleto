using System;

namespace nomecompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine ("Digite seu primeiro nome");
            string nome = Console.ReadLine();

             Console.WriteLine ("digite seu Segundo nome");
            string segundonome = Console.ReadLine();
            
            Console.WriteLine ("Seu nome completo é "+ nome + " " + segundonome);

            Console.WriteLine ("Seu nome catalágo é " + segundonome.ToUpper() + " " + nome);
            
            

           




        }   
    }
}
