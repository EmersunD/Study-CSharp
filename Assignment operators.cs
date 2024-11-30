Console.WriteLine("Operadores de atribuição\n");

Console.WriteLine("Insira o valor de X");

var x = Console.ReadLine();

Console.WriteLine($"O valor inicial de X é = {x}\n");



Console.WriteLine("Pressione ENTER para seguir com os operadores de atribuição");
Console.ReadLine();
int xnum = Convert.ToInt32(x);

xnum += 5;
Console.WriteLine($" O valor de x+5 é de {xnum}");

xnum = Convert.ToInt32(x);
xnum -= 5;
Console.WriteLine($" O valor de x-5 é de {xnum}");

xnum = Convert.ToInt32(x); //add class convert for reset xnum value
xnum = 5;
Console.WriteLine($" O valor de x5 é de {xnum}");

xnum = Convert.ToInt32(x);
xnum = Convert.ToInt32(xnum); 

xnum = Convert.ToInt32(x);
xnum /= 5;
Console.WriteLine($" O valor de x/5 é de {xnum}");

xnum = Convert.ToInt32(x);
xnum %= 5;
Console.WriteLine($" O valor de x%5 é de {xnum}");

Console.ReadKey();