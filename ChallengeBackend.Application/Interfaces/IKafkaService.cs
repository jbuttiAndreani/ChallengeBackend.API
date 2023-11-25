﻿using ChallengeBackend.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBackend.Application.Interfaces
{
    public interface IKafkaService
    {
        Task ProduceMessageAsync(KafkaMessage message);
    }
}
