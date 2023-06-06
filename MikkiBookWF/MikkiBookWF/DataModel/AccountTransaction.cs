using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MikkiBookWF.DataModel
{
    public class AccountTransaction: ICloneable
    {
        public AccountTransaction(long id, string description, string transType, DateTime transactionDate, DateTime? reconciliationDate, decimal amount, string checkNumber)
        {
            Id = id;
            Description = description;
            TransType = transType;
            TransactionDate = transactionDate;
            ReconciliationDate = reconciliationDate;
            Amount = amount;
            CheckNumber = checkNumber;
        }

        [Key]
        public long Id { get; set; }

        [Required]
        [Column("DESC")]
        public string Description { get; set; }

        [Required]
        [Column("TYPE")]
        public string TransType { get; set; }

        [Required]
        [Column("TDATE")]
        public DateTime TransactionDate { get; set; }

        [Column("RDATE")]
        public DateTime? ReconciliationDate { get; set; }

        [Required]
        [Column("AMOUNT")]
        public decimal Amount { get; set; }

        [Column("CHECK_NUMBER")]
        public string CheckNumber { get; set; }

        public object Clone()
        {
            return new AccountTransaction(Id, Description, TransType, TransactionDate, ReconciliationDate, Amount, CheckNumber);
        }

        public override string ToString()
        {
            var amtchar = Amount >= 0.00M ? "+" : string.Empty;
            return $"{TransType.PadRight(2, ' ')} - {Description.PadRight(100, ' ')} - {amtchar}{Amount.ToString("N2")}";
        }
    }
}
