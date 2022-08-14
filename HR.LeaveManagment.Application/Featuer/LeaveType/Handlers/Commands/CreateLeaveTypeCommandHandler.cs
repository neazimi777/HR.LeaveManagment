using AutoMapper;
using HR.LeaveManagment.Application.DTos.LeaveType.Validators;
using HR.LeaveManagment.Application.Exceptions;
using HR.LeaveManagment.Application.Featuer.LeaveType.Requestes.Commands;
using HR.LeaveManagment.Application.Persistence.Contract;
using HR.LeaveManagment.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveType.Handlers.Commands
{
    public class CreatLeaveTypeCommandHandler : IRequestHandler<CreatLeaveTypeCommand, BaseCommandResponse>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreatLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreatLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.leaveTypeDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                //var leaveType = _mapper.Map<LeaveType>(request.leaveTypeDto);

                //leaveType = await _unitOfWork.LeaveTypeRepository.Add(leaveType);
                //await _unitOfWork.Save();

                response.Success = true;
                response.Message = "Creation Successful";
              // response.Id = .Id;
            }

            return response;
        }
    }
}

