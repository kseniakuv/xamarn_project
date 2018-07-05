using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Xamarin.Forms;
using Java.Lang;
             
[assembly: Dependency(typeof(testo.Droid.Cl))]
namespace testo.Droid
{
    ////[BroadcastReceiver]
    //public class MyReceiver : BroadcastReceiver
    //{
    //    public override void OnReceive(Context context, Intent intent)
    //    {
    //        Toast.MakeText(context, "Alarm Ringing!", ToastLength.Short).Show();
    //    }
    //}

    public class Cl : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ICl
    {
        public string GetInfo()
        {
            return $"Android {Build.VERSION.Release.ToString()}";
        }

        public int go(int time)
        {

            //GET TIME IN SECONDS AND INITIALIZE INTENT

            Intent i = new Intent(this, typeof(MyReceiver));

            //PASS CONTEXT,YOUR PRIVATE REQUEST CODE,INTENT OBJECT AND FLAG
            PendingIntent pi = PendingIntent.GetBroadcast(this, 0, i, 0);

            //INITIALIZE ALARM MANAGER
            AlarmManager alarmManager = (AlarmManager)GetSystemService(AlarmService);

            //SET THE ALARM
            alarmManager.Set(AlarmType.RtcWakeup, JavaSystem.CurrentTimeMillis() + (time * 1000), pi);
            Toast.MakeText(this, "Alarm set In: " + time + "minutes", ToastLength.Short).Show();
            return 0;
        }

    }
}
