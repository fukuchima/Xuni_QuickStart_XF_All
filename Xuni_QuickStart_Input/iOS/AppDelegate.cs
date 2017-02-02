using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Xuni_QuickStart.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Xuniのコンポーネントを初期化
			Xuni.Forms.Input.Platform.iOS.Forms.Init();
			Xuni.Forms.Calendar.Platform.iOS.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
