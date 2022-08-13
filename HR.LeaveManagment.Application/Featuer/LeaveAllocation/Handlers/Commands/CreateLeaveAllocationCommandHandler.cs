using AutoMapper;
using HR.LeaveManagment.Application.DTos.LeaveAllocation.Validators;
using HR.LeaveManagment.Application.Exceptions;
using HR.LeaveManagment.Application.Featuer.LeaveAllocation.Requestes.Commands;
using HR.LeaveManagment.Application.Persistence.Contract;
using HR.LeaveManagment.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveAllocation.Handlers.Commands
{
     public class CreateLeaveAllocationCommandHandler:IRequestHandler<CreateLeaveAllocationCommand, BaseCommandResponse>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {

            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
           
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveAllocationDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.leaveAllocationDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            var leaveAllocation = _mapper.Map<Domain.LeaveAllocation>(request.leaveAllocationDto);

            leaveAllocation = await _leaveAllocationRepository.Add(leaveAllocation);

            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = leaveAllocation.Id;

            return response;
        }
    }
}
