using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using RxNetDemo.Internal.Models;
using RxNetDemo.Internal.Services;

namespace RxNetDemo
{
    internal class Demo2
    {
        public void Run()
        {
            var dbService = new DbService();
            var cacheService = new CacheService();

            var schools = new List<School>
            {
                new School {Name = "School_1"},
                new School {Name = "School_2"},
                new School {Name = "School_3"},
                new School {Name = "School_4"}
            };

            dbService.AddRange(schools)
                .ToObservable()
                .SelectMany(res => cacheService.AddRange(res).ToObservable())
                .Select(res => { return res.Select(item => item.Name).ToList(); }).Subscribe(res =>
                {
                    res.ForEach(Console.WriteLine);
                    Console.WriteLine("[DONE]");
                });
        }
    }
}