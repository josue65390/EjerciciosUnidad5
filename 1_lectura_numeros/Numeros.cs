using System;
using System.Collections.Generic;
using System.Text;

namespace _1_lectura_numeros
{
    class Numeros
    {
        //Atributos 
        //Arreglo
        int[] almacen;
        int numero, suma, mayor, menor;
        //para considerar los puntos decimales
        double promedio;
        //------------Propiedades--------------

        public int NUMERO { get { return numero; } set { numero = value; } }
        public int SUMA { get { return suma; } set { suma = value; } }
        public double PROMEDIO { get { return promedio; } set { promedio = value; } }
        public int MAYOR { get { return mayor; } set { mayor = value; } }
        public int MENOR { get { return menor; } set { menor = value; } }

        //método
        public void calcularLaSuma()
        {
            almacen = new int[10];
            SUMA += NUMERO;
        }
        public void calcularPromedio()
        {
            almacen = new int[10];
            PROMEDIO = SUMA / 10;
        }
        public void calcularElMayor()
        {
            almacen = new int[10];
            for (int i = 0; i <= 10; i++)
            {
                almacen[i] = NUMERO;
                if (almacen[i] == 0)
                {
                    MAYOR = NUMERO;
                }
                else if(i != 0)
                {

                    if(NUMERO >MAYOR)
                    {
                        MAYOR = NUMERO;
                    }
                }
            }
        }
        public void calcularElMenor()
        {
            almacen = new int[10];
            for (int i = 0; i <= 10; i++)
            {
                almacen[i] = NUMERO;
                if (almacen[i] == 0)
                {
                  MENOR = NUMERO;
                }
                else if (i != 0)
                {
                    if (NUMERO < MENOR)
                    {
                        MENOR = NUMERO;
                    }
                }
            }
        }
    }

}
