﻿// Ejercicio 1 Escribe un programa que reciba tu nombre y lo escriba por consola.

Console.WriteLine("Introduce tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);


//Ejercicio 2 Escribe un programa que tome la hora y la escriba por pantalla.

Console.WriteLine("Introduce la hora: ");
DateTime dateTime = DateTime.Parse(Console.ReadLine());
Console.WriteLine(dateTime);