﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mvc.RoleAuthorization.Models;

namespace Mvc.RoleAuthorization.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{

		}
		public DbSet<RoleMenuPermission> RoleMenuPermission { get; set; }

		public DbSet<NavigationMenu> NavigationMenu { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<RoleMenuPermission>()
			.HasKey(c => new { c.RoleId, c.NavigationMenuId});
			

			base.OnModelCreating(builder);
		}

		public DbSet<User> User { get; set; }

		public DbSet<Role> Role { get; set; }
	}
}