using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Intro;

namespace Basics
{


    //todo UGLY CODE just playground
    class Program
    {
        static void Main(string[] args)
        {
            // var test = new AbrakaDabra();

            // var rectangle = new Rectangle(5.5f, 4.5f);
            // var (a, b) = rectangle;

            RepositoryBase<Guid, Entity> a = new Entity1Repository();
            var b = new Entity2Repository();

            var entity = a.GetById(Guid.Empty);
            Func<Guid,Entity> test = a.GetById;


            var mySuperEntity = test(Guid.Empty);




            var entityb = b.GetById("asdas");
            var list2 = new List<string>();
            //var bbbbss = list2.GetAllGoodIds();


            var list = new List<Entity>();


            var bbbb = list.GetAllGoodIds();
            EntityBase bbbbaaa = list.FirstOrDefaultAA();

           

            try
            {
                NewMethod();

            }
            catch (Exception ex)
            {

                throw;
            }

            using var asdasdasdasd = new DisposableCusotmObject();



            Console.WriteLine("Hello World!");
        }

        private static void NewMethod()
        {
            try
            {
                throw new MyCustomException("aaaaaaaaa");
                ////asdasdadas
            }
            catch (MyCustomException ex) when (ex.Age > 5)
            {
                throw new MyCustomException("warpper", ex);
            }
            catch (MyCustomException ex) when (ex.Age <= 5)
            {
                throw new MyCustomException("warpper", ex);
            }
            catch (Exception ex)
            {
                throw;
            }


            finally
            {

            }
        }
    }

    public static class ExtensionMethods
    {
        public static IEnumerable<T> GetAllGoodIds<T>(this IEnumerable<T> items)
            where T : EntityBase
        {
            return items;
        }

        public static EntityBase FirstOrDefaultAA<T>(this IEnumerable<T> items)
           where T : EntityBase
        {
            return items.FirstOrDefault();
        }
    }


    public readonly struct Rectangle
    {
        public readonly float Width, Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }
    }

    public class DisposableCusotmObject : IDisposable
    {
        public void Dispose()
        {
            System.Console.WriteLine("Disposed");
        }
    }


    public class MyCustomException : Exception
    {
        public int Age { get; set; }
        public MyCustomException(string message) : base(message)
        {
        }

        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }

    public abstract class RepositoryBase<TKey, TEntity> 
        where TEntity : class, IEntity<TKey> , new()
    {
        public virtual TEntity GetById(TKey key)
        {
            var a = new TEntity();
            Console.WriteLine(a.Id);
            return new TEntity();
        }
    }

    public class Entity1Repository: RepositoryBase<Guid, Entity>
    {
        public override Entity GetById(Guid key)
        {
            //log
            return base.GetById(key);
        }
    }
    public class Entity2Repository : RepositoryBase<string, Entity2>
    {

    }

    public class Entity : EntityBase
    {
    }

    public class Entity2 : IEntity<string>
    {
        public string Id { get; }
    }

    public abstract class EntityBase : IEntity<Guid>
    {
        public Guid Id { get; }
    }
}
