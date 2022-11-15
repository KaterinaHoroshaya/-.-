// . В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.
string message = "hi";
string password = "secret";

Console.WriteLine("Введите пароль: ");
string a = Console.ReadLine();

if (a == password)
{
   Console.WriteLine($"{message}");
}

else 
{
    Console.WriteLine("Введите пароль ещё раз: ");
    a = Console.ReadLine();
}

if ( a == password)
{
   Console.WriteLine($"{message}");
}

else 
{
    Console.WriteLine("Введите пароль в последний раз: ");
    a = Console.ReadLine();
}
if ( a == password)
{
   Console.WriteLine($"{message}");
}
else 
{
    Console.WriteLine("Пароль неверный!");
}