using System;
namespace ClassWork.Models
{
	internal class Car
	{
		public string name;
		public int speed;
		private string color;
		public string Color {
			get
			{
				if (speed > 400)
				{
					return color;
				}
				return null;
			}
			set
			{
				color = value;
			}

		}
	}
}

