using System.Collections.Generic;

namespace RxNetDemo.Internal.Models
{
    public class School
    {
        public string Id { get; set; }

        public string Name { set; get; }

        public List<Teacher> Teachers { get; set; }
    }
}