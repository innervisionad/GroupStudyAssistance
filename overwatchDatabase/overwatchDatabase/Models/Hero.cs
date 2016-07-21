using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace overwatchDatabase.Models
{
    public partial class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
    }
}