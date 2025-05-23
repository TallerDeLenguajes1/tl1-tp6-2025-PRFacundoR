// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
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
