﻿using System.Threading.Tasks;

namespace FreePOS.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
