using NUnit.Framework;
using CSLearning;

namespace UnitTests
{
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert            
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {                
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // Act
            string actual = customer.FullName;

            // Assert            
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {                
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert            
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void StaticTest()
        {
            //-- Arrange
            var customer = new Customer();
            customer.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer.FirstName = "Rosie";
            Customer.InstanceCount += 1;
            //-- Act
            
            //-- Assert            
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}