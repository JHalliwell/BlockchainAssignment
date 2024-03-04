using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlockchainAssignment.HashCode
{
    static class HashFinder
    {
        private static int currentNonce = 0;
        private static int finalNonce = 0;
        private static string finalHash = "";
        private static bool found = false;

        private delegate void FindHashDelegate(Block block, String prefix);

        private static void FindHash(Block block, String prefix)
        {
            int localNonce;

            while (!found)
            {
                // Atomically increment current nonce and retrieve previous value
                localNonce = Interlocked.Increment(ref currentNonce) - 1;

                String hash = Block.CreateHash(block, localNonce);

                if (isValidHash(hash))
                {
                    found = true; // Signal other threads to stop
                    finalNonce = localNonce; // Set final nonce
                    finalHash = hash;
                    break;
                }
            }
        }

        private static bool isValidHash(String hash)
        {
            // Determine the required amount of leading 0s based on difficulty
            int leadingZeros = 1 + ((Blockchain.difficulty + 1) / 9);
            String requiredStart = new string('0', leadingZeros);

            if (!hash.StartsWith(requiredStart)) return false;

            int characterIndex = leadingZeros + 4;

            Console.WriteLine($"Starting zeros: {leadingZeros}");

            // If difficulty is within the range that requires checking the next character
            if ((Blockchain.difficulty - 1) % 8 != 0)
            {
                string validChars = GetValidCharsForDifficulty();
                Console.WriteLine($"Followed by any from: {validChars}");
                // Ensure the character at the specified index is within the allowed range
                if (characterIndex < hash.Length && validChars.Contains(hash[characterIndex]))
                {
                    return true;
                }
                return false;
            }

            return true;
        }

        private static string GetValidCharsForDifficulty()
        {
            // Generate valid characters based on difficulty
            int validCharCount;
            // Adjust allowed characters based on difficulty
            validCharCount = 16 - 2 * ((Blockchain.difficulty - 1) % 8);
            // Generate a string of hexadecimal characters of length validCharCount.
            String chars = string.Join(
                "",
                Enumerable.Range(0, validCharCount).Select(i => i.ToString("x"))
            ); 
            return chars;
        }

        public static (int, String) StartMining(Block block, int numberOfThreads, String prefix) 
        {
            found = false;
            currentNonce = 0;
            finalNonce = 0;

            Thread[] threads = new Thread[numberOfThreads];

            // Create instance of delegate pionting to the ProofOfWork function
            FindHashDelegate proofOfWork = new FindHashDelegate(FindHash);

            for (int i = 0; i < numberOfThreads; i++)
            {
                // Use delegate instance to start threads
                threads[i] = new Thread(() => proofOfWork(block, prefix));
                threads[i].Start();
            }

            // Wait until threads are complete to continue with main process
            for (int i = 0; i < numberOfThreads; i++)
            {
                threads[i].Join();
            }

            return (finalNonce, finalHash);
        }
    }
}
