using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using DesignPatterns2.Cap9;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
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

            //var contractHistory = new ContractHistory();
            //var contract = new Contract(DateTime.Now, "Amanda", ContractType.New);
            //contractHistory.Add(contract.Save());

            //contract.Continue();
            //contractHistory.Add(contract.Save());
            //contract.Continue();
            //contractHistory.Add(contract.Save());
            //Console.WriteLine(contract.ContractType);
            //Console.WriteLine(contractHistory.Get(2).Contract.ContractType);

            //IExpression firstExpresion = new Sum(new Num(1), new Num(10));
            //IExpression secondExpresion = new Subtraction(new Num(20), new Num(10));
            //IExpression sum = new Sum(firstExpresion, secondExpresion);
            //Console.WriteLine(sum.Avaliate());

            //Expression sum2 = Expression.Add(Expression.Constant(1), Expression.Constant(20));
            //Func<int> interpreter = Expression.Lambda<Func<int>>(sum2).Compile();
            //int result = interpreter();
            //Console.WriteLine(result);

            //PrinterVisitor printer = new PrinterVisitor();
            //sum.Accept(printer);

            //IMessage message = new ClientMessage("amanda");
            //ISender sender = new SmsSender();
            //message.Sender = sender;
            //message.Send();

            //Queue queue = new Queue();
            //Order order1 = new Order("Amanda", 10);
            //Order order2 = new Order("Mauricio ", 200);

            //queue.Add(new PayOrder(order1));
            //queue.Add(new PayOrder(order2));
            //queue.Add(new EndOrder(order2));
            //queue.Process();


            //Client client = new Client();
            //client.Name = "Amanda";
            //client.Address = "Campos Salles";
            //client.BirthDate = DateTime.Now;

            //String json = new JsonGenerator().Json(client);
            //Console.WriteLine(json);

            FacadeCompany facadeCompany = new CompanyFacadeSingleton().Instance;
            Client client = facadeCompany.GetClient("cpf");
            var invoice = facadeCompany.CreateInvoice(client, 500);
        }
    }
}
