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
        * Testing property songTitel - at least 3 chars
        */

        // acceptable values 3 chars and 4 chars
        [TestMethod]
        [DataRow("123")]
        [DataRow("1234")]
        public void Test_SongTitel_Accept(String songtitel)
        {
            // Arrange
            String expectedValue = songtitel;

            // Act
            sp.SongTitle = songtitel;
            String actualValue = songtitel;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        [DataRow("1")]
        public void Test_Songtitel_NotAccept1(String songtitel)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentException>(() => sp.SongTitle = songtitel);

        }

        // Error values null and 10 spaces -> empty 
        [TestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void Test_SongTitel_Not_Accept2(String songtitel)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => sp.SongTitle = songtitel);

        }

        /*
         *
         * Testing property genre 10 char. long
         *
         * testing 
         */

        [TestMethod]
        [DataRow("1234567891")]
        [DataRow("1234")]
        public void Test_Genre_Accept(String genre)
        {
            // Arrange
            String expectedValue = genre;

            // Act
            sp.SongTitle = genre;
            String actualValue = genre;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }


        [TestMethod]
        [DataRow("1")]
        public void Test_Genre_Not_Accept1(String genre)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentException>(() => sp.Genre = genre);

        }

        // Error values null and 10 spaces -> empty 
        [TestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void Test_Artist_Not_Accept2(String genre)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => sp.Genre = genre);

        }


        /*
         * Testing property artist
         */

        [TestMethod]
        [DataRow("1234567891")]
        [DataRow("1234")]
        public void Test_Artist_Accept(String artist)
        {
            // Arrange
            String expectedValue = artist;

            // Act
            sp.SongTitle = artist;
            String actualValue = artist;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        [DataRow("1")]
        public void Test_Artist_Not_Accept1(String artist)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentException>(() => sp.Artist = artist);

        }

        // Error values null and 10 spaces -> empty 
        [TestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void Test_genre_Not_Accept2(String genre)
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => sp.Genre = genre);

        }

        /*
         * Testing property imsges
         */

        [TestMethod]
        [DataRow("1234567891")]
        [DataRow("1234")]
        public void Test_images_Accept(String images)
        {
            // Arrange
            String expectedValue = images;

            // Act
            sp.SongTitle = images;
            String actualValue = images;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        // Error values null and 10 spaces -> empty 
        [TestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void Test_Images_Not_Accept2(String images )
        {
            // Arrange - all in assert

            // Act - all in assert

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => sp.Images = images);

        }










    }
}














