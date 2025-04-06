using Microsoft.AspNetCore.Mvc;
using ornek.Models.ModelMetadataTypes;

namespace ornek.Models
{
    [ModelMetadataType(typeof(CustomerMetadata))]
	public class Customer
	{
        public string CustomerName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
