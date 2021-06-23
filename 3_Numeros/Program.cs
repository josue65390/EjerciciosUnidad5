using System;
namespace _3_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello World! ");
            //---Se crea el objeto---
            Leer_Numero objMiOrden = new Leer_Numero();
            Console.WriteLine(" En este programa te ayudaremos a darle un orden a una cantidad de numeros predeterminados");
            //---manda a llamar los metodos
            objMiOrden.GuardarCaracter();
            objMiOrden.ordenarNum();
            objMiOrden.MostrarNum();
            
        }
    }
}
