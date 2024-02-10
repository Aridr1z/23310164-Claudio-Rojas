using System;
using System.Timers;

//Creo la clase animal
class Animal 
{

    public virtual void Sonido()
    
    {
        Console.WriteLine("El animal hace un sonido generico");

    }

}


//Clase que va heredar el metodo de Animal que es hacer sonido

class Perro : Animal
{

    public override void Sonido()

    {
        Console.WriteLine("El perro dice guau");
            
    }


}

//Clase que va heredar el metodo de Animal que es hacer sonido

class Gato : Animal 

{

    public override void Sonido()

    {
        Console.WriteLine("El gato dice miau");

    }

}




class Codigo

{

    static void Main(string[] args)
    {

        Animal animal = new Animal();

        Perro perro = new Perro();

        Gato gato = new Gato();

        Console.WriteLine("Sonido de animal genérico:");
        animal.Sonido();

        Console.WriteLine("\nSonido de un perro:");
        perro.Sonido();

        Console.WriteLine("\nSonido de un gato:");
        gato.Sonido();

    }


}