//  Показать вторую цифру трёхзначного числа.
int randomNumber = new Random().Next(100,999);
Console.WriteLine($"Случайное трёхзначное число:  {randomNumber}");
char[] array = randomNumber.ToString().ToCharArray();
var char1 = array[1];
Console.WriteLine($"Втоая цифра трёхзначного числа: {char1}");





