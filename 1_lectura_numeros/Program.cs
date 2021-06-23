using System;

namespace _1_lectura_numeros
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //se manda a llamar el objeto al metodo main de impresion a consola
            Numeros objOrdenamiento = new Numeros();
            //.......cambio de color.......
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(".....BIENVENIDO....");
            Console.WriteLine(" Esta aplicacion le servira para hacer la sumatoria, el promedio, el numero mayor y el numero menor de 10 números ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Introduce los numeros");
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(" + " + (i + 1) + ": ");
                    objOrdenamiento.NUMERO = int.Parse(Console.ReadLine());
                }
                //Aqui se madnara a imprimir el objeto creado
                while (objOrdenamiento.NUMERO <= 0);
                objOrdenamiento.calcularElMenor();
                objOrdenamiento.calcularElMayor();
                objOrdenamiento.calcularLaSuma();
                objOrdenamiento.calcularPromedio();
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" La suma de los números es: " + objOrdenamiento.SUMA);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" El promedio es: " + Convert.ToDouble(objOrdenamiento.PROMEDIO));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" El numero mayor es: " + objOrdenamiento.MAYOR);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" El numero menor es: " + objOrdenamiento.MENOR);

        }
    }
}

