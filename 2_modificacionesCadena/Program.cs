using System;
namespace _2_modificacionesCadena
{
    class Arreglos
    {
        //Se hace una variable del tipo string para almacenar los comentarios establecidos 
        string cadenaCaract;
        public void nombre()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****Bienvenido*****");
            Console.WriteLine("--Le harémos unas configuraciones al texto ingresado a estre programa--");
            Console.Write(" Introduce el texto a probar: ");//Se guarda en variable nombrada como cadena caracteriasticas 
                                                            //Al ingresar se cambia el tono de la letra
            Console.ForegroundColor = ConsoleColor.Magenta;
            cadenaCaract = Convert.ToString(Console.ReadLine());
            //Cadena para almacenar 
            char[] cadenaArreglo = cadenaCaract.ToCharArray();
            //Crear un atributo para guardar la 
            string reversa = String.Empty;
            //Lleva el conteo de los caracteres ingresados 
            for (int i = cadenaArreglo.Length - 1; i > -1; i--)
            {
                //reserva acumula el valor ingresado de cadena arreglo i veces 
                reversa += cadenaArreglo[i];
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            //Mostrar el resultado  en inversa 
            Console.WriteLine(" El enunciado alreves es : " + reversa);
            Console.WriteLine("\n");
        }

        public void Mayus()
        {
            //Se coloca el ToUpper para volver mayuscula lo que en este caso cadenaCaract guardo 
            Console.WriteLine(" El enunciado en mayusculas es: {0}", cadenaCaract.ToUpper());
            Console.WriteLine("\n");
            //Se utiliza el Remplace para asi poder cambiar el texto con ciertas coincidencias
            Console.WriteLine(" El enunciado nuevo es: {0}",
            cadenaCaract.Replace("A", "4").Replace("I", "1").Replace("S", "5").Replace("B", "8").Replace("E", "3").Replace("T", "7"));
            //Esto nos facilita el cambio de las letras a la hora d edetectar en el codigo el comentario 
        }

        /* static string Reverse(string text)
         {

             char[] charArray = text.ToCharArray();
             Array.Reverse(charArray);
             return new string(charArray);}*/
    }
    class Program
        { 
    
            static void Main(string[] args)
            {

                //---Se mandan a llamar los objetos de los arreglos y el metodo para mostar en consola 
                Arreglos objcade = new Arreglos();
                objcade.nombre();
                Arreglos objcadesa = new Arreglos();
                objcade.Mayus();

                /*
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("****Bienvenido*****");
                Console.WriteLine("Introduce un mensaje: ");
                string mensaje = Console.ReadLine().ToUpper();
                string reversed = Reverse(mensaje);
                String reversa = mensaje;
                reversa = reversa.Replace("A", "4");
                reversa = reversa.Replace("I", "1");
                reversa = reversa.Replace("S", "5");
                reversa = reversa.Replace("B", "8");
                reversa = reversa.Replace("E", "3");
                reversa = reversa.Replace("T", "7");
                Console.WriteLine(reversed);
                Console.WriteLine(mensaje);
                Console.WriteLine(reversa);*/
            }
        }
}
