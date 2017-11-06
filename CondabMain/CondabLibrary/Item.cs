using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondabLibrary
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PriceInCoin { get; set; }
        public double BoughtByAddress { get; set; }
        public double TransferredToAddress { get; set; }
        public double TxFees { get; set; }
        public bool ValidationConfirmed { get; set; }
        public Author Owner { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public File Book { get; set; }
    }
}
