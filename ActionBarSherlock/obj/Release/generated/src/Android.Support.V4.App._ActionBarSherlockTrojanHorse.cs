using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V4.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']"
	[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse", DoNotGenerateAcw=true)]
	public abstract partial class _ActionBarSherlockTrojanHorse : global::Android.Support.V4.App.FragmentActivity, global::Com.Actionbarsherlock.ActionBarSherlock.IOnCreatePanelMenuListener, global::Com.Actionbarsherlock.ActionBarSherlock.IOnMenuItemSelectedListener, global::Com.Actionbarsherlock.ActionBarSherlock.IOnPreparePanelListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v4.app']/interface[@name='_ActionBarSherlockTrojanHorse.OnCreateOptionsMenuListener']"
		[Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnCreateOptionsMenuListener", "", "Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnCreateOptionsMenuListenerInvoker")]
		public partial interface IOnCreateOptionsMenuListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/interface[@name='_ActionBarSherlockTrojanHorse.OnCreateOptionsMenuListener']/method[@name='onCreateOptionsMenu' and count(parameter)=2 and parameter[1][@type='com.actionbarsherlock.view.Menu'] and parameter[2][@type='com.actionbarsherlock.view.MenuInflater']]"
			[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnCreateOptionsMenuListenerInvoker, ActionBarSherlock")]
			void OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0, global::Com.Actionbarsherlock.View.MenuInflater p1);

		}

		[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnCreateOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnCreateOptionsMenuListenerInvoker : global::Java.Lang.Object, IOnCreateOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnCreateOptionsMenuListener");
			IntPtr class_ref;

			public static IOnCreateOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCreateOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v4.app._ActionBarSherlockTrojanHorse.OnCreateOptionsMenuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCreateOptionsMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnCreateOptionsMenuListenerInvoker); }
			}

			static Delegate cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_;
