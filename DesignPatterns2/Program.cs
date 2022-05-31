using DesignPatterns2.Cap3;
using System;
using Contract = DesignPatterns2.Cap3.Contract;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDbConnection connection = new ConnectionFactory().GetConnection();
            //IDbCommand command = connection.CreateCommand();
            //command.CommandText = "select * from table";

            //MusicalNotes notes = new MusicalNotes();
            //var music = new List<INote>()
            //{
            //    notes.Get("do"),
            //    notes.Get("re"),
            //    notes.Get("mi"),
            //    notes.Get("fa"),
            //    notes.Get("fa"),
            //    notes.Get("fa"),
            //};

            //Piano piano = new Piano();
            //piano.Play(music);

            var contractHistory = new ContractHistory();
            var contract = new Contract(DateTime.Now, "Amanda", ContractType.New);
            contractHistory.Add(contract.Save());

            contract.Continue();
            contractHistory.Add(contract.Save());
            contract.Continue();
            contractHistory.Add(contract.Save());
            Console.WriteLine(contract.ContractType);
            Console.WriteLine(contractHistory.Get(2).Contract.ContractType);

        }
    }
}
