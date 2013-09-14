using System;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Actionbarsherlock.App;

namespace Animaonline.Android.Console.Code.Fragments
{
    public class ConsoleFragment : SherlockFragment
    {
        #region OnCreate

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        #endregion

        #region Private Fields

        private readonly object sync_lock = new object();

        #endregion

        #region Public Properties

        public ScrollView ConsoleScroller { get; set; }
        public TextView ConsoleTextView { get; set; }
        public ConsoleBuffer ConsoleBuffer { get; set; }
        public bool IsReady { get; set; }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        private void ScrollToBottom()
        {
            if (this.ConsoleScroller != null)
                this.ConsoleTextView.PostDelayed(() => this.ConsoleScroller.FullScroll(FocusSearchDirection.Down), 100);
        }

        #endregion

        #region Overridden Methods

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle p2)
        {
            var fragmentHost = Activity as IConsoleFragmentHost;

            if (fragmentHost == null)
                throw new NotSupportedException("Parent must implement IConsoleFragmentHost");

            var view = inflater.Inflate(Resource.Layout.console_view, null);

            fragmentHost.ConsoleViewCreated(view);

            return view;
        }

        #endregion

        #region Console Implementation

        public void Refresh()
        {
            if (this.ConsoleTextView == null)
                return;

            this.ConsoleTextView.Post(() =>
            {
                var bufferContents = this.ConsoleBuffer.Buffer;

                if (string.IsNullOrWhiteSpace(bufferContents))
                    bufferContents = "Ready...";

                this.ConsoleTextView.SetText(bufferContents, TextView.BufferType.Normal);

                ScrollToBottom();
            });
        }

        public void Clear()
        {
            lock (sync_lock)
            {
                if (this.IsReady && this.ConsoleTextView != null)
                {
                    if (this.ConsoleBuffer != null)
                        this.ConsoleBuffer.Clear();

                    this.ConsoleTextView.Post(() =>
                    {
                        this.ConsoleTextView.Text = string.Empty;
                    });
                }
            }
        }

        public void Write(string value)
        {
            lock (sync_lock)
            {
                if (this.IsReady && this.ConsoleTextView != null && this.ConsoleBuffer != null)
                {
                    this.ConsoleBuffer.Write(value);

                    var bufferContents = this.ConsoleBuffer.Buffer;

                    this.ConsoleTextView.Post(() =>
                    {
                        this.ConsoleTextView.SetText(bufferContents, TextView.BufferType.Normal);

                        ScrollToBottom();
                    });
                }
            }
        }

        public void WriteLine(string value)
        {
            lock (sync_lock)
            {
                if (this.IsReady && this.ConsoleTextView != null && this.ConsoleBuffer != null)
                {
                    this.ConsoleBuffer.WriteLine(value);

                    var bufferContents = this.ConsoleBuffer.Buffer;

                    this.ConsoleTextView.Post(() =>
                    {
                        this.ConsoleTextView.SetText(bufferContents, TextView.BufferType.Normal);

                        ScrollToBottom();
                    });
                }
            }
        }

        public void WriteLine()
        {
            lock (sync_lock)
            {
                if (this.IsReady && this.ConsoleTextView != null && this.ConsoleBuffer != null)
                {
                    this.ConsoleBuffer.WriteLine();

                    var bufferContents = this.ConsoleBuffer.Buffer;

                    this.ConsoleTextView.Post(() =>
                    {
                        this.ConsoleTextView.SetText(bufferContents, TextView.BufferType.Normal);

                        ScrollToBottom();
                    });
                }
            }
        }

        #endregion
    }
}