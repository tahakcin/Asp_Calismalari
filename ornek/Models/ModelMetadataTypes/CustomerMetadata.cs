using System.ComponentModel.DataAnnotations;

namespace ornek.Models.ModelMetadataTypes
{
	public class CustomerMetadata
	{
        [Required(ErrorMessage = "Please enter a customer name.")]
        [StringLength(100,ErrorMessage = "Name field can included at most 100 characters.")]
        public string CustomerName { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a correct email address.")]
        public string Email { get; set; }
    }
}
