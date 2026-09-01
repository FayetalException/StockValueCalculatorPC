using System.Diagnostics;

namespace StockValueCalculator
{
    public class CD : IProduct
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Tracks { get; set; }
        public decimal BasePrice { get; set; }
        public decimal PriceIncludingVAT
        {
            get
            {
                return decimal.Round(BasePrice * 1.20m, 2);  // 20% VAT on CDs                
            }
        }

        public CD(string name, string artist, int tracks, decimal basePrice)
        {
            Name = name;
            Artist = artist;
            Tracks = tracks;
            BasePrice = basePrice;
        }

    }
}
