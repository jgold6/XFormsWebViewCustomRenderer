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

		public WebViewPage ()
		{

			MyWebView webView = new MyWebView();
			webView.Source = "http://www.example.com";

			this.Content = webView;
		}
	}

	public class MyWebView : WebView {}

}

