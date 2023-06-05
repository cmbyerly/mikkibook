namespace MikkiBookWF.UIClasses
{
    public class TransactionTypes
    {
        public TransactionTypes(string transactionTypeCode, string transactionType, bool isDebit, bool isCredit)
        {
            TransactionTypeCode = transactionTypeCode;
            TransactionType = transactionType;
            IsDebit = isDebit;
            IsCredit = isCredit;
        }

        public string TransactionTypeCode { get; set; }

        public string TransactionType { get; set; }

        public bool IsDebit { get; set; }

        public bool IsCredit { get; set; }

        public override string ToString()
        {
            return $"{TransactionTypeCode} - {TransactionType}";
        }

        public static TransactionTypes[] GetTransactionTypes()
        { 
            List<TransactionTypes> transactionTypes = new List<TransactionTypes>();

            transactionTypes.Add(new TransactionTypes("ATM", "ATM Withdrawl", true, false));
            transactionTypes.Add(new TransactionTypes("DC", "Debit Card", true, false));
            transactionTypes.Add(new TransactionTypes("AP", "Automatic Payment", true, false));
            transactionTypes.Add(new TransactionTypes("IP", "Internet Payment", true, false));
            transactionTypes.Add(new TransactionTypes("DD", "Direct Deposit", false, true));
            transactionTypes.Add(new TransactionTypes("D", "Deposit", false, true));
            transactionTypes.Add(new TransactionTypes("PH", "Phone", true, false));
            transactionTypes.Add(new TransactionTypes("OD", "Other Debit", true, false));
            transactionTypes.Add(new TransactionTypes("CK", "Check", true, false));
            transactionTypes.Add(new TransactionTypes("OC", "Other Credit", false, true));


            return transactionTypes.OrderBy(x => x.TransactionTypeCode).ToArray();
        }

    }
}
