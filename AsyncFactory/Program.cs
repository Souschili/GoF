using System.Dynamic;
using System.Runtime.InteropServices;

namespace AsyncFactory
{
    #region asyncfactory
    public interface IAsyncInit<T>
    {
        Task<T> InitAsync();
    }

    class Foo2 : IAsyncInit<Foo2>
    {
        public Task<Foo2> InitAsync()
        {
            throw new NotImplementedException();
        }
    }

    public static class AsyncFactory
    {
        public static async Task<T> Create<T> ()
            where T : IAsyncInit<T>, new()
        {
            return await new T().InitAsync();
        }
    }
    #endregion

    class Foo
    {
        public Foo() { }

        public async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        // factory method
        public static async Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return await result.InitAsync();
        }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            // for async factory method
            var foo = await Foo.CreateAsync();
            // async factory
            var foo2=AsyncFactory.Create<Foo2>();
        }
    }
}
