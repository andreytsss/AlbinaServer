using Albina.DataAccess.Cor.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAccess.Cor.Models
{
    [Table("AcceptExpense")]
    public class AcceptExpenseRtp
    {
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        [Key] public int Id { get; set; }
        public int UserId { get; set; }
        public UserRto User { get; set; }
        public string WhereSpand { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public DateTimeOffset CreateDataTine { get; set; }
        public DateTimeOffset RejectDataTime { get; set; }

    }
}
