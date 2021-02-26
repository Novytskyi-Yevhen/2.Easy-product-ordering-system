using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewTask.Models {
	public class ShoppingOrder 
	{
		[Required(ErrorMessage = "Please enter your name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter your email adress")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Please select one of malls")]
		public string Mall { get; set; }

		public DateTime? ShoppingDate { get; set; }
	}
}
