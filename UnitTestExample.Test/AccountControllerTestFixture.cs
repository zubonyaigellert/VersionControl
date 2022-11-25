﻿using Moq;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Abstractions;
using UnitTestExample.Controllers;
using UnitTestExample.Entities;
using UnitTestExample.Test;

namespace UnitTestExample.Test
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
            var accountController = new AccountController();
            var actualResult = accountController.ValidateEmail(email);
            Assert.AreEqual(expectedResult, actualResult);
        }
            [Test,
            TestCase("asdfASDF",false),
            TestCase("ASDF1234", false),
            TestCase("asdf1234", false),
            TestCase("asd123", false), 
            TestCase("Asdf1234", true),
            ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualResult = accountController.ValidatePassword(password);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [
        Test,
        TestCase("irf@uni-corvinus.hu", "Asdf1234"),
        TestCase("irf@uni-corvinus.hu", "Asdfgh123456"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Returns<Account>(a => a);
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;
            var actualResult = accountController.Register(email, password);
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
            accountServiceMock.Verify(m => m.CreateAccount(actualResult), Times.Once);
        }
        [
        Test,
        TestCase("irf@uni-corvinus", "Asdf1234"),
        TestCase("irf.uni-corvinus.hu", "Asdf1234"),
        TestCase("irf@uni-corvinus.hu", "asdf1234"),
        TestCase("irf@uni-corvinus.hu", "ASDF1234"),
        TestCase("irf@uni-corvinus.hu", "asdfASDF"),
        TestCase("irf@uni-corvinus.hu", "As1234"),
        ]
        public void TestRegisterValidateException(string email, string password)
        {
            var accountController = new AccountController();
            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }
        }
        [
        Test,
        TestCase("irf@uni-corvinus.hu", "Abcd1234")
        ]
        public void TestRegisterApplicationException(string newEmail, string newPassword)
        {
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Throws<ApplicationException>();
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;
            try
            {
                var actualResult = accountController.Register(newEmail, newPassword);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ApplicationException>(ex);
            }
        }
    }
}
