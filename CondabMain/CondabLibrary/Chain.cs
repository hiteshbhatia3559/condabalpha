using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondabLibrary
{
    public class Chain
    {
        public List<Author> Authors { get; set; }
        public const int NetCoinsFlow = 100;
        public double NetTransacted { get; set; }
        public double ChainHoldsCoins { get; set; }
        
    }
}
