using System.Runtime.CompilerServices;

int cantidad1 = 5;
int cantidad2 = 5;

bool cantidadesIguales = cantidad1 == cantidad2; //true
//se hace uso de string interpolation para insertar expresiones en las cadenas.
Console.WriteLine($"¿{cantidad1} y {cantidad2} son iguales? {cantidadesIguales}");

bool cantidadesDistintas = cantidad1 != cantidad2; //false
Console.WriteLine($"¿{cantidad1} y {cantidad2} son distintas? {cantidadesDistintas}");

string nombre1 = "Elizabeth";
string nombre2 = "Daniel";

Console.WriteLine($"¿{nombre1} y {nombre2} son iguales? {nombre1 == nombre2}");
Console.WriteLine($"¿{nombre1} y {nombre2} son distintos? {nombre1 != nombre2}");

// el operador "is" se usa para hacer comparaciones, sustituyendo el operador lógico "=="
Console.WriteLine($"¿{nombre1} es igual a nulo? {nombre1 is null}");
Console.WriteLine($"¿{nombre1} es diferente a nulo? {nombre1 is not null}");

bool mayorYmenor = 6 >= 5 && 7 <= 10;
Console.WriteLine($"¿6 es mayor o igual a 5 y 7 es menor o igual a 10? {mayorYmenor}");

bool mayorYmenor2 = 3 >= 5 && 7 >= 10;
Console.WriteLine($"¿3S es mayor o igual a 5 y 7 es menor o igual a 10? {mayorYmenor2}");

int numero = 6;
/*si el primer operando es falso, el segundo ya no se evalúa*/
/*
    true && true = true
    true && false = false
    false && true = false
    false && false = false
 */
bool entreXCantidad = numero >= 5 && numero <= 10; 
Console.WriteLine($"¿{numero} está entre 5 y 10? {entreXCantidad}");

//Si el primer operando es verdadero, el segundo ya no se evalúa, de lo contrario, se evalúan los dos operandos.
bool esIgualQue = numero == 5 || numero == 6; //true
Console.WriteLine($"¿{numero} es igual a 5 o {numero} es igual a 6? {esIgualQue}");

string cadena = "Nombre";
Console.WriteLine($"¿{cadena} es igual a {cadena.ToUpper()}? {cadena == cadena.ToUpper()}"); //false

//Evitar error de referencia nula -> evaluar si la variable es nula
Console.WriteLine($"¿{cadena} es distinta de nulo o {cadena} está en mayúsculas?" +
    $"{cadena is not null && cadena == cadena.ToUpper()}");

/*
    * sentencias de selección:
        1. If
        2. Operador ternario
        3. Switch
*/

//Esta estructura sólo aplica cuando hay una sola línea de código debajo del if.
if (cadena is not null && cadena != cadena.ToUpper())
    Console.WriteLine($"{cadena} es diferente de nulo y no está en mayúsculas.");

Console.WriteLine("Si la condición es verdadera, también se ejecuta esta línea, de lo contrario, sólo esta línea se ejecuta.");

//Operador ternario
bool loguedx = true;
string estaLogueadx = loguedx ? "Bienvenidx" : "Inicia sesión";
Console.WriteLine($"¿Está logueadx? {estaLogueadx}");

//Sentencia Switch
int lugar = 2;

switch(lugar)
{
    case 1:
        Console.WriteLine("Primer lugar");
        break;
    case 2: Console.WriteLine("Segundo lugar");
        break;
    case 3: Console.WriteLine("Tercer lugar");
        break;
    default: Console.WriteLine("Fin");
        break;
}

//Expresiones switch
string mensajeLugar = lugar switch
{
    1 => "Primer lugar",
    2 => "Eres segundo lugar",
    3 => "Tercer lugar",
    4 or 5 => "Casi lo logras",
    _ => "Fin" //Siempre debe haber un menssaje por defecto o lanzará un error de excepción.
};
Console.WriteLine(mensajeLugar);

//Console.WriteLine(lugar switch //También se puede hacer de esta manera.
//{
//    1 => "Primer lugar",
//    2 => "Eres segundo lugar",
//    3 => "Tercer lugar",
//    4 or 5 => "Casi lo logras",
//    _ => "Fin" //Siempre debe haber un menssaje por defecto o lanzará un error de excepción.
//});

//Patrones relacionales: para comparar el resultado de una expresión con una constante especificada.
int temperatura = 35;

