using System;
using dropdown.Data;

namespace dropdown.Models
{
    public class Section : ISoftDelete
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
