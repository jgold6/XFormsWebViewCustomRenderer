using System;
using Xamarin.Forms;
using XFormsWebViewCustomRenderer;
using XFormsWebViewCustomRenderer.iOS;
using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;
using System.Drawing;
using System.Collections.Generic;
using System.Collections.Concurrent;
using MonoTouch.Foundation;


[assembly: ExportRenderer (typeof (MyWebView), typeof (MyWebViewRenderer))]

namespace XFormsWebViewCustomRenderer.iOS
{
	public class MyWebViewRenderer : WebViewRenderer
    {
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) {   // perform initial setup
				// lets get a reference to the native control
				var webView = (UIWebView)this.NativeView;
				webView.ScalesPageToFit = true;
				webView.LoadFinished += (object sender2, EventArgs e2) => {
					Console.WriteLine("Load Finished {0}", webView.Request.Url.AbsoluteString);
					WebViewPage.CurrentUrl = webView.Request.Url.AbsoluteString;
				};
			}
		}
    }
}

