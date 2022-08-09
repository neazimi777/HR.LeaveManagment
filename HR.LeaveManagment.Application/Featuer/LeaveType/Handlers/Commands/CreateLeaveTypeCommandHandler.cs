using AutoMapper;
using HR.LeaveManagment.Application.DTos.LeaveType.Validators;
using HR.LeaveManagment.Application.Featuer.LeaveType.Requestes.Commands;
using HR.LeaveManagment.Application.Persistence.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Featuer.LeaveType.Handlers.Commands
{
    public class CreatLeaveTypeCommandHandler : IRequestHandler<CreatLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreatLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async  Task<int> Handle(CreatLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveTypeDtoValidator();
            var resultValidator = await validator.ValidateAsync(request.leaveTypeDto);

            if (resultValidator.IsValid == false)
            {
                throw new Exception();
            }

            



            var leaveType = _mapper.Map<HR.LeaveManagment.Domain.LeaveType>(request.leaveTypeDto);
            leaveType = await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
