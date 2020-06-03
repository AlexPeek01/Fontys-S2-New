﻿using Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class UserManagerTests
    {
        private FavoursUserManager usermanager;
        [TestInitialize]
        public void Initialize()
        {
            usermanager = new FavoursUserManager();
        }

        [TestMethod]
        public void GettingUserData_CorrectCredentials()
        {
            //Arrange
            string username = "Alex1";
            string password = "AlexWW1";

            //Act
            User testUser = usermanager.GetUserDataByUsername(username, password);

            //Assert
            Assert.AreEqual(testUser.UserId, "1");
        }
        [TestMethod]
        public void GettingUserData_IncorrectCredentials()
        {
            //Arrange
            string username = "Alex1";
            string password = "WrongPassword";

            //Act
            User testUser = usermanager.GetUserDataByUsername(username, password);

            //Assert
            Assert.AreEqual(testUser, null);
        }
        [TestMethod]
        public void GettingUserData_EmptyInput()
        {
            //Arrange
            string username = "";
            string password = "";

            //Act
            User testUser = usermanager.GetUserDataByUsername(username, password);

            //Assert
            Assert.AreEqual(testUser, null);
        }
        [TestMethod]
        public void GettingUserData_NullInput()
        {
            //Arrange
            string username = null;
            string password = null;

            //Act
            User testUser = usermanager.GetUserDataByUsername(username, password);

            //Assert
            Assert.AreEqual(testUser, null);
        }
    }
}
