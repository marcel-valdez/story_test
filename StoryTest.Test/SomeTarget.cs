
namespace StoryTest.Test
{
    class SomeTarget
    {
        public int Number
        {
            get;
            set;
        }

        public void PlusOne()
        {
            this.Number += 1;
        }

        public void MinusOne()
        {
            this.Number -= 1;
        }
    }
}
