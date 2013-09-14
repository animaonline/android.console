using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Actionbarsherlock.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider']"
	[global::Android.Runtime.Register ("com/actionbarsherlock/widget/ShareActionProvider", DoNotGenerateAcw=true)]
	public partial class ShareActionProvider : global::Com.Actionbarsherlock.View.ActionProvider {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider']/field[@name='DEFAULT_SHARE_HISTORY_FILE_NAME']"
		[Register ("DEFAULT_SHARE_HISTORY_FILE_NAME")]
		public const string DefaultShareHistoryFileName = (string) "share_history.xml";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock.widget']/interface[@name='ShareActionProvider.OnShareTargetSelectedListener']"
		[Register ("com/actionbarsherlock/widget/ShareActionProvider$OnShareTargetSelectedListener", "", "Com.Actionbarsherlock.Widget.ShareActionProvider/IOnShareTargetSelectedListenerInvoker")]
		public partial interface IOnShareTargetSelectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.widget']/interface[@name='ShareActionProvider.OnShareTargetSelectedListener']/method[@name='onShareTargetSelected' and count(parameter)=2 and parameter[1][@type='com.actionbarsherlock.widget.ShareActionProvider'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onShareTargetSelected", "(Lcom/actionbarsherlock/widget/ShareActionProvider;Landroid/content/Intent;)Z", "GetOnShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_Handler:Com.Actionbarsherlock.Widget.ShareActionProvider/IOnShareTargetSelectedListenerInvoker, ActionBarSherlock")]
			bool OnShareTargetSelected (global::Com.Actionbarsherlock.Widget.ShareActionProvider p0, global::Android.Content.Intent p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/widget/ShareActionProvider$OnShareTargetSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnShareTargetSelectedListenerInvoker : global::Java.Lang.Object, IOnShareTargetSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/widget/ShareActionProvider$OnShareTargetSelectedListener");
			IntPtr class_ref;

			public static IOnShareTargetSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnShareTargetSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.widget.ShareActionProvider.OnShareTargetSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnShareTargetSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnShareTargetSelectedListenerInvoker); }
			}

			static Delegate cb_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_Handler ()
			{
				if (cb_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_ == null)
					cb_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_);
				return cb_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_;
			}

			static bool n_OnShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Actionbarsherlock.Widget.ShareActionProvider.IOnShareTargetSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.Widget.ShareActionProvider.IOnShareTargetSelectedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.Widget.ShareActionProvider p0 = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.Widget.ShareActionProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnShareTargetSelected (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_;
			public bool OnShareTargetSelected (global::Com.Actionbarsherlock.Widget.ShareActionProvider p0, global::Android.Content.Intent p1)
			{
				if (id_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_ == IntPtr.Zero)
					id_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onShareTargetSelected", "(Lcom/actionbarsherlock/widget/ShareActionProvider;Landroid/content/Intent;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
				return __ret;
			}

		}

		public partial class ShareTargetSelectedEventArgs : global::System.EventArgs {

			public ShareTargetSelectedEventArgs (bool handled, global::Com.Actionbarsherlock.Widget.ShareActionProvider p0, global::Android.Content.Intent p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Actionbarsherlock.Widget.ShareActionProvider p0;
			public global::Com.Actionbarsherlock.Widget.ShareActionProvider P0 {
				get { return p0; }
			}

			global::Android.Content.Intent p1;
			public global::Android.Content.Intent P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/widget/ShareActionProvider_OnShareTargetSelectedListenerImplementor")]
		internal sealed class IOnShareTargetSelectedListenerImplementor : global::Java.Lang.Object, IOnShareTargetSelectedListener {

			object sender;

			public IOnShareTargetSelectedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/widget/ShareActionProvider_OnShareTargetSelectedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ShareTargetSelectedEventArgs> Handler;
#pragma warning restore 0649

			public bool OnShareTargetSelected (global::Com.Actionbarsherlock.Widget.ShareActionProvider p0, global::Android.Content.Intent p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new ShareTargetSelectedEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnShareTargetSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider.ShareAcitivityChooserModelPolicy']"
		[global::Android.Runtime.Register ("com/actionbarsherlock/widget/ShareActionProvider$ShareAcitivityChooserModelPolicy", DoNotGenerateAcw=true)]
		public partial class ShareAcitivityChooserModelPolicy : global::Java.Lang.Object {

			protected ShareAcitivityChooserModelPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider.ShareMenuItemOnMenuItemClickListener']"
		[global::Android.Runtime.Register ("com/actionbarsherlock/widget/ShareActionProvider$ShareMenuItemOnMenuItemClickListener", DoNotGenerateAcw=true)]
		public partial class ShareMenuItemOnMenuItemClickListener : global::Java.Lang.Object, global::Com.Actionbarsherlock.View.IMenuItemOnMenuItemClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/actionbarsherlock/widget/ShareActionProvider$ShareMenuItemOnMenuItemClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShareMenuItemOnMenuItemClickListener); }
			}

			protected ShareMenuItemOnMenuItemClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_;
#pragma warning disable 0169
			static Delegate GetOnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_Handler ()
			{
				if (cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ == null)
					cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_);
				return cb_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_;
			}

			static bool n_OnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Actionbarsherlock.Widget.ShareActionProvider.ShareMenuItemOnMenuItemClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.Widget.ShareActionProvider.ShareMenuItemOnMenuItemClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenuItem p0 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMenuItemClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider.ShareMenuItemOnMenuItemClickListener']/method[@name='onMenuItemClick' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
			[Register ("onMenuItemClick", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_Handler")]
			public virtual bool OnMenuItemClick (global::Com.Actionbarsherlock.View.IMenuItem p0)
			{
				if (id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
					id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemClick", "(Lcom/actionbarsherlock/view/MenuItem;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
				return __ret;
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/widget/ShareActionProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareActionProvider); }
		}

		protected ShareActionProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider']/constructor[@name='ShareActionProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ShareActionProvider (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ShareActionProvider)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onCreateActionView;
#pragma warning disable 0169
		static Delegate GetOnCreateActionViewHandler ()
		{
			if (cb_onCreateActionView == null)
				cb_onCreateActionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnCreateActionView);
			return cb_onCreateActionView;
		}

		static IntPtr n_OnCreateActionView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.Widget.ShareActionProvider __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.Widget.ShareActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCreateActionView ());
		}
#pragma warning restore 0169

		static IntPtr id_onCreateActionView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider']/method[@name='onCreateActionView' and count(parameter)=0]"
		[Register ("onCreateActionView", "()Landroid/view/View;", "GetOnCreateActionViewHandler")]
		public override global::Android.Views.View OnCreateActionView ()
		{
			if (id_onCreateActionView == IntPtr.Zero)
				id_onCreateActionView = JNIEnv.GetMethodID (class_ref, "onCreateActionView", "()Landroid/view/View;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_onCreateActionView), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_onCreateActionView), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setShareHistoryFileName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShareHistoryFileName_Ljava_lang_String_Handler ()
		{
			if (cb_setShareHistoryFileName_Ljava_lang_String_ == null)
				cb_setShareHistoryFileName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShareHistoryFileName_Ljava_lang_String_);
			return cb_setShareHistoryFileName_Ljava_lang_String_;
		}

		static void n_SetShareHistoryFileName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.Widget.ShareActionProvider __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.Widget.ShareActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShareHistoryFileName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShareHistoryFileName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider']/method[@name='setShareHistoryFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setShareHistoryFileName", "(Ljava/lang/String;)V", "GetSetShareHistoryFileName_Ljava_lang_String_Handler")]
		public virtual void SetShareHistoryFileName (string p0)
		{
			if (id_setShareHistoryFileName_Ljava_lang_String_ == IntPtr.Zero)
				id_setShareHistoryFileName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setShareHistoryFileName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShareHistoryFileName_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShareHistoryFileName_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setShareIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetShareIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_setShareIntent_Landroid_content_Intent_ == null)
				cb_setShareIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShareIntent_Landroid_content_Intent_);
			return cb_setShareIntent_Landroid_content_Intent_;
		}

		static void n_SetShareIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.Widget.ShareActionProvider __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.Widget.ShareActionProvider> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShareIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShareIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.widget']/class[@name='ShareActionProvider']/method[@name='setShareIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("setShareIntent", "(Landroid/content/Intent;)V", "GetSetShareIntent_Landroid_content_Intent_Handler")]
		public virtual void SetShareIntent (global::Android.Content.Intent p0)
		{
			if (id_setShareIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_setShareIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "setShareIntent", "(Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShareIntent_Landroid_content_Intent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShareIntent_Landroid_content_Intent_, new JValue (p0));
		}

	}
}
