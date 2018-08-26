using Plugin.Messaging;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PokeDexApp.CodeLogics;
using PokeDexApp.Models;

namespace PokeDexApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorDetail : ContentPage
	{
        private Doctor CurrentDoctor { get; set; }
        private Doctor EditDoctor { get; set; }
        public DoctorDetail(Doctor doctor)
        {

            InitializeComponent();

            //NavigationPage.SetHasBackButton(this,false)
            CurrentDoctor = doctor;
            EditDoctor = new Doctor()
            {
                Image = CurrentDoctor.Image,
                Name = CurrentDoctor.Name,
                Title = CurrentDoctor.Title,
                Phone = CurrentDoctor.Phone,
                Address = CurrentDoctor.Address
            };
            BindingContext = EditDoctor;

        }
        public DoctorDetail()
        {
            InitializeComponent();            

        }

        private void ButtonCall_Clicked(object sender, EventArgs e)
        {
            // Make Phone Call
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(Phone.Text);
            
        }
        private async void ButtonSMS_Clicked(object sender, EventArgs e)
        {
            // Send Sms
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (await Check.CheckPermissions(Permission.Sms))
            {
                if (smsMessenger.CanSendSmsInBackground)
                    smsMessenger.SendSmsInBackground(Phone.Text, sms.Text);
            }
            else
                smsMessenger.SendSms(Phone.Text, sms.Text);
        }
        private void ButtonEmail_Clicked(object sender, EventArgs e)
        {
            // Send Sms
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                // Send simple e-mail to single receiver without attachments, bcc, cc etc.
                emailMessenger.SendEmail("nhanthanhtruc@gmail.com", "Xamarin Messaging Plugin", sms.Text);

                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc.
                var email = new EmailMessageBuilder()
                  .To("nhanthanhtruc@gmail.com")
                  .Cc("ntruc.apple@gmail.com")
                  //.Bcc(new[] { "bcc1.plugins@xamarin.com", "bcc2.plugins@xamarin.com" })
                  .Subject("Xamarin Messaging Plugin")
                  .Body(sms.Text)
                  .Build();

                emailMessenger.SendEmail(email);
            }
        }
        private  void ButtonSave_Clicked(object sender, EventArgs e)
        {
            CurrentDoctor.Image = EditDoctor.Image;
            CurrentDoctor.Name = EditDoctor.Name;
            CurrentDoctor.Title = EditDoctor.Title;
            CurrentDoctor.Phone = EditDoctor.Phone;
            CurrentDoctor.Address = EditDoctor.Address;
            Navigation.PopAsync();
        }
        private void ButtonView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DoctorFacebook());
        }

    }
}