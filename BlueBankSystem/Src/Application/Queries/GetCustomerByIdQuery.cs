﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.Shared.Handlers;

namespace BlueBank.System.Application.Queries
{
    public class GetCustomerByIdQuery : IHandler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        private CustomerRepository _repository;
        public GetCustomerByIdQuery(CustomerRepository repository)
        {
            _repository = repository;
        }
        public GetCustomerByIdResponse Handle(GetCustomerByIdRequest request)
        {
            
            var customer = _repository.GetById(request.Id);

            return new GetCustomerByIdResponse()
            {
                Id = customer.Id,
                Name = customer.Name,
                Telephone = customer.Telephone,
                IsActive = customer.IsActive 
            };
        }

    }
}
