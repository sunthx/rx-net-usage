using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using RxNetDemo.Internal.Models;
using RxNetDemo.Internal.Services;

namespace RxNetDemo
{
    class Demo1
    {
public void Run()
{
    Console.WriteLine("Rx Operator --- Zip");

    var service = new ApiService();

    var schoolObservable = service.GetSchoolUpdates();
    var teacherObservable = service.GetTeacherUpdates();
    var studentsObservable = service.GetStudentUpdates();

    // Zip — combine the emissions of multiple Observables together via a specified function and emit single 
    // items for each combination based on the results of this function
    schoolObservable
        .Zip(teacherObservable, studentsObservable, CombineExam)
        .Subscribe(result =>
        {
            Console.WriteLine("School Data [DONE]");
        });
}

List<Teacher> CombineExam(List<School> schools, List<Teacher> teachers, List<Student> students)
{
    teachers.ForEach(item =>
    {
        item.Students = students;
    });

    schools.ForEach(item =>
    {
        item.Teachers = teachers;
    });

    return teachers;
}
    }
}
