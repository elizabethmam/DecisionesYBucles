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

//Operadores relacionales
int temperatura = 35;

string mensaje 