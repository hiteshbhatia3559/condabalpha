using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondabLibrary
{
    public class Block
    {
       // public List<Author> Authors { get; set; }
        //public const int NetCoinsFlow = 100;
        //public double NetTransacted { get; set; }
        //public double ChainHoldsCoins { get; set; }
        public int Index { get; set; }
        // public string Timestamp { get; set; }
        private string transactions;
        public string PreviousHash { get; set; }
        private string BlockHash;
        static string sha256(string randomString)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString), 0, Encoding.UTF8.GetByteCount(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        public Block( string PreviousHash, string transactions)
        {
            this.PreviousHash = PreviousHash;
            this.transactions = transactions;
            this.BlockHash = sha256(PreviousHash+transactions);
        }
        public string getPreviousHash()
        {
            return PreviousHash;

        }
        public string getTransactions()
        {
            return transactions;
        }
        public string getBlockHash()
        {
            return BlockHash;
        }
        


    }
}
