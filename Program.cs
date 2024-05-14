// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);
*/
//  ----------INICIO PUNTO 1 ----------
int i=0,inv=0;
string num="";

Console.WriteLine("Ingrese un numero:");
num=Console.ReadLine();

if(int.TryParse(num, out i))
{
    Console.WriteLine("Es un numero");
    if(i>0)
    {
        while(i>0)
        {
            inv=inv*10+i%10;
            i=i/10;

        }
        Console.WriteLine("El numero invertido es:"+inv);
    }else
    {
        Console.WriteLine("Es <0 por lo que el programa no lo puede invertir");
    }
}else
{
    Console.WriteLine("NO es un numero");
}


//  ----------INICIO PUNTO 2 ----------

string eleccion="10";

while(eleccion!="0")
{   
    while(eleccion!="0"||eleccion!="1"||eleccion!="2"||eleccion!="3"||eleccion!="4")
    {
        Console.WriteLine("Elija que operacion desea realizar:\n1-Sumar \n2-Restar \n3-Multiplicar \n4-Dividir\n0-Sali");
        eleccion=Console.ReadLine();
    }
    switch (eleccion)
    {
        case "1":

    }

}