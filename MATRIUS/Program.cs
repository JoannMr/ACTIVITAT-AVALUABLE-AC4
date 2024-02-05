// 1. Una sala de cine ha vendido las siguientes localidades 
// FILA0 (3): 1 1 1 
// FILA1 (4): 1 0 1 1 
// FILA2 (5): 0 0 1 1 1 
// FILA3 (5): 1 1 1 1 1 
// FILA4 (5): 0 1 0 1 1 
// Codifica un programa que calcule el total de localidades vendidas (1) y el total de localidades disponibles (0) 


// using System;

class Program
{
    static void Main()
    {
        int[][] salaDeCine = new int[][]
        {
            new int[] {1, 1, 1},
            new int[] {1, 0, 1, 1},
            new int[] {0, 0, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1},
            new int[] {0, 1, 0, 1, 1}
        };

        int totalLocalidadesVendidas = 0;
        int totalLocalidadesDisponibles = 0;

        foreach (var fila in salaDeCine)
        {
            foreach (var localidad in fila)
            {
                if (localidad == 1)
                {
                    totalLocalidadesVendidas++;
                }
                else if (localidad == 0)
                {
                    totalLocalidadesDisponibles++;
                }
            }
        }

        Console.WriteLine("Total de localidades vendidas: " + totalLocalidadesVendidas);
        Console.WriteLine("Total de localidades disponibles: " + totalLocalidadesDisponibles);
    }
}

// 2. El software de un hotel tiene un sistema de reservas con una matriz: 
// new string[] { "O", "X", "X", "X", "X" }, 
// new string[] { "X", "X", "X", "O", "X" }, 
// new string[] { "X", "X", "X", "X", "X" }, 
// new string[] { "X", "O", "X", "X", "X" }, 
// new string[] { "X", "X", "X", "X", "X" }, 
// new string[] { "O", "X", "X", "X", "X" }, 
// new string[] { "X", "O", "X", "X" }, 
// new string[] { "X", "X", "X" }, 
// Codifica un programa en c# con las siguientes opciones 
// - Mostrar habitaciones disponibles 
// - Reservar habitaciones (únicamente se pueden reservar las libres (O)) - Modificar o borrar reserva.

// using System;

// class HotelReservationSystem
// {
//     static string[][] habitaciones = new string[][]
//     {
//         new string[] { "O", "X", "X", "X", "X" },
//         new string[] { "X", "X", "X", "O", "X" },
//         new string[] { "X", "X", "X", "X", "X" },
//         new string[] { "X", "O", "X", "X", "X" },
//         new string[] { "X", "X", "X", "X", "X" },
//         new string[] { "O", "X", "X", "X", "X" },
//         new string[] { "X", "O", "X", "X" },
//         new string[] { "X", "X", "X" }
//     };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Mostrar habitaciones disponibles");
            Console.WriteLine("2. Reservar habitaciones");
            Console.WriteLine("3. Modificar o borrar reserva");
            Console.WriteLine("4. Salir");

            Console.Write("Ingrese el número de la opción deseada: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarHabitacionesDisponibles();
                    break;

                case "2":
                    ReservarHabitaciones();
                    break;

                case "3":
                    ModificarOBorrarReserva();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                    break;
            }

            Console.WriteLine(); 
        }
    }

    static void MostrarHabitacionesDisponibles()
    {
        Console.WriteLine("Habitaciones Disponibles:");
        for (int i = 0; i < habitaciones.Length; i++)
        {
            for (int j = 0; j < habitaciones[i].Length; j++)
            {
                if (habitaciones[i][j] == "O")
                {
                    Console.WriteLine($"Habitación ({i + 1}, {j + 1})");
                }
            }
        }
    }

    static void ReservarHabitaciones()
    {
        Console.WriteLine("Reservar Habitaciones:");
        Console.Write("Ingrese la fila de la habitación: ");
        int fila = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Ingrese la columna de la habitación: ");
        int columna = int.Parse(Console.ReadLine()) - 1;

        if (fila >= 0 && fila < habitaciones.Length && columna >= 0 && columna < habitaciones[fila].Length)
        {
            if (habitaciones[fila][columna] == "O")
            {
                Console.WriteLine("¡Habitación reservada con éxito!");
                habitaciones[fila][columna] = "X";
            }
            else
            {
                Console.WriteLine("La habitación no está disponible para reservar.");
            }
        }
        else
        {
            Console.WriteLine("Ubicación de la habitación no válida.");
        }
    }

    static void ModificarOBorrarReserva()
    {
        Console.WriteLine("Modificar o Borrar Reserva:");
        Console.Write("Ingrese la fila de la habitación: ");
        int fila = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Ingrese la columna de la habitación: ");
        int columna = int.Parse(Console.ReadLine()) - 1;

        if (fila >= 0 && fila < habitaciones.Length && columna >= 0 && columna < habitaciones[fila].Length)
        {
            if (habitaciones[fila][columna] == "O")
            {
                Console.WriteLine("1. Modificar reserva");
                Console.WriteLine("2. Borrar reserva");
                Console.Write("Ingrese el número de la opción deseada: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese la nueva información de la reserva...");
                        Console.WriteLine("Reserva modificada con éxito.");
                        break;

                    case "2":
                        habitaciones[fila][columna] = "O";
                        Console.WriteLine("Reserva borrada con éxito.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("La habitación no tiene una reserva para modificar o borrar.");
            }
        }
        else
        {
            Console.WriteLine("Ubicación de la habitación no válida.");
        }
    }
}


