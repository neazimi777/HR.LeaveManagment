using HR.LeaveManagment.Application.DTos.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveRequest.Requestes.Queries
{
    public  class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {
    }
}
