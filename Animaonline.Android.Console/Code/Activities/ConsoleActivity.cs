using System;
using System.Threading.Tasks;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using Animaonline.Android.Console.Code.Fragments;
using Animaonline.Utils;
using Com.Actionbarsherlock.App;

namespace Animaonline.Android.Console.Code.Activities
{
    [Activity(Label = "@string/Console", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.Sherlock")]
    public class ConsoleActivity : SherlockFragmentActivity, IConsoleFragmentHost
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //enter full screen
            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

            //load the layout
            SetContentView(Resource.Layout.main_activity);

            //create the console fragment
            this.ConsoleFragment = new ConsoleFragment();

            //show the console fragment
            using (var ft = SupportFragmentManager.BeginTransaction())
                ft.Replace(Resource.Id.content_frame, this.ConsoleFragment, "fragment").Commit();

            //handles the interception of console input
            var androidConsoleInputHandler = new AndroidConsoleInputHandler(this);

            //start intercepting console IO
            ConsoleInputCapture.Start(androidConsoleInputHandler.OnReadLine, androidConsoleInputHandler.OnRead);
            System.Console.SetOut(new Utils.ConsoleTextWriter(System.Console.Out, this.OnWrite, this.OnWriteLine));

            //start the sample console program
            Task.Factory.StartNew(Program.Main);
        }

        #region Public Static Properties

        public static ConsoleBuffer ConsoleBuffer { get; set; }

        #endregion

        #region Console Output

        private void OnWrite(string value)
        {
            if (ConsoleBuffer == null)
                ConsoleBuffer = new ConsoleBuffer();

            ConsoleBuffer.Write(value);

            if (this.ConsoleFragment != null)
                ConsoleFragment.Refresh();
        }

        private void OnWriteLine(string value)
        {
            if (ConsoleBuffer == null)
                ConsoleBuffer = new ConsoleBuffer();

            ConsoleBuffer.WriteLine(value);

            if (this.ConsoleFragment != null)
                ConsoleFragment.Refresh();
        }

        #endregion

        #region Private Properties

        private ConsoleFragment ConsoleFragment { get; set; }

        #endregion

        #region ConsoleViewCreated Callback

        public void ConsoleViewCreated(View view)
        {
            this.ConsoleFragment.ConsoleScroller = view.FindViewById<ScrollView>(Resource.Id.consoleScroller);

            this.ConsoleFragment.ConsoleTextView = view.FindViewById<TextView>(Resource.Id.consoleTextView);

            try
            {
                this.ConsoleFragment.ConsoleTextView.Typeface = Typeface.CreateFromAsset(Assets, "perfect_dos.ttf");
            }
            catch (Exception ex)
            {
                //failed to set font
            }

            if (ConsoleBuffer == null)
                ConsoleBuffer = new ConsoleBuffer();

            this.ConsoleFragment.ConsoleBuffer = ConsoleBuffer;

            this.ConsoleFragment.IsReady = true;
            this.ConsoleFragment.Refresh();
        }

        #endregion
    }
}

