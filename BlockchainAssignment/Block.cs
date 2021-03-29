using BlockchainAssignment.HashCode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {

        // global variables 

        const int THREADS = 15; //modify threading 
        const double TARGET_BLOCK_TIME = 0.5; // modify desired block time to compare against actual block time to adjust difficulty

        public int index;
        public DateTime timestamp;
        public String hash;
        public String prevHash;

        public int nonce_a = 0; // nonce
        public int nonce_b = 0; // e-nonce
        public int difficulty; 

        public double reward = 1.0;
        public double fees = 0.0;

        public String minerAddress = "";
        public List<Transaction> transactions = new List<Transaction>();
        public string merkleRoot;

        public double block_time; //time between blocks
        bool HashFound; 

        public Block() 
        {
            this.timestamp = DateTime.Now; // current time
            this.index = 0; 
            this.prevHash = ""; // since there is no previous block string is null
            this.MineThread(); 
        }

        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress = "")
        {
            this.timestamp = DateTime.Now; 
            this.index = lastBlock.index + 1; 
            this.prevHash = lastBlock.hash;

            // DIFFICULTY DYNAMICS 

            if (lastBlock.block_time < TARGET_BLOCK_TIME)
            {
                // increase difficulty if block time < desired block time
                this.difficulty = lastBlock.difficulty + 1;
            }
            else
            {
                // otherwise lower difficulty level
                this.difficulty = lastBlock.difficulty - 1;
            }

            this.minerAddress = minerAddress; 

            transactions.Add(createRewardTransaction(transactions)); 
            this.transactions = transactions; 
            this.merkleRoot = createMerkleRoot(transactions); // count merkleroot of transactions

            HashFound = false; // for threading purposes 
            this.MineThread(); 
        }

        public String createHash()
        {
            // SHA256 hashing method from SHA Class
            String hash = new Sha256Class().createHash(
                                                                 "Index: " + index.ToString() +
                                                                "\tTimestamp: " + timestamp.ToString() +
                                                               "\nPrevious Hash: " + prevHash +
                                                               "\nNonce: " + nonce_a.ToString() +
                                                                "\nTwin Nonce: " + nonce_b.ToString() +
                                                               "\nReward: " + reward.ToString() +
                                                              "\n" + merkleRoot);

            return hash;
        }

        public void MineThread()
        {
            WaitHandle[] waitHandles = new WaitHandle[THREADS]; 
            Random rnd = new Random();

            for (int i = 0; i < THREADS; i++) 
            {
                var handle = new EventWaitHandle(false, EventResetMode.ManualReset); // generate handle flag

                new Thread(delegate ()
                {
                    
                    String currentHash = createHash();
                    int threadNonceA = 0;
                    int threadNonceB = rnd.Next(1, int.MaxValue);

                    // null string for hash matching
                    String re = new string('0', difficulty);

                    while (!HashFound)
                    {
                        threadNonceA++; 
                        currentHash = new Sha256Class().createHash( 
                                                               "Index: " + index.ToString() +
                                                                "\tTimestamp: " + timestamp.ToString() +
                                                               "\nPrevious Hash: " + prevHash +
                                                               "\nNonce: " + threadNonceA.ToString() +
                                                                "\nTwin Nonce: " + threadNonceB.ToString() +
                                                               "\nReward: " + reward.ToString() +
                                                              "\n"  + merkleRoot);

                        if (HexToBinary.HexStringToBinary(currentHash).StartsWith(re))
                        {
                            // thread mining to stop when hash is found 
                            HashFound = true;

                            TimeSpan time_gap = DateTime.Now - this.timestamp;
                            block_time = time_gap.TotalSeconds; // time diff between block timestamp and time when hash found
                            
                            this.nonce_a = threadNonceA;
                            this.nonce_b = threadNonceB;
                            this.hash = currentHash;
                            handle.Set(); 
                        } 
                    }
                }).Start();
                waitHandles[i] = handle;
            }
            WaitHandle.WaitAny(waitHandles); 
        }

        public String Mine()
        {
            String hash = createHash();
            String re = new string('0', difficulty);

            while (!hash.StartsWith(re))
            {
                
                nonce_a++;
                hash = createHash();
            }
            
            TimeSpan time_gap = DateTime.Now - this.timestamp;
            this.block_time = time_gap.TotalSeconds;

            return hash;
        }

        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            this.fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transaction("Miner Rewards", minerAddress , (reward + fees), 0, ""); 
        }

        public override string ToString()
        {
            return "BLOCK: " + JsonConvert.SerializeObject(this);
        }

        public static String createMerkleRoot(List<Transaction> transactions)
        {
            List<String> hashes = transactions.Select(t => t.hash).ToList();

            if (hashes.Count == 0) 
            {
                return "";
            }
            if (hashes.Count == 1) 
            {
                return HashCode.HashTools.combineHash(hashes[0], hashes[0]);
            }
            while (hashes.Count != 1) 
            {
                List<String> merkleLeaves = new List<String>(); 

                for (int i = 0; i < hashes.Count; i += 2) 
                {
                    if (i == hashes.Count - 1)
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i]));
                    }
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i + 1]));
                    }
                }
                hashes = merkleLeaves; 
            }
            return hashes[0];
        }
    }
}
