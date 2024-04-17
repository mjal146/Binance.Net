﻿using Binance.Net.Converters;
using Binance.Net.Enums;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// Open Interest History info
    /// </summary>
    public class BinanceFuturesCoinOpenInterestHistory
    {
        /// <summary>
        /// The symbol the information is about
        /// </summary>
        public string Pair { get; set; } = string.Empty;

        /// <summary>
        /// Contract type
        /// </summary>
        [JsonConverter(typeof(ContractTypeConverter))]
        public ContractType ContractType { get; set; }

        /// <summary>
        /// Total open interest
        /// </summary>
        public decimal SumOpenInterest { get; set; }

        /// <summary>
        /// Total open interest value
        /// </summary>
        public decimal SumOpenInterestValue { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty("timestamp"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Timestamp { get; set; }
    }
}
