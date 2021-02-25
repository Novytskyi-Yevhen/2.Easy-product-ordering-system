using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewTask.Models {
	public static class Repository {
		static List<ShoppingOrder> responses = new List<ShoppingOrder>();

		public static IEnumerable<ShoppingOrder> Responses 
		{
			get { return responses; }
		}

		public static void AddResponse(ShoppingOrder response) 
		{
			responses.Add(response);
		}
	}
}
