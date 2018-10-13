using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestFixture]

    public class AccountTests
    {

        /*// leave for later
        [Test]
        public void Test_Client_CTR()
        {
            Test_Client
        }
        */ // leave for later

        [Test]
        public void Test_LName_Prop()
        {
            //arrange
            Client myClient = new Client();

            //action

            myClient.LName = "Doh";
            string response = myClient.LName;

            //assert

            Assert.That(response, Is.EqualTo("Doh"));
        }

        [Test]
        public void Test_FName_Prop()
        {
            //arrange
            Client myClient = new Client();

            //action

            myClient.FName = "John";
            string response = myClient.FName;

            //assert

            Assert.That(response, Is.EqualTo("John"));
        }

        [Test]
        public void Test_AccountNum_Prop()
        {
            //arrange
            Client myClient = new Client();

            //action

            myClient.AccountNum = "0101010";
            string response = myClient.AccountNum;

            //assert

            Assert.That(response, Is.EqualTo("0101010"));
        }

        [Test]
        public void Test_Client_Menu_CTR()
        {
            //arrange
            Client myClient = new Client("John", "Doh", "0101010");

            //action


            string response = myClient.GetConstString();

            //assert

            Assert.That(response, Is.EqualTo("Welcome " + myClient.FName + " " + myClient.LName + ". Your Acount number is " + myClient.AccountNum));

        }

        [Test]
        public void Test_Account_CTR()
        {
            //arrange
            Account myAccount = new Account();

            //action

            myAccount.AcctBal = 0;
            double response = myAccount.AcctBal;

            //assert

            Assert.That(response, Is.EqualTo(0));
        }

        [Test]
        public void Test_Client_CTR_1_Para()
        {
            //arrange
            Client myClient = new Client(0);

            //action


            double response = myClient.AcctBal;

            //assert

            Assert.That(response, Is.EqualTo(0));

        }
        [Test]
        public void Test_Deposit_Prop()
        {
            //arrange
            Account myAccount = new Account();

            //action

            myAccount.Deposit = 0;
            double response = myAccount.Deposit;

            //assert

            Assert.That(response, Is.EqualTo(0));
        }

        [Test]
        public void Test_Withdraw_Prop()
        {
            //arrange
            Account myAccount = new Account();

            //action

            myAccount.Withdraw = 0;
            double response = myAccount.Withdraw;

            //assert

            Assert.That(response, Is.EqualTo(0));
        }

        [Test]
        public void Test_Withdraw_Method()
        {
            //arrange
            Account myAccount = new Account();

            //action

            double response = myAccount.GetWithdraw(0);

            //assert

            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Deposit_Method()
        {
            //arrange
            Account myAccount = new Account();

            //action

            double response = myAccount.GetDeposit(0);

            //assert

            Assert.That(response, Is.EqualTo(0));
        }

        [Test]
        public void Test_Account_Type_Prop()
        {
            //arrange
            Account myAccount = new Account();

            //action

            myAccount.AcctType = " ";
            string response = myAccount.AcctType;

            //assert

            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Test_Checking_Account_CTR()
        {
            //arrange
            Account myAccount = new Account();

            //action

            myAccount.AcctBal = 110;
            double response = myAccount.AcctBal;

            //assert

            Assert.That(response, Is.EqualTo(110));
        }

        [Test]
        public void Test_Checking_Deposit_Method()
        {
            //arrange
            Account myAccount = new Account();

            //action
            myAccount.AcctBal = 5;
            double response = myAccount.GetDeposit(110);

            //assert

            Assert.That(response, Is.EqualTo(115));
        }

        [Test]
        public void Test_Checking_Withdraw_Method()
        {
            //arrange
            Account myAccount = new Account();

            //action
            myAccount.AcctBal = 300;
            double response = myAccount.GetWithdraw(100);

            //assert

            Assert.That(response, Is.EqualTo(200));
        }
        [Test]
        public void Test_Savings_Min_Balance_Prop()
        {
            //arrange
            Savings mySavingsAccount = new Savings();

            //action

            mySavingsAccount.MinBal = 150;
            double response = mySavingsAccount.MinBal;

            //assert

            Assert.That(response, Is.EqualTo(150));
        }

        [Test]
        public void Test_AccountNum_Prop_Account_Class()
        {
            //arrange
            Account myAccount = new Account();

            //action

            myAccount.AccountNum = "0101010";
            string response = myAccount.AccountNum;

            //assert

            Assert.That(response, Is.EqualTo("0101010"));
        }

        [Test]
        public void Test_Account_GetBalance__Method()
        {
            //arrange
            Account myAccount = new Account();

            //action
            myAccount.AcctBal = 300;
            double response = myAccount.GetBalance();

            //assert

            Assert.That(response, Is.EqualTo(300));
        }

        [Test]
        public void Test_Checking_Class_CTR()
        {
            //arrange
            Checking myAccount = new Checking();

            //action

            myAccount.AcctType = "Checking";
            string response = myAccount.AcctType;

            //assert

            Assert.That(response, Is.EqualTo("Checking"));
        }

        [Test]
        public void Test_Savings_Class_CTR()
        {
            //arrange
            Savings myAccount = new Savings();

            //action

            myAccount.AcctType = "Savings";
            string response = myAccount.AcctType;

            //assert

            Assert.That(response, Is.EqualTo("Savings"));
        }

    }
}
