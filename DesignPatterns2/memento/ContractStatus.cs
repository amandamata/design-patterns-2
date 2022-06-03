namespace DesignPatterns2.memento
{
    public class ContractStatus
    {
        public Contract Contract { get; set; }
        public ContractStatus(Contract contract)
        {
            Contract = contract;
        }
    }
}
