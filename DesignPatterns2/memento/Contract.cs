using System;

namespace DesignPatterns2.memento
{
    public class Contract
    {
        public DateTime Date { get; }
        public string Client { get; }
        public ContractType ContractType { get; private set; }

        public Contract(DateTime dateTime, string client, ContractType contractType)
        {
            Date = dateTime;
            Client = client;
            ContractType = contractType;
        }

        public void Continue()
        {
            if (ContractType == ContractType.New) ContractType = ContractType.InProgress;
            else if (ContractType == ContractType.InProgress) ContractType = ContractType.Adjusted;
            else if (ContractType == ContractType.Adjusted) ContractType = ContractType.Completed;
        }

        public ContractStatus Save()
        {
            return new ContractStatus(new Contract(Date, Client, ContractType));
        }
    }
}
