using System;

namespace console_dotnet
{    
    class Validacao
    {
        public void numero(int a, int b) {
            Random r = new Random();
            int n = r.Next(a, b);
            int s = r.Next(a, b);
            int resul = n + s;
            System.Console.WriteLine(n + " + " + s + " = ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == resul) {
                System.Console.WriteLine("Acesso liberado!");
            } else {
                System.Console.WriteLine("Acesso bloqueado!");
            }
        }
    }
}