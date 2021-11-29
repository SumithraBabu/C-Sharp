using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
   
    class BeneficiaryDetails
    {
        public List<VaccineDetails> VaccinationDetails { get; set; }
        public static int Number = 1001;
        public string BeneficiaryName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public long MobileNumber { get; set; }
        public int RegistrationNumber { get; set; }
        public BeneficiaryDetails(string name, string address, int age, int gender, long mobnum)
        {
            this.BeneficiaryName = name;
            this.City = address;
            this.Age = age;
            this.MobileNumber = mobnum;
            this.Gender = (GenderType)gender;
            RegistrationNumber = Number++;
        }
      
    }
  
    
    public void VaccinationDetails(string name,string address, int age, int gender, long mobnum,int dose, int dosetype,string date)
    {
        if()
    }
    public void DueDate(string name, string adress, int age, int gender, long mobnum, int dose, int dosetype,string date)
    {
        if()
    
    }

    public enum GenderType
    {
        Male =0,
        Female=1,
        others =2,
    }
    
   

}
