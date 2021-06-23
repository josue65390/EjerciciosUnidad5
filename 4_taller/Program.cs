using System;

namespace _4_taller
{

    /*
    class datos
    {
        private int[] data;
        private int indice, limite;
        //métodos
        /*.........................Datos.....................
         * Este constructor requiere de un valor entero tamaño 
         * para crear el espacio de la pila de enteros 
         * que utilizaran para almacenar 
         * --------------------------------------------------
        public datos (int tamaño)
        {
            this.data = new int[tamaño];
            this.indice = -1;
            this.limite = tamaño;
        }
        //------------------------Avanzar/empujar----------------------
        //El método recibe un dato y lo empuja (push) a la pila de datos 
        public int Push(int data)
        {
            int exito = 0;
            if (indice < this.limite - 1)
                this.data[++indice] = data;
            else exito = 1;
            return exito;
        }
    }         
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello World! ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Este es un taller mecanico en el cual arreglamos tu auto" + "¡Vamos dejalo aqui!");
            Console.ForegroundColor = ConsoleColor.White;
            Taller taller = new Taller(5);// SE INSTANCIA CON 5 QUE ES LA MAX.
            Console.WriteLine(taller.EspacioDisponible());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Estos son los espacios disponible");
            Console.WriteLine("Si ingresa 'S' el programa cerrara");
            char ans;
            char salir = 'f';
            while (salir != 'S')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("¿Que deseas hacer?");
                Console.WriteLine("A)Meter\nB)sacar\n");
                Console.WriteLine("Seleccione su inciso: ");
                ans = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                switch (ans)
                {
                    case 'A':
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ha seleccionado meter");
                            Console.Write("Ingrese su placa: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            string placa = Convert.ToString(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Ingrese su nombre: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            string nombre = Convert.ToString(Console.ReadLine());
                            if (taller.Meter(placa, nombre) == false)
                            {
                                Console.WriteLine("Error tabla llena");
                                Console.ReadKey();
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.WriteLine("Se ha actualizado la tabla");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(taller.EspacioDisponible());
                            Console.ReadKey();
                            break;
                        }
                    case 'B':
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Ha seleccionado sacar");
                            if (taller.Sacar() == false)
                            {
                                Console.WriteLine("Error tabla vacia");
                                Console.ReadKey();
                            }
                            Console.WriteLine("Se ha actualizado la tabla");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(taller.EspacioDisponible());
                            Console.ReadKey();
                            break;
                        }
                }
                Console.Clear();
                Console.WriteLine("¿Desea salir? presione S o presione cualquier tecla para continuar");
                salir = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.Clear();
            }
        }
    }
}
