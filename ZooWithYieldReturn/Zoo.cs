using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWithYieldReturn
{

        internal class Zoo : IEnumerable
        {
            public Animal[] Animals = new Animal[]
            {
         new Animal("Lion", "A majestic predator known for its powerful roar.", "Carnivore"),
         new Animal("Elephant", "A large herbivore with big ears and a trunk.", "Herbivore"),
         new Animal("Giraffe", "An animal with a long neck and spotted coat.", "Herbivore"),
         new Animal("Monkey", "Playful and intelligent, often spends time in trees.", "Primate"),
         new Animal("Panda", "A peaceful animal with a black-and-white coat, eating bamboo.", "Herbivore"),
            };
            public IEnumerator GetEnumerator()
            {
                yield return Animals[0];
                yield return Animals[1];
                yield return Animals[2];
                yield return Animals[3];
            }
        }
    
}
