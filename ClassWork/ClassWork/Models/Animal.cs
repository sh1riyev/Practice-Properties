using System;
namespace ClassWork.Models
{
	public abstract class Animal
	{
		public string Name { get; set; }

        public abstract void Test();

        public virtual void AnimalSoud()
        {
            Console.WriteLine("Animal sound");
        }
    }
}

