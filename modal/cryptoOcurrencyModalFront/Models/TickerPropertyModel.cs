using System;
using System.Collections.Generic;

namespace cryptoOcurrencyModalFront.Models
{
    public class TickerPropertyModel
    {
    public TickerModel Ticker { get; set; }
    public int Timestamp { get; set; }
    public bool Success { get; set; }
    public string Error { get; set; }

    }
}