﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using Uri = Android.Net.Uri;

namespace Exercise_3
{
    [Activity(Label = "DisplayImageActivity")]
    public class DisplayImageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_display_image);

            var imageView = FindViewById<ImageView>(Resource.Id.imageView);
            var fileImage = Intent.GetStringExtra("fileImage");
            imageView.SetImageURI(Uri.FromFile(new File(fileImage)));
        }
    }
}