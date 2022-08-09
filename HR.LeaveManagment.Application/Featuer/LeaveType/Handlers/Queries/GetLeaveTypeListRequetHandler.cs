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
    public class GetLeaveTypeListRequetHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
      private readonly  ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _Mapper;
        public GetLeaveTypeListRequetHandler(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetAll();

            return _Mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        }
    }
}
