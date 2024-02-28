using System;
namespace ClassWork.Models
{
	public class Bird :Animal
	{
		public string Color { get; set; }

        public override void Test()
        {
			Console.WriteLine("Salam");
        }

        public override void AnimalSoud()
		{
			Console.WriteLine("Animal bird sound");
		}
	}
}

