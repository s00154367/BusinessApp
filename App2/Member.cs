using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App2
{
    class Member
    {
        public List<Contact> Contacts { get; set; }
        public Location Local { get; set; }
        public DatePicker Date { get; set; }
        public TimePicker Time { get; set; }
    }
}