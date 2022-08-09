using HR.LeaveManagment.Application.DTos.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveAllocation.Requestes.Commands
{
    public  class UpdateLeaveAllocationCommand :IRequest<Unit>
    {

        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
