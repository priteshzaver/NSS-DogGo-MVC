﻿using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
    public class ProfileViewModel
    {
        public Owner Owner { get; set; }
        public Dog Dog { get; set; }
        public Walker Walker { get; set; }
        public Walks Walk { get; set; }
        public WalkStatus WalkStatus { get; set; }
        public List<Walker> Walkers { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Walks> Walks { get; set; }
    }
}
