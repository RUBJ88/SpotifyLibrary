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
         *  Set up spotifyLibrary class to be testet
         */
        private Spotify sp = null;

        [TestInitialize]
        public void BeforeEachTestMethod()
        {
            sp = new Spotify();

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

        // Error values -1 and -1000  
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-1000)]
        public void Test_SongId_Not_Accept(int songId)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentException>(() => sp.SongId = songId);
        }



        /*
         * Testing property song id - between 0-10
         */

        // acceptable values 0 and 5 and 10
        [TestMethod]
        [DataRow(0)]
        [DataRow(10)]
        public void Test_SongId_Value_Accept(int songId)
        {
            // Arrange
            int expectedValue = songId;

            // Act
            sp.SongId = songId;
            int actualValue = sp.SongId;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        // Error values -1 and 11  
        [TestMethod]
        [DataRow(-1)]
        [DataRow(11)]
        public void Test_SongId_Value_Not_Accept(int songid)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentException>(() => sp.SongId = songid );

        }

        /*
  * Testing property songTitel - at least 10 chars
  */

        // acceptable values 10 chars and 15 chars
        [TestMethod]
        [DataRow("1")]
        [DataRow("111111111111111111111111111111")]
        public void Test_Accept(String songtitel)
        {
            // Arrange
            String expectedValue = songtitel;

            // Act
            sp.SongTitle = songtitel;
            String actualValue = songtitel;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        // Error values 9 chars  
        [TestMethod]
        [DataRow("123456789")]
        public void Test_songtitel_NotAccept1(String songtitel)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentException>(() => sp.SongTitle = songtitel);

        }

        // Error values null and 10 spaces -> empty 
        [TestMethod]
        [DataRow(null)]
        [DataRow("          ")]
        public void Test_SongTitel_Not_Accept2(String songtitel)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => sp.SongTitle = songtitel);

        }














    }
}