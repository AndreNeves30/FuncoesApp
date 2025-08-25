using System;

namespace MyApp
{
    internal class Program
    {
        /// <summary>
        /// Atalho para printar na tela
        /// </summary>
        /// <param name="message">aqui ver oque deve ser exibido</param>
        static void Print(string message) 
        {
            Console.WriteLine(message);
        }
        static void Print(double message)
        {
            Console.WriteLine(message.ToString());
        }
        static void Print(int message)
        {
            Console.WriteLine(message.ToString());
        }
        static void Print(float message)
        {
            Console.WriteLine(message.ToString());
        }
        /// <summary>
        /// Essa função calcula a area do circulo
        /// </summary>
        /// <param name="area">aqui fica o raio do circulo</param>
        /// <returns></returns>

        static Double CalcArea(Double area) 
        {
            Double saida = 0;
            saida = Math.PI* Math.Pow(area,2);
            return saida;
        }
        static void Main(string[] args)
        {
            Print("Olá insira seu nome!");
            String nome = Console.ReadLine();
            Print(nome + " agora insira a area do circulo que deseja calcular!");
            Double area = CalcArea(double.Parse(Console.ReadLine()));
            Print(nome + " a area do circulo será: " + area);
        }
    }
}