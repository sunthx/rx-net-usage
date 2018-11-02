using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RxNetDemo.Internal.Services
{
    class DbService
    {
        public Task<List<T>> AddRange<T>(List<T> values)
        {
            return Task.Factory.StartNew(() =>
            {
                Task.Delay(5000).Wait();

                Console.WriteLine($"DbService AddRange {typeof(T).Name} [DONE]");
                return values;
            });
        }
    }
}
