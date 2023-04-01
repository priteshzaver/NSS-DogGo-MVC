using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DogGo.Models
{
    public class Walks
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int WalkerId { get; set; }
        public int DogId { get; set; }
        public int WalkStatusId { get; set; }
        public Walker Walker { get; set; }
        public Dog Dog { get; set; }
        public WalkStatus WalkStatus { get; set; }
        public List<Dog> Dogs { get; set; } = new List<Dog>();

        [BindProperty]
        public List<int> AreChecked { get; set; }
    }
}
