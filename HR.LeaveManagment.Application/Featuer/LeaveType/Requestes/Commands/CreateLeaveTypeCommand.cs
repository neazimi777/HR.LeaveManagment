using HR.LeaveManagment.Application.DTos.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveType.Requestes.Commands
{
    public  class CreatLeaveTypeCommand :IRequest<int>
    {
        public CreateLeaveTypeDto leaveTypeDto { get; set; }
    }
}
