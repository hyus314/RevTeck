using Microsoft.AspNetCore.Mvc;
using Moq;
using RevTech.App.Controllers;
using RevTech.Core.Contracts;
using RevTech.Data.ViewModels.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Web.Tests
{
    public class PartsControllerTests
    {
        private PartsController controller;
        private Mock<IPerformancePartService> mockService;

        public PartsControllerTests()
        {
            this.mockService = new Mock<IPerformancePartService>();

            this.controller = new PartsController(this.mockService.Object);
        }

        [Fact]
        public async Task Action_ReturnsCollectionOfPartModels()
        {
            this.mockService
                .Setup(service => service.GetTCUTuningsAsync())
                .ReturnsAsync(new List<TCUTuningViewModel>());

            var result = await controller.LoadTcuTunings() as JsonResult;

            var jsonResult = Assert.IsType<JsonResult>(result);
            var returnValue = Assert.IsType<List<TCUTuningViewModel>>(jsonResult.Value);
            Assert.NotNull(returnValue);
        }
    }
}
