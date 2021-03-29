using MoreLinq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> chain = new List<Block>();
        public List<Transaction> transactionPool = new List<Transaction>();

        private const int MAX_TRANSACTIONS = 5;

        // GEENSIS BLOCK INITIALISATION

        public Blockchain()
        {
            chain.Add(new Block()); 
        }

        public Block getLastBlock()
        {
            return chain.LastOrDefault();
        }

        public List<Transaction> getTrasnactions()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); //maximum num of transactions from the pool = 5

            List<Transaction> transaction_pendings = transactionPool.GetRange(0, n); 
            transactionPool.RemoveRange(0, n); 

            return transaction_pendings; 
        }

        // ALTRUISTIC METHOD
        public List<Transaction> getTrasnactionsAltruistic()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); 

            List<Transaction> transaction_pendings = transactionPool.OrderBy(transaction => transaction.timestamp).Take(n).ToList(); 
            transactionPool = transactionPool.OrderBy(transaction => transaction.timestamp).Skip(n).ToList(); 

            return transaction_pendings; 
        }

        // UNPREDICTABLE METHOD 
        public List<Transaction> getTrasnactionsRandom()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); 
            List<Transaction> transaction_pendings = new List<Transaction>();

            Random rnd = new Random();

            for (int i = 0; i < n; i++) // per every transaction 
            {
                int i_rdm = rnd.Next(transactionPool.Count - 1); // random int
                
                // remove selected int from the pool 

                transaction_pendings.Add(transactionPool[i_rdm]);
                transactionPool.RemoveAt(i_rdm);
            }

            return transaction_pendings; 
        }

        // GREEDY METHOD

        public List<Transaction> getTrasnactionsGreedy()
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); 

            List<Transaction> transaction_pendings = transactionPool.OrderByDescending(transaction => transaction.fee).Take(n).ToList(); // order pool by fee and get the highest
            transactionPool = transactionPool.OrderByDescending(transaction => transaction.fee).Skip(n).ToList(); 

            return transaction_pendings; 
        }

        public List<Transaction> getTrasnactionsOwner(String address)
        {
            int n = Math.Min(MAX_TRANSACTIONS, transactionPool.Count); 
            List<Transaction> transaction_pendings = new List<Transaction>();

            for (int i = 0; i < n; i++) // per transaction
            {
                //find the first occurance of a transaction with the specified sender address
                int addressIndex = transactionPool.FindIndex(transaction => transaction.senderAddress == address); 
                if(addressIndex != -1) 
                {
                    // remove from pool
                    transaction_pendings.Add(transactionPool[addressIndex]);
                    transactionPool.RemoveAt(addressIndex);
                }
            }

            return transaction_pendings; 
        }

        public double getBalance(String address)
        {
            double balance = 0.0;

            foreach(Block block in chain)
            {
                foreach (Transaction transaction in block.transactions)
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
        public bool validateHash(Block block)
        {
            return block.hash.Equals(block.createHash());
        }
        public bool validateMerkleRoot(Block block)
        {
            return block.merkleRoot.Equals(Block.createMerkleRoot(block.transactions));
        }

        public bool validateTransactionPool()
        {
            return transactionPool.All(transaction => Wallet.Wallet.ValidateSignature(transaction.senderAddress, transaction.hash, transaction.signature));
        }

        public override string ToString()
        {
            return "BLOCKCHAIN: \n" + string.Join("\n", chain) 
                + "\nTRANSACTION POOL: \n" + string.Join("\n", transactionPool);
        }
    }
}
