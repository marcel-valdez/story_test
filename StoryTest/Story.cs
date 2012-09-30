using System;

namespace StoryTest
{
    public static class Story
    {
        public static Story<T> With<T>(T actor)
        {
            return new Story<T>()
            {
                Actor = actor
            };
        }
    }

    public class Story<T>
    {
        internal Story()
        {

        }

        public void Act(Action<T> act)
        {
            try
            {
                act(this.Actor);
            }
            catch
            {
                throw;
            }
        }

        internal T Actor
        {
            get;
            set;
        }
    }
}
