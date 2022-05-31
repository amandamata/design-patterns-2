namespace DesignPatterns2.Cap3
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
