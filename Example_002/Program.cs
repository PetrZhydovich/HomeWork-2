// Удалить вторую цифру трёхзначного числа.
int randomNumber = new Random().Next(100,999);
Console.WriteLine($"Случайное трёхзначное число:  {randomNumber}");
char[] array = randomNumber.ToString().ToCharArray();
var char1 = array[0];
var char2 = array[1];
var char3 = array[2];
Console.WriteLine($"Удалили вторую цифру трехзначного числа: {char1} {char3}");