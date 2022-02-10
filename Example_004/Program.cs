// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int GetRandom()
{
int randomNumber = new Random().Next(1,7);
return randomNumber;
}
int randomNumber = GetRandom();
Console.WriteLine($"Случайное число: {randomNumber}");
if (randomNumber >= 6)
{
Console.WriteLine("Выходной день!");
}
else
    Console.WriteLine("Будний день!");