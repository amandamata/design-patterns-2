using System.Collections.Generic;

namespace DesignPatterns2.Cap2
{
    class MusicalNotes
    {
        private static IDictionary<string, INote> notes =
            new Dictionary<string, INote>
            {
                {"do", new Do()},
                {"re", new Re()},
                {"mi", new Mi()},
                {"fa", new Fa()},
                {"sol", new Sol()},
                {"la", new La()},
                {"si", new Si()}
            };

        public INote Get(string name)
        {
            return notes[name];
        }
    }
}
