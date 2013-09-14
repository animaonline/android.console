using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Actionbarsherlock {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']"
	[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock", DoNotGenerateAcw=true)]
	public abstract partial class ActionBarSherlock : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		protected const bool Debug = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/field[@name='FLAG_DELEGATE']"
		[Register ("FLAG_DELEGATE")]
		public const int FlagDelegate = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "ActionBarSherlock";

		static IntPtr mActivity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/field[@name='mActivity']"
		[Register ("mActivity")]
		protected global::Android.App.Activity MActivity {
			get {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mActivity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mActivity_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mIsDelegate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/field[@name='mIsDelegate']"
		[Register ("mIsDelegate")]
		protected bool MIsDelegate {
			get {
				if (mIsDelegate_jfieldId == IntPtr.Zero)
					mIsDelegate_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDelegate", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsDelegate_jfieldId);
			}
			set {
				if (mIsDelegate_jfieldId == IntPtr.Zero)
					mIsDelegate_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDelegate", "Z");
				JNIEnv.SetField (Handle, mIsDelegate_jfieldId, value);
			}
		}

		static IntPtr mMenuInflater_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/field[@name='mMenuInflater']"
		[Register ("mMenuInflater")]
		protected global::Com.Actionbarsherlock.View.MenuInflater MMenuInflater {
			get {
				if (mMenuInflater_jfieldId == IntPtr.Zero)
					mMenuInflater_jfieldId = JNIEnv.GetFieldID (class_ref, "mMenuInflater", "Lcom/actionbarsherlock/view/MenuInflater;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMenuInflater_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMenuInflater_jfieldId == IntPtr.Zero)
					mMenuInflater_jfieldId = JNIEnv.GetFieldID (class_ref, "mMenuInflater", "Lcom/actionbarsherlock/view/MenuInflater;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMenuInflater_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']"
		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$Implementation", DoNotGenerateAcw=true)]
		public abstract partial class Implementation : global::Java.Lang.Object, global::Java.Lang.Annotation.IAnnotation {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/field[@name='DEFAULT_API']"
			[Register ("DEFAULT_API")]
			public const int DefaultApi = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/field[@name='DEFAULT_DPI']"
			[Register ("DEFAULT_DPI")]
			public const int DefaultDpi = (int) -1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$Implementation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Implementation); }
			}

			protected Implementation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_api;
#pragma warning disable 0169
			static Delegate GetApiHandler ()
			{
				if (cb_api == null)
					cb_api = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Api);
				return cb_api;
			}

			static int n_Api (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Actionbarsherlock.ActionBarSherlock.Implementation __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.Implementation> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Api ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/method[@name='api' and count(parameter)=0]"
			[Register ("api", "()I", "GetApiHandler")]
			public abstract int Api ();

			static Delegate cb_dpi;
#pragma warning disable 0169
			static Delegate GetDpiHandler ()
			{
				if (cb_dpi == null)
					cb_dpi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Dpi);
				return cb_dpi;
			}

			static int n_Dpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Actionbarsherlock.ActionBarSherlock.Implementation __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.Implementation> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Dpi ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/method[@name='dpi' and count(parameter)=0]"
			[Register ("dpi", "()I", "GetDpiHandler")]
			public abstract int Dpi ();

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Actionbarsherlock.ActionBarSherlock.Implementation __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.Implementation> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/method[@name='annotationType' and count(parameter)=0]"
			[Register ("annotationType", "()Ljava/lang/Class;", "GetAnnotationTypeHandler")]
			public abstract global::Java.Lang.Class AnnotationType ();

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$Implementation", DoNotGenerateAcw=true)]
		internal partial class ImplementationInvoker : Implementation {

			public ImplementationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImplementationInvoker); }
			}

			static IntPtr id_api;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/method[@name='api' and count(parameter)=0]"
			[Register ("api", "()I", "GetApiHandler")]
			public override int Api ()
			{
				if (id_api == IntPtr.Zero)
					id_api = JNIEnv.GetMethodID (class_ref, "api", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_api);
			}

			static IntPtr id_dpi;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/method[@name='dpi' and count(parameter)=0]"
			[Register ("dpi", "()I", "GetDpiHandler")]
			public override int Dpi ()
			{
				if (id_dpi == IntPtr.Zero)
					id_dpi = JNIEnv.GetMethodID (class_ref, "dpi", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_dpi);
			}

			static IntPtr id_annotationType;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock.Implementation']/method[@name='annotationType' and count(parameter)=0]"
			[Register ("annotationType", "()Ljava/lang/Class;", "GetAnnotationTypeHandler")]
			public override global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnActionModeFinishedListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeFinishedListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnActionModeFinishedListenerInvoker")]
		public partial interface IOnActionModeFinishedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnActionModeFinishedListener']/method[@name='onActionModeFinished' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.ActionMode']]"
			[Register ("onActionModeFinished", "(Lcom/actionbarsherlock/view/ActionMode;)V", "GetOnActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnActionModeFinishedListenerInvoker, ActionBarSherlock")]
			void OnActionModeFinished (global::Com.Actionbarsherlock.View.ActionMode p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeFinishedListener", DoNotGenerateAcw=true)]
		internal class IOnActionModeFinishedListenerInvoker : global::Java.Lang.Object, IOnActionModeFinishedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnActionModeFinishedListener");
			IntPtr class_ref;

			public static IOnActionModeFinishedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnActionModeFinishedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnActionModeFinishedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnActionModeFinishedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnActionModeFinishedListenerInvoker); }
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
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnActionModeFinishedListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnActionModeFinishedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActionModeFinished (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_;
			public void OnActionModeFinished (global::Com.Actionbarsherlock.View.ActionMode p0)
			{
				if (id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ == IntPtr.Zero)
					id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeFinished", "(Lcom/actionbarsherlock/view/ActionMode;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActionModeFinished_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
			}

		}

		public partial class ActionModeFinishedEventArgs : global::System.EventArgs {

			public ActionModeFinishedEventArgs (global::Com.Actionbarsherlock.View.ActionMode p0)
			{
				this.p0 = p0;
			}

			global::Com.Actionbarsherlock.View.ActionMode p0;
			public global::Com.Actionbarsherlock.View.ActionMode P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeFinishedListenerImplementor")]
		internal sealed class IOnActionModeFinishedListenerImplementor : global::Java.Lang.Object, IOnActionModeFinishedListener {

			object sender;

			public IOnActionModeFinishedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeFinishedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActionModeFinishedEventArgs> Handler;
#pragma warning restore 0649

			public void OnActionModeFinished (global::Com.Actionbarsherlock.View.ActionMode p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ActionModeFinishedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnActionModeFinishedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnActionModeStartedListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeStartedListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnActionModeStartedListenerInvoker")]
		public partial interface IOnActionModeStartedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnActionModeStartedListener']/method[@name='onActionModeStarted' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.ActionMode']]"
			[Register ("onActionModeStarted", "(Lcom/actionbarsherlock/view/ActionMode;)V", "GetOnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnActionModeStartedListenerInvoker, ActionBarSherlock")]
			void OnActionModeStarted (global::Com.Actionbarsherlock.View.ActionMode p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnActionModeStartedListener", DoNotGenerateAcw=true)]
		internal class IOnActionModeStartedListenerInvoker : global::Java.Lang.Object, IOnActionModeStartedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnActionModeStartedListener");
			IntPtr class_ref;

			public static IOnActionModeStartedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnActionModeStartedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnActionModeStartedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnActionModeStartedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnActionModeStartedListenerInvoker); }
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
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnActionModeStartedListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnActionModeStartedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActionModeStarted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_;
			public void OnActionModeStarted (global::Com.Actionbarsherlock.View.ActionMode p0)
			{
				if (id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ == IntPtr.Zero)
					id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeStarted", "(Lcom/actionbarsherlock/view/ActionMode;)V");
				JNIEnv.CallVoidMethod (Handle, id_onActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_, new JValue (p0));
			}

		}

		public partial class ActionModeStartedEventArgs : global::System.EventArgs {

			public ActionModeStartedEventArgs (global::Com.Actionbarsherlock.View.ActionMode p0)
			{
				this.p0 = p0;
			}

			global::Com.Actionbarsherlock.View.ActionMode p0;
			public global::Com.Actionbarsherlock.View.ActionMode P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeStartedListenerImplementor")]
		internal sealed class IOnActionModeStartedListenerImplementor : global::Java.Lang.Object, IOnActionModeStartedListener {

			object sender;

			public IOnActionModeStartedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnActionModeStartedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActionModeStartedEventArgs> Handler;
#pragma warning restore 0649

			public void OnActionModeStarted (global::Com.Actionbarsherlock.View.ActionMode p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ActionModeStartedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnActionModeStartedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnCreateOptionsMenuListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnCreateOptionsMenuListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnCreateOptionsMenuListenerInvoker")]
		public partial interface IOnCreateOptionsMenuListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnCreateOptionsMenuListener']/method[@name='onCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
			[Register ("onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnCreateOptionsMenuListenerInvoker, ActionBarSherlock")]
			bool OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnCreateOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnCreateOptionsMenuListenerInvoker : global::Java.Lang.Object, IOnCreateOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnCreateOptionsMenuListener");
			IntPtr class_ref;

			public static IOnCreateOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCreateOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnCreateOptionsMenuListener"));
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
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnCreateOptionsMenuListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnCreateOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreateOptionsMenu (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			public bool OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
			{
				if (id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
				return __ret;
			}

		}

		public partial class CreateOptionsMenuEventArgs : global::System.EventArgs {

			public CreateOptionsMenuEventArgs (bool handled, global::Com.Actionbarsherlock.View.IMenu p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Actionbarsherlock.View.IMenu p0;
			public global::Com.Actionbarsherlock.View.IMenu P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreateOptionsMenuListenerImplementor")]
		internal sealed class IOnCreateOptionsMenuListenerImplementor : global::Java.Lang.Object, IOnCreateOptionsMenuListener {

			object sender;

			public IOnCreateOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreateOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CreateOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public bool OnCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new CreateOptionsMenuEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnCreateOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnCreatePanelMenuListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnCreatePanelMenuListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnCreatePanelMenuListenerInvoker")]
		public partial interface IOnCreatePanelMenuListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnCreatePanelMenuListener']/method[@name='onCreatePanelMenu' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.actionbarsherlock.view.Menu']]"
			[Register ("onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z", "GetOnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnCreatePanelMenuListenerInvoker, ActionBarSherlock")]
			bool OnCreatePanelMenu (int p0, global::Com.Actionbarsherlock.View.IMenu p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnCreatePanelMenuListener", DoNotGenerateAcw=true)]
		internal class IOnCreatePanelMenuListenerInvoker : global::Java.Lang.Object, IOnCreatePanelMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnCreatePanelMenuListener");
			IntPtr class_ref;

			public static IOnCreatePanelMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCreatePanelMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnCreatePanelMenuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCreatePanelMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnCreatePanelMenuListenerInvoker); }
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
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnCreatePanelMenuListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnCreatePanelMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenu p1 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreatePanelMenu (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_;
			public bool OnCreatePanelMenu (int p0, global::Com.Actionbarsherlock.View.IMenu p1)
			{
				if (id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreatePanelMenu", "(ILcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
				return __ret;
			}

		}

		public partial class CreatePanelMenuEventArgs : global::System.EventArgs {

			public CreatePanelMenuEventArgs (bool handled, int p0, global::Com.Actionbarsherlock.View.IMenu p1)
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

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Com.Actionbarsherlock.View.IMenu p1;
			public global::Com.Actionbarsherlock.View.IMenu P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreatePanelMenuListenerImplementor")]
		internal sealed class IOnCreatePanelMenuListenerImplementor : global::Java.Lang.Object, IOnCreatePanelMenuListener {

			object sender;

			public IOnCreatePanelMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnCreatePanelMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CreatePanelMenuEventArgs> Handler;
#pragma warning restore 0649

			public bool OnCreatePanelMenu (int p0, global::Com.Actionbarsherlock.View.IMenu p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new CreatePanelMenuEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnCreatePanelMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnMenuItemSelectedListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnMenuItemSelectedListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnMenuItemSelectedListenerInvoker")]
		public partial interface IOnMenuItemSelectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnMenuItemSelectedListener']/method[@name='onMenuItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.actionbarsherlock.view.MenuItem']]"
			[Register ("onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z", "GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnMenuItemSelectedListenerInvoker, ActionBarSherlock")]
			bool OnMenuItemSelected (int p0, global::Com.Actionbarsherlock.View.IMenuItem p1);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnMenuItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnMenuItemSelectedListenerInvoker : global::Java.Lang.Object, IOnMenuItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnMenuItemSelectedListener");
			IntPtr class_ref;

			public static IOnMenuItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMenuItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnMenuItemSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMenuItemSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMenuItemSelectedListenerInvoker); }
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
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnMenuItemSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnMenuItemSelectedListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenuItem p1 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMenuItemSelected (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_;
			public bool OnMenuItemSelected (int p0, global::Com.Actionbarsherlock.View.IMenuItem p1)
			{
				if (id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
					id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemSelected", "(ILcom/actionbarsherlock/view/MenuItem;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_, new JValue (p0), new JValue (p1));
				return __ret;
			}

		}

		public partial class MenuItemSelectedEventArgs : global::System.EventArgs {

			public MenuItemSelectedEventArgs (bool handled, int p0, global::Com.Actionbarsherlock.View.IMenuItem p1)
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

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Com.Actionbarsherlock.View.IMenuItem p1;
			public global::Com.Actionbarsherlock.View.IMenuItem P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnMenuItemSelectedListenerImplementor")]
		internal sealed class IOnMenuItemSelectedListenerImplementor : global::Java.Lang.Object, IOnMenuItemSelectedListener {

			object sender;

			public IOnMenuItemSelectedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnMenuItemSelectedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MenuItemSelectedEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMenuItemSelected (int p0, global::Com.Actionbarsherlock.View.IMenuItem p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MenuItemSelectedEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMenuItemSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnOptionsItemSelectedListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnOptionsItemSelectedListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnOptionsItemSelectedListenerInvoker")]
		public partial interface IOnOptionsItemSelectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnOptionsItemSelectedListener']/method[@name='onOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
			[Register ("onOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnOptionsItemSelectedListenerInvoker, ActionBarSherlock")]
			bool OnOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnOptionsItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnOptionsItemSelectedListenerInvoker : global::Java.Lang.Object, IOnOptionsItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnOptionsItemSelectedListener");
			IntPtr class_ref;

			public static IOnOptionsItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnOptionsItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnOptionsItemSelectedListener"));
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
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnOptionsItemSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnOptionsItemSelectedListener> (native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnOptionsItemSelectedListenerImplementor")]
		internal sealed class IOnOptionsItemSelectedListenerImplementor : global::Java.Lang.Object, IOnOptionsItemSelectedListener {

			object sender;

			public IOnOptionsItemSelectedListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnOptionsItemSelectedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnPrepareOptionsMenuListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnPrepareOptionsMenuListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnPrepareOptionsMenuListenerInvoker")]
		public partial interface IOnPrepareOptionsMenuListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnPrepareOptionsMenuListener']/method[@name='onPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
			[Register ("onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnPrepareOptionsMenuListenerInvoker, ActionBarSherlock")]
			bool OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnPrepareOptionsMenuListener", DoNotGenerateAcw=true)]
		internal class IOnPrepareOptionsMenuListenerInvoker : global::Java.Lang.Object, IOnPrepareOptionsMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnPrepareOptionsMenuListener");
			IntPtr class_ref;

			public static IOnPrepareOptionsMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPrepareOptionsMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnPrepareOptionsMenuListener"));
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
					cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_);
				return cb_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			}

			static bool n_OnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnPrepareOptionsMenuListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnPrepareOptionsMenuListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenu p0 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPrepareOptionsMenu (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
			public bool OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
			{
				if (id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
				return __ret;
			}

		}

		public partial class PrepareOptionsMenuEventArgs : global::System.EventArgs {

			public PrepareOptionsMenuEventArgs (bool handled, global::Com.Actionbarsherlock.View.IMenu p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Actionbarsherlock.View.IMenu p0;
			public global::Com.Actionbarsherlock.View.IMenu P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor")]
		internal sealed class IOnPrepareOptionsMenuListenerImplementor : global::Java.Lang.Object, IOnPrepareOptionsMenuListener {

			object sender;

			public IOnPrepareOptionsMenuListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PrepareOptionsMenuEventArgs> Handler;
#pragma warning restore 0649

			public bool OnPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new PrepareOptionsMenuEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnPrepareOptionsMenuListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnPreparePanelListener']"
		[Register ("com/actionbarsherlock/ActionBarSherlock$OnPreparePanelListener", "", "Com.Actionbarsherlock.ActionBarSherlock/IOnPreparePanelListenerInvoker")]
		public partial interface IOnPreparePanelListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/interface[@name='ActionBarSherlock.OnPreparePanelListener']/method[@name='onPreparePanel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.actionbarsherlock.view.Menu']]"
			[Register ("onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z", "GetOnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_Handler:Com.Actionbarsherlock.ActionBarSherlock/IOnPreparePanelListenerInvoker, ActionBarSherlock")]
			bool OnPreparePanel (int p0, global::Android.Views.View p1, global::Com.Actionbarsherlock.View.IMenu p2);

		}

		[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock$OnPreparePanelListener", DoNotGenerateAcw=true)]
		internal class IOnPreparePanelListenerInvoker : global::Java.Lang.Object, IOnPreparePanelListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock$OnPreparePanelListener");
			IntPtr class_ref;

			public static IOnPreparePanelListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPreparePanelListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.actionbarsherlock.ActionBarSherlock.OnPreparePanelListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPreparePanelListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPreparePanelListenerInvoker); }
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
				global::Com.Actionbarsherlock.ActionBarSherlock.IOnPreparePanelListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock.IOnPreparePanelListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenu p2 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPreparePanel (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_;
			public bool OnPreparePanel (int p0, global::Android.Views.View p1, global::Com.Actionbarsherlock.View.IMenu p2)
			{
				if (id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPreparePanel", "(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1), new JValue (p2));
				return __ret;
			}

		}

		public partial class PreparePanelEventArgs : global::System.EventArgs {

			public PreparePanelEventArgs (bool handled, int p0, global::Android.Views.View p1, global::Com.Actionbarsherlock.View.IMenu p2)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Android.Views.View p1;
			public global::Android.Views.View P1 {
				get { return p1; }
			}

			global::Com.Actionbarsherlock.View.IMenu p2;
			public global::Com.Actionbarsherlock.View.IMenu P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/actionbarsherlock/ActionBarSherlock_OnPreparePanelListenerImplementor")]
		internal sealed class IOnPreparePanelListenerImplementor : global::Java.Lang.Object, IOnPreparePanelListener {

			object sender;

			public IOnPreparePanelListenerImplementor (object sender)
				: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/actionbarsherlock/ActionBarSherlock_OnPreparePanelListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PreparePanelEventArgs> Handler;
#pragma warning restore 0649

			public bool OnPreparePanel (int p0, global::Android.Views.View p1, global::Com.Actionbarsherlock.View.IMenu p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new PreparePanelEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnPreparePanelListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/ActionBarSherlock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarSherlock); }
		}

		protected ActionBarSherlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/constructor[@name='ActionBarSherlock' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/app/Activity;I)V", "")]
		protected ActionBarSherlock (global::Android.App.Activity p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActionBarSherlock)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/app/Activity;I)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_app_Activity_I == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_app_Activity_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getActionBar;
#pragma warning disable 0169
		static Delegate GetGetActionBarHandler ()
		{
			if (cb_getActionBar == null)
				cb_getActionBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionBar);
			return cb_getActionBar;
		}

		static IntPtr n_GetActionBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionBar);
		}
#pragma warning restore 0169

		public abstract global::Com.Actionbarsherlock.App.ActionBar ActionBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='getActionBar' and count(parameter)=0]"
			[Register ("getActionBar", "()Lcom/actionbarsherlock/app/ActionBar;", "GetGetActionBarHandler")] get;
		}

		static Delegate cb_getMenuInflater;
#pragma warning disable 0169
		static Delegate GetGetMenuInflaterHandler ()
		{
			if (cb_getMenuInflater == null)
				cb_getMenuInflater = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMenuInflater);
			return cb_getMenuInflater;
		}

		static IntPtr n_GetMenuInflater (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MenuInflater);
		}
#pragma warning restore 0169

		static IntPtr id_getMenuInflater;
		public virtual global::Com.Actionbarsherlock.View.MenuInflater MenuInflater {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='getMenuInflater' and count(parameter)=0]"
			[Register ("getMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;", "GetGetMenuInflaterHandler")]
			get {
				if (id_getMenuInflater == IntPtr.Zero)
					id_getMenuInflater = JNIEnv.GetMethodID (class_ref, "getMenuInflater", "()Lcom/actionbarsherlock/view/MenuInflater;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (JNIEnv.CallObjectMethod  (Handle, id_getMenuInflater), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMenuInflater), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThemedContext;
#pragma warning disable 0169
		static Delegate GetGetThemedContextHandler ()
		{
			if (cb_getThemedContext == null)
				cb_getThemedContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThemedContext);
			return cb_getThemedContext;
		}

		static IntPtr n_GetThemedContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThemedContext);
		}
#pragma warning restore 0169

		protected abstract global::Android.Content.Context ThemedContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='getThemedContext' and count(parameter)=0]"
			[Register ("getThemedContext", "()Landroid/content/Context;", "GetGetThemedContextHandler")] get;
		}

		static Delegate cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler ()
		{
			if (cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
				cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_);
			return cb_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		static void n_AddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup.LayoutParams p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddContentView (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='addContentView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public abstract void AddContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1);

		static IntPtr id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='callbackCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("callbackCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "")]
		protected bool CallbackCreateOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
		{
			if (id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "callbackCreateOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_callbackCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='callbackOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
		[Register ("callbackOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z", "")]
		protected bool CallbackOptionsItemSelected (global::Com.Actionbarsherlock.View.IMenuItem p0)
		{
			if (id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ == IntPtr.Zero)
				id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "callbackOptionsItemSelected", "(Lcom/actionbarsherlock/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_callbackOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='callbackPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("callbackPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z", "")]
		protected bool CallbackPrepareOptionsMenu (global::Com.Actionbarsherlock.View.IMenu p0)
		{
			if (id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "callbackPrepareOptionsMenu", "(Lcom/actionbarsherlock/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_callbackPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_dispatchCloseOptionsMenu;
#pragma warning disable 0169
		static Delegate GetDispatchCloseOptionsMenuHandler ()
		{
			if (cb_dispatchCloseOptionsMenu == null)
				cb_dispatchCloseOptionsMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DispatchCloseOptionsMenu);
			return cb_dispatchCloseOptionsMenu;
		}

		static bool n_DispatchCloseOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DispatchCloseOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchCloseOptionsMenu;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchCloseOptionsMenu' and count(parameter)=0]"
		[Register ("dispatchCloseOptionsMenu", "()Z", "GetDispatchCloseOptionsMenuHandler")]
		public virtual bool DispatchCloseOptionsMenu ()
		{
			if (id_dispatchCloseOptionsMenu == IntPtr.Zero)
				id_dispatchCloseOptionsMenu = JNIEnv.GetMethodID (class_ref, "dispatchCloseOptionsMenu", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_dispatchCloseOptionsMenu);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchCloseOptionsMenu);
		}

		static Delegate cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetDispatchConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_dispatchConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_DispatchConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchConfigurationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchConfigurationChanged_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetDispatchConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual void DispatchConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_dispatchConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_dispatchConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchConfigurationChanged_Landroid_content_res_Configuration_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchConfigurationChanged_Landroid_content_res_Configuration_, new JValue (p0));
		}

		static Delegate cb_dispatchCreateOptionsMenu_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchCreateOptionsMenu_Landroid_view_Menu_Handler ()
		{
			if (cb_dispatchCreateOptionsMenu_Landroid_view_Menu_ == null)
				cb_dispatchCreateOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchCreateOptionsMenu_Landroid_view_Menu_);
			return cb_dispatchCreateOptionsMenu_Landroid_view_Menu_;
		}

		static bool n_DispatchCreateOptionsMenu_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p0 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchCreateOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("dispatchCreateOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchCreateOptionsMenu_Landroid_view_Menu_Handler")]
		public abstract bool DispatchCreateOptionsMenu (global::Android.Views.IMenu p0);

		static Delegate cb_dispatchDestroy;
#pragma warning disable 0169
		static Delegate GetDispatchDestroyHandler ()
		{
			if (cb_dispatchDestroy == null)
				cb_dispatchDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchDestroy);
			return cb_dispatchDestroy;
		}

		static void n_DispatchDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchDestroy' and count(parameter)=0]"
		[Register ("dispatchDestroy", "()V", "GetDispatchDestroyHandler")]
		public virtual void DispatchDestroy ()
		{
			if (id_dispatchDestroy == IntPtr.Zero)
				id_dispatchDestroy = JNIEnv.GetMethodID (class_ref, "dispatchDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchDestroy);
		}

		static Delegate cb_dispatchInvalidateOptionsMenu;
#pragma warning disable 0169
		static Delegate GetDispatchInvalidateOptionsMenuHandler ()
		{
			if (cb_dispatchInvalidateOptionsMenu == null)
				cb_dispatchInvalidateOptionsMenu = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchInvalidateOptionsMenu);
			return cb_dispatchInvalidateOptionsMenu;
		}

		static void n_DispatchInvalidateOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchInvalidateOptionsMenu ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchInvalidateOptionsMenu' and count(parameter)=0]"
		[Register ("dispatchInvalidateOptionsMenu", "()V", "GetDispatchInvalidateOptionsMenuHandler")]
		public abstract void DispatchInvalidateOptionsMenu ();

		static Delegate cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchKeyEvent_Landroid_view_KeyEvent_);
			return cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchKeyEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchKeyEvent_Landroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual bool DispatchKeyEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_dispatchKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchKeyEvent_Landroid_view_KeyEvent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchKeyEvent_Landroid_view_KeyEvent_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_dispatchMenuOpened_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchMenuOpened_ILandroid_view_Menu_Handler ()
		{
			if (cb_dispatchMenuOpened_ILandroid_view_Menu_ == null)
				cb_dispatchMenuOpened_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_DispatchMenuOpened_ILandroid_view_Menu_);
			return cb_dispatchMenuOpened_ILandroid_view_Menu_;
		}

		static bool n_DispatchMenuOpened_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchMenuOpened (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchMenuOpened_ILandroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchMenuOpened' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("dispatchMenuOpened", "(ILandroid/view/Menu;)Z", "GetDispatchMenuOpened_ILandroid_view_Menu_Handler")]
		public virtual bool DispatchMenuOpened (int p0, global::Android.Views.IMenu p1)
		{
			if (id_dispatchMenuOpened_ILandroid_view_Menu_ == IntPtr.Zero)
				id_dispatchMenuOpened_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchMenuOpened", "(ILandroid/view/Menu;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchMenuOpened_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchMenuOpened_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_dispatchOpenOptionsMenu;
#pragma warning disable 0169
		static Delegate GetDispatchOpenOptionsMenuHandler ()
		{
			if (cb_dispatchOpenOptionsMenu == null)
				cb_dispatchOpenOptionsMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DispatchOpenOptionsMenu);
			return cb_dispatchOpenOptionsMenu;
		}

		static bool n_DispatchOpenOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DispatchOpenOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchOpenOptionsMenu;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchOpenOptionsMenu' and count(parameter)=0]"
		[Register ("dispatchOpenOptionsMenu", "()Z", "GetDispatchOpenOptionsMenuHandler")]
		public virtual bool DispatchOpenOptionsMenu ()
		{
			if (id_dispatchOpenOptionsMenu == IntPtr.Zero)
				id_dispatchOpenOptionsMenu = JNIEnv.GetMethodID (class_ref, "dispatchOpenOptionsMenu", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_dispatchOpenOptionsMenu);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_dispatchOpenOptionsMenu);
		}

		static Delegate cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetDispatchOptionsItemSelected_Landroid_view_MenuItem_Handler ()
		{
			if (cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_ == null)
				cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchOptionsItemSelected_Landroid_view_MenuItem_);
			return cb_dispatchOptionsItemSelected_Landroid_view_MenuItem_;
		}

		static bool n_DispatchOptionsItemSelected_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem p0 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchOptionsItemSelected (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
		[Register ("dispatchOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetDispatchOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public abstract bool DispatchOptionsItemSelected (global::Android.Views.IMenuItem p0);

		static Delegate cb_dispatchPanelClosed_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchPanelClosed_ILandroid_view_Menu_Handler ()
		{
			if (cb_dispatchPanelClosed_ILandroid_view_Menu_ == null)
				cb_dispatchPanelClosed_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DispatchPanelClosed_ILandroid_view_Menu_);
			return cb_dispatchPanelClosed_ILandroid_view_Menu_;
		}

		static void n_DispatchPanelClosed_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPanelClosed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPanelClosed_ILandroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchPanelClosed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("dispatchPanelClosed", "(ILandroid/view/Menu;)V", "GetDispatchPanelClosed_ILandroid_view_Menu_Handler")]
		public virtual void DispatchPanelClosed (int p0, global::Android.Views.IMenu p1)
		{
			if (id_dispatchPanelClosed_ILandroid_view_Menu_ == IntPtr.Zero)
				id_dispatchPanelClosed_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchPanelClosed", "(ILandroid/view/Menu;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPanelClosed_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPanelClosed_ILandroid_view_Menu_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_dispatchPause;
#pragma warning disable 0169
		static Delegate GetDispatchPauseHandler ()
		{
			if (cb_dispatchPause == null)
				cb_dispatchPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchPause);
			return cb_dispatchPause;
		}

		static void n_DispatchPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPause ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchPause' and count(parameter)=0]"
		[Register ("dispatchPause", "()V", "GetDispatchPauseHandler")]
		public virtual void DispatchPause ()
		{
			if (id_dispatchPause == IntPtr.Zero)
				id_dispatchPause = JNIEnv.GetMethodID (class_ref, "dispatchPause", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPause);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPause);
		}

		static Delegate cb_dispatchPostCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetDispatchPostCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_dispatchPostCreate_Landroid_os_Bundle_ == null)
				cb_dispatchPostCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchPostCreate_Landroid_os_Bundle_);
			return cb_dispatchPostCreate_Landroid_os_Bundle_;
		}

		static void n_DispatchPostCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPostCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPostCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchPostCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("dispatchPostCreate", "(Landroid/os/Bundle;)V", "GetDispatchPostCreate_Landroid_os_Bundle_Handler")]
		public virtual void DispatchPostCreate (global::Android.OS.Bundle p0)
		{
			if (id_dispatchPostCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_dispatchPostCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "dispatchPostCreate", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPostCreate_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPostCreate_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_dispatchPostResume;
#pragma warning disable 0169
		static Delegate GetDispatchPostResumeHandler ()
		{
			if (cb_dispatchPostResume == null)
				cb_dispatchPostResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchPostResume);
			return cb_dispatchPostResume;
		}

		static void n_DispatchPostResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPostResume ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPostResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchPostResume' and count(parameter)=0]"
		[Register ("dispatchPostResume", "()V", "GetDispatchPostResumeHandler")]
		public virtual void DispatchPostResume ()
		{
			if (id_dispatchPostResume == IntPtr.Zero)
				id_dispatchPostResume = JNIEnv.GetMethodID (class_ref, "dispatchPostResume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchPostResume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchPostResume);
		}

		static Delegate cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetDispatchPrepareOptionsMenu_Landroid_view_Menu_Handler ()
		{
			if (cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_ == null)
				cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchPrepareOptionsMenu_Landroid_view_Menu_);
			return cb_dispatchPrepareOptionsMenu_Landroid_view_Menu_;
		}

		static bool n_DispatchPrepareOptionsMenu_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p0 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchPrepareOptionsMenu (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("dispatchPrepareOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchPrepareOptionsMenu_Landroid_view_Menu_Handler")]
		public abstract bool DispatchPrepareOptionsMenu (global::Android.Views.IMenu p0);

		static Delegate cb_dispatchStop;
#pragma warning disable 0169
		static Delegate GetDispatchStopHandler ()
		{
			if (cb_dispatchStop == null)
				cb_dispatchStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchStop);
			return cb_dispatchStop;
		}

		static void n_DispatchStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchStop ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchStop' and count(parameter)=0]"
		[Register ("dispatchStop", "()V", "GetDispatchStopHandler")]
		public virtual void DispatchStop ()
		{
			if (id_dispatchStop == IntPtr.Zero)
				id_dispatchStop = JNIEnv.GetMethodID (class_ref, "dispatchStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchStop);
		}

		static Delegate cb_dispatchTitleChanged_Ljava_lang_CharSequence_I;
#pragma warning disable 0169
		static Delegate GetDispatchTitleChanged_Ljava_lang_CharSequence_IHandler ()
		{
			if (cb_dispatchTitleChanged_Ljava_lang_CharSequence_I == null)
				cb_dispatchTitleChanged_Ljava_lang_CharSequence_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DispatchTitleChanged_Ljava_lang_CharSequence_I);
			return cb_dispatchTitleChanged_Ljava_lang_CharSequence_I;
		}

		static void n_DispatchTitleChanged_Ljava_lang_CharSequence_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchTitleChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchTitleChanged_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchTitleChanged' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("dispatchTitleChanged", "(Ljava/lang/CharSequence;I)V", "GetDispatchTitleChanged_Ljava_lang_CharSequence_IHandler")]
		public virtual void DispatchTitleChanged (global::Java.Lang.ICharSequence p0, int p1)
		{
			if (id_dispatchTitleChanged_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_dispatchTitleChanged_Ljava_lang_CharSequence_I = JNIEnv.GetMethodID (class_ref, "dispatchTitleChanged", "(Ljava/lang/CharSequence;I)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchTitleChanged_Ljava_lang_CharSequence_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_dispatchTitleChanged_Ljava_lang_CharSequence_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		public void DispatchTitleChanged (string p0, int p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			DispatchTitleChanged (jls_p0, p1);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_hasFeature_I;
#pragma warning disable 0169
		static Delegate GetHasFeature_IHandler ()
		{
			if (cb_hasFeature_I == null)
				cb_hasFeature_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_HasFeature_I);
			return cb_hasFeature_I;
		}

		static bool n_HasFeature_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFeature (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='hasFeature' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasFeature", "(I)Z", "GetHasFeature_IHandler")]
		public abstract bool HasFeature (int p0);

		static IntPtr id_registerImplementation_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='registerImplementation' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("registerImplementation", "(Ljava/lang/Class;)V", "")]
		public static void RegisterImplementation (global::Java.Lang.Class p0)
		{
			if (id_registerImplementation_Ljava_lang_Class_ == IntPtr.Zero)
				id_registerImplementation_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "registerImplementation", "(Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerImplementation_Ljava_lang_Class_, new JValue (p0));
		}

		static Delegate cb_requestFeature_I;
#pragma warning disable 0169
		static Delegate GetRequestFeature_IHandler ()
		{
			if (cb_requestFeature_I == null)
				cb_requestFeature_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RequestFeature_I);
			return cb_requestFeature_I;
		}

		static bool n_RequestFeature_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestFeature (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='requestFeature' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestFeature", "(I)Z", "GetRequestFeature_IHandler")]
		public abstract bool RequestFeature (int p0);

		static Delegate cb_setContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetContentView_Landroid_view_View_Handler ()
		{
			if (cb_setContentView_Landroid_view_View_ == null)
				cb_setContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentView_Landroid_view_View_);
			return cb_setContentView_Landroid_view_View_;
		}

		static void n_SetContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setContentView", "(Landroid/view/View;)V", "GetSetContentView_Landroid_view_View_Handler")]
		public virtual void SetContentView (global::Android.Views.View p0)
		{
			if (id_setContentView_Landroid_view_View_ == IntPtr.Zero)
				id_setContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setContentView", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setContentView_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setContentView_Landroid_view_View_, new JValue (p0));
		}

		static Delegate cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler ()
		{
			if (cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
				cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_);
			return cb_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		static void n_SetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup.LayoutParams p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetContentView (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setContentView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public abstract void SetContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1);

		static Delegate cb_setContentView_I;
#pragma warning disable 0169
		static Delegate GetSetContentView_IHandler ()
		{
			if (cb_setContentView_I == null)
				cb_setContentView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetContentView_I);
			return cb_setContentView_I;
		}

		static void n_SetContentView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentView (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setContentView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentView", "(I)V", "GetSetContentView_IHandler")]
		public abstract void SetContentView (int p0);

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
		public abstract void SetProgress (int p0);

		static Delegate cb_setProgressBarIndeterminate_Z;
#pragma warning disable 0169
		static Delegate GetSetProgressBarIndeterminate_ZHandler ()
		{
			if (cb_setProgressBarIndeterminate_Z == null)
				cb_setProgressBarIndeterminate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetProgressBarIndeterminate_Z);
			return cb_setProgressBarIndeterminate_Z;
		}

		static void n_SetProgressBarIndeterminate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarIndeterminate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgressBarIndeterminate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setProgressBarIndeterminate", "(Z)V", "GetSetProgressBarIndeterminate_ZHandler")]
		public abstract void SetProgressBarIndeterminate (bool p0);

		static Delegate cb_setProgressBarIndeterminateVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetProgressBarIndeterminateVisibility_ZHandler ()
		{
			if (cb_setProgressBarIndeterminateVisibility_Z == null)
				cb_setProgressBarIndeterminateVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetProgressBarIndeterminateVisibility_Z);
			return cb_setProgressBarIndeterminateVisibility_Z;
		}

		static void n_SetProgressBarIndeterminateVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarIndeterminateVisibility (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgressBarIndeterminateVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setProgressBarIndeterminateVisibility", "(Z)V", "GetSetProgressBarIndeterminateVisibility_ZHandler")]
		public abstract void SetProgressBarIndeterminateVisibility (bool p0);

		static Delegate cb_setProgressBarVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetProgressBarVisibility_ZHandler ()
		{
			if (cb_setProgressBarVisibility_Z == null)
				cb_setProgressBarVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetProgressBarVisibility_Z);
			return cb_setProgressBarVisibility_Z;
		}

		static void n_SetProgressBarVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressBarVisibility (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgressBarVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setProgressBarVisibility", "(Z)V", "GetSetProgressBarVisibility_ZHandler")]
		public abstract void SetProgressBarVisibility (bool p0);

		static Delegate cb_setSecondaryProgress_I;
#pragma warning disable 0169
		static Delegate GetSetSecondaryProgress_IHandler ()
		{
			if (cb_setSecondaryProgress_I == null)
				cb_setSecondaryProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSecondaryProgress_I);
			return cb_setSecondaryProgress_I;
		}

		static void n_SetSecondaryProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSecondaryProgress (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setSecondaryProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSecondaryProgress", "(I)V", "GetSetSecondaryProgress_IHandler")]
		public abstract void SetSecondaryProgress (int p0);

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static void n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public virtual void SetTitle (int p0)
		{
			if (id_setTitle_I == IntPtr.Zero)
				id_setTitle_I = JNIEnv.GetMethodID (class_ref, "setTitle", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTitle_I, new JValue (p0));
		}

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static void n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public abstract void SetTitle (global::Java.Lang.ICharSequence p0);

		public void SetTitle (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetTitle (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_setUiOptions_I;
#pragma warning disable 0169
		static Delegate GetSetUiOptions_IHandler ()
		{
			if (cb_setUiOptions_I == null)
				cb_setUiOptions_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUiOptions_I);
			return cb_setUiOptions_I;
		}

		static void n_SetUiOptions_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUiOptions (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setUiOptions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setUiOptions", "(I)V", "GetSetUiOptions_IHandler")]
		public abstract void SetUiOptions (int p0);

		static Delegate cb_setUiOptions_II;
#pragma warning disable 0169
		static Delegate GetSetUiOptions_IIHandler ()
		{
			if (cb_setUiOptions_II == null)
				cb_setUiOptions_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetUiOptions_II);
			return cb_setUiOptions_II;
		}

		static void n_SetUiOptions_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUiOptions (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setUiOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setUiOptions", "(II)V", "GetSetUiOptions_IIHandler")]
		public abstract void SetUiOptions (int p0, int p1);

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
			global::Com.Actionbarsherlock.ActionBarSherlock __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.ActionMode.ICallback p0 = (global::Com.Actionbarsherlock.View.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='startActionMode' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.ActionMode.Callback']]"
		[Register ("startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;", "GetStartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_Handler")]
		public abstract global::Com.Actionbarsherlock.View.ActionMode StartActionMode (global::Com.Actionbarsherlock.View.ActionMode.ICallback p0);

		static IntPtr id_unregisterImplementation_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='unregisterImplementation' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("unregisterImplementation", "(Ljava/lang/Class;)Z", "")]
		public static bool UnregisterImplementation (global::Java.Lang.Class p0)
		{
			if (id_unregisterImplementation_Ljava_lang_Class_ == IntPtr.Zero)
				id_unregisterImplementation_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterImplementation", "(Ljava/lang/Class;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_unregisterImplementation_Ljava_lang_Class_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_wrap_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("wrap", "(Landroid/app/Activity;)Lcom/actionbarsherlock/ActionBarSherlock;", "")]
		public static global::Com.Actionbarsherlock.ActionBarSherlock Wrap (global::Android.App.Activity p0)
		{
			if (id_wrap_Landroid_app_Activity_ == IntPtr.Zero)
				id_wrap_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/app/Activity;)Lcom/actionbarsherlock/ActionBarSherlock;");
			global::Com.Actionbarsherlock.ActionBarSherlock __ret = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_app_Activity_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_wrap_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='wrap' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("wrap", "(Landroid/app/Activity;I)Lcom/actionbarsherlock/ActionBarSherlock;", "")]
		public static global::Com.Actionbarsherlock.ActionBarSherlock Wrap (global::Android.App.Activity p0, int p1)
		{
			if (id_wrap_Landroid_app_Activity_I == IntPtr.Zero)
				id_wrap_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/app/Activity;I)Lcom/actionbarsherlock/ActionBarSherlock;");
			global::Com.Actionbarsherlock.ActionBarSherlock __ret = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.ActionBarSherlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_app_Activity_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/actionbarsherlock/ActionBarSherlock", DoNotGenerateAcw=true)]
	internal partial class ActionBarSherlockInvoker : ActionBarSherlock {

		public ActionBarSherlockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarSherlockInvoker); }
		}

		static IntPtr id_getActionBar;
		public override global::Com.Actionbarsherlock.App.ActionBar ActionBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='getActionBar' and count(parameter)=0]"
			[Register ("getActionBar", "()Lcom/actionbarsherlock/app/ActionBar;", "GetGetActionBarHandler")]
			get {
				if (id_getActionBar == IntPtr.Zero)
					id_getActionBar = JNIEnv.GetMethodID (class_ref, "getActionBar", "()Lcom/actionbarsherlock/app/ActionBar;");
				return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.App.ActionBar> (JNIEnv.CallObjectMethod  (Handle, id_getActionBar), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getThemedContext;
		protected override global::Android.Content.Context ThemedContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='getThemedContext' and count(parameter)=0]"
			[Register ("getThemedContext", "()Landroid/content/Context;", "GetGetThemedContextHandler")]
			get {
				if (id_getThemedContext == IntPtr.Zero)
					id_getThemedContext = JNIEnv.GetMethodID (class_ref, "getThemedContext", "()Landroid/content/Context;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getThemedContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='addContentView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public override void AddContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1)
		{
			if (id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_dispatchCreateOptionsMenu_Landroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchCreateOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("dispatchCreateOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchCreateOptionsMenu_Landroid_view_Menu_Handler")]
		public override bool DispatchCreateOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_dispatchCreateOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_dispatchCreateOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchCreateOptionsMenu_Landroid_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_dispatchInvalidateOptionsMenu;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchInvalidateOptionsMenu' and count(parameter)=0]"
		[Register ("dispatchInvalidateOptionsMenu", "()V", "GetDispatchInvalidateOptionsMenuHandler")]
		public override void DispatchInvalidateOptionsMenu ()
		{
			if (id_dispatchInvalidateOptionsMenu == IntPtr.Zero)
				id_dispatchInvalidateOptionsMenu = JNIEnv.GetMethodID (class_ref, "dispatchInvalidateOptionsMenu", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_dispatchInvalidateOptionsMenu);
		}

		static IntPtr id_dispatchOptionsItemSelected_Landroid_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchOptionsItemSelected' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
		[Register ("dispatchOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetDispatchOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public override bool DispatchOptionsItemSelected (global::Android.Views.IMenuItem p0)
		{
			if (id_dispatchOptionsItemSelected_Landroid_view_MenuItem_ == IntPtr.Zero)
				id_dispatchOptionsItemSelected_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "dispatchOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchOptionsItemSelected_Landroid_view_MenuItem_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_dispatchPrepareOptionsMenu_Landroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='dispatchPrepareOptionsMenu' and count(parameter)=1 and parameter[1][@type='android.view.Menu']]"
		[Register ("dispatchPrepareOptionsMenu", "(Landroid/view/Menu;)Z", "GetDispatchPrepareOptionsMenu_Landroid_view_Menu_Handler")]
		public override bool DispatchPrepareOptionsMenu (global::Android.Views.IMenu p0)
		{
			if (id_dispatchPrepareOptionsMenu_Landroid_view_Menu_ == IntPtr.Zero)
				id_dispatchPrepareOptionsMenu_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "dispatchPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchPrepareOptionsMenu_Landroid_view_Menu_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hasFeature_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='hasFeature' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasFeature", "(I)Z", "GetHasFeature_IHandler")]
		public override bool HasFeature (int p0)
		{
			if (id_hasFeature_I == IntPtr.Zero)
				id_hasFeature_I = JNIEnv.GetMethodID (class_ref, "hasFeature", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_hasFeature_I, new JValue (p0));
		}

		static IntPtr id_requestFeature_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='requestFeature' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestFeature", "(I)Z", "GetRequestFeature_IHandler")]
		public override bool RequestFeature (int p0)
		{
			if (id_requestFeature_I == IntPtr.Zero)
				id_requestFeature_I = JNIEnv.GetMethodID (class_ref, "requestFeature", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_requestFeature_I, new JValue (p0));
		}

		static IntPtr id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setContentView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetSetContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public override void SetContentView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1)
		{
			if (id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setContentView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setContentView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setContentView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentView", "(I)V", "GetSetContentView_IHandler")]
		public override void SetContentView (int p0)
		{
			if (id_setContentView_I == IntPtr.Zero)
				id_setContentView_I = JNIEnv.GetMethodID (class_ref, "setContentView", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setContentView_I, new JValue (p0));
		}

		static IntPtr id_setProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
		public override void SetProgress (int p0)
		{
			if (id_setProgress_I == IntPtr.Zero)
				id_setProgress_I = JNIEnv.GetMethodID (class_ref, "setProgress", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgress_I, new JValue (p0));
		}

		static IntPtr id_setProgressBarIndeterminate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgressBarIndeterminate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setProgressBarIndeterminate", "(Z)V", "GetSetProgressBarIndeterminate_ZHandler")]
		public override void SetProgressBarIndeterminate (bool p0)
		{
			if (id_setProgressBarIndeterminate_Z == IntPtr.Zero)
				id_setProgressBarIndeterminate_Z = JNIEnv.GetMethodID (class_ref, "setProgressBarIndeterminate", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgressBarIndeterminate_Z, new JValue (p0));
		}

		static IntPtr id_setProgressBarIndeterminateVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgressBarIndeterminateVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setProgressBarIndeterminateVisibility", "(Z)V", "GetSetProgressBarIndeterminateVisibility_ZHandler")]
		public override void SetProgressBarIndeterminateVisibility (bool p0)
		{
			if (id_setProgressBarIndeterminateVisibility_Z == IntPtr.Zero)
				id_setProgressBarIndeterminateVisibility_Z = JNIEnv.GetMethodID (class_ref, "setProgressBarIndeterminateVisibility", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgressBarIndeterminateVisibility_Z, new JValue (p0));
		}

		static IntPtr id_setProgressBarVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setProgressBarVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setProgressBarVisibility", "(Z)V", "GetSetProgressBarVisibility_ZHandler")]
		public override void SetProgressBarVisibility (bool p0)
		{
			if (id_setProgressBarVisibility_Z == IntPtr.Zero)
				id_setProgressBarVisibility_Z = JNIEnv.GetMethodID (class_ref, "setProgressBarVisibility", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setProgressBarVisibility_Z, new JValue (p0));
		}

		static IntPtr id_setSecondaryProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setSecondaryProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSecondaryProgress", "(I)V", "GetSetSecondaryProgress_IHandler")]
		public override void SetSecondaryProgress (int p0)
		{
			if (id_setSecondaryProgress_I == IntPtr.Zero)
				id_setSecondaryProgress_I = JNIEnv.GetMethodID (class_ref, "setSecondaryProgress", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setSecondaryProgress_I, new JValue (p0));
		}

		static IntPtr id_setTitle_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public override void SetTitle (global::Java.Lang.ICharSequence p0)
		{
			if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setUiOptions_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setUiOptions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setUiOptions", "(I)V", "GetSetUiOptions_IHandler")]
		public override void SetUiOptions (int p0)
		{
			if (id_setUiOptions_I == IntPtr.Zero)
				id_setUiOptions_I = JNIEnv.GetMethodID (class_ref, "setUiOptions", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setUiOptions_I, new JValue (p0));
		}

		static IntPtr id_setUiOptions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='setUiOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setUiOptions", "(II)V", "GetSetUiOptions_IIHandler")]
		public override void SetUiOptions (int p0, int p1)
		{
			if (id_setUiOptions_II == IntPtr.Zero)
				id_setUiOptions_II = JNIEnv.GetMethodID (class_ref, "setUiOptions", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_setUiOptions_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock']/class[@name='ActionBarSherlock']/method[@name='startActionMode' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.ActionMode.Callback']]"
		[Register ("startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;", "GetStartActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_Handler")]
		public override global::Com.Actionbarsherlock.View.ActionMode StartActionMode (global::Com.Actionbarsherlock.View.ActionMode.ICallback p0)
		{
			if (id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ == IntPtr.Zero)
				id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "startActionMode", "(Lcom/actionbarsherlock/view/ActionMode$Callback;)Lcom/actionbarsherlock/view/ActionMode;");
			global::Com.Actionbarsherlock.View.ActionMode __ret = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_startActionMode_Lcom_actionbarsherlock_view_ActionMode_Callback_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
