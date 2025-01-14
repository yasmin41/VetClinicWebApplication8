using System.ComponentModel.DataAnnotations;

namespace VetClinicWebApplication8.Models
{
    public class Owner_Pet

    {
        [Key] 
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; }
        public string PetName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public DateTime Pet_BD { get; set; }
        public string Species { get; set; }

        public string Breed { get; set; }

        public int VacDose { get; set; }
        public DateTime Vac_Date { get; set; } = DateTime.Now;
        public DateTime NextVac_Date { get; set; }

        public string Deworming { get; set; }
        public DateTime DE_Date { get; set; } = DateTime.Now;
        public DateTime NextDe_Date { get; set; }

    }
}
