using DesignPatterns2.Cap2;
using System.Collections.Generic;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDbConnection connection = new ConnectionFactory().GetConnection();
            //IDbCommand command = connection.CreateCommand();
            //command.CommandText = "select * from table";

            MusicalNotes notes = new MusicalNotes();
            var music = new List<INote>()
            {
                notes.Get("do"),
                notes.Get("re"),
                notes.Get("mi"),
                notes.Get("fa"),
                notes.Get("fa"),
                notes.Get("fa"),
            };

            Piano piano = new Piano();
            piano.Play(music);
        }
    }
}
