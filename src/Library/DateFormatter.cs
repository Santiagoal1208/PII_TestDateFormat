namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if(date==""){
            Console.WriteLine("Acaba de ingresar una fecha en blanco\n Por favor ingrese una fecha con el siguiente formato dd/mm/yyyy");
            return date;
        }
        if(!(date[5]=='/') && (date[2]=='/')){
            Console.WriteLine("Por favor ingrese una fecha con el siguiente formato dd/mm/yyyy");
            return date;
        }
        string resultado= date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        try
        {
            DateTime fecha =DateTime.Parse(resultado);
        }
        catch (System.FormatException )
        {
           Console.WriteLine("No se paso una fecha valida\n Por favor ingrese una fecha con el siguiente formato dd/mm/yyyy");
           return date;
        }
        return resultado;
        
    }
}
