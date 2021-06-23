using System;
namespace _3_Numeros
{
    class Leer_Numero
    {
        //Atributos
        private int[] cantidad;
        private int numero, y;
        //Se hace el metodo para guardar los numeros en la cadena/arreglo
        public void GuardarCaracter()
        {
            cantidad = new int[20];
            for (int i=0;i < cantidad.Length;i++)
            {
                //En este bucle se almacenan los numeros a registrar 20
                Console.Write(" " + (i + 1) + " : ");
                numero = int.Parse(Console.ReadLine());
                //La cantidad y variedad de nuneros se guarda en la cadena cantidad
                cantidad[i] = numero;
            }
        }
        //En este metodo se crea el orden por medio de blucles que seran utulizados para el metodo para mostrar en consola
        public void ordenarNum()
        {
            //que i sea menor a 19 tomando el rango de numeros que hay en 0 a 19
            for (int i = 0; i < 19; i++)
            {
                for (int h = 0; h < 19 - i; h++)
                {
                    //se evalua el for si la cantidad de h es mayor a la cantidad del arreglo h + 1
                    if (cantidad[h] > cantidad[h + 1])
                    {
                        // se le asigna el valor de y para mostrar en nuevo apartado sin que aparezca 0
                        y = cantidad[h];
                        cantidad[h] = cantidad[h + 1];
                        //por ultimo una vez evaluada el arreglo se imprime el valor almacenado en y
                        cantidad[h + 1] = y;
                    }
                }

            }
        }
        public void MostrarNum()
        {
            Console.WriteLine(" Números ordenados del menor a mayor ");
            //Asignar un limite a su vez leer la variable cantidad que sea menor
            for (int i = 0; i < cantidad.Length; i++)
            {
                //en este console se envian los resultados repitiendolo i veces el arreglo de cantidad de i
                    Console.WriteLine(" " + (i + 1) + ". " + cantidad[i]);

            }
            Console.ReadKey();
        }
    }
}
