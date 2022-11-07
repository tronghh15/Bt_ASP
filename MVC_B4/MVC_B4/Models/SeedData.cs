using MVC_B4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_B4.Controllers;

namespace MVC_B4.Models
{
    public class SeedData
    {
		public static void Initialize(ApplicationDbContext context)
		{
			context.Database.EnsureCreated();

			// Look for any data
			if (context.Product.Any())
			{
				return;   // DB has been seeded
			}

			var Products = new Product[]
			{
		new Product{Name="Giày đá bóng Adidas Ace 15.2 CG đen xanh",Manufacturer="Adidas",Price=1320000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="a1.jpg"},
		new Product{Name="Giày đá bóng Nike Magistax finale TF vàng",Manufacturer="Nike",Price=2020000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="n1.jpg"},
		new Product{Name="Giày đá bóng Adidas X 16.3 TF bạc",Manufacturer="Adidas",Price=2150000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="a2.jpg"},
		new Product{Name="Giày đá bóng Adidas X 16.3 TF đỏ",Manufacturer="Adidas",Price=2150000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="a3.jpg"},
		new Product{Name="Giày đá bóng Nike Hypervenomx Pro TF đen",Manufacturer="Nike",Price=2050000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="n2.jpg"},
		new Product{Name="Giày đá bóng Nike Magistax Onda II TF vàng",Manufacturer="Nike",Price=1850000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="n3.jpg"},
		new Product{Name="Giày thể thao Puma Ignite Sock W.T",Manufacturer="Puma",Price=1790000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="p1.jpg"},
		new Product{Name="Giày thể thao nam Puma Smash Suede V2",Manufacturer="Puma",Price=1590000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="p2.jpg"},
		new Product{Name="Giày nữ Nike Air Relentless 4 MSL hồng",Manufacturer="Nike",Price=1775000,Quantity=10,Desciption="Thiết kế thời trang. Chất liệu tốt.",Image="n4.jpg"}
			};

			context.Product.AddRange(Products);
			context.SaveChanges();
		}
	}
}
