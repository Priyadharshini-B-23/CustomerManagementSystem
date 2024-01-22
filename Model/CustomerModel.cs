using System.ComponentModel.DataAnnotations;

namespace Customer.Data
{
    public class Customer

    {
        [Key]
        public int Customer_Id { get; set; }

        [Required]

        public string? Customer_Name { get; set; }

        [Required]

        public string? Customer_Location { get; set; }

        [Required]

        public long Customer_PhNum { get; set; }



    }
}