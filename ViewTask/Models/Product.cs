﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewTask.Models {
	public class Product {
		public string Name { get; set; }
		public double Price { get; set; }

		public Product(string Name, double Price) 
		{
			this.Name = Name;
			this.Price = Price;
		}
	}
}
