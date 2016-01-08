using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.XamarinSmallBang;
using Android.Graphics;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, View.IOnClickListener, ISmallBangListener
    {
        int count = 1;
        private SmallBang mSmallBang;
        private ImageView mImage;
        private Button mButton;
        private TextView mText;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            mSmallBang = SmallBang.Attach2Window(this);
            mImage = FindViewById<ImageView>(Resource.Id.image);

            mButton = FindViewById<Button>(Resource.Id.button);
            mText = FindViewById<TextView>(Resource.Id.text);
            mImage.SetOnClickListener(this);
            mButton.SetOnClickListener(this);
            mText.SetOnClickListener(this);
        }
        public void AddNumber(View view)
        {
            mSmallBang.Bang(view, this);
        }
        public void RedText(View view)
        {
            mText.SetTextColor(Color.Red);
            mSmallBang.Bang(view, 50, new redText(this));

        }
        public void Like(View view)
        {
            mImage.SetImageResource(Resource.Drawable.heart_red);
            mSmallBang.Bang(view);
            mSmallBang.SetmListener(new like(this));
        }
        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.image:
                    Like(v);
                    break;
                case Resource.Id.button:
                    AddNumber(v);
                    break;
                case Resource.Id.text:
                    RedText(v);
                    break;
            };
        }

        public void OnAnimationEnd()
        {

        }
        public void OnAnimationStart()
        {
            Toast.MakeText(this, "按钮+1", ToastLength.Short).Show();
        }
        public class redText : Java.Lang.Object, ISmallBangListener
        {
            MainActivity con;
            public redText(MainActivity c)
            {
                con = c;
            }

            public void OnAnimationEnd()
            {

            }

            public void OnAnimationStart()
            {
                Toast.MakeText(con, "Text+1", ToastLength.Short).Show();
            }
        }

        public class like : Java.Lang.Object, ISmallBangListener
        {
            MainActivity con;
            public like(MainActivity c)
            {
                con = c;
            }
            public void OnAnimationEnd()
            {

            }

            public void OnAnimationStart()
            {
                Toast.MakeText(con, "爱心+1", ToastLength.Short).Show();
            }
        }

    }
}

