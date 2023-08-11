using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using RevTech.App.Controllers;
using RevTech.Core.Contracts;
using RevTech.Data.User;
using RevTech.Data.ViewModels.Admin.Vehicle;
using System.Data;

namespace RevTech.Web.Tests
{
    public class AdminControllerTest
    {
        private AdminController controller;
        private Mock<IAdminService> mockAdminService;
        private Mock<UserManager<RevTeckUser>> mockUserManager;
        public AdminControllerTest()
        {
            this.mockAdminService = new Mock<IAdminService>();
            var mockUserManager = new Mock<UserManager<RevTeckUser>>(
     Mock.Of<IUserStore<RevTeckUser>>(),
     null,
     null,
     null,
     null,
     null,
     null,
     null,
     null
 );


            this.controller = new AdminController(mockAdminService.Object, mockUserManager.Object);
        }

        [Fact]
        public async Task ActionReturns_ACollectionOfVehicles()
        {
            this.mockAdminService
                .Setup(service => service.GenerateAllViewModelsAsync())
                .ReturnsAsync(new List<AllManufacturerViewModel>());

            var result = await controller.AllVehicles() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal(typeof(List<AllManufacturerViewModel>), result.Model.GetType());
        }
    }
}

