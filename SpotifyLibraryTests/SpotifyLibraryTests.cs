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
        private SpotifyLibrary us = null;

        [TestInitialize]
        public void BeforeEachTestMethod()
        {
            us = new SpotifyLibrary();

        }

        /*
         * Testing property songId
         */

        [TestMethod]
        [DataRow("123")]
        [DataRow("1234567890")]
        public void Test_SongID_Accept(string songId);








    }
}