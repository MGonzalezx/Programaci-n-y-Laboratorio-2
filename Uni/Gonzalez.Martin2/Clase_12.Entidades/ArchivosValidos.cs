//Nuestro delegado que sea visto por todos (public), palabra reservada delegate, luego definir la firma 
//que va a soportar nuestro delegado
using Clase_12.Entidades;

/// <summary>
/// Solo los metodos que respeten firma van a poder usar el delegado, con este delegado podemos hacerlo visible
/// a nuestra class library y program
/// </summary>
/// <param name="sueldo">Sueldo del empleado</param>
/// <param name="emp">Objeto Empleado</param>
public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);

public delegate void LimiteSueldoMejoradoDel(Empleado sender, EmpleadoEventArgs e);

public enum TipoManejador
{
    LimiteSueldo,
    LimiteSueldoMejorado,
    Todos
}