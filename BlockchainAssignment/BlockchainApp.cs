using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;

        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            updateMainTB("New Blockchain Initialised!");
        }

        private void updateMainTB(String text)
        {
            mainConsoleTB.Text = text;
        }

        private void printBlockBtnClick(object sender, EventArgs e)
        {
            int index = 0;

            if(Int32.TryParse(textBox1.Text, out index))
            {
                updateMainTB(blockchain.getBlockAsString(index));
            }
        }

        private void generateWalletBtnClick(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            publicKeyTB.Text = myNewWallet.publicID;
            privateKeyTB.Text = privKey;
        }

        private void validateKeysBtnClick(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKeyTB.Text, publicKeyTB.Text))
            {
                updateMainTB("Keys are valid");
            }
            else
            {
                updateMainTB("Keys are Invalid");
            }
        }

        private void createTransactionBtnClick(object sender, EventArgs e)
        {
            double amount, fee;

            if (!double.TryParse(amountTB.Text, out amount))
            {
                MessageBox.Show("Invalid input for amount. Please enter a valid number.");
            }
            if (!double.TryParse(feeTB.Text, out fee))
            {
                MessageBox.Show("Invalid input for fee. Please enter a valid number.");
            }

            double newBalance = blockchain.getBalance(publicKeyTB.Text) - amount + fee;

            if(true)
            {
                Transaction newTransaction = new Transaction(
                    publicKeyTB.Text,
                    receiverKeyTB.Text,
                    amount,
                    fee,
                    privateKeyTB.Text
                );

                blockchain.addToTransactionPool(newTransaction);

                updateMainTB(newTransaction.ToString());
            }
            else
            {
                MessageBox.Show(
                    $"You do not have sufficient funds for this transaction." +
                    $"\nYou're trying to send: {amount}" +
                    $"\nWith a fee of: {fee}" +
                    $"\nBut have a balance of: {blockchain.getBalance(publicKeyTB.Text)}",
                    "Transaction Error"
                );

            }
        }

        private void generateBlockBtnClick(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getPendingTransactions(transactionPreferenceCB.Text);
            Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicKeyTB.Text);
            blockchain.blocks.Add(newBlock);

            updateMainTB(blockchain.ToString()); 
        }

        private void validateChainBtnClick(object sender, EventArgs e)
        {
            // Contiguity Checks
            bool isValid = true;

            if(blockchain.blocks.Count == 1)
            {
                if (!Blockchain.ValidateMerkleRoot(blockchain.blocks[0]))
                {
                    updateMainTB("Blockchain is invalid");
                }
                else
                {
                    updateMainTB("Blockchain is valid");
                }
                return;
            }

            for(int i = 1; i< blockchain.blocks.Count - 1; i++)
            {
                // Compare neighbouring hash/previous hash for blocks in the blockchain
                // and check transactions via merkle root
                if (
                    blockchain.blocks[i].prevHash != blockchain.blocks[i - 1].hash
                        || Blockchain.ValidateHash(blockchain.blocks[i])
                        || !Blockchain.ValidateMerkleRoot(blockchain.blocks[i])
                )
                {
                    updateMainTB("Blockchain is invalid");
                    return;
                }
            }

            if(isValid)
            {
                updateMainTB("Blockchain is valid");
            }
            else
            {
                updateMainTB("Blockchain is invalid");
            }
        }

        private void checkBalanceBtnClick(object sender, EventArgs e)
        {
            updateMainTB(blockchain.getBalance(publicKeyTB.Text).ToString() + " Sickle Coins");
        }

        private void readAllBtnClick(object sender, EventArgs e)
        {
            updateMainTB(blockchain.ToString());
        }

        private void readPendingTransactionsBtnClick(object sender, EventArgs e)
        {
            updateMainTB(String.Join("\n", blockchain.transactionPool));
        }
    }
}
