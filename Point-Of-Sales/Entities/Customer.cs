using System.Text.Json.Serialization;

namespace Point_Of_Sales.Entities
{
    public class Customer
    {
        public int Id { get; set; } 

        public string Email { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Purchase>? Purchases { get; set; }
    }
}
