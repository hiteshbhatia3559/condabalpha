using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondabLibrary

{       public class main
    {
        public List<Block> blockchain = new List<Block>();
        public static void Main(String[] args)
        {

            string genesisTransactions = "Hitesh sends Nikita 10 CDAaaa";
            Block genesisBlock = new Block(PreviousHash:"0", transactions: genesisTransactions);
            Console.WriteLine(genesisBlock.getBlockHash());
            
            Console.ReadLine();
        }
    }
}
