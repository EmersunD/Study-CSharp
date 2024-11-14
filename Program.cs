Console.WriteLine("Testing CI/CE/CONVERT");

int a = 2;

float b = a;

Console.WriteLine(b);

// CI, because int and float have 4 bytes

Console.WriteLine("CE");
decimal c = 20m;
int d = (int) c; //realized cast in the int because decimal have more bytes.
Console.WriteLine(d);

Console.WriteLine("Convert");
float e = 12.45f;
Console.WriteLine(Convert.ToDecimal(e));
//Class convert is more pratic

