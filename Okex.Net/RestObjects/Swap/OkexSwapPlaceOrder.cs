﻿using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters;
using Okex.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Okex.Net.Enums;

namespace Okex.Net.RestObjects
{
    public class OkexSwapPlaceOrder
    {
        [JsonProperty("type"), JsonConverter(typeof(SwapOrderTypeConverter))]
        public OkexSwapOrderType Type { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Size { get; set; }

        [JsonProperty("order_type"), JsonConverter(typeof(SwapTimeInForceConverter))]
        public OkexSwapTimeInForce TimeInForce { get; set; } = OkexSwapTimeInForce.NormalOrder;

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Price { get; set; }
        
        [JsonProperty("match_price")]
        public bool MatchPrice { get; set; }

        [JsonProperty("client_oid")]
        public string ClientOrderId { get; set; } = "";
    }
}
