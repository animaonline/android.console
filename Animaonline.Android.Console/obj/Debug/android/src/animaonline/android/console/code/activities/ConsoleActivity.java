package animaonline.android.console.code.activities;


public class ConsoleActivity
	extends com.actionbarsherlock.app.SherlockFragmentActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Animaonline.Android.Console.Code.Activities.ConsoleActivity, Animaonline.Android.Console, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ConsoleActivity.class, __md_methods);
	}


	public ConsoleActivity ()
	{
		super ();
		if (getClass () == ConsoleActivity.class)
			mono.android.TypeManager.Activate ("Animaonline.Android.Console.Code.Activities.ConsoleActivity, Animaonline.Android.Console, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
