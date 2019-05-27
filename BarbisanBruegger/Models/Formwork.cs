using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BarbisanBruegger.Models
{
	public class Formwork
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public string Number { get; set; }
		public int PricePerMonth { get; set; }
		public int Quantity { get; set; }

	}

	public class FormworkDBContext: DbContext
	{
		public DbSet<Formwork> Formworks { get; set; }
	}
}