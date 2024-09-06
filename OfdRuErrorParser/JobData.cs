using System;

namespace OfdRuErrorParser
{
    internal class Receipt
    {
        public Operation operation;
        public Position[] items;
        public CorrectionData correction = new CorrectionData();
        public Payment payment = new Payment();
        public double total;
    }

    internal class Operation
    {
        public bool income;
        public bool refund;

        public Operation(int value) =>
            (income, refund) = (value/3==0, value % 2 == 0);

        public Operation(string value) =>
            (income, refund) = (value.EndsWith("ncome"), value.StartsWith("Refund"));

        public Operation(string value, bool isRevoke) =>
            (income, refund) = (value.EndsWith("ncome"), value.StartsWith("Refund") == !isRevoke);
    }

    internal class Payment
    {
        public double cash = 0;
        public double ecash = 0;
        public double prepaid = 0;
        public double credit = 0;
    }

    internal class CorrectionData
    {
        public DateTime date;
        public string sign;
        public string orderId = " ";
    }

    internal class Position
    {
        public string name = "";
        public double quantity = 1;
        public double price;
        public double total = -1;
        public int tax = -1;
        public int measure = -1;
        public int type = -1;
        public int payment = 4;
    }
}
