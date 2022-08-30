Console.WriteLine("Введите два чила");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int min = num1;
int max = num2;

if(num1 > num2 ) max = num1;
if(num1 < num2 ) max = num2;

if(num1 > num2 ) min = num2;
if(num1 < num2 ) min = num1;

Console.Write("минимальное число =");
Console.WriteLine(min);
Console.Write("максимальне число =");
Console.Write(max);