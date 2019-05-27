using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BarbisanBruegger.Models
{
	public class Order
	{
		public int Id { get; set; }

		public int FormworkId { get; set; }

		[ForeignKey("FormworkId")]
		public Formwork Formwork { get; set; }



		public int Quantity { get; set; }
	}

	public class OrderDBContext : DbContext
	{
		public DbSet<Order> Orders { get; set; }
	}
}