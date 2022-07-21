using System;
using System.Globalization;
namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            //--teste de aula-----------------------------------------------------------------------------------------------------------------------------------//
            int idade1 = 50;
            char genero1 = 'M';
            string nome = "Paulo";
            double saldo = 25.2641;
            
            Console.WriteLine("teste de aula");
            Console.WriteLine();
            Console.WriteLine(genero1);
            Console.WriteLine(idade1);
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine("{0} tem {1} anos e possui um saldo de {2:f3} reais", nome, idade1, saldo.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} tem {idade1} anos e possui um saldo de {saldo.ToString("f3", CultureInfo.InvariantCulture)} reais");
            Console.WriteLine(nome + " tem " + idade1 + " anos e tem saldo igual a " + saldo.ToString("F3", CultureInfo.InvariantCulture) + " reais ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            //--Exercicios---------------------------------------------------------------------------------------------------------------------------------------//
            byte idade = 30;
            char genero = 'M';
            int codigo = 5290;
            double preco2 = 650.50;
            double preco1 = 2100.00;
            double medida = 53.234567;
            string produto1 = "computador";
            string produto2 = "Mesa de escritorio";
                     
            Console.WriteLine("execicio 1");
            Console.WriteLine();
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine($"Registro:{idade} anos de idade, codigo {codigo} e genero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arrodondado tres casas decimais: {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}