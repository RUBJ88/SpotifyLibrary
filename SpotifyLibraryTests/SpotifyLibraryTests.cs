using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotifyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLibrary.Tests
{
    [TestClass()]
    public class SpotifyLibraryTests
    {
        /*
         *  Set up UserStory class to be testet
         */
        private SpotifyLibrary sp = null;

        [TestInitialize]
        public void BeforeEachTestMethod()
        {
            sp = new SpotifyLibrary();

        }

        /*
         * Testing property songId
         */

        [TestMethod]
        [DataRow(1)]
        public void Test_SongId_Accept(int songId)
        {
            // Arrange
            int expectedValue = songId;

            // Act
            sp.SongId = songId;
            int actualValue = sp.SongId;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }












    }
}