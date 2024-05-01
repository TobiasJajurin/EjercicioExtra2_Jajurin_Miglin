namespace EjercicioExtra2_Jajurin_Miglin;
class Program
{
    static void Main(string[] args)
    {
        string nombre, ciudad;
        double peso, velocidad, fuerza;
        double diferencia;
        int opccion;

        opccion = ingresarOpccion ("Ingrese que opccion desea");
        switch (opccion) 
        {
            case 1:
            IngresoTotalDatos(nombre, ciudad, peso, velocidad, fuerza);
            opccion = ingresarOpccion ("Ingrese que opccion desea");
            break;

            case 2:
            IngresoTotalDatos(nombre, ciudad, peso, velocidad, fuerza);
            opccion = ingresarOpccion ("Ingrese que opccion desea");
            break;

            case 3:
            opccion = ingresarOpccion ("Ingrese que opccion desea");
            break;

            case 4:
            break;


        }
    }
     public static int ingresarOpccion (string m)
    {
        int op;
        do
        {
            Console.WriteLine(m);
            op = int.Parse(Console.ReadLine());
        } while(op!= 1 && op!= 2 && op!= 3 && op!= 4);
        return op;
    }
    public static void IngresoTotalDatos (string nombre, string ciudad, double peso, double velocidad, double fuerza)
    {
         nombre = IngresarString("Ingrese el nombre del super heroe ");
         ciudad = IngresarString("Ingrese la ciudad del super heroe ");
         peso = ingresarDouble("Ingrese el peso del super heroe ");
         velocidad = IngresarVelocidad ("Ingrese la velocidad del super heroe ");
         fuerza = IngresarFuerza ("Ingrese la fuerza super heroe ");
         
    }
     public static string IngresarString (string m)
    {
        return Console.ReadLine();
    }
    public static double ingresarDouble (string m)
    {
        return double.Parse(Console.ReadLine());    
    }
    public static double IngresarVelocidad (string m)
    {
        double velocidad;
        do  
        {
            Console.WriteLine(m);
            velocidad = double.Parse(Console.ReadLine());
        } while(velocidad < 1 && velocidad > 100);
        return velocidad;
    }
    public static double IngresarFuerza (string m)
    {
        double fuerza;
        do  
        {
            Console.WriteLine(m);
            fuerza = double.Parse(Console.ReadLine());
        } while(fuerza < 1 && fuerza > 100);
        return fuerza;
    }

}
