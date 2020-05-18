using Excercise.Engine;
using System.Collections.Generic;
using System.Linq;

namespace Excercise
{
    public static class ExtensionMethods
    {
        public static IEnumerable<ICar<IEngine>> GetAllCarsByEngine<TEngineType>(IEnumerable<ICar<IEngine>> cars)
            where TEngineType : IEngine
        {
            return cars.Where(c => c.Engine.GetType() == typeof(TEngineType));
        }
    }
}
