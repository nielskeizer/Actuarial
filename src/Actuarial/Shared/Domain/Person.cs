using System;

namespace Shared.Domain
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}