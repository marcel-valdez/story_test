using NUnit.Framework;

namespace StoryTest.Test
{
    [TestFixture]
    public class AcceptanceTest
    {
        [Test]
        public void TestIfItCanDefineAStory()
        {
            // Arrange
            var begin = Story.Target(new SomeTarget());

            begin.Act(story => {
                story.Actor.Number = 0;

                Assert.That(story.Actor.Number, Is.EqualTo(0));

                Next.Act(() => {
                    story.Actor.PlusOne();

                    Assert.That(story.Actor.Number, Is.EqualTo(1));

                    Next.Act(() => {
                        story.Actor.MinusOne();

                        Assert.That(story.Actor.Number, Is.EqualTo(0));
                    });
                });
            });
        }

        [TestAttribute]
        [ExpectedException]
        public void TestIfItCanFailAStory()
        {
            // Arrange
            var begin = Story.Target(new SomeTarget());

            begin.Act(story => {
                story.Actor.Number = 0;

                Assert.That(story.Actor.Number, Is.EqualTo(1));
            });
        }
    }
}