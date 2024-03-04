using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> blocks;
        public List<Transaction> transactionPool = new List<Transaction>();
        int maxTransactionsPerBlock = 5;
        public static int difficulty = 35;
        public static int blockTime = 10; // seconds
        public static List<int> miningTimes = new List<int>();

        public Blockchain()
        {
            blocks = new List<Block>()
            {
                new Block()
            };
        }

        public static void updateMiningTimes(int miningTime)
        {
            miningTimes.Add(miningTime);

            if (miningTimes.Count() >= 5)
            {
                double averageMiningTime = miningTimes.Average();

                if (averageMiningTime < blockTime - 0.5)
                { 
                    difficulty++;
                    Console.WriteLine($"Average mining time: {averageMiningTime}s" +
                    $"\n{blockTime - averageMiningTime}s under block time" +
                    $"\nDifficulty increased to {difficulty}");
                }
                else if (averageMiningTime > blockTime + 0.5)
                {
                    difficulty--;
                    Console.WriteLine($"Average mining time: {averageMiningTime}s" +
                    $"\n{averageMiningTime - blockTime}s over block time" +
                    $"\nDifficulty decreased to {difficulty}");
                }

                miningTimes.Clear();
            } 
        }

        public String getBlockAsString(int index)
        {
            return blocks[index].ToString();
        }

        public Block GetLastBlock()
        {
            return blocks[blocks.Count - 1];
        }

        public void addToTransactionPool(Transaction transaction)
        {
            transactionPool.Add(transaction);
        }

        public List<Transaction> getPendingTransactions(string preference, string addressPreference = "")
        {
            int n = Math.Min(maxTransactionsPerBlock, transactionPool.Count);

            switch (preference)
            {
                case "Greedy":
                    List<Transaction> sortedGreedy = transactionPool.OrderByDescending(t => t.fee).ToList();
                    return sortedGreedy.GetRange(0, n);
                case "Altruistic":
                    List<Transaction> sortedTime = transactionPool.OrderBy(t => t.timestamp).ToList();
                    return sortedTime.GetRange(0, n);
                case "Random":
                    Random rng = new Random();
                    List<Transaction> randomTransactions = transactionPool.OrderBy(tx => rng.Next()).Take(n).ToList();
                    return randomTransactions;
                case "AddressPreference":
                    List<Transaction> selectedTransactions = transactionPool
                        .OrderByDescending(tx => tx.recipientAddress == addressPreference)
                        .Take(n)
                        .ToList();
                    return selectedTransactions;
                default:
                    List<Transaction> transactions = transactionPool.GetRange(0, n);
                    transactionPool.RemoveRange(0, n);

                    return transactions;
            }
        }

        public double getBalance(String address)
        {
            double balance = 0.0;
            foreach (Block block in blocks)
            {
                foreach(Transaction transaction in block.transactionList)
                {
                    if (transaction.recipientAddress.Equals(address))
                    {
                        balance += transaction.amount;
                    }
                    if (transaction.senderAddress.Equals(address))
                    {
                        balance -= (transaction.amount + transaction.fee);
                    }
                }
            }

            return balance;
        }

        public static bool ValidateHash(Block b)
        {
            String rehash = b.CreateHash();
            return rehash.Equals(b.hash);
        }

        public static bool ValidateMerkleRoot(Block b)
        {
            String reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.merkleRoot);
        }

        public override string ToString()
        {
            String output = String.Empty;
            blocks.ForEach(b => output += (b.ToString() + "\n"));
            return output;
        }
    }
}
