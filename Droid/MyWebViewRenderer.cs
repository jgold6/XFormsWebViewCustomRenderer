using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Drawing;
using Android.Webkit;
using XFormsWebViewCustomRenderer;
using XFormsWebViewCustomRenderer.Droid;

[assembly: ExportRenderer (typeof (MyWebView), typeof (MyWebViewRenderer))]

namespace XFormsWebViewCustomRenderer.Droid
{
	public class MyWebViewRenderer : WebRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
		{
			base.OnElementChanged(e);
			if (e.OldElement == null) {
				// lets get a reference to the native control
				var webView = (global::Android.Webkit.WebView)Control;
				webView.SetWebViewClient(new MyWebViewClient());
				webView.SetInitialScale(-1);
			}
		}
    }

	public class MyWebViewClient : WebViewClient
	{
		public override bool ShouldOverrideUrlLoading(Android.Webkit.WebView view, string url)
		{
			base.ShouldOverrideUrlLoading(view, url);
			Console.WriteLine("Current Url: {0}", url);
			WebViewPage.CurrentUrl = url;
			return false;
		}
	}
}

