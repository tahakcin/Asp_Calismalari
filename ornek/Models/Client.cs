using Microsoft.AspNetCore.Mvc;
using ornek.Models.ModelMetadataTypes;
using System.ComponentModel.DataAnnotations;

namespace ornek.Models
{
    [ModelMetadataType(typeof(ClientMetadata))]
	public class Client
	{
        //[Required(ErrorMessage = "Lütfen client name'i giriniz.")]
        //[StringLength(100,ErrorMessage = "Client name en fazla 100 karakterden oluşabilir.")]
        public string  ClientName { get; set; }
        public int ClientId { get; set; }
        //[EmailAddress(ErrorMessage = "Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }
    }
}
