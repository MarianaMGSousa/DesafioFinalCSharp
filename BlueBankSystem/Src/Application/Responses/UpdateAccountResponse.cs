﻿using System;


namespace BlueBank.System.Application.Responses
{
    public class UpdateAccountResponse
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerNome { get; set; }
        public decimal Balance { get; set; }
    }
}
