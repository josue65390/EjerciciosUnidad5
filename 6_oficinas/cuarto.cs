using System;
namespace _6_oficinas
{
    class cuarto
    {
        //Atributos 
        double menu;
        char pulsaciones;
        String empresa1, empresa2, empresa3, dia1, dia2, dia3, hora1, hora2, hora3;
        string res1, res2;
        public void Reunion()
        {
            do
            {
                /*Se boora al dar un comienzo en blanco al ingresar otro registro 
                Console.Clear();*/
                Console.SetCursorPosition(16, 1);
                Console.WriteLine("     RESERVACIÓN   ");
                do
                {
                    Console.SetCursorPosition(3, 2);
                    if (menu == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Sala: 1");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(30, 2);
                    if (menu == 2)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Sala: 2");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(60, 2);
                    if (menu == 3)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Sala: 3");

                    Console.ForegroundColor = ConsoleColor.White;
                    //Al mover con las flechas de la maquina se seleccionaran mandando un color diferente para indicar donde esta pulsado
                    //Se hace una pausa 
                    pulsaciones = (char)Console.ReadKey().Key;
                    switch (pulsaciones)
                    {
                        //En este switch lee o almacena lo seleccionado 
                        case (char)ConsoleKey.LeftArrow:
                            if (menu == 1) menu = 3; else menu--;
                            break;
                        case (char)ConsoleKey.RightArrow:
                            if (menu == 3) menu = 1; else menu++;
                            break;
                    }
                } 
                //  Al darl clic este recibe infomacion de iniciar 
                while (pulsaciones != (char)ConsoleKey.Escape && pulsaciones != (char)ConsoleKey.Enter);              
                if (pulsaciones == (char)ConsoleKey.Escape)
                    //Una vez seleccionado se inicia en cero el menu para no afectar el cambio de la sala 
                menu = 0;
                Console.WriteLine("" + menu);

                if (menu == 1)
                {
                    //Si se selecciona la sala uno (cuando menu es igual a uno) se incia este apartado 
                    Console.WriteLine("**** Sala 1 ****");
                    Console.Write(" Ingrese el nombre de la empresa: ");
                    empresa1 = Convert.ToString(Console.ReadLine());
                    Console.Write(" Horario: ");
                    hora1 = Convert.ToString(Console.ReadLine());
                    //Ateniendo la condicion de si el dia se escoge domingo mostarar el mensaje solicitado por el docente 
                    Console.Write(" Dia a agendar: ");
                    dia1 = Convert.ToString(Console.ReadLine());
                    //EVALUAR
                    if (dia1 == "domingo")
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" En este horario no se puede agendar cita");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(" Para saber su reporte de las citas introduzca -Reporte- : ");
                    res1 = Convert.ToString(Console.ReadLine()).ToUpper();
                    if (res1 == "Reporte")
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Sala 1 esta agendada ");
                        Console.WriteLine(" Nombre de empresa:" + empresa1);
                        Console.WriteLine(" Hora de su cita:" + hora1);
                        Console.WriteLine(" Dia para la sala:" + dia1);
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    Console.WriteLine("\n");
                    Console.Write(" ¿Quieres hacer otra cita? (si/no)");
                    res2 = Convert.ToString(Console.ReadLine());
                }
                else if (menu == 2)
                {
                    Console.WriteLine("**** Sala 2 ****");
                    Console.Write(" Ingrese el nombre de empresa: ");
                    empresa2 = Convert.ToString(Console.ReadLine());
                    Console.Write(" Horario: ");
                    hora2 = Convert.ToString(Console.ReadLine());
                    Console.Write(" Dia a agendar: ");
                    dia2 = Convert.ToString(Console.ReadLine());
                    if (dia2 == "domingo")
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("En este horario no se puede agendar cita");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Para saber su reporte de las citas introdusca -Reporte-");
                    res1 = Convert.ToString(Console.ReadLine());
                    if (res1 == "Reporte")
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Sala 2 esta agendada ");
                        Console.WriteLine(" Nombre de empresa:" + empresa2);
                        Console.WriteLine(" Hora de su cita:" + hora2);
                        Console.WriteLine(" Dia para la sala:" + dia2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("¿Necesita crear otra agenda?");
                    res2 = Convert.ToString(Console.ReadLine());
                }
                else
                {

                    Console.WriteLine("**** Sala 3 ****");
                    Console.Write(" Nombre de empresa: ");
                    empresa3 = Convert.ToString(Console.ReadLine());
                    Console.Write(" Hora: ");
                    hora3 = Convert.ToString(Console.ReadLine());
                    Console.Write(" Dia: ");
                    dia3 = Convert.ToString(Console.ReadLine());
                    if (dia3 == "Domingo")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" En este horario no se puede agendar cita");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine(" Para saber su reporte de las citas introdusca -Reporte-");
                    res1 = Convert.ToString(Console.ReadLine());
                    if (res1 == "Reporte")
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Sala 3 esta agendada ");
                        Console.WriteLine("Nombre de empresa:" + empresa3);
                        Console.WriteLine("Hora:" + hora3);
                        Console.WriteLine(" Dia:" + dia3);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine(" ¿Quieres otra agenda?");
                    res2 = Convert.ToString(Console.ReadLine());
                }
            } while (res2 == "si");
        }
    }
}
