using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ornek.Models.ModelMetadataTypes
{
	public class ClientMetadata 
	{
        [Required(ErrorMessage ="Müşteri ismi boş bırakılamaz!")]
        [StringLength(100,ErrorMessage ="Müşteri ismi uzunluğu 100 karakterden fazla olamaz.")]
        public string ClientName { get; set; }
        [EmailAddress(ErrorMessage ="Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }
    }
}
