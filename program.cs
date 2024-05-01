namespace EjercicioExtra2_Jajurin_Miglin;
class Program
{
    static void Main(string[] args)
    {
        string nombre=, ciudad=;
        double peso =, velocidad=, fuerza=;
        double diferencia;
        int opccion;

        opccion = ingresarOpccion ("Ingrese que opccion desea");
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
}
