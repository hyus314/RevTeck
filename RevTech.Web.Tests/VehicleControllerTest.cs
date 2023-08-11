using Microsoft.AspNetCore.Mvc;
using Moq;
using RevTech.App.Controllers;
using RevTech.Core.Contracts;
using RevTech.Data.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Web.Tests
{
    public class VehicleControllerTest
    {
        private VehicleController controller;
        private Mock<IVehicleService> mockService;

        public VehicleControllerTest()
        {
            this.mockService = new Mock<IVehicleService>();
            this.controller = new VehicleController(this.mockService.Object);
        }

        [Fact]
        public async Task Action_ShouldReturnAColletionOfCarModels()
        {
            this.mockService
                .Setup(service => service.GetAllCarModelsAsync())
                .ReturnsAsync(new List<CarModelViewModel>());

            var result = await controller.GetAllCarModels() as JsonResult;

            var jsonResult = Assert.IsType<JsonResult>(result);
            var returnValue = Assert.IsType<List<CarModelViewModel>>(jsonResult.Value);

            Assert.NotNull(returnValue);
        }
    }


}
