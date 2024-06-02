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
// int i=0,inv=0;
// string? num="";

// Console.WriteLine("Ingrese un numero:");
// num=Console.ReadLine();

// if(int.TryParse(num, out i))
// {
//     Console.WriteLine("Es un numero");
//     if(i>0)
//     {
//         while(i>0)
//         {
//             inv=inv*10+i%10;
//             i=i/10;

//         }
//         Console.WriteLine("El numero invertido es:"+inv);
//     }else
//     {
//         Console.WriteLine("Es <0 por lo que el programa no lo puede invertir");
//     }
// }else
// {
//     Console.WriteLine("NO es un numero");
// }

// //  ----------INICIO PUNTO 2 ----------

// string? eleccion="a",numS1="",numS2="";
// int num1=0,num2=0,resultado=0;


// while(eleccion!="0")
// {   
   
//     while(eleccion!="0")
//     {   
//         while(eleccion!="0"&&eleccion!="1"&&eleccion!="2"&&eleccion!="3"&&eleccion!="4")
//         {
//             Console.WriteLine("\nElija que operacion desea realizar:\n1-Sumar \n2-Restar \n3-Multiplicar \n4-Dividir\n0-Salir");
//             eleccion=Console.ReadLine();
//             if(eleccion!="0" && eleccion!="5")
//             {
//                 Console.WriteLine("\nIngrese el primer numero para operar:");
//                 numS1=Console.ReadLine();
//                 Console.WriteLine("\nIngrese el segundo numero para operar:");
//                 numS2=Console.ReadLine();
//             } 
//         }

//         if(int.TryParse(numS1, out num1)&&int.TryParse(numS2, out num2))
//         {
//             switch (eleccion)
//             {
//                 case "1":
//                     resultado=num1+num2;
//                     break;

//                 case "2":
//                     resultado=num1-num2;
//                     break;

//                 case "3":
//                     resultado=num1*num2;
//                     break;

//                 case "4":
//                     if(num2!=0)
//                     {
//                         resultado=num1/num2;
//                     }else
//                     {
//                         Console.WriteLine("No se puede divir en 0");
//                     }
                        
//                     break;

//             }

//             Console.WriteLine("\nEl resultado es:"+ resultado);
//         }
//         if(eleccion!="0")
//         {
//             eleccion="A";
//         }
//     }

// }
// //  ----------INICIO PUNTO 3 ----------

// string? calcNumS="";
// float calcNum;

// do
// {
//     Console.WriteLine("\nIngrese un numero:");
//     calcNumS=Console.ReadLine();
// } while (!(float.TryParse(calcNumS,out calcNum)));

// Console.WriteLine("\n Valor abosluto:"+Math.Abs(calcNum));
// Console.WriteLine("\n Cuadrado :"+Math.Pow(calcNum,2));
// Console.WriteLine("\n Raiz cuadrada:"+Math.Sqrt(calcNum));
// Console.WriteLine("\n Seno:"+Math.Sin(calcNum));
// Console.WriteLine("\n Coseno:"+Math.Cos(calcNum));
// Console.WriteLine("\n Parte entera:"+Math.Truncate(calcNum));


// string? numC1S="",numC2S="";
// int numC1,numC2;

// do
// {
//     Console.WriteLine("\nIngrese el primer numero para comparar:");
//     numC1S=Console.ReadLine();
// } while (!(int.TryParse(numC1S,out numC1)));

// do
// {
//     Console.WriteLine("\nIngrese el segundo numero para comparar:");
//     numC2S=Console.ReadLine();
// } while (!(int.TryParse(numC2S,out numC2)));

// if(numC1>numC2)
// {
//      Console.WriteLine("El numero "+numC1+" es el mayor");
//      Console.WriteLine("El numero "+numC2+" es el menor");
// }else
// {
//     Console.WriteLine("El numero "+numC2+" es el mayor");
//     Console.WriteLine("El numero "+numC1+" es el menor");
// }

//  ----------INICIO PUNTO 4 ----------

string? cad1="",cad2="",cad3="",cad4="",operaciones="";
string[] palabras, terminos;



Console.WriteLine("\nIngrese una cadena de texto:");
cad1=Console.ReadLine();

Console.WriteLine("\nLa longuiud de la cadena es de:"+cad1.Length);

Console.WriteLine("\nIngrese una segunda cadena de texto:");
cad2=Console.ReadLine();

cad3=cad1+cad2;

Console.WriteLine("\nLa nueva cadena es:"+cad3);

// cad4=cad3.Substring(4,cad3.Length/2);

// Console.WriteLine("\nUna nueva subcadena es:"+cad4);

// Console.WriteLine("\nLa sumade 4 y 58 es:"+(4+58));

// foreach (var caracter in cad3)
// {
//     Console.WriteLine(caracter);
// }
//Hacer ● Buscar la ocurrencia de una palabra determinada en la cadena ingresada

int inicioPalabra = 0;
int finPalabra = cad3.Length;
int recorrido;
string palabraBuscada = "hola";
int contador = 0;
int indiceOcurrencia = 0;
while (indiceOcurrencia != -1)
{

    recorrido = finPalabra - inicioPalabra;
    indiceOcurrencia = cad3.IndexOf(palabraBuscada, inicioPalabra, recorrido);//busco el indice de la primera letra de la primera ocurrencia partiendo desde el primer caracter de la cadena de caracteres
    if (indiceOcurrencia == -1) break;
    contador = contador + 1;
    inicioPalabra = indiceOcurrencia + 1;
}

// Console.WriteLine("La cadena en mayusculas:"+cad3.ToUpper());
// Console.WriteLine("La cadena en minusculas:"+cad3.ToLower());

// palabras=cad3.Split(" ");
// foreach (var palabra in palabras)
// {
//     Console.WriteLine(palabra);
// }

char[] operadores={'+','-','*','/'};

Console.WriteLine("\nIngrese una opereacion:");
operaciones=Console.ReadLine();

terminos=operaciones.Split(operadores);
int indiceTermino=-1;
int i=0;

while (indiceTermino == -1)
{
    indiceTermino = operaciones.IndexOf(operadores[i]);
    if (indiceTermino != -1)
    {
        break;
    }
    else
    {
        i++;
        if (i > terminos.Length)
        {
            break;
        }
    }
}

if (indiceTermino == -1)
{
    System.Console.WriteLine("Error la expresion ingresada tiene un operador invalido");

}
else
{
    if (int.TryParse(terminos[0], out int numeroSplit1))
    {
        if (int.TryParse(terminos[1], out int numeroSplit2))
        {
            // System.Console.WriteLine($"numero1 = {numeroSplit1}");
            // System.Console.WriteLine($"numero2 = {numeroSplit2}");
            string operador = operaciones.Substring(indiceTermino, 1);
            switch (operador)
            {
                case "+":
                    int resultado = numeroSplit1+numeroSplit2;
                    Console.WriteLine(resultado);
                    break;

                case "-":
                    resultado = numeroSplit1-numeroSplit2;
                    Console.WriteLine(resultado);
                    break;

                case "*":
                    resultado =  numeroSplit1*numeroSplit2;
                    Console.WriteLine(resultado);
                    break;

                case "/":
                    resultado = numeroSplit1/numeroSplit2;
                    Console.WriteLine(resultado);
                    break;
            }
        }
        else
        {
            System.Console.WriteLine("El segundo termino de la ecuacion no es un numero valido");
        }
    }
    else
    {
        System.Console.WriteLine("El primer termino de la ecuacion no es un numero valido");
    }
}