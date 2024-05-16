// Equivalencia de numeros a romanos

List<string> romanos = new List<string>() {"I","II","III","IV","V","VI","VII","VIII","IX","X","XI","XII","XIII","XIV","XV","XVI","XVII","XVIII","XIV","XX"};

int numero;
Console.WriteLine("Ingrese un numero del 1 al 20: ");
numero = int.Parse(Console.ReadLine());

if (numero >= 1 && numero <= 20)
{
    Console.WriteLine($"El equivalente del numero {numero} en romanoes es: {romanos[numero - 1]}");
}
else {
    Console.WriteLine("Numero fuera de rango");
}

