// MAIN MENU
//using MediSureClinic;
using Quickmart;
    class Program
    {
        static void Main(string[] args)
        {

            #region MediSureClinic
            /*
            Billing service = new Billing();
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\n================== MediSure Clinic Billing ==================");
                Console.WriteLine("1. Create New Bill (Enter Patient Details)");
                Console.WriteLine("2. View Last Bill");
                Console.WriteLine("3. Clear Last Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        service.CreateNewBill();
                        break;

                    case "2":
                        service.ViewLastBill();
                        break;

                    case "3":
                        service.ClearLastBill();
                        break;

                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            */
            #endregion

            #region QuickMart
            TransactionService service = new TransactionService();

              while (true)
              {
                  Console.WriteLine("\n================== QuickMart Traders ==================");
                  Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                  Console.WriteLine("2. View Last Transaction");
                  Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                  Console.WriteLine("4. Exit");
                  Console.Write("Enter your option: ");
      
                  string choice = Console.ReadLine();
      
                  switch (choice)
                  {
                      case "1":
                          service.CreateTransaction();
                          break;
      
                      case "2":
                          service.ViewLastTransaction();
                          break;
      
                      case "3":
                          service.RecalculateProfitLoss();
                          break;
      
                      case "4":
                          Console.WriteLine("\nThank you. Application closed normally.");
                          return;
      
                      default:
                          Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                          break;
                  }
              }

            #endregion
        
        }
    }
