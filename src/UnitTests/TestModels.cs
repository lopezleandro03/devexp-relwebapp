using Relecloud.Web.Models.ConcertContext;
namespace UnitTests;


[TestClass]
public class TestModels
{
    [TestMethod]
    public void CreateUser()
    {
        var user = new User();
        user.DisplayName = "Test";
        Assert.IsNotNull(user);
        Assert.IsTrue(user.DisplayName.Equals("Test"));
    }

    [TestMethod]
    public void CreateCustomer()
    {
        var customer = new Customer
        {
            Email = "test@xyz.com",
            Name = "Test",
            Phone = "12345"
        };

        Assert.IsNotNull(customer.Id);
        
    }


}
    



    

