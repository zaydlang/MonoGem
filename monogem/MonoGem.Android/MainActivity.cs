using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace MonoGem.Android {
    [Activity(Label = "MonoGem.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            var g = new Game1();
            SetContentView((View) g.Services.GetService(typeof(View)));
            g.Run();
        }
    }
}