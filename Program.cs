using TestConsole.Classes;

TestClass x = new TestClass() { square = 3 };

Console.WriteLine(x.square);

TestClass y = new TestClass() { square = 5 };

Console.WriteLine(y.square);

y = x;

Console.WriteLine(y.square);

x.square++;

Console.WriteLine(y.square);