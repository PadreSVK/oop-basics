using System;

namespace Basics
{
    //todo UGLY CODE just playground
    public class MySuperException : Exception
    {
        public MySuperException(string message, Exception exception) : base(message, exception)
        {
        }
    }

    public static class Sample
    {
        public static void SampleS()
        {
            try
            {
                System.Console.WriteLine("super throwable code here");
            }
            catch (Exception ex)
            {
                throw; // Rethrow the same exception
                throw new MySuperException("something broken :(", ex);
            }
        }
        delegate void Action(); //has no parameters
        delegate void Action<in T>(T obj); //has one parameter
        delegate TResult Func<out TResult>(); //has no parameters
        delegate TResult Func<in T, out TResult>(T arg); //has one parameter
        public static void DelegateSample()
        {
            Action a = () => {System.Console.WriteLine("HU");};
            a += () => {System.Console.WriteLine("ha");};

            a();
            a.Invoke();


        }
    }
}