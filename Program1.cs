namespace MeuSegundoApp;

class Program
{
    static void Main(string[] args)
    {
        //exercicio 1
        /*
            System.Console.WriteLine("Insira o primeiro numero: ");
            var num1 = int.Parse(Console.ReadLine() );
            System.Console.WriteLine("Insira o segundo numero: ");
            var num2 = int.Parse(Console.ReadLine() );

            var soma = num1 + num2;
            var subtracao = num1 - num2;
            var mult = num1 * num2;
            double div = (double)num1 / num2; // Corrigido aqui

            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Subtração: {subtracao}");
            System.Console.WriteLine($"Multiplicação: {mult}");
            System.Console.WriteLine($"Divisão: {div}");
        */
        //Exercicio 2
        /*
        Console.WriteLine("Digite o valor que deseja calcular o desconto: ");
        var num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do desconto: ");
        var num2 = int.Parse(Console.ReadLine());

        var Descont = (num1 * num2) / 100 ;
        var result = (num1 - Descont);

        Console.WriteLine($"Seu valor do desconto é: {Descont} Seu valor total é: {result}");
        */
        //Exercicio 3
        /*
                for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i);

            if (i < 20)
            {
                Console.Write(", ");
            }
        }
        */
        //Exercicio 4
        /*
        Console.WriteLine("Digite o primeiro numero: ");
        var num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        var num2 = int.Parse(Console.ReadLine());

        int calc = 0;
            for (int i = num1; i < num2 +1; i++) {
            calc += i;
        }
        Console.WriteLine($"O total é {calc}");
        */

        //Exercicio 5
        /*
        int[] num = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o {i + 1} numero que deseja colocar: ");
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Os valores na ordem inversa:");
        for (int o = 4; o >= 0; o--)
        {
            Console.WriteLine(num[o] + "");
        }

        //Exercicio 6
        /*

        int[] num = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º numero que deseja colocar: ");
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Digite o numero que deseja buscar: ");
        var busca = int.Parse(Console.ReadLine());

        bool achou = false;
        foreach (int nume in num)
        {
            if (nume == busca)
            {
                achou = true;
                break;
            }
        }
        if (achou)
        {
            Console.WriteLine($"O numero {busca} que voce digitou esta lista");
        }
        else
        {
            Console.WriteLine($"O numero {busca} que voce digitou não esta na lista");
        }

        //Exercicio 7
        /*
            Console.WriteLine("Digite a sua primeira nota: ");
            var num1 = int.Parse(Console.ReadLine() );
            Console.WriteLine("Digite a sua segunda nota: ");
            var num2 = int.Parse(Console.ReadLine() );
            Console.WriteLine("Digite a sua terceira nota: ");
            var num3 = int.Parse(Console.ReadLine() );

            double med = (num1 + num2 + num3) / 3;

            Console.WriteLine($"Sua media é: {med}");
        */

        //Exercicio 8

        /*
        Console.Write("Digite um número para verificar se é primo: ");
        int numero = int.Parse(Console.ReadLine());

        if (NumPrim(numero))
        {
            Console.WriteLine($"{numero} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é um número primo.");
        }
        }

            static bool NumPrim(int numero)
        {
        if (numero <= 1)
        {
            return false;
        }
        if (numero == 2)
        {
            return true;
        }
        if (numero % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i * i <= numero; i += 2)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
        */
    }
    //Exercicio 9
    /*
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
    }

    static void Main(string[] args)
    {
        Carro carro1 = new Carro();

        carro1.Marca = "TOYOTA";
        carro1.Modelo = "AE86";
        carro1.Ano = 1987;

        Console.WriteLine($"{carro1.Marca} {carro1.Modelo} - {carro1.Ano}");
    }
    */
    //Exercicio 10

    class Program
    {
        static int Somar(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Dividir(int a, int b)
        {

            if (b == 0)
            {
                Console.WriteLine("Erro");
                return 0;
            }
            return (double)a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("SOMA: " + Somar(num1, num2));
            Console.WriteLine("SUBTRAÇÃO: " + Subtrair(num1, num2));
            Console.WriteLine("MULTIPLICAÇÃO: " + Multiplicar(num1, num2));
            Console.WriteLine("DIVISÃO: " + Dividir(num1, num2));
        }
    }
}