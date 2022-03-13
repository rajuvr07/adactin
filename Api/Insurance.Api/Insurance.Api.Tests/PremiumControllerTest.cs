using Insurance.Api.Controllers;
using Insurance.Models;
using Insurance.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Threading;

namespace Insurance.Api.Tests
{
    public class PremiumControllerTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CalculateMonthlyPremiumOkResponse()
        {
            //Arrange
            var mockRepository = new Mock<IPremiumService>();
            var controller = new PremiumsController(mockRepository.Object);
            // Act
            var actionResult = controller.CalculateMonthlyPremium(new CustomerModel(), new CancellationToken());
            //Assert
            Assert.IsInstanceOf<OkObjectResult>(actionResult);

        }
    }
}
