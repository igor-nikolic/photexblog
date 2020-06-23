﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase
{
    public interface IUseCaseLogger
    {
        void Log(IUseCase useCase,object useCaseData);
    }
}
