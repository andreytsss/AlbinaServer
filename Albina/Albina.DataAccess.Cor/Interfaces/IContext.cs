using Albina.DataAccess.Cor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Albina.DataAccess.Cor.Interfaces
{
    public  interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set;}
        DbSet<VirtualExpenseRto> VirtualExpenses { get; set; }
        DbSet<RejectExpenseRto> RejectExpenses { get; set; }
        DbSet<AcceptExpenseRtp> AcceptExpenses { get; set; }
        Task <int> SaveChangesAsync(CancellationToken cancellationToken = default)
    }
}
