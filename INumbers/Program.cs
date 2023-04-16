// See https://aka.ms/new-console-template for more information


Test<TestCommand>();

void Test<T>() where T : ICommand
{
    Console.WriteLine(nameof(T));
}

interface ICommand
{

}

public class TestCommand : ICommand { }