using System.Collections.Generic;

namespace RxNetDemo.Internal.Models
{
    public class Teacher
    {
        public string Id { get; set; }

        public List<Student> Students { get; set; }
    }
}