using System;

namespace StoryTest
{
    public static class Story
    {
        public static Story<T> Target<T>(T target)
        {
            return new Story<T>()
            {
                Actor = target
            };
        }
    }

    public class Story<T>
    {
        internal Story()
        {

        }

        public void Act(Action<Story<T>> act)
        {
            try
            {
                act(this);
            }
            catch
            {
                throw;
            }
        }

        public T Actor
        {
            get;
            set;
        }
    }
}
