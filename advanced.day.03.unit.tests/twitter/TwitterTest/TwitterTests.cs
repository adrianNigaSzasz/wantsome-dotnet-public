using System;
using Xunit;
using Moq;
using _6.Twitter.Interfaces;

namespace TwitterTests
{
	public class TwitterTests
	{
		[Fact]
		public void ReceiveMessageShouldInvokeItsClientToWriteTheMessage()
		{
			var clientMock = new Mock<IClient>();


			var testedClass = new _6.Twitter.Models.Tweet(clientMock.Object);
			testedClass.ReceiveMessage("test");

			clientMock.Verify(c => c.SendTweetToServer("test"), Times.Once);

		}

		[Fact]
		public void ReceiveMessageShouldInvokeItsClientToSendTheMessageToTheServer()
		{
			var clientMock = new Mock<IClient>();


			var testedClass = new _6.Twitter.Models.Tweet(clientMock.Object);
			testedClass.ReceiveMessage("test");

			clientMock.Verify(c => c.SendTweetToServer("test"), Times.Once);

		}
	}
}
