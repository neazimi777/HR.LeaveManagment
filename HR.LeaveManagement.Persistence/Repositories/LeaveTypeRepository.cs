using HR.LeaveManagment.Application.Persistence.Contract;
using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public  class LeaveTypeRepository :GenericRepository<LeaveType>,ILeaveTypeRepository
    {
        private  LeaveManagmentDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagmentDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
