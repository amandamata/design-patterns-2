using System.Collections.Generic;

namespace DesignPatterns2.Cap3
{
    public class ContractHistory
    {
        private readonly IList<ContractStatus> ContractStatus = new List<ContractStatus>();

        public void Add(ContractStatus contractStatus)
        {
            ContractStatus.Add(contractStatus);
        }

        public ContractStatus Get(int id)
        {
           return ContractStatus[id];
        }
    }
}
