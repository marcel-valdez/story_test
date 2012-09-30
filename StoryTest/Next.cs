using System;

namespace StoryTest
{    

    public static class Next
    {               
        public static void Act(Action act)
        {
            try
            {
                act();
            }
            catch
            {
                throw;
            }
        }
    }
}
