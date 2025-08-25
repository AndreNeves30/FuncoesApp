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

        /// <summary>
        /// Essa função soma dois numeros inteiros
        /// </summary>
        /// <param name="n1">fica o primeiro numero inteiro</param>
        /// <param name="n2">fica o segundo numero inteiro</param>
        /// <returns>Retorna soma do n1 e n2</returns>
        static int soma(int n1, int n2) 
        {
            return n1 + n2;
        }

        static void Saudacao(string nome)
        {
            Print("Olá, " + nome + "!");
        }

        /// <summary>
        /// Calcula a área de um retângulo.
        /// </summary>
        /// <param name="baseRet">Base do retângulo</param>
        /// <param name="alturaRet">Altura do retângulo</param>
        /// <returns>Área do retângulo</returns>
        static double CalcAreaRetangulo(double baseRet, double alturaRet)
        {
            return baseRet * alturaRet;
        }

        /// <summary>
        /// Calcula a área de um triângulo.
        /// </summary>
        /// <param name="baseTri">Base do triângulo</param>
        /// <param name="alturaTri">Altura do triângulo</param>
        /// <returns>Área do triângulo</returns>
        static double CalcAreaTriangulo(double baseTri, double alturaTri)
        {
            return (baseTri * alturaTri) / 2;
        }

        /// <summary>
        /// Multiplica dois números e retorna double
        /// </summary>
        /// <param name="n1">fica o primeiro numero double</param>
        /// <param name="n2>fica o segundo numero double</param>
        /// <returns>Retorna multiplicacao do n1 e n2</returns>
        static double multiplica(double n1, double n2)
        {
            return n1 * n2;
        }
        /// <summary>
        /// Multiplica dois números e retorna int
        /// </summary>
        /// <param name="n1">fica o primeiro numero inteiro</param>
        /// <param name="n2">fica o segundo numero inteiro</param>
        /// <returns>Retorna multiplicacao do n1 e n2</returns>
        static int multiplica(int n1, int n2)
        {
            return n1 * n2;
        }

        static void Main(string[] args)
        {
            //Print("Olá insira seu nome!");
            //String nome = Console.ReadLine();
            //Print(nome + " agora insira a area do circulo que deseja calcular!");
            //Double area = CalcArea(double.Parse(Console.ReadLine()));
            //Print(nome + " a area do circulo será: " + area);

            int n1 = 5;
            int n2 = 10;
            double n3 = 5.5;
            double n4 = 10.5;
            String nome = "Andre";

            Saudacao(nome);

            Print("A soma de " + n1 + " e " + n2 + " é: " + soma(n1, n2));

            Print("A area do retangulo é: " + CalcAreaRetangulo(5, 10));
            Print("A area do triangulo é: " + CalcAreaTriangulo(5, 10));

            Print("A multiplicação de " + n1 + " e " + n2 + " é: " + multiplica(n1, n2));
            Print("A multiplicação de " + n3 + " e " + n4 + " é: " + multiplica(n3, n4));


        }
    }
}