using CloudCityCenter.Controllers;
using CloudCityCenter.Data;
using CloudCityCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace CloudCityCenter.Tests;

public class HomeControllerTests
{
    [Fact]
    public async Task Index_ReturnsViewResult_WithServers()
    {
        var root = new InMemoryDatabaseRoot();
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("Home_Index_ReturnsViewResult_WithServers", root)
            .Options;
        await using var context = new ApplicationDbContext(options);
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
        context.Servers.Add(new Server
        {
            Id = 1,
            Name = "S1",
            Location = "US",
            PricePerMonth = 10,
            Configuration = "C",
            IsAvailable = true,
            ImageUrl = "img"
        });
        await context.SaveChangesAsync();
        var controller = new HomeController(NullLogger<HomeController>.Instance, context);

        var result = await controller.Index();

        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<List<Server>>(viewResult.Model);
        Assert.Single(model);
    }
}

