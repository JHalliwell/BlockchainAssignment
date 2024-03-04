using BlockchainAssignment.HashCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    class Block
    {
        DateTime timestamp;
        int index;
        public String hash;
        public String prevHash;

        public List<Transaction> transactionList = new List<Transaction>();
        public String merkleRoot;

        public long nonce = 0;

        public double reward = 1.0;
        public double fees = 0.0;

        public String minerAddress = String.Empty;

        public Block(
            Block lastBlock,
            List<Transaction> transactions, 
            String minerAddress = ""
        )
        {
            timestamp = DateTime.Now;
            prevHash = lastBlock.hash;
            index = lastBlock.index + 1;

            this.minerAddress = minerAddress;

            transactions.Add(CreateRewardTransaction(transactions));
            transactionList = new List<Transaction>(transactions);

            merkleRoot = MerkleRoot(transactionList);

            this.hash = MineParallel();
        }

        // genesis block constructor
        public Block()
        {
            this.timestamp = DateTime.Now;
            this.prevHash = String.Empty;
            this.index = 0;
            this.reward = 0;

            this.hash = MineParallel();
        }

        public Transaction CreateRewardTransaction(List <Transaction> transactions)
        {
            fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, "");
        }

        public void adjustDifficulty()
        {

        }

        public String CreateHash()
        {
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() 
                + timestamp.ToString() 
                + prevHash 
                + nonce.ToString() 
                + reward.ToString() 
                + merkleRoot;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            String hash = string.Empty;
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            return hash;
        }

        public static String CreateHash(Block block, int nonce)
        {
            SHA256 hasher = SHA256Managed.Create();
            String input = block.index.ToString()
                + block.timestamp.ToString()
                + block.prevHash
                + nonce.ToString()
                + block.reward.ToString()
                + block.merkleRoot;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            String hash = string.Empty;
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            return hash;
        }


        public String Mine()
        { 
            String hash = CreateHash();

            // difficulty criteria definition
            String re = new string('0', Blockchain.difficulty); // create a regex string of N (difficulty i.e 4) 0's

            // re-hash until criteria is met
            while (!hash.StartsWith(re))
            {
                nonce++;
                hash = CreateHash();
            }

            return hash;
        }
        public String MineParallel()
        { 
            // difficulty criteria definition
            String re = new string('0', Blockchain.difficulty); // create a regex string of N (difficulty i.e 4) 0's

            int finalNonce;

            Stopwatch sw = Stopwatch.StartNew();

            (finalNonce, hash) = HashFinder.StartMining(this, 4, re);

            sw.Stop();
            int miningTimeInSeconds = (int)sw.Elapsed.TotalSeconds;
            // Console.WriteLine(miningTimeInSeconds);
            Blockchain.updateMiningTimes((int)sw.Elapsed.TotalSeconds);

            nonce = finalNonce;

            return hash;
        }

        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList();
            if(hashes.Count == 0)
            {
                return String.Empty;
            }
            if(hashes.Count == 1) 
            {
                return HashCode.HashTools.CombineHash(hashes[0], hashes[0]);
            }
            while(hashes.Count != 1)
            {
                List<String> merkelLeaves = new List<String>(); 
                for(int i = 0; i < hashes.Count; i += 2) 
                {
                    if(i == hashes.Count - 1)
                    {
                        merkelLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i]));
                    }
                    else
                    {
                        merkelLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i + 1]));
                    }
                    hashes = merkelLeaves;
                }
            }

            return hashes[0];
        }

        public override string ToString()
        {
            String output = String.Empty;
            transactionList.ForEach(t => output += (t.ToString() + "\n"));

            return "Index: " + index.ToString()
                + "\nTimestamp: " + timestamp.ToString()
                + "\nPrevious Hash: " + prevHash
                + "\nHash: " + hash
                + "\nNonce: " + nonce.ToString()
                + "\nDifficulty: " + Blockchain.difficulty.ToString()
                + "\nReward: " + reward.ToString()
                + "\nFes: : " + fees.ToString()
                + "\nMiner's Address: " + minerAddress
                + "\n\nTransactions:" + output;
        }
    }
}
