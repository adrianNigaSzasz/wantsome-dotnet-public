using System;
using Xunit;
using Moq;
using _6.Twitter.Interfaces;

namespace TwitterTest
{
	public class MicrowaveOvenTests
	{
		[Fact]
		public void SendTweetToServerShouldSendTheMessageToItsServer()
		{
			var writerMock = new Mock<IWriter>();

			var repomock = new Mock<ITweetRepository>();



			var testedClass = new _6.Twitter.Models.MicrowaveOven(writerMock.Object, repomock.Object);

			testedClass.SendTweetToServer("test");

			repomock.Verify(r => r.SaveTweet("test2"), Times.Once);



		}

		[Fact]
		public void WriteTweetShouldCallItsWriterWithTheTweetsMessage()
		{
			var writerMock = new Mock<IWriter>();

			var repomock = new Mock<ITweetRepository>();


			var testedClass = new _6.Twitter.Models.MicrowaveOven(writerMock.Object, repomock.Object);

			testedClass.WriteTweet("test");

			writerMock.Verify(r => r.WriteLine("test"), Times.Once);

		}
	}
}
