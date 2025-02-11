﻿using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using DS4Windows.Shared.Common.Util;
using PropertyChanged;

namespace DS4Windows.Shared.Configuration.Profiles.Schema
{
    [AddINotifyPropertyChangedInterface]
    public class LinkedProfiles : JsonSerializable<LinkedProfiles>
    {
        public Dictionary<PhysicalAddress, Guid> Assignments { get; set; } = new();
    }
}