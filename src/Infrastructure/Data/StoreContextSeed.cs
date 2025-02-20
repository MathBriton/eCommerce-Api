using System.Reflection;
using System.Text.Json;
using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data;

public class StoreContextSeed
{
  public static async Task SeedAsync(
    StoreContext context,
    UserManager<AppUser> userManager)
  {

    // Adding Roles and Admin
    if (!userManager.Users.Any(x => x.UserName == "admin@test.com"))
    {
      var user = new AppUser
      {
        FirstName = "Admin",
        LastName = "Admin",
        UserName = "admin@test.com",
        Email = "admin@test.com",
      };

      await userManager.CreateAsync(user, "Pa$$w0rd");
      await userManager.AddToRoleAsync(user, "Admin");
    }

    // Adding Roles and Customer Test
    if (!userManager.Users.Any(x => x.UserName == "johndoe@test.com"))
    {
      var userCustomer = new AppUser
      {
        FirstName = "John",
        LastName = "Doe",
        Email = "johndoe@test.com",
        UserName = "johndoe@test.com"
      };

      await userManager.CreateAsync(userCustomer, "Pa$$w0rd");
      await userManager.AddToRoleAsync(userCustomer, "Customer");
    }

    // See if we are on production or development
    var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    if (!context.Products.Any())
    {
      // var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/products.json");
      var productsData = await File.ReadAllTextAsync(path + @"/Data/SeedData/products.json");
      var products = JsonSerializer.Deserialize<List<Product>>(productsData);

      if (products == null) return;

      context.Products.AddRange(products);

      await context.SaveChangesAsync();
    }

    if (!context.DeliveryMethods.Any())
    {
      var dmData = await File.ReadAllTextAsync(path + "/Data/SeedData/delivery.json");
      var methods = JsonSerializer.Deserialize<List<DeliveryMethod>>(dmData);

      if (methods == null) return;

      context.DeliveryMethods.AddRange(methods);

      await context.SaveChangesAsync();
    }
  }
}