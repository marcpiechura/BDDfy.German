using System;
using TestStack.BDDfy;

namespace BDDfy.German
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class GermanStoryAttribute : StoryNarrativeAttribute
    {
        public GermanStoryAttribute()
        {
            TitlePrefix = "Storie: ";
        }

        // ReSharper disable InconsistentNaming
        private const string I_want_prefix = "Will ich";
        private const string So_that_prefix = "Damit";
        private const string As_a_prefix = "Als ein";
        // ReSharper restore InconsistentNaming

        public string AlsEin
        {
            get { return Narrative1; }
            set { Narrative1 = CleanseProperty(value, As_a_prefix); }
        }

        public string WillIch
        {
            get { return Narrative2; }
            set { Narrative2 = CleanseProperty(value, I_want_prefix); }
        }

        public string Damit
        {
            get { return Narrative3; }
            set { Narrative3 = CleanseProperty(value, So_that_prefix); }
        }
    }
}
