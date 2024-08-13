// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// inteiro
int var1 = 2;
Console.WriteLine(var1);

// double
double var2 = 2.345;
Console.WriteLine(var2);
Console.WriteLine(var1 + var2);

// cast
Console.WriteLine(var1 + (int)var2);

// string
string string1 = "teste";
string string2 = "dotnet";
Console.WriteLine(string1 + " " + string2);

Console.WriteLine(string1 + " " + var1);

// if

//double var3 = 2.0000000000000001; //18
double var3 = 2.000000000000001;  //17
Console.WriteLine(var3);
if (var3>2)
{
  Console.WriteLine("Verdade!!");
} 
else 
{
  Console.WriteLine("Falso!!");
}

// for
int tamanho = 10;
string aux = "";
for (int i = 0; i < tamanho; i++){
    aux = aux + i.ToString();
    Console.Write(aux);
}