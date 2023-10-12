// Tres matrices básicas
// Crea una matriz para contener los valores enteros 0 a 9.​
int[] digitos = new int[10];
for(int i=0; i<digitos.Length; i++){
  digitos[i] = i;
}
foreach(int num in digitos){
  Console.WriteLine(num);
}

// Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​
string[] nombres = new string[]{"Tim", "Martin", "Nikki", "Sara"};
foreach(string nombre in nombres){
  Console.WriteLine(nombre);
}

// Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​
bool[] valores = new bool[10];
for(int j=1; j<= valores.Length; j++){
  if(j%2 == 0){
    valores[j-1] = false;
  }else{
    valores[j-1] = true;
  }
}
foreach(bool valor in valores){
  Console.WriteLine(valor);
}

// Lista de Sabores
// Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​
List<string> sabores = new List<string>();
sabores.Add("Chocolate");
sabores.Add("Piña");
sabores.Add("Frutilla");
sabores.Add("Vainilla");
sabores.Add("Pasas al Ron");
sabores.Add("Lucuma");
sabores.Add("Chirimoya Alegre");
foreach(string sabor in sabores){
  Console.WriteLine(sabor);
}

// Imprime la longitud de esta lista después de construirla.
Console.WriteLine($"La longitud de la lista  es: {sabores.Count}");

// Imprime el tercer sabor de la lista y luego elimina ese valor.
Console.WriteLine($"El 3er sabor de la lista es: {sabores[2]}");
sabores.RemoveAt(2);
Console.WriteLine("--------------------");
foreach(string sabor in sabores){
  Console.WriteLine(sabor);
}

// Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​
Console.WriteLine($"La nueva longitud de la lista es: {sabores.Count}");

// Diccionario de información del usuario
// Crea un diccionario que almacene tanto claves de cadena como valores de cadena.
Dictionary<string, string> usuario = new Dictionary<string, string>();

/* Añade pares clave/valor a este diccionario donde:​
cada clave sea un nombre de la matriz de nombres​
cada valor sea un sabor seleccionado al azar de tu lista de sabores.​ */
Random rand = new Random();
for(int k=0; k<nombres.Length; k++){
  int num = rand.Next(sabores.Count);
  usuario.Add(nombres[k], sabores[num]);
}

// Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.
foreach(KeyValuePair<string, string> fila in usuario){
  Console.WriteLine($"El sabor de helado favorito de {fila.Key} es {fila.Value}");
}