using AutoMapper;
using HR.LeaveManagment.Application.DTos.LeaveAllocation;
using HR.LeaveManagment.Application.DTos.LeaveRequest;
using HR.LeaveManagment.Application.DTos.LeaveType;
using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveType, LeaveRequestListDto>().ReverseMap();


        }
    }
}
