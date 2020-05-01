using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.StackProblems
{

    #region Animal
    public abstract class Animal
    {
        private int Order;
        public string name;
        public Animal(string n)
        {
            name = n;
        }

        public void SetOrder(int order)
        {
            Order = order;
        }

        public int GetOrder()
        {
            return Order;
        }
        public bool IsOlderThan(Animal animal)
        {
            if (animal != null)
            {
                return Order > animal.Order;
            }
            return false;
        }


    }
    #endregion

    #region AnimalQueue

    public class AnimalQueue
    {

        #region private variables
        LinkedList<Dog> dogs = new LinkedList<Dog>();
        LinkedList<Cat> cats = new LinkedList<Cat>();
        int order = 1;
        #endregion

        #region EnQueue
        public void EnQueue(Animal a)
        {
            a.SetOrder(order);
            order++;
            if (a is Dog)
            {
                dogs.AddLast((Dog)a);
            }
            if (a is Cat)
            {
                cats.AddLast((Cat)a);
            }

        }
        #endregion

        #region Dequeue
        public Animal DeQueue()
        {
            if (dogs.Count == 0)
            {
                return DequeueCat();
            }

            if (cats.Count == 0)
            {
                return DequeueDog();
            }

            var cat = cats.First();
            var dog = dogs.First();

            if (cat.IsOlderThan(dog))
            {
                return DequeueCat();
            }
            else
            {
                return DequeueDog();
            }
        }
        #endregion

        #region private methods
        private Dog DequeueDog()
        {

            if (dogs?.Count > 0)
            {
                var dog = dogs.FirstOrDefault();
                dogs.RemoveFirst();
                return dog;
            }
            return null;
        }

        private Cat DequeueCat()
        {
            if (cats?.Count > 0)
            {
                var cat = cats.First();
                cats.RemoveFirst();
                return cat;
            }
            return null;
        }
        #endregion

    }
    #endregion

    #region Dog
    public class Dog : Animal
    {
        public Dog(string n) : base(n)
        {

        }
    }
    #endregion

    #region Cat
    public class Cat : Animal
    {
        public Cat(string n) : base(n)
        {

        }
    }
    #endregion

}
