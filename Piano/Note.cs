using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Piano
{
    class Note
    {
        private Tone tone;
        private Duration duration;

        public Note()
        {
            tone = Tone.Pause;
            duration = Duration.Whole;
        }

        public Note(string t, string d)
        {
            Enum.TryParse(t, out tone);
            Enum.TryParse(d, out duration);
        }

        public void Sound()
        {
            if ((int)tone == 0)
                Thread.Sleep((int)duration);
            else
                Console.Beep((int)tone, (int)duration);
        }
    }
}
