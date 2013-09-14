using System.Threading;
using Android.App;
using Android.Text;
using Android.Widget;
using Com.Actionbarsherlock.App;

namespace Animaonline.Android.Console.Code
{
    public class AndroidConsoleInputHandler
    {
        public AndroidConsoleInputHandler(Activity context)
        {
            this.Context = context;
        }

        private Activity Context { get; set; }

        private string ShowSyncPrompt(string title, bool oneChar = false)
        {
            var dialogShown = true;
            EditText textInput = null;

            Context.RunOnUiThread(() =>
            {
                var inputDialog = new AlertDialog.Builder(this.Context).SetCancelable(false);

                textInput = new EditText(this.Context);

                if (oneChar)
                {
                    var filterArray = new IInputFilter[1];
                    filterArray[0] = new InputFilterLengthFilter(1);

                    textInput.SetFilters(filterArray);
                }

                inputDialog.SetView(textInput);

                inputDialog.SetPositiveButton(Context.GetString(Resource.String.OK), (o, e) =>
                {
                    dialogShown = false;
                });

                inputDialog.Show();
            });

            while (dialogShown)
            {
                Thread.Sleep(100);
            }

            var enteredText = textInput.Text;

            return enteredText;
        }

        public string OnReadLine()
        {
            return ShowSyncPrompt("Console.ReadLine()");
        }

        public int OnRead()
        {
            var cin = ShowSyncPrompt("Console.Read()", true);

            if (!string.IsNullOrEmpty(cin))
            {
                return cin[0];
            }

            return 0;
        }
    }
}