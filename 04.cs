BankAccount account = new BankAccount("Ana");

account.Deposit(100);
account.Deposit(50);
account.ShowBalance();

account.Withdraw(30);
account.ShowBalance();

account.Withdraw(500);
account.ShowBalance();

class BankAccount {
  public string Owner;
  public double Balance;

  public BankAccount(string owner) {
    Owner = owner;
    Balance = 0;
  }

  public void Deposit(double amount) {
    if (amount > 0) {
      Balance += amount;
    }
  }

  public void Withdraw(double amount) {
    if (amount > 0 && amount <= Balance) {
      Balance -= amount;
    } else {
      Console.WriteLine("Withdrawal rejected.");
    }
  }

  public void ShowBalance() {
    Console.WriteLine($"{Owner}'s balance: {Balance}");
  }
}
