using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
public class Alumno
{

    byte nota1, nota2;
    float notaFinal;
    //int legajo;
    string nombre; //apellido;

    // Method
    public void CalcularFinal()
    {
        Random rand = new Random();
         
        if(nota1 >= 4 && nota2 >= 4)
        {
            notaFinal = rand.Next(1, 10);
        }
        else
        {
            notaFinal = -1;
        }
    }

    public void Estudiar(byte notaUno, byte notaDos)
    {
        nota1 = notaUno;
        nota2 = notaDos;
    }

    public void Mostrar()
    {
        Console.WriteLine(nombre);
        Console.WriteLine("Nota1: {0}", nota1);
        Console.WriteLine("Nota2: {0}", nota2);

        if (notaFinal == -1)
        {
            Console.WriteLine("Alumno desaprobado");
        }
        else
        {
            Console.WriteLine("Nota Final: {0}", notaFinal);
        }

}

    public void SetName(string newName)
    {
        nombre = newName;
    }
}
}
