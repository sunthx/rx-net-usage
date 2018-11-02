using System;
using System.Collections.Generic;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using RxNetDemo.Internal.Models;

namespace RxNetDemo.Internal.Services
{
    class ApiService
    {
        public IObservable<List<School>> GetSchoolUpdates()
        {
            var task = Task.Factory.StartNew(() =>
            {
                Task.Delay(2000).Wait();
                return new List<School>
                {
                    new School
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = Guid.NewGuid().ToString()
                    }
                };
            });

            var observable = task.ToObservable();
            return observable;
        }

        public IObservable<List<Teacher>> GetTeacherUpdates()
        {
            var task = Task.Factory.StartNew(() =>
            {
                Task.Delay(3000).Wait();
                Console.WriteLine("GetTeacherUpdates [DONE]");

                return new List<Teacher>
                {
                    new Teacher
                    {
                        Id = Guid.NewGuid().ToString()
                    }
                };
            });

            var observable = task.ToObservable();
            return observable;
        }

        public IObservable<List<Student>> GetStudentUpdates()
        {
            var task = Task.Factory.StartNew(() =>
            {
                Task.Delay(6000).Wait();
                Console.WriteLine("GetStudentUpdates [DONE]");

                return new List<Student>
                {
                    new Student
                    {
                        Name = Guid.NewGuid().ToString()
                    }
                };
            });

            var observable = task.ToObservable();
            return observable;
        }
    }
}