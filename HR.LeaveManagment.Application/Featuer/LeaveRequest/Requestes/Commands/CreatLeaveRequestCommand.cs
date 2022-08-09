﻿using HR.LeaveManagment.Application.DTos.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveRequest.Requestes.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
