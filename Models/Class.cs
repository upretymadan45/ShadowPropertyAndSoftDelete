using System;

namespace dropdown.Models{
    public class Class : ISoftDelete{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}