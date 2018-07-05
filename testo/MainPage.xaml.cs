using System;
using Android.App;
using Android.Content;
//using Android.Widget;
using Plugin.Messaging;  
using Xamarin.Forms;
 

using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.OS;

using Plugin.Media;
using Plugin.Media.Abstractions;




namespace testo
{
    
    public interface ICl
    {
        int go(int time);
    }



    public partial class MainPage : ContentPage
    {
     
        //DateTime triggerTime;
        public MainPage()
        {
            InitializeComponent();
            ToolbarItem toolbar = new ToolbarItem();

            ICl deviceInfo = DependencyService.Get<ICl>();
            int t = deviceInfo.go(6);

             //InitializeComponent();
            Button takePhotoBtn = new Button { Text = "Сделать фото" };
            Button getPhotoBtn = new Button { Text = "Выбрать фото" };
            Image img = new Image();
 
            // выбор фото
            getPhotoBtn.Clicked += async (o, e) =>
            {
                if (CrossMedia.Current.IsPickPhotoSupported)
                {
                    MediaFile photo = await CrossMedia.Current.PickPhotoAsync();
                    img.Source = ImageSource.FromFile(photo.Path);
                }
            };
 
            // съемка фото
            takePhotoBtn.Clicked += async (o, e) =>
            {
                if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
                {
                    MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        SaveToAlbum = true,
                        Directory = "Sample",
                        Name = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"
                    });
 
                    if (file == null)
                        return;

 
                    img.Source = ImageSource.FromFile(file.Path);
                }
            };

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new StackLayout
                    {
                        Children = {takePhotoBtn, getPhotoBtn},
                         Orientation =StackOrientation.Horizontal,
                         HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    img
                }
            };
            //InitializeComponent();
            //Button takePhotoBtn = new Button { Text = "Сделать фото" };
            //Button getPhotoBtn = new Button { Text = "Выбрать фото" };
            //Image img = new Image();

            // выбор фото
            getPhotoBtn.Clicked += async (o, e) =>
            {
                if (CrossMedia.Current.IsPickPhotoSupported)
                {
                    MediaFile photo = await CrossMedia.Current.PickPhotoAsync();
                    img.Source = ImageSource.FromFile(photo.Path);
                }
            };

            // съемка фото
            takePhotoBtn.Clicked += async (o, e) =>
            {
                if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
                {
                    MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        SaveToAlbum = true,
                        Directory = "Sample",
                        Name = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"
                    });

                    if (file == null)
                        return;

                    img.Source = ImageSource.FromFile(file.Path);
                }
            };
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new StackLayout
                    {
                         Children = {takePhotoBtn, getPhotoBtn},
                         Orientation =StackOrientation.Horizontal,
                         HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    img
                }
            };
            //Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            //TimePicker timePicker = new TimePicker();
            //Label text = new Label();
            //text.Text = "yyy";
            //Content = new StackLayout {
            //    Children = {timePicker, text}
            //};
            //timePicker.PropertyChanged += (sender, e) =>
            //{
            //text.Text = timePicker.Time.ToString();
            //namespace testo.Droid
            //{ 
            //    testo.Android.MainActivity.go(1);
            //logo.On<Xamarin.Forms.PlatformConfiguration.Android>().MainActivity.go(8);
            //}

        }

    


async void MonthClick(object sender, System.EventArgs e)
{
    var acr = await DisplayActionSheet("Months", "Cancel", null, "January", "February", "March", "April", "May", "June", "July", "August", "September",
                       "October", "November", "December");

    await Navigation.PushAsync(new February());
}
}

}
        

        //private void BtnSend_Click (object sender, System.EventArgs e)    
        //{  
            
        //   var SmsTask = CrossMessaging.Current.SmsMessenger;    
    
        //    if (SmsTask.CanSendSms)    
        //        SmsTask.SendSms (MsgTo.Text, Message.Text);    
        //}    
    
    
        //private void BtnCall_Click (object sender, System.EventArgs e)    
        //{    
        //    var PhoneCallTask = CrossMessaging.Current.PhoneDialer;    
        //    if (PhoneCallTask.CanMakePhoneCall)    
        //        PhoneCallTask.MakePhoneCall (PhoneNumber.Text);    
        //}    
    
    
        //private void BtnEmail_Click (object sender, System.EventArgs e)    
        //{    
        //    var EmailTask = CrossMessaging.Current.EmailMessenger;    
    
        //    if (EmailTask.CanSendEmail)    
        //        EmailTask.SendEmail (EmailTo.Text, EmailSubject.Text, EmailBody.Text);    
        //}    
  
    
