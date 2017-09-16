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
using Java.Text;
using Java.Util;

namespace Chatdesign
{
    class CommonMethods
    {
        private static DateFormat dateFormat = new SimpleDateFormat("d MMM yyyy");
        private static DateFormat timeFormat = new SimpleDateFormat("K:mma");

        public static String getCurrentTime()
        {
            Locale loc = new Locale("en", "us");
            Date today = Calendar.GetInstance(loc).Time;
            return timeFormat.Format(today);
        }

        public static String getCurrentDate()
        {
            Locale loc = new Locale("en", "us");
            Date today = Calendar.GetInstance(loc).Time;
            return dateFormat.Format(today);
        }
    }
}