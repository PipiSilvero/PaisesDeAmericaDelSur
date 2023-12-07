// See https://aka.ms/new-console-template for more information
// Array declarando primero los países de América del Sur
string[] paisesAmericaSur = { "Argentina",
            "Brasil", "Chile", "Bolivia", "Colombia",
            "Ecuador", "Paraguay", "Perú", "Uruguay",
            "Guyana", "Venezuela" };

Console.Write("Ingresa un país: ");

// Entrada del usuario
string paisIngresado = Console.ReadLine();

// Convertir el nombre del país  a minusculas
paisIngresado = paisIngresado.ToLower();

// Chequeo de la entrada del usuario
if (Array.Exists(paisesAmericaSur, p => p.ToLower() == paisIngresado))
{
    Console.WriteLine($"{paisIngresado} es un país de América del Sur.");
}
else
{
    Console.WriteLine($"{paisIngresado} no es un país de América del Sur.");
}
