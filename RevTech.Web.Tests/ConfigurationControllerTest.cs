using Microsoft.AspNetCore.Mvc;
using Moq;
using RevTech.App.Controllers;
using RevTech.Core.Contracts;
using RevTech.Data.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Web.Tests
{
    public class ConfigurationControllerTest
    {
        private ConfigurationController controller;
        private Mock<IConfigurationService> mockService;
        
        public ConfigurationControllerTest()
        {
            this.mockService = new Mock<IConfigurationService>();

            this.controller = new ConfigurationController(this.mockService.Object);
        }

        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
