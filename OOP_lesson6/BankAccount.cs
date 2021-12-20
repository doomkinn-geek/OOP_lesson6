﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lesson6
{
    public enum AccountType
    {
        Current, //текущий
        Checking, //расчетный
        Credit, //кредитный        
        Deposit, //депозитный
        Social //социальный
    }
    public class BankAccount
    {
        public long AccountNumber
        {
            get => _accountNumber;
            set { _accountNumber = value; }
        }
        public decimal Balance
        {
            get => _balance;
            set { _balance = value; }
        }
        public AccountType Type
        {
            get => _type;
            set { _type = value; }
        }
        private long _accountNumber;
        private decimal _balance;
        private AccountType _type;

        private static long _baseAccountNumber = 11111111111111;
        public override string ToString() => $"Номер счета - {AccountNumber}, Баланс - {Balance}, Тип счета - {Type}";
        private long GenerateAccountNumber()
        {
            return _baseAccountNumber++;
        }

        public BankAccount()
        {
            AccountNumber = GenerateAccountNumber();
            Balance = 0;
        }

        public BankAccount(decimal balance, AccountType type)
        {
            AccountNumber = GenerateAccountNumber();
            Balance = balance;
            Type = type;
        }

        public BankAccount(decimal balance)
        {
            AccountNumber = GenerateAccountNumber();
            Balance = balance;
        }

        public BankAccount(AccountType type)
        {
            AccountNumber = GenerateAccountNumber();
            Balance = 0;
            Type = type;
        }

        public void GetMoney(decimal amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете");
            }
        }

        public void IncreaseBalance(decimal amount)
        {
            this.Balance += amount;
        }

        public override bool Equals(object obj)
        {
            if ((BankAccount)obj == this)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(BankAccount b1, BankAccount b2)
        {
            if (b1.Type == b2.Type && b1.Balance == b2.Balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(BankAccount b1, BankAccount b2)
        {
            if (b1.Type == b2.Type && b1.Balance == b2.Balance)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
