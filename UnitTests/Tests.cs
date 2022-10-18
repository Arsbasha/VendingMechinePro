using Moq;
using NUnit.Framework;
using Xunit.Sdk;
using Xunit.Extensions;
using Xunit.Abstractions;
using System.IO;
using System.Text;
using System;
using VendingMechinePro;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UnitTest
{
    public class Tests
    {
        StringBuilder _Output;
        Mock<TextReader> _reader;
        [SetUp]

        public void setup()
        {
            _Output = new StringBuilder();
            var consoleouput = new StringWriter(_Output);
            _reader = new Mock<TextReader>();
            Console.SetOut(consoleouput);
            Console.SetIn(_reader.Object);
        }
       
        private string[] RunMainMethod()
        {
            ProgramVending.Main(default);
            return _Output.ToString().Split("\r\n");
        }
        [Test]
        public void Entry_RunMainMethod()
        {
            SetupUserResponse("5");
            var text = "Enter your choose :";
            var ouput_line = RunMainMethod();
            Assert.AreEqual(text, ouput_line[0]);

        }

        public MockSequence SetupUserResponse(params string[] lines)
        {
            var sequence = new MockSequence();
            foreach (var response in lines)
                _reader.InSequence(sequence).Setup(x => x.ReadLine()).Returns(response);
            return sequence;
        }
      

    }
}