using System;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstname, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public string getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {

        return balance;
    }

    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is:" + currentUser.getBalance());
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //check if the user has enough money
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You're good to go! Thank you :)");
            }

        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4532772919527395", 1234, "John", "Griffith", 150.31));
        cardHolders.Add(new cardHolder("4532761841325802", 4321, "Ashley", "Jones", 321.13));
        cardHolders.Add(new cardHolder("5128381368581872", 9999, "Frida", "James", 850.31));
        cardHolders.Add(new cardHolder("6011188364697109", 2468, "Joe", "Smith", 1500000.31));
        cardHolders.Add(new cardHolder("34*/693153147110", 4826, "Skyler", "Halverson", 1500.31));

        //Prompt User
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert yout debit card: ");
        string debitCardNum = "";
        cardHolder currenUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //Check against our db
                currenUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currenUser != null) { break; }
                else { Console.WriteLine("Card not reconized. Please try again"); }
            }
            catch { Console.WriteLine("Card not reconized. Please try again"); }
        }
        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currenUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorret pin. Please try again"); }
            }
            catch { Console.WriteLine("Incorret pin. Please try again"); }
        }
        Console.WriteLine("Welcome " + currenUser.getFirstName() + " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currenUser); }
            else if (option == 2) { withdraw(currenUser); }
            else if (option == 3) { balance(currenUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day");
    }
}

