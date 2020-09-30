using System.Threading.Tasks;
using MyEmployee.Models.TokenAuth;
using MyEmployee.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyEmployee.Web.Tests.Controllers
{
    public class HomeController_Tests: MyEmployeeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}