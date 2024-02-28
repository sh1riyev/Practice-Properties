﻿using System;
namespace ClassWork.Models
{
	public class Book
	{
		public int Id{ get; set; }
		public string Name{ get; set; }
		public string Author{ get; set; }

        public override string ToString()
        {
            return Name + " " + Author;
        }
    }
}

