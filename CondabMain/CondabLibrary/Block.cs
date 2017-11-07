using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondabLibrary
{
    public class Block
    {
        public List<Author> Authors { get; set; }
        public const int NetCoinsFlow = 100;
        public double NetTransacted { get; set; }
        public double ChainHoldsCoins { get; set; }
        public int Index { get; set; }
        public string Timestamp { get; set; }
        
        public string PreviousHash { get; set; }
        public string NextHash { get; set; }


        
    }
}
