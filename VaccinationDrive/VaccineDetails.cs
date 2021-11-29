using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class VaccineDetails
    {
        public int Dosage { get; set; }
        public VaccinationType DoseType { get; set; }
        public string  Date { get; set; }

        public VaccineDetails(int dose, int dosetype, string  date)
        {
            this.Date = date;
            this.Dosage = dose;
            this.DoseType = (VaccinationType)dosetype;
        }
    }      
    public enum VaccinationType
    {
        Covaxin = 0,
        Covidshield = 1,
    }
}
  
    
      

