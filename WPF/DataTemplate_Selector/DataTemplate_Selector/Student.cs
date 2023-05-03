using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplate_Selector
{
    public class Student
    {
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Birthday { get; set; } = "";
        public string School { get; set; } = "";

        public override string ToString() {
            return $"Name: {Name}, Gender: {Gender}, Birthday:{Birthday}, School:{School}";
        }

        public static List<Student> Students =>new() {

            new Student{Name="Kim", Gender="male", Birthday="19800101", School="Seoul"},
            new Student{Name="Li", Gender="female", Birthday="19830207", School="Busan"},
            new Student{Name="Park", Gender="female", Birthday="19820308", School="Daegu"},
            new Student{Name="Yon", Gender="male", Birthday="19880409", School="Inchen"},

        };
    }
}
