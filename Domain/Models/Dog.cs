﻿using Domain.Models.Animal;

namespace Domain.Models
{
    public class Dog : AnimalModel
    {
        public new string Name { get; set; } = string.Empty;
        public int Weight { get; set; }
        public string Breed { get; set; } = string.Empty;
        public static string Bark()
        {
            return "This animal barks";
        }

    }
}
