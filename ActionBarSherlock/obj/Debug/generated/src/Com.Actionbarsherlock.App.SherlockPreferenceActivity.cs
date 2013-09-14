using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Actionbarsherlock.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']"
	[global::Android.Runtime.Register ("com/actionbarsherlock/app/SherlockPreferenceActivity", DoNotGenerateAcw=true)]
	public abstract partial class SherlockPreferenceActivity : global::Android.Preferences.PreferenceActivity, global::Com.Actionbarsherlock.ActionBarSherlock.IOnActionModeFinishedListener, global::Com.Actionbarsherlock.ActionBarSherlock.IOnActionModeStartedListener, global::Com.Actionbarsherlock.ActionBarSherlock.IOnCreatePanelMenuListener, global::Com.Actionbarsherlock.ActionBarSherlock.IOnMenuItemSelectedListener, global::Com.Actionbarsherlock.ActionBarSherlock.IOnPreparePanelListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/app/SherlockPreferenceActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SherlockPreferenceActivity); }
		}

		protected SherlockPreferenceActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/constructor[@name='SherlockPreferenceActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SherlockPreferenceActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SherlockPreferenceActivity)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getSherlock;
		protected global::Com.Actionbarsherlock.ActionBarSherlock Sherlock {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='getSherlock' and count(parameter)=0]"
			[Register ("getSherlock", "()Lcom/actionbarsherlock/ActionBarSherlock;", "GetGetSherlockHandler")]
			get {
				if (id_getSherlock == IntPtr.Zero)
					id_getSherlock = JNIEnv.GetMethodID (class_ref, "getSherlock", "()Lcom/actionbarsherlock/ActionBarSherlock;");
				return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (JNIEnv.CallObjectMethod  (Handle, id_getSherlock), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSupportActionBar;
#pragma warning disable 0169
		static Delegate GetGetSupportActionBarHandler ()
		{
			if (cb_getSupportActionBar == null)
				cb_getSupportActionBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportActionBar);
			return cb_getSupportActionBar;
		}

		static IntPtr n_GetSupportActionBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportActionBar);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportActionBar;
		public virtual global::Com.Actionbarsherlock.App.ActionBar SupportActionBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='getSupportActionBar' and count(parameter)=0]"
			[Register ("getSupportActionBar", "()Lcom/actionbarsherlock/app/ActionBar;", "GetGetSupportActionBarHandler")]
			get {
				if (id_getSupportActionBar == IntPtr.Zero)
					id_getSupportActionBar = JNIEnv.GetMethodID (class_ref, "getSupportActionBar", "()Lcom/actionbarsherlock/app/ActionBar;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.ActionBar> (JNIEnv.CallObjectMethod  (Handle, id_getSupportActionBar), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.ActionBar> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSupportActionBar), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSupportMenuInflater;
#pragma warning disable 0169
		static Delegate GetGetSupportMenuInflaterHandler ()
		{
			if (cb_getSupportMenuInflater == null)
				cb_getSupportMenuInflater = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportMenuInflater);
			return cb_getSupportMenuInflater;
		}

		static IntPtr n_GetSupportMenuInflater (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportMenuInflater);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportMenuInflater;
		public virtual global::Com.Actionbarsherlock.View.MenuInflater SupportMenuInflater {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='getSupportMenuInflater' and count(parameter)=0]"
			[Register ("getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetSupportMenuInflaterHandler")]
			get {
				if (id_getSupportMenuInflater == IntPtr.Zero)
					id_getSupportMenuInflater = JNIEnv.GetMethodID (class_ref, "getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (JNIEnv.CallObjectMethod  (Handle, id_getSupportMenuInflater), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSupportMenuInflater), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_invalidateOptionsMenu;
#pragma warning disable 0169
		static Delegate GetInvalidateOptionsMenuHandler ()
		{
			if (cb_invalidateOptionsMenu == null)
				cb_invalidateOptionsMenu = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvalidateOptionsMenu);
			return cb_invalidateOptionsMenu;
		}

		static void n_InvalidateOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidateOptionsMenu;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='invalidateOptionsMenu' and count(parameter)=0]"
		[Register ("invalidateOptionsMenu", "()V", "GetInvalidateOptionsMenuHandler")]
		public virtual void InvalidateOptionsMenu ()
		{
			if (id_invalidateOptionsMenu == IntPtr.Zero)
				id_invalidateOptionsMenu = JNIEnv.GetMethodID (class_ref, "invalidateOptionsMenu", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_invalidateOptionsMenu);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_invalidateOptionsMenu);
		}

		static Delegate cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_Handler ()
		{
			if (cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ == null)
				cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_);
			return cb_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_;
		}

		static void n_OnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActionModeFinished (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onActionModeFinished' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.ActionMode']]"
		[Register ("onActionModeFinished", "(Lcom/actionbarsherlock/view/ActionMode;)V", "GetOnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_Handler")]
		public virtual void OnActionModeFinished (global::Com.Actionbarsherlock.View.ActionMode p0)
		{
			if (id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ == IntPtr.Zero)
				id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeFinished", "(Lcom/actionbarsherlock/view/ActionMode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
		}

		static Delegate cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_Handler ()
		{
			if (cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ == null)
				cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_);
			return cb_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_;
		}

		static void n_OnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActionModeStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onActionModeStarted' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.ActionMode']]"
		[Register ("onActionModeStarted", "(Lcom/actionbarsherlock/view/ActionMode;)V", "GetOnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_Handler")]
		public virtual void OnActionModeStarted (global::Com.Actionbarsherlock.View.ActionMode p0)
		{
			if (id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ == IntPtr.Zero)
				id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeStarted", "(Lcom/actionbarsherlock/view/ActionMode;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
		}

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", "")]
		public override sealed bool OnCreateOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_onCreateOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreateOptionsMenu_Landroid_view_Menu_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == null)
				cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
			return cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public virtual bool OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
		{
			if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ == null)
				cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_);
			return cb_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p1 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreatePanelMenu (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onCreatePanelMenu' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z", "GetOnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_Handler")]
		public virtual bool OnCreatePanelMenu (int p0, global::Com.Actionbarsherlock.View.IMenu p1)
		{
			if (id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ == null)
				cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_);
			return cb_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
		}

		static bool n_OnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenuItem p1 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemSelected (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onMenuItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.actionbarsherlock.view.MenuItem']]"
		[Register ("onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler")]
		public virtual bool OnMenuItemSelected (int p0, global::Com.Actionbarsherlock.View.IMenuItem p1)
		{
			if (id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_onMenuOpened_ILandroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onMenuOpened' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onMenuOpened", "(ILandroid/view/Menu;)Z", "")]
		public override sealed bool OnMenuOpened (int p0, global::Android.Views.IMenu p1)
		{
			if (id_onMenuOpened_ILandroid_view_Menu_ == IntPtr.Zero)
				id_onMenuOpened_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuOpened_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
		[Register ("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "")]
		public override sealed bool OnOptionsItemSelected (global::Android.Views.IMenuItem p0)
		{
			if (id_onOptionsItemSelected_Landroid_view_MenuItem_ == IntPtr.Zero)
				id_onOptionsItemSelected_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Landroid_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler ()
		{
			if (cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == null)
				cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_);
			return cb_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		}

		static bool n_OnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenuItem p0 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
		[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler")]
		public virtual bool OnOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0)
		{
			if (id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", "")]
		public override sealed bool OnPrepareOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_onPrepareOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onPrepareOptionsMenu_Landroid_view_Menu_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == null)
				cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
			return cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public virtual bool OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
		{
			if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ == null)
				cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_);
			return cb_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
		}

		static bool n_OnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p2 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPreparePanel (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='onPreparePanel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_Handler")]
		public virtual bool OnPreparePanel (int p0, global::Android.Views.View p1, global::Com.Actionbarsherlock.View.IMenu p2)
		{
			if (id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_requestWindowFeature_J;
#pragma warning disable 0169
		static Delegate GetRequestWindowFeature_JHandler ()
		{
			if (cb_requestWindowFeature_J == null)
				cb_requestWindowFeature_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_RequestWindowFeature_J);
			return cb_requestWindowFeature_J;
		}

		static void n_RequestWindowFeature_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestWindowFeature (p0);
		}
#pragma warning restore 0169

		static IntPtr id_requestWindowFeature_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='requestWindowFeature' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("requestWindowFeature", "(J)V", "GetRequestWindowFeature_JHandler")]
		public virtual void RequestWindowFeature (long p0)
		{
			if (id_requestWindowFeature_J == IntPtr.Zero)
				id_requestWindowFeature_J = JNIEnv.GetMethodID (class_ref, "requestWindowFeature", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_requestWindowFeature_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_requestWindowFeature_J, new JValue (p0));
		}

		static Delegate cb_setSupportProgress_I;
#pragma warning disable 0169
		static Delegate GetSetSupportProgress_IHandler ()
		{
			if (cb_setSupportProgress_I == null)
				cb_setSupportProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSupportProgress_I);
			return cb_setSupportProgress_I;
		}

		static void n_SetSupportProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSupportProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSupportProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='setSupportProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSupportProgress", "(I)V", "GetSetSupportProgress_IHandler")]
		public virtual void SetSupportProgress (int p0)
		{
			if (id_setSupportProgress_I == IntPtr.Zero)
				id_setSupportProgress_I = JNIEnv.GetMethodID (class_ref, "setSupportProgress", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSupportProgress_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSupportProgress_I, new JValue (p0));
		}

		static Delegate cb_setSupportProgressBarIndeterminate_Z;
#pragma warning disable 0169
		static Delegate GetSetSupportProgressBarIndeterminate_ZHandler ()
		{
			if (cb_setSupportProgressBarIndeterminate_Z == null)
				cb_setSupportProgressBarIndeterminate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSupportProgressBarIndeterminate_Z);
			return cb_setSupportProgressBarIndeterminate_Z;
		}

		static void n_SetSupportProgressBarIndeterminate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSupportProgressBarIndeterminate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSupportProgressBarIndeterminate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='setSupportProgressBarIndeterminate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSupportProgressBarIndeterminate", "(Z)V", "GetSetSupportProgressBarIndeterminate_ZHandler")]
		public virtual void SetSupportProgressBarIndeterminate (bool p0)
		{
			if (id_setSupportProgressBarIndeterminate_Z == IntPtr.Zero)
				id_setSupportProgressBarIndeterminate_Z = JNIEnv.GetMethodID (class_ref, "setSupportProgressBarIndeterminate", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSupportProgressBarIndeterminate_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSupportProgressBarIndeterminate_Z, new JValue (p0));
		}

		static Delegate cb_setSupportProgressBarIndeterminateVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetSupportProgressBarIndeterminateVisibility_ZHandler ()
		{
			if (cb_setSupportProgressBarIndeterminateVisibility_Z == null)
				cb_setSupportProgressBarIndeterminateVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSupportProgressBarIndeterminateVisibility_Z);
			return cb_setSupportProgressBarIndeterminateVisibility_Z;
		}

		static void n_SetSupportProgressBarIndeterminateVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSupportProgressBarIndeterminateVisibility (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSupportProgressBarIndeterminateVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='setSupportProgressBarIndeterminateVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSupportProgressBarIndeterminateVisibility", "(Z)V", "GetSetSupportProgressBarIndeterminateVisibility_ZHandler")]
		public virtual void SetSupportProgressBarIndeterminateVisibility (bool p0)
		{
			if (id_setSupportProgressBarIndeterminateVisibility_Z == IntPtr.Zero)
				id_setSupportProgressBarIndeterminateVisibility_Z = JNIEnv.GetMethodID (class_ref, "setSupportProgressBarIndeterminateVisibility", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSupportProgressBarIndeterminateVisibility_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSupportProgressBarIndeterminateVisibility_Z, new JValue (p0));
		}

		static Delegate cb_setSupportProgressBarVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetSupportProgressBarVisibility_ZHandler ()
		{
			if (cb_setSupportProgressBarVisibility_Z == null)
				cb_setSupportProgressBarVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSupportProgressBarVisibility_Z);
			return cb_setSupportProgressBarVisibility_Z;
		}

		static void n_SetSupportProgressBarVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSupportProgressBarVisibility (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSupportProgressBarVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='setSupportProgressBarVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSupportProgressBarVisibility", "(Z)V", "GetSetSupportProgressBarVisibility_ZHandler")]
		public virtual void SetSupportProgressBarVisibility (bool p0)
		{
			if (id_setSupportProgressBarVisibility_Z == IntPtr.Zero)
				id_setSupportProgressBarVisibility_Z = JNIEnv.GetMethodID (class_ref, "setSupportProgressBarVisibility", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSupportProgressBarVisibility_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSupportProgressBarVisibility_Z, new JValue (p0));
		}

		static Delegate cb_setSupportSecondaryProgress_I;
#pragma warning disable 0169
		static Delegate GetSetSupportSecondaryProgress_IHandler ()
		{
			if (cb_setSupportSecondaryProgress_I == null)
				cb_setSupportSecondaryProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSupportSecondaryProgress_I);
			return cb_setSupportSecondaryProgress_I;
		}

		static void n_SetSupportSecondaryProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSupportSecondaryProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSupportSecondaryProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='setSupportSecondaryProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSupportSecondaryProgress", "(I)V", "GetSetSupportSecondaryProgress_IHandler")]
		public virtual void SetSupportSecondaryProgress (int p0)
		{
			if (id_setSupportSecondaryProgress_I == IntPtr.Zero)
				id_setSupportSecondaryProgress_I = JNIEnv.GetMethodID (class_ref, "setSupportSecondaryProgress", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSupportSecondaryProgress_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSupportSecondaryProgress_I, new JValue (p0));
		}

		static Delegate cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_;
#pragma warning disable 0169
		static Delegate GetStartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_Handler ()
		{
			if (cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ == null)
				cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_);
			return cb_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_;
		}

		static IntPtr n_StartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.ActionMode.ICallback p0 = (global::Com.Actionbarsherlock.View.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='startActionMode' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.ActionMode.Callback']]"
		[Register ("startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;", "GetStartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_Handler")]
		public virtual global::Com.Actionbarsherlock.View.ActionMode StartActionMode (global::Com.Actionbarsherlock.View.ActionMode.ICallback p0)
		{
			if (id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ == IntPtr.Zero)
				id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;");

			global::Com.Actionbarsherlock.View.ActionMode __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_supportInvalidateOptionsMenu;
#pragma warning disable 0169
		static Delegate GetSupportInvalidateOptionsMenuHandler ()
		{
			if (cb_supportInvalidateOptionsMenu == null)
				cb_supportInvalidateOptionsMenu = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SupportInvalidateOptionsMenu);
			return cb_supportInvalidateOptionsMenu;
		}

		static void n_SupportInvalidateOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.App.SherlockPreferenceActivity __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.SherlockPreferenceActivity> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SupportInvalidateOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_supportInvalidateOptionsMenu;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.app']/class[@name='SherlockPreferenceActivity']/method[@name='supportInvalidateOptionsMenu' and count(parameter)=0]"
		[Register ("supportInvalidateOptionsMenu", "()V", "GetSupportInvalidateOptionsMenuHandler")]
		public virtual void SupportInvalidateOptionsMenu ()
		{
			if (id_supportInvalidateOptionsMenu == IntPtr.Zero)
				id_supportInvalidateOptionsMenu = JNIEnv.GetMethodID (class_ref, "supportInvalidateOptionsMenu", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_supportInvalidateOptionsMenu);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_supportInvalidateOptionsMenu);
		}

	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/app/SherlockPreferenceActivity", DoNotGenerateAcw=true)]
	internal partial class SherlockPreferenceActivityInvoker : SherlockPreferenceActivity {

		public SherlockPreferenceActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SherlockPreferenceActivityInvoker); }
		}

	}

}
