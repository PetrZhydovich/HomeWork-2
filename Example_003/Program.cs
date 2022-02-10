// Найти третью цифру числа или сообщить, что её нет.
int GetRandom()
{
int randomNumber = new Random().Next(1,150);
return randomNumber;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число: {randomazer}");
int result = randomazer /10;
if(result >= 10)
{
    Console.WriteLine(randomazer % 10);
}
else
{
    Console.WriteLine("Нет 3-ей цифры!");
}