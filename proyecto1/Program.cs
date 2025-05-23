// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

Console.WriteLine("Hello, World!");
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/


Console.WriteLine("ingrese un numero");
int i = 0;
string numero = Console.ReadLine();





string invertir(int i, int resto)
{
    resto = i % 10;
    string aux1 = i.ToString();
    string aux2 = resto.ToString();
    
    if (i < 10)
    {
        return aux1;

    }
    else
    {

        return aux2 +invertir(i / 10, resto);
    }
    


}
if (i >= 0 && int.TryParse(numero, out i))
{
    int resto = i % 10;
    Console.WriteLine("El numero invertido es " + invertir(i, resto));

}
string num1, num2;
float a,b, resultado ;
string opcion;
do
{
    Console.WriteLine("ingrese una operacion 'suma', 'resta', 'multiplicacion', 'division'");
    Console.WriteLine("'valor absoluto(va)','cuadrado','raiz cuadrada', 'seno', 'coseno','parte entera de un float(entero de float)','max entre dos numeros(max)','min entre dos numeros(min)'");
    Console.WriteLine("Si quiere salir escriba 'salir' ");
    opcion = Console.ReadLine().ToLower();


    switch (opcion)
    {
        case "sumar":
            Console.WriteLine("ingrese 2 numeros");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            if (float.TryParse(num1, out a) && float.TryParse(num2, out b))
            {
                resultado = a + b;
                Console.WriteLine("El resultado de la operacion " + opcion + " es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra");
            }
            break;

        case "resta":

            Console.WriteLine("ingrese 2 numeros");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            if (float.TryParse(num1, out a) && float.TryParse(num2, out b))
            {
                resultado = a - b;
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra");
            }
            break;

        case "multiplicacion":
            Console.WriteLine("ingrese 2 numeros");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            if (float.TryParse(num1, out a) && float.TryParse(num2, out b))
            {
                resultado = a * b;
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra");
            }
            break;

        case "division":
            Console.WriteLine("ingrese 2 numeros");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            if (float.TryParse(num1, out a) && float.TryParse(num2, out b) && b > 0)
            {
                resultado = a / b;
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra o ingrese un valor mayor a 0 para el denominador");
            }
            break;

        case "va":
            Console.WriteLine("ingrese 1 numero");
            num1 = Console.ReadLine();
            if (float.TryParse(num1, out a))
            {
                resultado = Math.Abs(a);
                Console.WriteLine("El resultado de la operacion  valor absoluto es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;

        case "cuadrado":
            Console.WriteLine("ingrese 1 numero");
            num1 = Console.ReadLine();
            if (float.TryParse(num1, out a))
            {
                resultado = (float)Math.Pow(a, 2);
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;

        case "raiz cuadrada":
            Console.WriteLine("ingrese 1 numero");
            num1 = Console.ReadLine();
            if (float.TryParse(num1, out a))
            {
                resultado = (float)Math.Sqrt(a);
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;

        case "seno":
            Console.WriteLine("ingrese 1 numero");
            num1 = Console.ReadLine();
            if (float.TryParse(num1, out a))
            {
                resultado = (float)Math.Sin(a);
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;
        case "coseno":
            Console.WriteLine("ingrese 1 numero");
            num1 = Console.ReadLine();
            if (float.TryParse(num1, out a))
            {
                resultado = (float)Math.Cos(a);
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;
        case "entero de float":
            Console.WriteLine("ingrese 1 numero");
            num1 = Console.ReadLine();
            if (float.TryParse(num1, out a))
            {
                resultado = (int)Math.Truncate(a);
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;
        case "max":
            Console.WriteLine("ingrese 2 numero");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            if (float.TryParse(num1, out a) && float.TryParse(num2, out b))
            {
                resultado = (float)Math.MaxMagnitude(a,b);
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;
        case "min":
            Console.WriteLine("ingrese 2 numero");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            if (float.TryParse(num1, out a) && float.TryParse(num2, out b))
            {
                resultado = (float)Math.MaxMagnitude(a,b);
                Console.WriteLine("El resultado de la operacion " + opcion + "es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingrese un numero no una letra ");
            }
            break;
    }


} while (opcion!="salir");