StoryTest
==========

A very simple API to define tests with stories, acts and actors in NUnit.  
  
I was fooling around and figured a tool like this would be fun to use.  

Sample Usage
============
````csharp
using NUnit.Framework;
using StoryTest;

namespace SomeNamespace.Test
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
    }
}
````