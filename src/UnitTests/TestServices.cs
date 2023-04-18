using Relecloud.Web.Api.Services;
using Relecloud.Web.Api.Services.MockServices;
using Relecloud.Web.Models.ConcertContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

[TestClass]
public class TestServices
{
    private static IConcertRepository s_repo = new MockConcertRepository();

    [TestMethod]
    public async Task GetConcertById()
    {
        

        var concert = new Concert
        {
            Id = 1,
            Artist = "Test Artist",
            Genre = "Test Genre",
            Location = "Test Location",
            Title = "Test Title",
            Description = "Test Description",
            Price = 10.00,
            StartTime = DateTimeOffset.UtcNow.AddDays(30)
        };
       
        await s_repo.CreateConcertAsync(concert);

        var result = await s_repo.GetConcertByIdAsync(1);

        Assert.IsTrue(result.Equals(concert));
        Assert.IsTrue(false);
    }
}
