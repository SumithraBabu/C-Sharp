using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class Program
    {
        static void Main(string[] args)
        {   List<VaccineDetails> Detail = new List<VaccineDetails>();
            List<BeneficiaryDetails> Beneficiary = new List<BeneficiaryDetails>();
            var a = new VaccineDetails(0, 2, "07/07/2000");
            var b = new VaccineDetails(1, 1, "08/08/2000");
            var c = new VaccineDetails(2, 1, "09/09/2000");
            var person1 = new BeneficiaryDetails("sumi", "Villupuram", 21, 1, 7339504211);
            var person2 = new BeneficiaryDetails("Mithran", "Chennai", 21, 0, 9842311220);
            var person3 = new BeneficiaryDetails("Shakshi", "Madurai", 21, 1, 6789546345);
                                                         
            do
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Enter the Process /n Beneficiary detail 1 /n Vaccination 2 /n Exit 3 ");
                Console.WriteLine("--------------------------------------------------");
                int Option = int.Parse(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        
                            Console.WriteLine("Beneficiary Registration Process");
                            Console.WriteLine("Enter the Beneficiary Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter your Age:");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your Gender:");
                            int gender = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter you city:");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter your Mobilenumber:");
                            long mobnum = long.Parse(Console.ReadLine());
                            Console.WriteLine("Your Registration Number is :");
                    case 2:

                        Console.WriteLine("Enter your Registration Number:");
                        int num = int.Parse(Console.ReadLine());
                        if (find)
                        {
                            Console.WriteLine("Enter the Vaccination Type:");
                            string DosageType = Console.ReadLine();
                        }



                }

            }


        }
    }
}
