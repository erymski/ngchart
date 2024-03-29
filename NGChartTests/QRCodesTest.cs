// Copyright (c) 2008, Eugene Rymski
// All rights reserved.
// Redistribution and use in source and binary forms, with or without modification, are permitted 
//  provided that the following conditions are met:
// * Redistributions of source code must retain the above copyright notice, this list of conditions 
//   and the following disclaimer.
// * Redistributions in binary form must reproduce the above copyright notice, this list of conditions 
//   and the following disclaimer in the documentation and/or other materials provided with the distribution.
// * Neither the name of the "NGChart" nor the names of its contributors may be used to endorse or 
//   promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED 
// WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE REGENTS AND CONTRIBUTORS BE LIABLE FOR ANY 
// DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED 
// TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE.

using NGChart;
using NGChart.QR;
using NUnit.Framework;

namespace NGChartTests
{
    [TestFixture]
    public class QRCodesTest
    {
        [Test]
        public void GoogleExampleTest()
        {
            QRCodes codes = new QRCodes(new ChartSize(150, 150), "hello world", EncodingType.UTF8);
            string result = codes.ToString();

            Assert.IsTrue(result.Contains("cht=qr"));
            Assert.IsTrue(result.Contains("chl=hello%20world"));
            Assert.IsFalse(result.Contains("choe=UTF-8"), "Default encoding should not be added");


            QRCodes codes2 = new QRCodes(new ChartSize(150, 150), "hello world 2", EncodingType.ISO_8859_1, ErrorCorrectionLevel.M, 8);
            string result2 = codes2.ToString();

            Assert.IsTrue(result2.Contains("cht=qr"));
            Assert.IsTrue(result2.Contains("chl=hello%20world%202"));
            Assert.IsTrue(result2.Contains("choe=ISO-8859-1"));
            Assert.IsTrue(result2.Contains("chld=M|8"));
        }

        [Test]
        public void EncodingTypeTests()
        {
            Assert.AreEqual("Shift_JIS", EncodingTypeParam.ConvertEncodingType(EncodingType.Shift_JIS));
            Assert.AreEqual("UTF-8", EncodingTypeParam.ConvertEncodingType(EncodingType.UTF8));
            Assert.AreEqual("ISO-8859-1", EncodingTypeParam.ConvertEncodingType(EncodingType.ISO_8859_1));
        }

        [Test]
        public void QROptionsTest()
        {
            QROptions options = new QROptions(ErrorCorrectionLevel.Q, 5);
            string result = options.ToString();

            Assert.AreEqual("chld=Q|5", result);

            QROptions minMargin = new QROptions(ErrorCorrectionLevel.H, 2);
            Assert.AreEqual("H|4", minMargin.Data, "Margin should not be less than minimal possible value");
        }
    }
}