string mensaje = temperatura switch
{
    37 => "No tienes ninguna condición",
    > 37 => "Tienes fiebre",
    < 37 => "Puede que tengas baja el azúcar"
};
Console.WriteLine(mensaje);

//Patrones lógicos: para probar si una expresión coincide con una combinación lógica de patrones.
string? palabra = "Cualquier palabra.";

if (palabra is not null)
{
    Console.WriteLine(palabra.ToUpper());
}

Console.WriteLine("El programa ha terminado.");

int temp2 = 30;

string message = temp2 switch //se debe cubrir todos los casos o lanza una advertencia
{
    37 => "No tienes ninguna condición",
    > 37 and < 39 => "Tienes fiebre",
    >= 39 and < 43 => "Debes ir a lx médicx.",
    >= 43 => "rarx",
    < 37 => "Puede que tengas baja el azúcar"
};
Console.WriteLine(message);

DateTime hoy = DateTime.Today;

string estacion = hoy.Month switch
{
    12 or 1 or 2 => "Invierno",
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    9 or 10 or 11 => "Otoño",
    _ => throw new ApplicationException("Mes incorrecto.") // "_" es la variable de descarte.
};
Console.WriteLine(estacion);


//Bucle while
int contador = 1; //Inicialización de la variable

while (contador <= 10) //Condición
{ //Bloque de código
    Console.WriteLine(contador);
    //Modificación de la variable inicializada.
    contador++; //ir cambiando la variable para que en un momento determinado se evalúe como falso y salga del bucle; evitar un bucle infinito.


}

decimal balance = 200m;
decimal interes = 1.07m;
int contadorInteres = 1;

while(contadorInteres <= 10)
{
    balance *= interes;
    contadorInteres++;
}
Console.WriteLine(balance);

//Bucle do while: el código se ejecuta al menos una vez, incluso si la condición es falsa.
do
{
    Console.WriteLine(contador);
    contador++;

} while (contador <= 10);

//do
//{
//    Console.WriteLine(contador);
//    contador++;

//} while (contador > 10);


//Bucle for

//for (inicialización; condición; modificación de la variable inicializada) { bloque de código que se repetirá }
for (int i = 0; i <= 10; i++)
{
    //El scope (alcance) de la variable "i" sólo funciona dentro del bloque de código "for".
    Console.WriteLine(i);
}

//Bucle forEach: útil para colecciones de valores. Permite iterar los elementos de una colección de datos.
//String: cadena de caracteres, por lo tanto se puede iterar caracter por caracter con un forEach.
//Colección: varios elementos que podemos recorrer.

string miNombre = "Elizabeth";
 // forEach significa que intere por cada letra en la variable "miNombre"
foreach(char letra in miNombre)
{
    Console.WriteLine(letra);
}

//Sentencias de salto: funcionan para condicionales y bucles.
for (int j = 0; j <= 10; j++)
{
    if (j == 5)
    {
        break; //rompe el ciclo y muestra en pantalla hasta donde se iteró
    }

    Console.WriteLine(j);
}

for (int j = 0; j <= 10; j++)
{
    if (j == 5)
    {
        continue; //se salta el 5 y sigue con la iteración hasta que termine.
    }

    Console.WriteLine(j);
}


//Bucles infinitos

/*while (true)
{
    Console.WriteLine("éste es un bucle infinito.");
}*/

/*for (; ; )
{
    Console.WriteLine("También es un bucle infinito.");
}*/

while (true)
{
    Console.WriteLine("Te damos la bienvenida a la calculadora de suma con C#.");
    Console.Write("Escriba el primer número: ");
    string entradaUsuario = Console.ReadLine(); //se lee lo que el usuario escribe en la consola.

    if (entradaUsuario is null)
    {
        Console.WriteLine("Error, vuelve a comenzar.");
        continue;
    }

    decimal numero1 = decimal.Parse(entradaUsuario);

    Console.Write("Escriba el segundo número: ");
    entradaUsuario = Console.ReadLine();

    if (entradaUsuario is null)
    {
        Console.WriteLine("Error, vuelve a comenzar.");
        continue;
    }

    decimal numero2 = decimal.Parse(entradaUsuario);

    Console.WriteLine($"El resultado de sumar {numero1} + {numero2} es {numero1 + numero2}");
    Console.WriteLine("¿Desea sumar otra vez? (s/n): ");

    entradaUsuario = Console.ReadLine();

    if (entradaUsuario == "n")
    {
        break;
    }
}

Console.WriteLine("Adiós.");