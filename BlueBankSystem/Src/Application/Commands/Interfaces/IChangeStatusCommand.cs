﻿using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Domain.Shared.Entities;
using BlueBank.System.Domain.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands.Interfaces
{
    public interface IChangeStatusCommand<TEntity> : IHandler<ChangeStatusRequest, ChangeStatusResponse> where TEntity : Entity        
    {

    }

}