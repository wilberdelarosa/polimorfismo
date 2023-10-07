// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

class Persona

{

    public string Nombre;
    public int Edad;
    public string NIF;


    public virtual void Cumpleanos()
    {
       
        Console.WriteLine("incrementa edad de persona");
    }
    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;

    }

}

class Trabajador: Persona

{
    int Sueldo;

    Trabajador(string nombre, int edad, string nif, int sueldo) : base(nombre, edad, nif)
    { 
        
        Sueldo = sueldo; 
    
    }
    // polimorfismo
    public static void Main()
    {

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

        Persona p = new Trabajador("Josan", 22, "77588260-Z" , 100000);

        p.Cumpleanos();
        

    }

}

