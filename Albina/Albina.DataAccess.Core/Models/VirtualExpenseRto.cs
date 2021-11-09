using Albina.DataAccess.Core.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albina.DataAccess.Core.Models
{
    [Table("VirtualExpense")]
    public class VirtualExpenseRto
    {
        [Key] public int Id { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public VirtualExpenseStatusRto Status { get; set; }
        public DataTimeOffset CreateDateTime { get; set; }
        public List<DataTimeOffset> ChangeDateTimes { get; set; }
    }
}
