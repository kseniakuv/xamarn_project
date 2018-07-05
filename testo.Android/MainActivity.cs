using System;

using Android.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Content.PM;
using Java.Lang;

namespace testo.Droid
{
    [Activity(Label = "testo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

        }



        // public class MainActivity : Activity
        // {
        //     //DECLARE WIDGETS
        //     private Button startBtn;
        //     private EditText timeTxt;

        //     protected override void OnCreate(Bundle bundle)
        //     {
        //         base.OnCreate(bundle);

        //         SetContentView( Resource.Layout.Main);

        //         this.initializeViews();

        //     }
        //     /*
        //INITIALIZE VIEWS
        //*/
        //    private void initializeViews()
        //    {
        //        timeTxt = FindViewById<EditText>(Resource.Id.timeTxt);
        //        startBtn = FindViewById<Button>(Resource.Id.startBtn);

        //        startBtn.Click += startBtn_Click;

        //    }

        //    void startBtn_Click(object sender, EventArgs e)
        //    {
        //        go();
        //    }

        //    /*
        //    INITIALIZE AND START OUR ALARM
        //     */
    }


    [BroadcastReceiver]
    public class MyReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "Alarm Ringing!", ToastLength.Short).Show();
        }
    }


    //public class Cl : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity {
    //    public int go(int time){
    
    //    //GET TIME IN SECONDS AND INITIALIZE INTENT

    //    Intent i = new Intent(this, typeof(MyReceiver));

    //    //PASS CONTEXT,YOUR PRIVATE REQUEST CODE,INTENT OBJECT AND FLAG
    //    PendingIntent pi = PendingIntent.GetBroadcast(this, 0, i, 0);

    //    //INITIALIZE ALARM MANAGER
    //    AlarmManager alarmManager = (AlarmManager)GetSystemService(AlarmService);

    //    //SET THE ALARM
    //    alarmManager.Set(AlarmType.RtcWakeup, JavaSystem.CurrentTimeMillis() + (time * 1000), pi);
    //    Toast.MakeText(this, "Alarm set In: " + time + "minutes", ToastLength.Short).Show();
    //        return 0;
    //    }
    //}

}

