﻿using Bloodrayne1995.GlowingSpark.CherryData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloodrayne1995.GlowingSpark.CherryData.Cobra.Payloads
{
    public class RebootRequest : ICobraPayload
    {
        public string GetPayLoadType() => CobraRequestType.RebootRequest;

        //TODO: Secure passwords (no SecureString)
        [JsonPropertyName("adminPassword")]
        public string AdminPassword { get; set; } = string.Empty;


    }
}