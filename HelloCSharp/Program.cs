string input = "123";
int number = int.TryParse(input, out number) ? number : 0;

Console.WriteLine($"O valor convertido é: {number}");