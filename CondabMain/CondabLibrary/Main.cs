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

            string genesisTransactions = "Hitesh sends Nikita 10 CDA";
            Block genesisBlock = new Block(PreviousHash:"0", transactions: genesisTransactions);
            Console.WriteLine("Genesis blockhash is:");
            Console.WriteLine(genesisBlock.getBlockHash());

            string block2transactions = "Nikita sends Hitesh 10 CDA";
            Block block2 = new Block(genesisBlock.getBlockHash(), block2transactions);
            Console.WriteLine("Block#2 blockhash is:");
            Console.WriteLine(block2.getBlockHash());
            
            string block3transactions = "Nikita sends her friend 10 CDA";
            Block block3 = new Block(block2.getBlockHash(), block3transactions);
            Console.WriteLine("Block#3 blockhash is:");
            Console.WriteLine(block3.getBlockHash());
            Console.ReadLine();
        }
    }
}
