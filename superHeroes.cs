class superHeroe {
    public string NOMBRE{ get; set; }
    public string CIUDAD{ get; set; }   
    public double PESO  { get; set; }
    public double FUERZA { get; set; }
    public double VELOCIDAD { get; set; }

    public superHeroe (string nombre  , string ciudad, double peso , double fuerza , double velocidad)
    {
        NOMBRE = nombre;
        CIUDAD = ciudad;
        PESO = peso;
        FUERZA = fuerza;
        VELOCIDAD = velocidad;

    }
    public double calcularSkill ()
    {
        Random num = new Random();
        int numero = num.Next (0,10); 
        double skill;
        skill = (VELOCIDAD * 0.6)+(FUERZA * 0.8) + numero ;
        return skill;
    }
}