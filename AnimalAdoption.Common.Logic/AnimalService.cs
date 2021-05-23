using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "춘식이", Age = 33, Description = "Soft natured" },
            new Animal { Id = 2, Name = "추사랑하이", Age = 10, Description = "Under a lot of pressure" },
            new Animal { Id = 3, Name = "추사랑", Age = 20, Description = "Shiny and glasslike" },
        };
    }
}
