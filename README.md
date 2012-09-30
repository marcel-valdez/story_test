StoryTest
==========

A very simple API to define tests with stories, acts and actors in NUnit.  
  
I was fooling around and figured a tool like this would be fun to use.  

Sample Usage
============
````csharp
[Test]
public void TestIfItWorksCorrectly()
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
````