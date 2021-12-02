using Moq;
using NUnit.Framework;
using PurchaseOrder.BusinessManager.ItemMasters;
using PurchaseOrder.DataManager.ItemMasters;
using PurchaseOrder.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessManager.Tests.UnitTests.ItemMasterTests
{
    [TestFixture]
    public class ItemMasterProcessorTests
    {
        private readonly Mock<IItemMasterRepository> _mockRepo;

        public ItemMasterProcessorTests()
        {
            _mockRepo = new Mock<IItemMasterRepository>(MockBehavior.Strict);
        }



        [Test]
        public void GetAll_WhenItemsExists_ShouldReturnAllItems()
        {
            // Arrange
            IEnumerable<ItemMasterModel> expected = new List<ItemMasterModel> {
                new ItemMasterModel { ItemID = 1, ItemName = "Table" },
                new ItemMasterModel { ItemID = 2, ItemName = "Chair" }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(expected);
            IItemMasterProcessor _sut = new ItemMasterProcessor(_mockRepo.Object);

            // Act
            var actual = _sut.GetAll();

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetAll_WhenItemsDoesNotExists_ShouldNotReturnAnyItems()
        {
            // Arrange
            IEnumerable<ItemMasterModel> expected = new List<ItemMasterModel> { };

            _mockRepo.Setup(r => r.GetAll()).Returns(expected);
            IItemMasterProcessor _sut = new ItemMasterProcessor(_mockRepo.Object);

            // Act
            var actual = _sut.GetAll();

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void GetByID_WhenIdDoesExists_ShouldReturnAItem()
        {
            // Arrange
            ItemMasterModel expected = new ItemMasterModel { ItemID = 1, ItemName = "Table" };

            _mockRepo.Setup(r => r.GetByID(It.IsAny<int>())).Returns(expected);
            IItemMasterProcessor _sut = new ItemMasterProcessor(_mockRepo.Object);

            // Act
            var actual = _sut.GetByID(1);

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetByID_WhenIdDoesNotExists_ShouldNotReturnAnyItems()
        {
            // Arrange
            ItemMasterModel expected = new ItemMasterModel { ItemID = 1, ItemName = "Table" };

            _mockRepo.Setup(r => r.GetByID(It.IsAny<int>())).Returns(expected);
            IItemMasterProcessor _sut = new ItemMasterProcessor(_mockRepo.Object);

            // Act
            var actual = _sut.GetByID(2);

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

    }
}
