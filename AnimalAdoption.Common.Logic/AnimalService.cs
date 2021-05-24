using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "라이언1", Age = 33, Description = "라이언 인사" },
            new Animal { Id = 2, Name = "라이언2", Age = 10, Description = "양손 엄지척" },
            new Animal { Id = 3, Name = "라이언3", Age = 20, Description = "엄지척" },
            new Animal { Id = 4, Name = "라이언4", Age = 20, Description = "간식 사러간 라이언" },
        };
    }
}