#pragma warning disable 0169
			static Delegate GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_Handler ()
			{
				if (cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ == null)
					cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_);
				return cb_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_;
			}

			static void n_OnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnCreateOptionsMenuListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnCreateOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.MenuInflater p1 = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateOptionsMenu (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_;
			public void OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0, global::Com.Actionbarsherlock.View.MenuInflater p1)
			{
				if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ == IntPtr.Zero)
					id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V");
				JNIEnv.CallVoidMethod (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class CreateOptionsMenuEventArgs : global::System.EventArgs {

			public CreateOptionsMenuEventArgs (global::Com.Actionbarsherlock.View.IMenu p0, global::Com.Actionbarsherlock.View.MenuInflater p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Actionbarsherlock.View.IMenu p0;
			public global::Com.Actionbarsherlock.View.IMenu P0 {
				get { return p0; }
			}

			global::Com.Actionbarsherlock.View.MenuInflater p1;
			public global::Com.Actionbarsherlock.View.MenuInflater P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor")]
		internal sealed class IOnCreateOptionsMenuListenerImplementor : global::Java.Lang.Object, IOnCreateOptionsMenuListener {

			object sender;

			public IOnCreateOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnCreateOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CreateOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public void OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0, global::Com.Actionbarsherlock.View.MenuInflater p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CreateOptionsMenuEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnCreateOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v4.app']/interface[@name='_ActionBarSherlockTrojanHorse.OnOptionsItemSelectedListener']"
		[Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnOptionsItemSelectedListener", "", "Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnOptionsItemSelectedListenerInvoker")]
		public partial interface IOnOptionsItemSelectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/interface[@name='_ActionBarSherlockTrojanHorse.OnOptionsItemSelectedListener']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
			[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnOptionsItemSelectedListenerInvoker, ActionBarSherlock")]
			bool OnOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0);

		}

		[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnOptionsItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnOptionsItemSelectedListenerInvoker : global::Java.Lang.Object, IOnOptionsItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnOptionsItemSelectedListener");
			IntPtr class_ref;

			public static IOnOptionsItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnOptionsItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v4.app._ActionBarSherlockTrojanHorse.OnOptionsItemSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnOptionsItemSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnOptionsItemSelectedListenerInvoker); }
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
				global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnOptionsItemSelectedListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnOptionsItemSelectedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenuItem p0 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnOptionsItemSelected (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
			public bool OnOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0)
			{
				if (id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
					id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
				return __ret;
			}

		}

		public partial class OptionsItemSelectedEventArgs : global::System.EventArgs {

			public OptionsItemSelectedEventArgs (bool handled, global::Com.Actionbarsherlock.View.IMenuItem p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Actionbarsherlock.View.IMenuItem p0;
			public global::Com.Actionbarsherlock.View.IMenuItem P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor")]
		internal sealed class IOnOptionsItemSelectedListenerImplementor : global::Java.Lang.Object, IOnOptionsItemSelectedListener {

			object sender;

			public IOnOptionsItemSelectedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnOptionsItemSelectedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<OptionsItemSelectedEventArgs> Handler;
#pragma warning restore 0649

			public bool OnOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new OptionsItemSelectedEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnOptionsItemSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v4.app']/interface[@name='_ActionBarSherlockTrojanHorse.OnPrepareOptionsMenuListener']"
		[Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnPrepareOptionsMenuListener", "", "Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnPrepareOptionsMenuListenerInvoker")]
		public partial interface IOnPrepareOptionsMenuListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/interface[@name='_ActionBarSherlockTrojanHorse.OnPrepareOptionsMenuListener']/method[@name='onPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
			[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)V", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:Android.Support.V4.App._ActionBarSherlockTrojanHorse/IOnPrepareOptionsMenuListenerInvoker, ActionBarSherlock")]
			void OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0);

		}

		[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnPrepareOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnPrepareOptionsMenuListenerInvoker : global::Java.Lang.Object, IOnPrepareOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse$OnPrepareOptionsMenuListener");
			IntPtr class_ref;

			public static IOnPrepareOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPrepareOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v4.app._ActionBarSherlockTrojanHorse.OnPrepareOptionsMenuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPrepareOptionsMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPrepareOptionsMenuListenerInvoker); }
			}

			static Delegate cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler ()
			{
				if (cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == null)
					cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
				return cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			}

			static void n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnPrepareOptionsMenuListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse.IOnPrepareOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPrepareOptionsMenu (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			public void OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
			{
				if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)V");
				JNIEnv.CallVoidMethod (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			}

		}

		public partial class PrepareOptionsMenuEventArgs : global::System.EventArgs {

			public PrepareOptionsMenuEventArgs (global::Com.Actionbarsherlock.View.IMenu p0)
			{
				this.p0 = p0;
			}

			global::Com.Actionbarsherlock.View.IMenu p0;
			public global::Com.Actionbarsherlock.View.IMenu P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnPrepareOptionsMenuListenerImplementor")]
		internal sealed class IOnPrepareOptionsMenuListenerImplementor : global::Java.Lang.Object, IOnPrepareOptionsMenuListener {

			object sender;

			public IOnPrepareOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/android/support/v4/app/_ActionBarSherlockTrojanHorse_OnPrepareOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PrepareOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public void OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PrepareOptionsMenuEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnPrepareOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v4/app/_ActionBarSherlockTrojanHorse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (_ActionBarSherlockTrojanHorse); }
		}

		protected _ActionBarSherlockTrojanHorse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/constructor[@name='_ActionBarSherlockTrojanHorse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public _ActionBarSherlockTrojanHorse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (_ActionBarSherlockTrojanHorse)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Support.V4.App._ActionBarSherlockTrojanHorse __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportMenuInflater);
		}
#pragma warning restore 0169

		public abstract global::Com.Actionbarsherlock.View.MenuInflater SupportMenuInflater {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='getSupportMenuInflater' and count(parameter)=0]"
			[Register ("getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetSupportMenuInflaterHandler")] get;
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
			global::Android.Support.V4.App._ActionBarSherlockTrojanHorse __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public abstract bool OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0);

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
			global::Android.Support.V4.App._ActionBarSherlockTrojanHorse __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p1 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreatePanelMenu (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onCreatePanelMenu' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.actionbarsherlock.view.Menu']]"
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
			global::Android.Support.V4.App._ActionBarSherlockTrojanHorse __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenuItem p1 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemSelected (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onMenuItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.actionbarsherlock.view.MenuItem']]"
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
			global::Android.Support.V4.App._ActionBarSherlockTrojanHorse __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenuItem p0 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
		[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler")]
		public abstract bool OnOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0);

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
			global::Android.Support.V4.App._ActionBarSherlockTrojanHorse __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public abstract bool OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0);

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
			global::Android.Support.V4.App._ActionBarSherlockTrojanHorse __this = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App._ActionBarSherlockTrojanHorse> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p2 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPreparePanel (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onPreparePanel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.actionbarsherlock.view.Menu']]"
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

	}

	[global::Android.Runtime.Register ("android/support/v4/app/_ActionBarSherlockTrojanHorse", DoNotGenerateAcw=true)]
	internal partial class _ActionBarSherlockTrojanHorseInvoker : _ActionBarSherlockTrojanHorse {

		public _ActionBarSherlockTrojanHorseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (_ActionBarSherlockTrojanHorseInvoker); }
		}

		static IntPtr id_getSupportMenuInflater;
		public override global::Com.Actionbarsherlock.View.MenuInflater SupportMenuInflater {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='getSupportMenuInflater' and count(parameter)=0]"
			[Register ("getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetSupportMenuInflaterHandler")]
			get {
				if (id_getSupportMenuInflater == IntPtr.Zero)
					id_getSupportMenuInflater = JNIEnv.GetMethodID (class_ref, "getSupportMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;");
				return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (JNIEnv.CallObjectMethod  (Handle, id_getSupportMenuInflater), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public override bool OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
		{
			if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
		[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler")]
		public override bool OnOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0)
		{
			if (id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v4.app']/class[@name='_ActionBarSherlockTrojanHorse']/method[@name='onPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler")]
		public override bool OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
		{
			if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

	}

}
