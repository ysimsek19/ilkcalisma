using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ilkcalisma
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//Response.Write("yalçın şimşek");
			//string[] liste = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

			//Dictionary<string, string> liste = new Dictionary<string, string>();
			//	liste.Add("Sun", "1.jpg");
			//	liste.Add("Mon", "2.jpg");
			//	liste.Add("Tue", "3.jpg");
			//	liste.Add("Wed", "4.jpg");
			//	liste.Add("Thu", "5.jpg");
			//	liste.Add("Fri", "6.jpg");
			//	liste.Add("Sat", "7.jpg");
			//	//foreach (var aaaa in liste)
			//	//{
			//	//	list.InnerHtml += @"<li>"+aaaa+"</li>";

			//	//}
			//	//for (int i = 0; i < liste.Count(); i++)
			//	foreach (var y in liste)
			//	{
			//	list.InnerHtml += @"<div class=""item""> <img class=""ui avatar image"" src="""+y.Value+@"""/><div class=""content""> <div class=""header""> "+y.Key+"</div></div></div>";

			//	}
			//string yalcin = "KADIN";
			//if (yalcin == "ERKEK")
			//{ Response.Write("doğru"); }
			//else
			//{
			//	Response.Write("yanlış");
			//}
			//int myNum;
			//myNum = 15;
			//string mesaj = "doğru";
			////Response.Write(myNum);
			//if (20 > myNum)

			//	Response.Write(mesaj);


			//else

			//	Response.Write("Yanlış p");

			////Response.Write((14 > myNum) ?"doğru" : "y");
			//string txt = "<br/>We are the so-called \"Vikings\" from the north.";
			//Response.Write(txt);
			int x = 10;
			int y = 20;
			int z = x + y;
			int a = z + 10;
			int d = a + 10;

			Response.Write(d);





		}


		
	}
}