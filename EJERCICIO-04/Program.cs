// Registrar una matriz, ordenarla, mostrar el original y la ordenada.

using System.Runtime.InteropServices;

int[] arreglo = new int[5];

arreglo[0] = 4;
arreglo[1] = 3;
arreglo[2] = 7;
arreglo[3] = 1;
arreglo[4] = 9;

Console.WriteLine("Matriz original: ");

for (int i = 0; i < arreglo.Length; i++) {
    Console.Write($"[{arreglo[i]}]");
}

List<int> listaTemporal = arreglo.ToList();
listaTemporal.Sort();

Console.WriteLine(" ");
Console.WriteLine("Matriz ordenada:");


int [] arregloOrdenado= listaTemporal.ToArray();

for (int i = 0;i < arregloOrdenado.Length;i++) {
    Console.Write($"[{arregloOrdenado[i]}]");
}