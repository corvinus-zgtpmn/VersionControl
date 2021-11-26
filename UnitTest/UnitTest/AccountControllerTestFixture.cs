using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTest
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        public bool ValidatePassword(string password)
        {
            var kisbetu = new Regex(@"[a-z]+");
            var nagybetu = new Regex(@"[A-Z]+");
            var szam = new Regex(@"[0-9]+");
            var eleghosszu = new Regex(@".{8,}");
            return kisbetu.IsMatch(password) && nagybetu.IsMatch(password) && szam.IsMatch(password) && eleghosszu.IsMatch(password);

        }
    }
}
