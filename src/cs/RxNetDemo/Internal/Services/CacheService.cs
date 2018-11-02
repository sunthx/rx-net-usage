using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RxNetDemo.Internal.Services
{
    class CacheService
    {
        public Task<List<T>> AddRange<T>(List<T> values)
        {
            return Task.Factory.StartNew(() =>
            {
                Task.Delay(2000).Wait();

                Console.WriteLine($"CacheService AddRange {typeof(T).Name} [DONE]");
                return values;
            });
        }
    }
}
