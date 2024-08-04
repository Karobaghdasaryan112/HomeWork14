using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
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
           return (IEnumerator)new ZooEnumerator(Animals); //new ZooEnumerator(Animals)

        }
    }
    internal class ZooEnumerator  //: IEnumerator
    {
        private Animal[] Animals;
        private int CurrentIndex;
        public ZooEnumerator(Animal[] animals)
        {
            Animals = animals;
        }
        public object Current
        {
            get
            {
                if (CurrentIndex < 0 || CurrentIndex >= Animals.Length)
                    throw new InvalidOperationException();
                return Animals[CurrentIndex];
            }
        }

        public bool MoveNext()
        {
            if (CurrentIndex < Animals.Length - 1)
            {
                CurrentIndex++;
                return true;
            }
            return false;
        }
        //  public void Reset()
        // {
        //   CurrentIndex = -1;
    }
}


