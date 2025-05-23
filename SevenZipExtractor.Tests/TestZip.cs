﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SevenZipExtractor.Tests
{
    [TestClass]
    public class TestZip : TestBase
    {
        [TestMethod]
        public void TestGuessAndExtractToStream_OK()
        {
            this.TestExtractToStream(Resources.TestFiles.zip, this.TestEntriesWithFolder);
        }

        [TestMethod]
        public void TestKnownFormatAndExtractToStream_OK()
        {
            this.TestExtractToStream(Resources.TestFiles.zip, this.TestEntriesWithFolder, SevenZipFormat.Zip);
        }

        [TestMethod]
        public void TestKnownFormatAndExtractToStream_WithPassword_OK()
        {
            this.TestExtractToStream(Resources.TestFiles.zip_hello, this.TestEntriesWithFolder, SevenZipFormat.Zip, "hello");
        }
    }
}