// 3. Una tienda de comestibles ha registrado las ventas de productos en diferentes secciones de la tienda. La información se presenta en una matriz de la siguiente manera: 
// int[,] ventas = { 
// { 10, 5, 8, 12 }, 
// { 7, 15, 20, 10 }, 
// { 5, 3, 6, 8 }, 
// { 12, 8, 10, 18 }, 
// { 6, 10, 15, 7 } 
// }; 
// Cada número en la matriz representa las ventas diarias de un producto en una sección específica. Codifica un programa en C# que calcule el total de ventas y muestre el total de ventas por sección (Cada línea es una sección). 

using System;

class Program
{
    static void Main()
    {
        int[,] ventas = {
            { 10, 5, 8, 12 },
            { 7, 15, 20, 10 },
            { 5, 3, 6, 8 },
            { 12, 8, 10, 18 },
            { 6, 10, 15, 7 }
        };

        CalcularYMostrarTotales(ventas);
    }

    static void CalcularYMostrarTotales(int[,] ventas)
    {
        int totalGeneral = 0;

        Console.WriteLine("Total de ventas por sección:");

        for (int i = 0; i < ventas.GetLength(0); i++)
        {
            int totalSeccion = 0;
            Console.Write($"Sección {i + 1}: ");

            for (int j = 0; j < ventas.GetLength(1); j++)
            {
                totalSeccion += ventas[i, j];
                totalGeneral += ventas[i, j];
            }

            Console.WriteLine(totalSeccion);
        }

        Console.WriteLine("\nTotal general de ventas: " + totalGeneral);
    }
}


// 4. En un colegio, se lleva un registro de la asistencia de los estudiantes en diferentes clases a lo largo de la semana. La información se presenta en una matriz de la siguiente manera: 
// bool[,] asistencia = { 
// { true, false, true, true, false }, 
// { true, true, true, true, true }, 
// { false, false, true, true, false }, 
// { true, true, true, false, true }, 
// { true, false, true, false, true } 
// }; 
// Donde true indica que el estudiante asistió a la clase y false indica que el estudiante no asistió. Codifica un programa en C# que permita al usuario ingresar el número de estudiante y el día de la semana, y el programa debe mostrar si el estudiante asistió o no a esa clase. 

using System;

class Program
{
    static void Main()
    {
        bool[,] asistencia = {
            { true, false, true, true, false },
            { true, true, true, true, true },
            { false, false, true, true, false },
            { true, true, true, false, true },
            { true, false, true, false, true }
        };

        MostrarAsistencia(asistencia);

        Console.Write("\nIngrese el número de estudiante (1-5): ");
        int numeroEstudiante = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el día de la semana (1-5): ");
        int diaSemana = int.Parse(Console.ReadLine());

        VerificarAsistencia(asistencia, numeroEstudiante, diaSemana);
    }

    static void MostrarAsistencia(bool[,] asistencia)
    {
        Console.WriteLine("Registro de Asistencia:");

        for (int i = 0; i < asistencia.GetLength(0); i++)
        {
            for (int j = 0; j < asistencia.GetLength(1); j++)
            {
                Console.Write(asistencia[i, j] ? "A " : "F ");
            }
            Console.WriteLine();
        }
    }

    static void VerificarAsistencia(bool[,] asistencia, int numeroEstudiante, int diaSemana)
    {
        if (numeroEstudiante >= 1 && numeroEstudiante <= asistencia.GetLength(0) &&
            diaSemana >= 1 && diaSemana <= asistencia.GetLength(1))
        {
            bool asistio = asistencia[numeroEstudiante - 1, diaSemana - 1];

            Console.WriteLine(asistio
                ? $"El estudiante {numeroEstudiante} asistió a la clase el día {diaSemana}."
                : $"El estudiante {numeroEstudiante} no asistió a la clase el día {diaSemana}.");
        }
        else
        {
            Console.WriteLine("Número de estudiante o día de la semana no válidos.");
        }
    }
}

// 5. Explica el funcionamiento de este programa 
// int[][] matriz = { 
// new int[] { 1, 1, 1 }, 
// new int[] { 1}, 
// new int[] { 1, 1, 2 } 
// }; 
// for (int i = 0; i < 3; i++) 
// { 
// int sumaFila = 0; 
// int sumaColumna = 0; 
// for (int j = 0; j < matriz[i].Length; j++) 
// { 
// if (i < matriz[j].Length) 
// { 
// sumaFila += matriz[i][j]; 
// } 
// if (j < matriz[i].Length && i < matriz[j].Length) { 
// sumaColumna += matriz[i][j]; 
// } 
// } 
// Console.WriteLine("Suma de fila: " + sumaFila); 
// Console.WriteLine("Suma de columna: " + sumaColumna); } 

1.Se define una matriz llamada matriz que contiene tres filas de enteros.

2.Se utiliza un bucle externo (for) que recorre las filas de la matriz (i va desde 0 hasta 2).

3.Dentro del bucle externo, se inicializan las variables sumaFila y sumaColumna a cero para acumular las sumas.

4.Se utiliza un bucle interno para recorrer los elementos de la fila actual (matriz[i]).

5.En el bucle interno, se suma cada elemento a la variable sumaFila.

6.Se verifica si la columna j existe en la fila i antes de sumar el elemento correspondiente a la variable sumaColumna. Esto evita acceder a elementos inexistentes y provoca un error.

7.Se imprime en la consola la suma de la fila y la suma de la columna para cada fila.

