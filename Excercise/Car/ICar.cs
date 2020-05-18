using Excercise.Engine;
using System;

namespace Excercise
{
    //without generic
    //public interface ICar
    public interface ICar<TEngine> where TEngine : IEngine
    {
        TEngine Engine { get; }
        string Color { get; }
        string Name { get; }
        int ActualSpeed { get; }
        int MaxSpeed { get; }
        void Accelerate(int speed);
        void Break();
    }

    public class Mustang : ICar<V8Engine>
    {
        // without generics
        //IEngine ICar.Engine => Engine;
        public V8Engine Engine { get; }
        public string Color { get; }
        public string Name { get; }
        public int ActualSpeed { get; }
        public int MaxSpeed { get; }

        public void Accelerate(int speed)
        {
            var speedAfterAcceleration = ActualSpeed + speed;

            if (speedAfterAcceleration > MaxSpeed)
            {
                throw new MaxSpeedExceededException("Max speed was exceeed");
            }
            try
            {
                Engine.Accelerate(speed);
            }
            catch(Exception ex)
            {
                throw new EngineFailureException("Engine exception", ex);
            }
        }

        public void Break()
        {
            //todo
            throw new System.NotImplementedException();
        }
    }

}
