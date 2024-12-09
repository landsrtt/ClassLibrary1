using System;
using ClassLibrary1;
using ContainerSt;

class Program
{
    static void Main(string[] args)
    {
        StackContainer stack = new StackContainer(5, 0, 10);

        try
        {
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
        }
        catch (ContainerInvalidValueException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ContainerExceptionOverflow ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        catch (ContainerExceptionUnderflow ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine(stack[0]);
            Console.WriteLine(stack[3]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}