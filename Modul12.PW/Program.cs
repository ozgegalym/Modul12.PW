using Modul12.PW;
using System;

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();
        myObject.PropertyChanged += (sender, e) =>
        {
            Console.WriteLine($"Свойство {e.PropertyName} было изменено.");
        };

        myObject.MyProperty = 42;

        MathOperations.MathOperation addOperation = MathOperations.Add;
        MathOperations.MathOperation subtractOperation = MathOperations.Subtract;
        MathOperations.MathOperation multiplyOperation = MathOperations.Multiply;
        MathOperations.MathOperation divideOperation = MathOperations.Divide;

        MathOperations.MathOperation chainedOperation = addOperation + multiplyOperation - subtractOperation;

        double x = 5;
        double y = 3;

        Console.WriteLine($"Выполняем операцию: {x} + {y} = {addOperation(x, y)}");
        Console.WriteLine($"Выполняем операцию: результат * {y} = {multiplyOperation(addOperation(x, y), y)}");
        Console.WriteLine($"Выполняем операцию: результат - {y} = {subtractOperation(multiplyOperation(addOperation(x, y), y), y)}");

        double result = MathOperations.PerformOperation(x, y, chainedOperation);
        Console.WriteLine($"Результат операции: {result}");

        MathOperations.MathOperation powerOperation = (a, b) => Math.Pow(a, b);
        Console.WriteLine($"Выполняем операцию: {x} в степени {y} = {powerOperation(x, y)}");
    }
}
