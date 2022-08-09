using AutoMapper;
using HR.LeaveManagment.Application.DTos.LeaveRequest;
using HR.LeaveManagment.Application.Featuer.LeaveRequest.Requestes.Queries;
using HR.LeaveManagment.Application.Persistence.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<List<LeaveRequestDto>, GetLeaveRequestListRequest>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository , IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
                
        }
        public async Task<GetLeaveRequestListRequest> Handle(List<LeaveRequestDto> request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(leaveRequests);
        }
    }
}
