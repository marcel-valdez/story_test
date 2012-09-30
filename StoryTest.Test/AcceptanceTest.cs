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
            var begin = Story.With(actor: new SomeClass());

            begin.Act(actor => {
                actor.Number = 0;

                Assert.That(actor.Number, Is.EqualTo(0));

                Next.Act(() => {
                    actor.PlusOne();

                    Assert.That(actor.Number, Is.EqualTo(1));

                    Next.Act(() => {
                        actor.MinusOne();

                        Assert.That(actor.Number, Is.EqualTo(0));
                    });
                });
            });
        }

        [TestAttribute]
        [ExpectedException]
        public void TestIfItCanFailAStory()
        {
            // Arrange
            var begin = Story.With(new SomeClass());

            begin.Act(actor => {
                actor.Number = 0;

                Assert.That(actor.Number, Is.EqualTo(1));
            });
        }
    }
}