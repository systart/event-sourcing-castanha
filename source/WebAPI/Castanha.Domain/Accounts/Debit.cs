﻿namespace Castanha.Domain.Accounts
{
    using Castanha.Domain.ValueObjects;

    public class Debit : Transaction
    {
        public Debit(Amount amount)
            : base(amount)
        {
        }

        public Debit(System.Guid transactionId, Amount amount, System.DateTime transactionDate)
            : base(amount, transactionDate)
        {
            Id = transactionId;
        }

        public override string Description
        {
            get
            {
                return "Debit";
            }
        }
    }
}