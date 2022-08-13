using HR.LeaveManagment.Application.DTos.LeaveType;
using HR.LeaveManagment.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveType.Requestes.Commands
{
    public  class CreatLeaveTypeCommand :IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto leaveTypeDto { get; set; }
    }
}
