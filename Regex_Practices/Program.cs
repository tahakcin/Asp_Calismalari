using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Practices
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Regular Expression Operators
			#region ^ Operatörü
			// "^" operatörü : Satır başının istenilen ifadeyle başlamasını sağlar.
			//string data = "98324y983hdfjksdnb<k<ö";
			//string data2 = "jksdcjklwhe98rh2uıhdqjkwdnças";
			//Regex regex = new Regex("^9");
			//Match match = regex.Match(data);
			//Match match2 = regex.Match(data2);
			//Console.WriteLine(match.Success);
			//Console.WriteLine(match2.Success);
			#endregion
			#region \ Operatörü
			// \ operatörü : Belirli bir karakter grubu içerilmesi isteniyorsa kullanılır.

			// \D : Rakam olmayan tek bir karakterin bulunmasını belirtir.
			// \d : 0-9 arasında tek bir sayı oalcağını belirtir.

			// \W : Alfanümerik olmayan	karakterin olması gerektiğini belirtir.
			// \w : Alfanümerik olan karakterin olacağını belirtir.

			// \S : Tab ve Space dışında herhangi bir karakterin olabileceğini belirtir.
			// \s : Sadece bosluk karakterinin olacağını belirtir.

			// Örnek:  9 ile baslayıp ikinci karakteri herhangi bir sayı olan, 3. karakteri de bosluk olmayan ifade.
			//string data = "93fkdn93hlkw0w";
			//string data2 = "93 kdn93hlkw0w";
			//Regex regex = new Regex(@"^9\d\S");
			//Match match = regex.Match(data);
			//Match match2 = regex.Match(data2);
			//         Console.WriteLine(match.Success);
			//         Console.WriteLine(match2.Success);









			#endregion
			#region + Operatörü
			// Önündeki ifadenin bir veya daha fazla kullanılabileceğini belirtir.
			// Örnek:  9 ile baslayan, arada sayısal degerleri olan, son karakteri de bosluk olmayan ifade.
			//string data = "915648248324798329823978G";
			//string data2 = "9f12983dG";
			//Regex regex = new Regex(@"^9\d+\S");
			//Match match = regex.Match(data);
			//Match match2 = regex.Match(data2);
			//Console.WriteLine(match.Success);
			//Console.WriteLine(match2.Success);


			#endregion
			#region | operatörü
			//Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabileceği belirtilmek isteniyorsa kullanılır. 
			//Örnek: baş harfi a ya da b ya da c olan metinsel ifade

			//string data = "ahmet";
			//string data2 = "taha";

			//Regex regex = new Regex(@"^a|b|c");
			//Match match = regex.Match(data);
			//Console.WriteLine(match.Success);
			//Match match2 = regex.Match(data2);
			//Console.WriteLine(match2.Success);

			#endregion
			#region {} Operatörü
			// Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmelidir.
			//string data = "555-5555555";
			//string data2 = "5555555555";
			//Regex regex = new Regex(@"\d{3}-\d{7}");
			//Match match = regex.Match(data);
			//Console.WriteLine(match.Success);
			//Match match2 = regex.Match(data2); 
			//Console.WriteLine(match2.Success);


			#endregion
			#region ? Operatörü
			//Bu karakterin önüne gelen karakter en fazla bir en az da sıfır olabilmektedir. Yani ya vardır (1 adet ) ya da yoktur tarzında düşünülebilir.	

			//string data = "342AB";
			//string data2 = "854B";
			//string data3 = "837AAB";
			//Regex regex = new Regex(@"\d{3}A?B");
			//Match match = regex.Match(data);
			//Console.WriteLine(match.Success);
			//Match match2 = regex.Match(data2);
			//Console.WriteLine(match2.Success);
			//Match match3 = regex.Match(data3);
			//Console.WriteLine(match3.Success);

			#endregion
			#region . Operatörü
			// /n karakteri hariç kullanıldıgı zaman herhangi bir karakterin bulunabilecegini belirtir.

			//string data = "342fhwlA";
			//string data2 = "854ABA";
			//string data3 = "837AAA";
			//Regex regex = new Regex(@"\d{3}.A");
			//Match match = regex.Match(data);
			//Console.WriteLine(match.Success);
			//Match match2 = regex.Match(data2);
			//Console.WriteLine(match2.Success);
			//Match match3 = regex.Match(data3);
			//Console.WriteLine(match3.Success);
			////"837AAA" eşleşir çünkü sonunda fazladan bir 'A' olmasına rağmen "837A" regex tarafından coktan match edilir. 



			#endregion
			#region \b ve \B Operatörü
			// \B : Kelimenin basında ya da soınunda olmaması gereken karakterler belirtlir.
			// \b : İlgili kelimenin belirtilen karakter dizisi ile sonlanmasını saglar.


			//string data = "342fhwldır";
			//string data2 = "dır854ABA";
			//string data3 = "837dırAAA";
			//Regex regex = new Regex(@"\d{3}dır\B");
			//Match match = regex.Match(data);
			//Console.WriteLine(match.Success);
			//Match match2 = regex.Match(data2);
			//Console.WriteLine(match2.Success);
			//Match match3 = regex.Match(data3);
			//Console.WriteLine(match3.Success);

			//string data4 = "854dır";
			//string data5 = "837dırAAA";
			//string data6 = "854ABAdır";
			//Regex regex2 = new Regex(@"\d{3}dır\b");
			//Match match4 = regex2.Match(data4);
			//Console.WriteLine(match4.Success);
			//Match match5 = regex2.Match(data5);
			//Console.WriteLine(match5.Success);
			//Match match6 = regex2.Match(data6);
			//Console.WriteLine(match6.Success);




			#endregion
			#region [] Operatörü
			//[Karakter aralığı]
			//Ayrıca özel karakterlerin yerinde yazılmasını da ifade eder.

			//string data = "123P";
			//string data2 = "298C";
			//Regex regex = new Regex(@"\d{3}[A-E]");
			//Match match = regex.Match(data);
			//Console.WriteLine(match.Success);
			//Match match2 = regex.Match(data2);
			//Console.WriteLine(match2.Success);

			string data3 = "(554) 254 85 96";
			string data4 = "5542659857";
			Regex regex2 = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
			Match match3 = regex2.Match(data3);
			Match match4 = regex2.Match(data4);
            Console.WriteLine(match3.Success);
            Console.WriteLine(match4.Success);

			#endregion

			#endregion
		}
	}
}
