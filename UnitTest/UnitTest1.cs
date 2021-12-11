using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DeveloperRepo;
using DevTeamRepo;

namespace UnitTest
{
    [TestClass]
    public class KomodoInsuranceTests
    {
        [TestMethod]

        public void CreateNewDev_ReturnTrue()
        {
            //Arrange
            Developers developer = new Developers();
            KomodoRepo komodoRepo = new KomodoRepo();

            developer.IDNum = 0;

            //Act
            bool devCreated = komodoRepo.CreateDeveloper(developer);




            //Assert
            Assert.IsTrue(devCreated);
        }

    }
}
