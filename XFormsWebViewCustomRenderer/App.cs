using System;
using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.Generic;


namespace XFormsWebViewCustomRenderer
{
	public class App
	{
		public static Page GetMainPage()
		{	
		
			return new WebViewPage();
		}
	}

	public partial class WebViewPage : ContentPage {

		public static string CurrentUrl {get; set;}

		public WebViewPage ()
		{

			StackLayout objStackLayout = new StackLayout()
			{
			};

			MyWebView webView = new MyWebView();
			WebViewPage.CurrentUrl = "http://www.example.com";
			webView.Source = WebViewPage.CurrentUrl;

			webView.HeightRequest = 300;
			objStackLayout.Children.Add(webView);

			Button cmdButton1 = new Button();
			cmdButton1.Text = "Show Me Current Url";
			objStackLayout.Children.Add(cmdButton1);
			//
			cmdButton1.Clicked += ((o2, e2) =>
			{
				System.Diagnostics.Debug.WriteLine(CurrentUrl);
			});

			this.Content = objStackLayout;
		}
	}

	public class MyWebView : WebView {}

}

