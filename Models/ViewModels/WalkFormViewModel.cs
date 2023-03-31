using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DogGo.Models.ViewModels
{
    public class WalkFormViewModel
    {
        public Walks Walk { get; set; }
        public Walker Walker { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Walker> Walkers { get; set; }
        public List<int> SelectedDogs { get; set; }
    }
}
