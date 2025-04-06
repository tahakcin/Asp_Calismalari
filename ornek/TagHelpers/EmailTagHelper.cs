using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Diagnostics;

namespace ornek.TagHelpers
{
	public class EmailTagHelper: TagHelper
	//Bir sinifin TagHelper olabilmesi için TagHelper sinifindan turemesi gerekmektedir.

	{
        public string Mail { get; set; }
        public string Display{ get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
		//TagHelperin islevsellik gosterebilmesi icin Process metodunun override  edilmesi gerekir.
		//Context parametresi => Ilgili TagHelper'i getirmektedir. (Attributes, UniqueID...)
		//Output parametresi =>  Ilgili attribute'un ciktisini vermektedir.
		{
			output.TagName = "a";
			output.Attributes.Add("href",$"mailto:{Mail}");
			output.Content.Append(Display);
		}
	}


	

}
