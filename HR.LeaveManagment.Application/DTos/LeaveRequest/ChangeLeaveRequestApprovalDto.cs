using HR.LeaveManagment.Application.DTos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.DTos.LeaveRequest
{
    public  class ChangeLeaveRequestApprovalDto :BaseDto
    {
        public bool Approved { get; set; }
    }
}
