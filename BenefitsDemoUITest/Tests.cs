using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BenefitsDemoUITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void LabelTextIsDisplayed()
        {
            Assert.NotNull(app.Query(c => c.Marked("LblFindProvider")).FirstOrDefault());
            // Test the the element contains the proper value
            Assert.AreEqual("Find a Provider", app.Query(c => c.Marked("LblFindProvider")).First().Text);

            Assert.NotNull(app.Query(c => c.Marked("LblWellnessPortal")).FirstOrDefault());
            // Test the the element contains the proper value
            Assert.AreEqual("Wellness Portal", app.Query(c => c.Marked("LblWellnessPortal")).First().Text);

            Assert.NotNull(app.Query(c => c.Marked("LblClaimActivity")).FirstOrDefault());
            // Test the the element contains the proper value
            Assert.AreEqual("Claim Activity", app.Query(c => c.Marked("LblClaimActivity")).First().Text);

            Assert.NotNull(app.Query(c => c.Marked("LblBenefits")).FirstOrDefault());
            // Test the the element contains the proper value
            Assert.AreEqual("Benefits", app.Query(c => c.Marked("LblBenefits")).First().Text);

            Assert.NotNull(app.Query(c => c.Marked("LblIdCard")).FirstOrDefault());
            // Test the the element contains the proper value
            Assert.AreEqual("ID Card", app.Query(c => c.Marked("LblIdCard")).First().Text);

            Assert.NotNull(app.Query(c => c.Marked("LblContactUs")).FirstOrDefault());
            // Test the the element contains the proper value
            Assert.AreEqual("Contact Us", app.Query(c => c.Marked("LblContactUs")).First().Text);
        }
    }
}
