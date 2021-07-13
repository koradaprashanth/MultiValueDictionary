using Moq;
using MultiValueDictionary.BAL;
using NUnit.Framework;
using System.Collections.Generic;

namespace MultiValueDictionary.Unit_Testing
{
    [TestFixture]
    public class DictionaryAppTests
    {
        private Mock<IDictionaryApp> _mockDictionaryApp;
        private IBusiness _businessService;

        [SetUp]
        public void Setup()
        {
            _mockDictionaryApp = new Mock<IDictionaryApp>();            
            _businessService = new Business(_mockDictionaryApp.Object);
        }


        [TestCase]
        public void AddMember_ReturnsAdded()
        {
            _mockDictionaryApp.Setup(x => x.AddMember(It.IsAny<string>(), It.IsAny<string>())).Returns("Added");
            var result = _businessService.AddMember("foo","bar");
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "Added");
        }

        [TestCase]
        public void GetMembers_ReturnsMembersList()
        {
            _mockDictionaryApp.Setup(x => x.GetMembers(It.IsAny<string>())).Returns(new List<string> {"bar" });
            var result = _businessService.GetMembers("foo");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 1);
        }
    }

}
