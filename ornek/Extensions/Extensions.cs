using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ornek.Extensions
{
	static public class Extensions
	{
		//Extension metodu ile class veya struct yapilarinin tipleri bozulmadan bu yapilara metot eklenmesi saglanir.

		public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value = "", string placeHolder = "", string id = "") //htmlHelper turundeki nesnelere CustomTextBox isimli fonsiyonu extension olarak ekleyebilmemiz icin this keyword'u kullanilir.	
		=>
			htmlHelper.TextBox(name,value,new {
			style = "background-color: green; color: white; font-size: 20px;",
			@class = "form-input",
			placeholder = placeHolder,
			id = id
			});
		// Artık bu metot, html ifadesi yazildiktan sonra nokta koyulunca intellisense ile onerilerde gelmiş olur. 
	}
}
