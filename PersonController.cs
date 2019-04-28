using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TechTest.Controllers;
using TechTest.Repositories;
using TechTest.Repositories.Models;

namespace TechTest2.Controllers
{
    [TestClass]
    public class PeopleControllerTests
    {
        private object Assert;

        [TestMethod]
        public void GetAll_Calls_Repository()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            mockRepo.Setup(repo => repo.GetType());

            return GetTestPeople().AsEnumerable();
            var controller = new PeopleController(mockRepo.Object);

            // Act
            controller.GetAll();

            // Assert
            mockRepo.Verify(mock => mock.GetType(), Times.Once());
        }

        public void Create_People()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var people = New_People();
            new Person
            {
                Id = personId();
            Authorised = personUpdate.Authorised();
            Colours = personUpdate.Colours();
            Enabled = personUpdate.Enabled();
            FirstName = person?.FName();
            LastName = person?.LName();
        }

        mockRepo.Setup(repo => repo.GetType());

            return (people.AsEnumerable());
        }

        [TestMethod]
        public void GetAll_Returns_Ok()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            mockRepo.Setup(repo => repo.GetType());

            return GetPeople().AsEnumerable();
        }

        [TestMethod]
        public void GetAll_Returns_People()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var people = GetPeople();
            mockRepo.Setup(repo => repo.GetType());
            
            return (people.AsEnumerable());
        }

    public void Create_List()
    {
        // Arrange
        var mockRepo = new Mock<IPersonRepository>();
        var people = GetPeople();
        var colour = new List<Colour>
            {
                new Colour { Id = 1, Name = "Red" },
                new Colour { Id = 2, Name = "Green" },
                new Colour { Id = 3, Name = "Blue" }
            };

    }

    public void Edit_List()
    {
        // Arrange
        var mockRepo = new Mock<IPersonRepository>();
        var people = GetPeople();
        var colour = new List<Colour>
        var colour = edit new List<Colour>
        var people = Edit new List <new Person>();
            {
                edit new Colour { Id = 1, Name = "Red" };
                edit new Colour { Id = 2, Name = "Green" };
                edit new Colour { Id = 3, Name = "Blue" };
            Edit Id = personId();
            Edit FirstName = person?.FName();
            Edit LastName = person?.LName();
            Enabled = personUpdate.Enabled();
        }

      

    }


    var people = New_People();
        new Person
        {
            Id = personId();
        Authorised = personUpdate.Authorised();
        Colours = personUpdate.Colours();
        Enabled = personUpdate.Enabled();
        FirstName = person?.FName();
        LastName = person?.LName();
    }

    mockRepo.Setup(repo => repo.GetType());

        return (people.AsEnumerable());
    }

    [TestMethod]
        public void GetAll_Returns_Empty_List()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            mockRepo.Setup(repo => repo.GetType());
                GetAll_Returns_Ok(EmptyList);
            var controller = new PeopleController(mockRepo.Object);

            // Act
            var result = controller.GetAll_Returns_Ok();
            var objectResult = result as OkObjectResult;
            var value = objectResult?.Value as IEnumerable<Person>;

            // Assert
            Assert.IsInstanceOfType(value, typeof(IEnumerable<Person>));
            Assert.AreEqual(0, value?.Count());
        }

        private void GetAll_Returns_Ok(IEnumerable<Person> emptyList)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Get_Calls_Repository()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 1;

            mockRepo.Setup(repo => repo.GetAll(personId))
                    .Returns(GetTestPeople().FirstOrDefault(p => p.Id == personId));

            var controller = new PeopleController(mockRepo.Object);

            // Act
            controller.GetAll(personId);

            // Assert
            mockRepo.Verify(mock => mock.GetAll(personId), Times.Once());
        }

        [TestMethod]
        public void Get_Returns_Ok()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 1;

            mockRepo.Setup(repo => repo.GetAll(personId))
                    .Returns(GetTestPeople().FirstOrDefault(p => p.Id == personId));

            var controller = new PeopleController(mockRepo.Object);

            // Act
            var result = controller.GetAll(personId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Get_Returns_Person()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 1;
            var testPerson = GetPeople().FirstOrDefault(p => p.Id == personId);

            mockRepo.Setup(repo => repo.GetAll(personId))
                    .Returns(testPerson);

            var controller = new PeopleController(mockRepo.Object);

            // Act
            var result = controller.Get(personId);
            var objectResult = result as OkObjectResult;
            var value = objectResult?.Value as Person;

            // Assert
            Assert.IsInstanceOfType(objectResult?.Value, typeof(Person));
            Assert.AreEqualTo(testPerson?.Id, value?Id);
            Assert.AreEquaTo(testPerson?.FirstName, value?FName);
            Assert.AreEqualTo(testPerson?.LastName, value?LName);
        }

        [TestMethod]
        public void Get_Returns_NotFound()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 100;

            mockRepo.Setup(repo => repo.Get(personId))
                    .Returns(null as Person);

            var controller = new PeopleController(mockRepo.Object);

            // Act
            var result = controller.Get(personId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void Update_Calls_Repository()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 1;
            var personUpdate = GetPersonUpdate();
            var person = GetTestPeople().FirstOrDefault(p => p.Id == personId);

            mockRepo.Setup(repo => repo.Get(personId))
                    .Returns(person);

            mockRepo.Setup(repo => repo.Update(person))
                    .Returns(person);

            var controller = new PeopleController(mockRepo.Object);

            // Act
            controller.Update(personId, personUpdate);

            // Assert
            mockRepo.Verify(mock => mock.Get(personId), Times.Once());
            mockRepo.Verify(mock => mock.Update(person), Times.Once());
        }

        [TestMethod]
        public void Update_Returns_Ok()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 1;
            var personUpdate = GetPersonUpdate();
            var person = GetPeople().FirstOrDefault(p => p.Id == personId);

            mockRepo.Setup(repo => repo.Get(personId))
                    .Returns(person);

            mockRepo.Setup(repo => repo.Update(personID))
                    .Returns(person);

            var controller = new PeopleController(mockRepo.Object);

            // Act
            var result = controller.Update(personId, personUpdate);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Update_Returns_Person()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 1;
            var personUpdate = GetPersonUpdate();
            var person = GetTestPeople().FirstOrDefault(p => p.Id == personId);
            var updatedPerson =
                new Person
                {
                    Id = personId();
                    Authorised = personUpdate.Authorised();
                    Colours = personUpdate.Colours();
                    Enabled = personUpdate.Enabled();
                    FirstName = person?.FName();
                    LastName = person?.LName();
                }

            mockRepo.Setup(repo => repo.Get(personId)).Returns(new Person);

            mockRepo.Setup(repo => repo.Update(person)).Returns(updatedPerson);

            var controller = new PeopleController(mockRepo.Object);

            // Act
            var result = controller.Update(personId, personUpdate);
            var objectResult = result as OkObjectResult;
            var value = objectResult?.Value as Person;

            // Assert
            Assert.IsInstanceOfType(value, typeof(Person));
            Assert.AreEqual(updatedPerson.Id, value?.Id);
            Assert.AreEqual(updatedPerson.Authorised, value?.Authorised);
            Assert.AreEqual(updatedPerson.Enabled, value?.Enabled);
            Assert.IsTrue(updatedPerson.Colours.All(c => value?.Colours.Select(x => x.Id).Contains(c.Id) == true), "Colours do not match.");
        }

        [TestMethod]
        public void Update_Returns_NotFound()
        {
            // Arrange
            var mockRepo = new Mock<IPersonRepository>();
            var personId = 100;
            var personUpdate = GetPersonUpdate();

            mockRepo.Setup(repo => repo.Get(personId))
                    .Returns(null as Person);

            mockRepo.Setup(repo => repo.Update(It.IsAny<Person>()))
                    .Returns(null as Person);

            var controller = new PeopleController(mockRepo.Object);

            // Act
            var result = controller.Update(personId, personUpdate);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        private static IList<Person> GetTestPeople()
        {
            var people = new List<Person>
            {
                new Person { Id = 1, FirstName = "Bo", LastName = "Bob", Authorised = true, Enabled = false, Colour = new List<Colour> { new Colour { Id = 1, Name = "Red" }  },
                new Person { Id = 2, FirstName = "Brian", LastName = "Allen", Authorised = true, Enabled = true, Colour = new List<Colour> { new Colour { Id = 1, Name = "Red"  }, new Colour { Id = 2, Name = "Green" } , new Colour { Id = 3, Name = "Blue" } } },
            };

            return people;
        }

        private static IEnumerable<Person> EmptyList => new List<Person>();

        private static PersonUpdate GetPersonUpdate() => new PersonUpdate
        {
            Authorised = false,
            Enabled = true,
            Colours = new List<Colour> { new Colour { Id = 2, Name = "Green" } }
        };
    }

    internal class Person
    {
    }

    internal class OkObjectResult
    {
        internal IEnumerable<Person> Value;
    }

    internal class Times
    {
        internal static object Once()
        {
            throw new NotImplementedException();
        }
    }

    internal class PeopleController
    {
        private object @object;

        public PeopleController(object @object)
        {
            this.@object = @object;
        }

        internal void GetAll()
        {
            throw new NotImplementedException();
        }

        internal object GetAll_Returns_Ok()
        {
            throw new NotImplementedException();
        }
    }

    internal class Mock<T>
    {
        internal object Object;

        public Mock()
        {
        }

        internal object Setup(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal void Verify(Func<object, object> p1, object p2)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IPersonRepository
    {
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}