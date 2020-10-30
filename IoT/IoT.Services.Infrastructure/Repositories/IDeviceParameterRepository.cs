﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.Entities;
using IoT.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoT.Services.Infrastructure
{
    public interface IDeviceParameterRepository
    {
        Task<IEnumerable<DeviceParameter>> GetList(int deviceId, ContextSession session);
        Task<DeviceParameter> Get(int id, ContextSession session);
        Task<DeviceParameter> Edit(DeviceParameter parameter, ContextSession session);
        Task Delete(int id, ContextSession session);
    }
}
