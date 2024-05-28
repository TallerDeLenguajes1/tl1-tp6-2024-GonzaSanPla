﻿// See https://aka.ms/new-console-template for more information
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
string? num="";

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

string? eleccion="a",numS1="",numS2="";
int num1=0,num2=0,resultado=0;


while(eleccion!="0")
{   
   
    while(eleccion!="0")
    {   
        while(eleccion!="0"&&eleccion!="1"&&eleccion!="2"&&eleccion!="3"&&eleccion!="4")
        {
            Console.WriteLine("\nElija que operacion desea realizar:\n1-Sumar \n2-Restar \n3-Multiplicar \n4-Dividir\n0-Salir");
            eleccion=Console.ReadLine();
            if(eleccion!="0" && eleccion!="5")
            {
                Console.WriteLine("\nIngrese el primer numero para operar:");
                numS1=Console.ReadLine();
                Console.WriteLine("\nIngrese el segundo numero para operar:");
                numS2=Console.ReadLine();
            } 
        }

        if(int.TryParse(numS1, out num1)&&int.TryParse(numS2, out num2))
        {
            switch (eleccion)
            {
                case "1":
                    resultado=num1+num2;
                    break;

                case "2":
                    resultado=num1-num2;
                    break;

                case "3":
                    resultado=num1*num2;
                    break;

                case "4":
                    if(num2!=0)
                    {
                        resultado=num1/num2;
                    }else
                    {
                        Console.WriteLine("No se puede divir en 0");
                    }
                        
                    break;

            }

            Console.WriteLine("\nEl resultado es:"+ resultado);
        }
        if(eleccion!="0")
        {
            eleccion="A";
        }
    }

}
//  ----------INICIO PUNTO 3 ----------

string? calcNumS="";
float calcNum;

do
{
    Console.WriteLine("\nIngrese un numero:");
    calcNumS=Console.ReadLine();
} while (!(float.TryParse(calcNumS,out calcNum)));

Console.WriteLine("\n Valor abosluto:"+Math.Abs(calcNum));
Console.WriteLine("\n Cuadrado :"+Math.Pow(calcNum,2));
Console.WriteLine("\n Raiz cuadrada:"+Math.Sqrt(calcNum));
Console.WriteLine("\n Seno:"+Math.Sin(calcNum));
Console.WriteLine("\n Coseno:"+Math.Cos(calcNum));
Console.WriteLine("\n Parte entera:"+Math.Truncate(calcNum));


string? num1S="",num2S="";
int num1,num2;

do
{
    Console.WriteLine("\nIngrese el primer numero para comparar:");
    num1S=Console.ReadLine();
} while (!(int.TryParse(num1S,out num1)));

do
{
    Console.WriteLine("\nIngrese el segundo numero para comparar:");
    num2S=Console.ReadLine();
} while (!(int.TryParse(num2S,out num2)));

if(num1>num2)
{
     Console.WriteLine("El numero "+num1+" es el mayor");
     Console.WriteLine("El numero "+num2+" es el menor");
}else
{
    Console.WriteLine("El numero "+num2+" es el mayor");
    Console.WriteLine("El numero "+num1+" es el menor");
}