using AutoMapper;
using HR.LeaveManagment.Application.DTos.LeaveType;
using HR.LeaveManagment.Application.Featuer.LeaveType.Requestes.Queries;
using HR.LeaveManagment.Application.Persistence.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveRequestRepository _leaveReqestRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository , IMapper mapper)
        {
            _leaveReqestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveReqestRepository.Get(request.id);

            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
