// Pedir los lados de un rectangulo y dibujar en la pantalla

int lado1, lado2;

Console.Write("Ingrese el ancho del rectangulo: ");
lado1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el largo del rectangulo: ");
lado2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Recatangulo de {lado1} X {lado2}: ");
Console.WriteLine();

List<string> lista = new List<string>();
List<string> lista2 = new List<string>();



for (int i = 1; i <= lado1; i++) { 
    lista.Add("*");
}

for (int i = 1; i <= lado2-2; i++)
{
    
    lista2.Add("*");
    
}
string espacio = " ";

for (int i = 1;i < lado1-2; i++) {
    espacio += " ";
}


foreach (string item in lista) { 
    Console.Write(item);
}

Console.WriteLine("");

foreach (string item2 in lista2) { 
    Console.WriteLine(item2 + espacio + item2);
}

foreach (string item in lista)
{
    Console.Write(item);
}

