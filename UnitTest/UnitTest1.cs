using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using ProjetCSharp.Controllers;
using ProjetCSharp.Models;
using ProjetCSharp.Core;
using ProjetCSharp.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_returns_view()
        {
            var repository = new Mock<IMovieRepository>();
            
            //Arrage
            var controller = new HomeController(repository.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void VerifyListMovieCount()
        {
            var repository = new Mock<IMovieRepository>();
            repository.Setup(x => x.ListMovies()).Returns(new List<Movies>{
                new Movies()
            });
            var controller = new HomeController(repository.Object);
            var result = Assert.IsType<ViewResult>(controller.Index());
            var model = Assert.IsType<List<Movies>>(result.Model);

            Assert.Equal(1,model.Count());
        }

        [Fact]
        public void VerifyValidReturnsMovie()
        {
            Guid x2 = new Guid("85fa8e07-8fa2-44ed-a0f4-27477b3b7622");
            var repository = new Mock<IMovieRepository>();
            repository.Setup(x => x.GetMoviesById(new Guid("85fa8e07-8fa2-44ed-a0f4-27477b3b7622"))).Returns(new Movies{
                id= x2, name = "Star Wars", description = "Pew-Pew",status = Status.Enabled
            });
            var controller = new HomeController(repository.Object);
            var result = Assert.IsType<ViewResult>(controller.Details(x2));
            var model = Assert.IsType<Movies>(result.Model);

            Assert.Equal("Star Wars", model.name);
        }


        [Fact]
        public void VerifyNotValidId()
        {
            Guid x2 = new Guid("85fa8e07-8fa2-44ed-a0f4-27477b3b7634");
            var repository = new Mock<IMovieRepository>();
            repository.Setup(x => x.GetMoviesById(new Guid("85fa8e07-8fa2-44ed-a0f4-27477b3b7634"))).Returns((Movies)null);          
            var controller = new HomeController(repository.Object);
            var result = Assert.IsType<ViewResult>(controller.Details(x2));
            var model = Assert.IsType<Movies>(result.Model);

            Assert.Null(result.Model);
        }
    }
}
