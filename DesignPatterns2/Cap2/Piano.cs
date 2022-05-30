using System;
using System.Collections.Generic;

namespace DesignPatterns2.Cap2
{
    public class Piano
    {
        public void Play(IList<INote> music)
        {
            foreach(INote note in music)
            {
                Console.Beep(note.Frequency, 300);
            }
        }
    }
}
