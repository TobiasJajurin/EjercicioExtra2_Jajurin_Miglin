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
            superHeroe1 = obtenerSuperheroe(nombre, ciudad, peso, fuerza, velocidad);
            opccion = ingresarOpccion ("Ingrese que opccion desea");
            break;

            case 2:
            IngresoTotalDatos(nombre, ciudad, peso, velocidad, fuerza);
            superHeroe2 = obtenerSuperheroe(nombre, ciudad, peso, fuerza, velocidad);
            opccion = ingresarOpccion ("Ingrese que opccion desea");
            break;

            case 3:
        if(superHeroe1 != null && superHeroe2 != null)
        {
            if (superHeroe1.calcularSkill() > superHeroe2.calcularSkill())
            {
                diferencia = superHeroe1.calcularSkill() - superHeroe2.calcularSkill();
                if (diferencia <= 30)
                Console.WriteLine ("Gano el " + superHeroe1.NOMBRE + " Por amplia diferencia");
                else if (diferencia <= 10)
                Console.WriteLine ("Gano el " + superHeroe1.NOMBRE + " Fue muy parejo");
                else
                Console.WriteLine ("Gano el " + superHeroe1.NOMBRE + " No le sobro nada");

            }
            else if (superHeroe1.calcularSkill() < superHeroe2.calcularSkill())
            {
                diferencia = superHeroe2.calcularSkill() - superHeroe1.calcularSkill();
                if (diferencia <= 30)
                Console.WriteLine ("Gano el " + superHeroe2.NOMBRE + " Por amplia diferencia");
                else if (diferencia <= 10)
                Console.WriteLine ("Gano el " + superHeroe2.NOMBRE + " Fue muy parejo");
                else
                Console.WriteLine ("Gano el " + superHeroe2.NOMBRE + " No le sobro nada");
            }
            else
            {
                Console.WriteLine ("EMPATARON BINKER");
            }
        }
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
    public static superHeroe obtenerSuperheroe(string nombre, string ciudad, double peso, double fuerza, double velocidad)
    {
        superHeroe retornoHeroe;
        retornoHeroe = new superHeroe(nombre, ciudad, peso, fuerza, velocidad);
        return retornoHeroe;
    }

}
