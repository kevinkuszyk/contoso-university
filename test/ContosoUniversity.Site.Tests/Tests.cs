using FluentAssertions;
using NUnit.Framework;

namespace ContosoUniversity.Site.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Foo_should_be_true()
        {
            // Arrange
            var foo = true;

            // Assert
            foo.Should().BeTrue();
        }

        [Test]
        public void Bar_should_be_false()
        {
            // Arrange
            var bar = false;

            // Assert
            bar.Should().BeFalse();
        }
    }
}
