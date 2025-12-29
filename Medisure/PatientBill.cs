
namespace MediSureClinic
{
    /// <summary>
    /// the patient bill class 
    /// </summary>
    public class PatientBill
    {
        public string? BillId;
        public string? PatientName;
        public bool HasInsurance;
        public decimal ConsultationFee;
        public decimal LabCharges;
        public decimal MedicineCharges;
        public decimal GrossAmount;
        public decimal DiscountAmount;
        public decimal FinalPayable;
    }

    /// <summary>
    /// billing Service is the class for teh 
    /// </summary>
    public class Billing
    {
        public static PatientBill LastBill;
        public static bool HasLastBill = false;

        /// <summary>
        /// create new bill function 
        /// </summary>
        public void CreateNewBill()
        {
            PatientBill bill = new PatientBill();

            Console.Write("Enter Bill Id: ");
            bill.BillId = Console.ReadLine();

            //here validation for the bill 
            if (string.IsNullOrWhiteSpace(bill.BillId))
            {
                Console.WriteLine("Bill Id cannot be empty.");
                return;
            }

            Console.Write("Enter Patient Name: ");
            bill.PatientName = Console.ReadLine();

            Console.Write("Is the patient insured? (Y/N): ");
            string insuranceInput = Console.ReadLine();

            if (insuranceInput == "Y" || insuranceInput == "y")
                bill.HasInsurance = true;
            else if (insuranceInput=="N" || insuranceInput == "n")
                bill.HasInsurance = false;
            else{
                Console.WriteLine("enter valid input");
                return;
            }

            Console.Write("Enter Consultation Fee: ");
            bill.ConsultationFee = Convert.ToDecimal(Console.ReadLine());

            if (bill.ConsultationFee <= 0)
            {
                Console.WriteLine("Consultation Fee must be greater than 0.");
                return;
            }

            Console.Write("Enter Lab Charges: ");
            bill.LabCharges = Convert.ToDecimal(Console.ReadLine());

            if (bill.LabCharges < 0)
            {
                Console.WriteLine("Lab Charges cannot be negative.");
                return;
            }

            Console.Write("Enter Medicine Charges: ");
            bill.MedicineCharges = Convert.ToDecimal(Console.ReadLine());

            if (bill.MedicineCharges < 0)
            {
                Console.WriteLine("Medicine Charges cannot be negative.");
                return;
            }

            // BILL CALCULATIONS
            bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

            if (bill.HasInsurance)
                bill.DiscountAmount = bill.GrossAmount * 0.10m;
            else
                bill.DiscountAmount = 0;

            bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

            LastBill = bill;
            HasLastBill = true;

            Console.WriteLine("\nBill created successfully.");
            Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
            Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
            Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
        }

        // 2. VIEW LAST BILL
        public void ViewLastBill()
        {
            if (!HasLastBill)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            Console.WriteLine("\n----------- Last Bill -----------");
            Console.WriteLine($"BillId: {LastBill.BillId}");
            Console.WriteLine($"Patient: {LastBill.PatientName}");
            Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
            Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
            Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
            Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
            Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
            Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
            Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
            Console.WriteLine("--------------------------------");
        }

        // 3. CLEAR LAST BILL
        public void ClearLastBill()
        {
            LastBill = null;
            HasLastBill = false;
            Console.WriteLine("Last bill cleared.");
        }
    }


}

