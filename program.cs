﻿namespace EjercicioExtra2_Jajurin_Miglin;
class Program
{
    static void Main(string[] args)
    {
        int opccion, cambio;
        double velocidadCambiada, fuerzaCambiada;
        superHeroe superHeroe1 = null , superHeroe2 = null;

        opccion = ingresarOpccion ("Ingrese que opccion desea");
        while(opccion!= 4)
        {
            switch (opccion) 
            {
                case 1:
                superHeroe1 = obtenerSuperheroe();
                opccion = ingresarOpccion ("Ingrese que opccion desea");
                break;

                case 2:
                superHeroe2 = obtenerSuperheroe();
                opccion = ingresarOpccion ("Ingrese que opccion desea");
                break;

                case 3:
                calcularLucha(superHeroe1, superHeroe2);
                opccion = ingresarOpccion ("Ingrese que opccion desea");
                break;

                case 5:
                cambio = IngresarCambio ("Ingrese que superHeroe quiere cambiar");
        
                switch(cambio)
                {
                    case 1:
                    velocidadCambiada = IngresarVelocidad("Ingrese el cambio de velocidad");
                    fuerzaCambiada = IngresarFuerza("Ingrese cambio de fuerza");
                    superHeroe1.VELOCIDAD = velocidadCambiada;
                    superHeroe1.FUERZA = fuerzaCambiada;
                    break;

                    case 2:
                    velocidadCambiada = IngresarVelocidad("Ingrese el cambio de velocidad");
                    fuerzaCambiada = IngresarFuerza("Ingrese cambio de fuerza");
                    superHeroe2.VELOCIDAD = velocidadCambiada;
                    superHeroe2.FUERZA = fuerzaCambiada;
                    break;

                
                }
                calcularLucha(superHeroe1, superHeroe2);
                opccion = ingresarOpccion ("Ingrese que opccion desea");
                break;   

            }
        }
    }
    public static int IngresarCambio(string s)
    {
        int op;
        do
        {
            Console.WriteLine(s);
            op = int.Parse(Console.ReadLine());

        }while (op != 1 && op != 2);
        return op;
    }
     public static int ingresarOpccion (string m)
    {
        int op;
        do
        {
            Console.WriteLine(m);
            op = int.Parse(Console.ReadLine());
        } while(op!= 1 && op!= 2 && op!= 3 && op!= 4 && op!= 5);
        return op;
    }
    
     public static string IngresarString (string m)
    { 
        Console.WriteLine (m);
        return Console.ReadLine();
    }
    public static double ingresarDouble (string m)
    {
        Console.WriteLine (m);
        return double.Parse(Console.ReadLine());    
    }
    public static double IngresarVelocidad (string m)
    {
        double velocidad;
        do  
        {
            Console.WriteLine(m);
            velocidad = double.Parse(Console.ReadLine());
        } while(velocidad < 1 || velocidad > 100);
        return velocidad;
    }
    public static double IngresarFuerza (string m)
    {
        double fuerza;
        do  
        {
            Console.WriteLine(m);
            fuerza = double.Parse(Console.ReadLine());
        } while(fuerza < 1 || fuerza > 100);
        return fuerza;
    }
    public static superHeroe obtenerSuperheroe()
    {
        string nombre = IngresarString("Ingrese el nombre del super heroe ");
        string ciudad = IngresarString("Ingrese la ciudad del super heroe ");
        double peso = ingresarDouble("Ingrese el peso del super heroe ");
        double velocidad = IngresarVelocidad ("Ingrese la velocidad del super heroe ");
        double fuerza = IngresarFuerza ("Ingrese la fuerza super heroe ");
        return new superHeroe(nombre, ciudad, peso, velocidad, fuerza);
    }
    public static void calcularLucha (superHeroe superHeroe1, superHeroe superHeroe2)
    {
        double skill1, skill2, diferencia;
        if(superHeroe1 != null && superHeroe2 != null)
            {
                skill1 = superHeroe1.calcularSkill();
                skill2 = superHeroe2.calcularSkill();
                Console.WriteLine(skill1);
                Console.WriteLine(skill2);
                if (skill1 > skill2)
                {
                    
                    diferencia = skill1 - skill2;
                    if (diferencia >= 30)
                    Console.WriteLine ("Gano el " + superHeroe1.NOMBRE + " Por amplia diferencia");
                    else if (diferencia >= 10)
                    Console.WriteLine ("Gano el " + superHeroe1.NOMBRE + " Fue muy parejo");
                    else
                    Console.WriteLine ("Gano el " + superHeroe1.NOMBRE + " No le sobro nada");

                }
                else if (skill1 < skill2)
                {
                    diferencia = skill2 - skill1;
                    if (diferencia >= 30)
                    Console.WriteLine ("Gano el " + superHeroe2.NOMBRE + " Por amplia diferencia");
                    else if (diferencia >= 10)
                    Console.WriteLine ("Gano el " + superHeroe2.NOMBRE + " Fue muy parejo");
                    else
                    Console.WriteLine ("Gano el " + superHeroe2.NOMBRE + " No le sobro nada");
                }
                else
                {
                    Console.WriteLine ("EMPATARON BINKER");
                }
            }
    }

}
