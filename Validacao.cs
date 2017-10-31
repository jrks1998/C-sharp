using System;

namespace console_dotnet
{    
    class Validacao
    {
        public Boolean numero(int a, int b) {
            Random r = new Random();
            int n = r.Next(a, b);
            int s = r.Next(a, b);
            int soma = n + s;
            System.Console.WriteLine(n + " + " + s + " = ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == soma) {
                System.Console.WriteLine("Acesso liberado!");
                return true;
            } else {
                System.Console.WriteLine("Acesso bloqueado!");
                return false;
            }
        }
    }
}