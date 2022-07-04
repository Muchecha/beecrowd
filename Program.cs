using System;
using System.Globalization;

namespace Beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // --------------------------------------------------------------------------------- Cedulas
            int n1, n2, n3, n4, n5, n6, n7;
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);

            n1 = (a - a % 100) / 100;
            a = a % 100;

            n2 = (a - a % 50) / 50;
            a = a % 50;

            n3 = (a - a % 20) / 20;
            a = a % 20;

            n4 = (a - a % 10) / 10;
            a = a % 10;

            n5 = (a - a % 5) / 5;
            a = a % 5;

            n6 = (a - a % 2) / 2;
            a = a % 2;

            n7 = (a - a % 1) / 1;
            a = a % 1;

            
            Console.WriteLine($"{n1} nota(s) de R$ 100,00");
            Console.WriteLine($"{n2} nota(s) de R$ 50,00");
            Console.WriteLine($"{n3} nota(s) de R$ 20,00");
            Console.WriteLine($"{n4} nota(s) de R$ 10,00");
            Console.WriteLine($"{n5} nota(s) de R$ 5,00");
            Console.WriteLine($"{n6} nota(s) de R$ 2,00");
            Console.WriteLine($"{n7} nota(s) de R$ 1,00");

            //---------------------------------------------------------------------------------------------------------------

            //int valor;
            //valor = int.Parse(Console.ReadLine());

            //Console.WriteLine(valor);

            //int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    int qtdNotas = (valor / notas[i]);
            //    valor -= qtdNotas * notas[i];
            //    Console.WriteLine(qtdNotas + " nota(s) de R$ " + notas[i].ToString("F2"));
            //}


            // --------------------------------------------------------------------------------- Gasto de Combustivel
            //int horas;
            //int velocidade;

            //horas = int.Parse(Console.ReadLine());
            //velocidade = int.Parse(Console.ReadLine());


            //int consumo = 12;
            //double km = horas * velocidade;
            //double litros = km / consumo;

            //Console.WriteLine(litros.ToString("F3"));



            // --------------------------------------------------------------------------------- Distancia
            //int carroX;
            //int carroY;
            //int quilometros;

            //quilometros = int.Parse(Console.ReadLine());

            //quilometros = quilometros * 2;
            //Console.WriteLine(quilometros + " minutos");



            // --------------------------------------------------------------------------------- Distância Entre Dois Pontos
            //double x1;
            //double x2;
            //double y1;
            //double y2;

            //string[] valores1 = Console.ReadLine().Split();
            //x1 = double.Parse(valores1[0], CultureInfo.InvariantCulture);
            //y1 = double.Parse(valores1[1], CultureInfo.InvariantCulture);


            //string[] valores2 = Console.ReadLine().Split();
            //x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            //y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);


            //double soma = (Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2))));
            //Console.WriteLine(soma.ToString("F4"));



            // --------------------------------------------------------------------------------- Consumo
            //int x;
            //double y;

            //x = int.Parse(Console.ReadLine());
            //y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //var valor = x / y;

            //Console.WriteLine(valor.ToString("F3") + " km/l");



            // --------------------------------------------------------------------------------- O Maior
            //int a;
            //int b;
            //int c;
            //int valorA;
            //int valorB;


            //string[] valores = Console.ReadLine().Split();

            //a = int.Parse(valores[0]);
            //b = int.Parse(valores[1]);
            //c = int.Parse(valores[2]);

            //valorA = (a + b + Math.Abs(a - b)) / 2;
            //valorB = (valorA + c + Math.Abs(valorA - c)) / 2;



            //Console.WriteLine(valorB + " eh o maior");



            // --------------------------------------------------------------------------------- Area
            //double a;
            //double b;
            //double c;
            //double pi = 3.14159;

            //string text = Console.ReadLine();
            //string[] input = text.Split();
            //a = double.Parse(input[0], CultureInfo.InvariantCulture);
            //b = double.Parse(input[1], CultureInfo.InvariantCulture);
            //c = double.Parse(input[2], CultureInfo.InvariantCulture);

            //var triangulo = (a * c) / 2;
            //var circulo = (c * c) * pi;
            //var trapezio = ((a + b) * c) / 2;
            //var quadrado = b * b;
            //var retangulo = a * b;

            //Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));



            // --------------------------------------------------------------------------------- Cálculo Simples
            //int codigoA;
            //int pecasA;
            //double valorA;
            //int codigoB;
            //int pecasB;
            //double valorB;

            //string text = Console.ReadLine();
            //string[] input = text.Split();
            ////codigoA = int.Parse(input[0]);
            //pecasA = int.Parse(input[1]);
            //valorA = double.Parse(input[2], CultureInfo.InvariantCulture);

            //input = Console.ReadLine().Split();
            ////codigoB = int.Parse(input[0]);
            //pecasB = int.Parse(input[1]);
            //valorB = double.Parse(input[2], CultureInfo.InvariantCulture);

            //double somaA = pecasA * valorA;
            //double somaB = pecasB * valorB;

            //double soma = somaA + somaB;

            //Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
