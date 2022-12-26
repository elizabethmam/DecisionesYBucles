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
