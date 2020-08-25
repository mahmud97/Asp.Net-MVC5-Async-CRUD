using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class ClientDBContext: DbContext
	{
		public ClientDBContext()
		   : base("DefaultConnection")
		{
		}

		public DbSet<Client> Clients { get; set; }
	}
}