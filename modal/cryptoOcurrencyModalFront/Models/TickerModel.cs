using System;
using System.Collections.Generic;

namespace cryptoOcurrencyModalFront.Models
{
    public class TickerModel
    {
    public string Base { get; set; }
    public string Target { get; set; }
    public string Price { get; set; }
    public string Volume { get; set; }
    public string Change { get; set; }
    public List<MarketModel> Markets { get; set; }
    }
}