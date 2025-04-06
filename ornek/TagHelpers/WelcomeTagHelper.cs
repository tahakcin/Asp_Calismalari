using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ornek.TagHelpers
{
	public class WelcomeTagHelper : TagHelper
	{
		public string Name { get; set; }

		public string WelcomeMessage { get; } = "I'm very happy that your name included in my ASP.NET exercise :)";
		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			
			output.TagName  = "p";
			output.Content.SetHtmlContent($"Welcome <strong>{Name}</strong>! {WelcomeMessage}");
		}
	}
}
