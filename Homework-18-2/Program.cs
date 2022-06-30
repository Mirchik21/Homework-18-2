namespace Homework_18_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money som = new Money(800, "KGS", 80.0);
            Console.WriteLine("Amount is the soms : " + som.amount);
            Console.WriteLine("Currency code of soms: " + som.code);
            Console.WriteLine("USD Relation som is: " + som.usdRelation);
            Console.WriteLine();
            Money dollar = new Money(10, "USD", 80.0);
            Console.WriteLine("Amount is the dollars : " + dollar.amount);
            Console.WriteLine("Currency code of dollar: " + dollar.code);
            Console.WriteLine("USD Relation dollar is: " + dollar.usdRelation);
            Console.WriteLine();
            Money sum1 = som + dollar;
            Console.WriteLine("Amount is the sum1 : " + sum1.amount);
            Console.WriteLine("Currency code of sum1: " + sum1.code);
            Console.WriteLine("USD Relation sum1 is: " + sum1.usdRelation);
            Console.WriteLine();
            Money som1 = new Money(3500, "KGS", 80.0);
            Money dollar1 = new Money(10, "USD", 80.0);
            Money difference = som1 - dollar1;
            Console.WriteLine("Amount is the difference : " + difference.amount);
            Console.WriteLine("Currency code of difference: " + difference.code);
            Console.WriteLine("USD Relation difference is: " + difference.usdRelation);
            Console.WriteLine();
            if (som1 == dollar1)
                Console.WriteLine("They are equal");
            else
                Console.WriteLine("They are not equal");
           
            if (som1 > dollar1)
                Console.WriteLine("Som1 value greater than dollar1");
            else
                Console.WriteLine("The specified condition is not true");
        }

    }

    class Money
    {
        public int amount;
        public string code;
        public double usdRelation;
        public Money(int amount, string code, double usdRelation)
        {
            this.amount = amount;
            this.code = code;
            this.usdRelation = usdRelation;
        }
        public static Money operator +(Money table1, Money table2)
        {   
            double Conversion = (table1.amount / table2.usdRelation);
            double amount1 = Conversion + table2.amount;
            int amount = Convert.ToInt32(amount1);
            string code = table2.code;
            double usdRelation = table2.usdRelation;
            Money table = new Money(amount, code, usdRelation);
            return table;
        }
        public static Money operator -(Money table1, Money table2)
        {
            double Conversion = (table1.amount / table2.usdRelation);
            double amount1 = Conversion - table2.amount;
            int amount = Convert.ToInt32(amount1);
            string code = table2.code;
            double usdRelation = table2.usdRelation;
            Money table = new Money(amount, code, usdRelation);
            return table;
        }
        public static bool operator ==(Money table1, Money table2)
        {
            double convercion = (table1.amount / table2.usdRelation);
            int amount = Convert.ToInt32(convercion);
            if (amount == table2.amount)
                return true;
            return false;
        }
        public static bool operator !=(Money table1, Money table2)
        {
            double convercion = (table1.amount / table2.usdRelation);
            int amount = Convert.ToInt32(convercion);
            if (amount != table2.amount)
                return true;
            return false;
        }
        public static bool operator >(Money table1, Money table2)
        {
            double convercion = (table1.amount / table2.usdRelation);
            int amount = Convert.ToInt32(convercion);
            if (amount > table2.amount)
                return true;
            return false;
        }
        public static bool operator <(Money table1, Money table2)
        {
            double convercion = (table1.amount / table2.usdRelation);
            int amount = Convert.ToInt32(convercion);
            if (amount < table2.amount)
                return true;
            return false;
        }
    }
}