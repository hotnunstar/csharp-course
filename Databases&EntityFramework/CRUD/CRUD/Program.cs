using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Program
    {
        static void Main()
        {
            using (var context = new AppDbContext())
            {
                context.Database.Migrate();
            }

            using (var context = new AppDbContext())
            {
                var newItem1 = new Item { Name = "Pecan Pie" };
                var newItem2 = new Item { Name = "Apple Pie" };
                var newItem3 = new Item { Name = "Pumpkin Pie" };

                context.Items.AddRange(newItem1, newItem2, newItem3);
                context.SaveChanges();

                var allItems = context.Items.ToList();
                Console.WriteLine("All Items:");
                foreach (var item in allItems)
                {
                    Console.WriteLine($"{item.Id} - {item.Name}");
                }

                var itemToUpdate = context.Items.FirstOrDefault(item => item.Id == newItem1.Id);
                if (itemToUpdate != null) itemToUpdate.Name = "Updated Item 1";

                var itemToDelete = context.Items.FirstOrDefault(item => item.Id == newItem2.Id);
                if (itemToDelete != null) context.Items.Remove(itemToDelete);

                context.SaveChanges();
            }
        }
    }
}
