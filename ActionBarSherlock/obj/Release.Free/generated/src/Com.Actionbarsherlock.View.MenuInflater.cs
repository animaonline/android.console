using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Actionbarsherlock.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater']"
	[global::Android.Runtime.Register ("com/actionbarsherlock/view/MenuInflater", DoNotGenerateAcw=true)]
	public partial class MenuInflater : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.InflatedOnMenuItemClickListener']"
		[global::Android.Runtime.Register ("com/actionbarsherlock/view/MenuInflater$InflatedOnMenuItemClickListener", DoNotGenerateAcw=true)]
		public partial class InflatedOnMenuItemClickListener : global::Java.Lang.Object, global::Com.Actionbarsherlock.View.IMenuItemOnMenuItemClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/actionbarsherlock/view/MenuInflater$InflatedOnMenuItemClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InflatedOnMenuItemClickListener); }
			}

			protected InflatedOnMenuItemClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.InflatedOnMenuItemClickListener']/constructor[@name='MenuInflater.InflatedOnMenuItemClickListener' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
			public InflatedOnMenuItemClickListener (global::Android.Content.Context p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (InflatedOnMenuItemClickListener)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
			}

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
				global::Com.Actionbarsherlock.View.MenuInflater.InflatedOnMenuItemClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater.InflatedOnMenuItemClickListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Actionbarsherlock.View.IMenuItem p0 = (global::Com.Actionbarsherlock.View.IMenuItem)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMenuItemClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.InflatedOnMenuItemClickListener']/method[@name='onMenuItemClick' and count(parameter)=1 and parameter[1][@type='com.actionbarsherlock.view.MenuItem']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']"
		[global::Android.Runtime.Register ("com/actionbarsherlock/view/MenuInflater$MenuState", DoNotGenerateAcw=true)]
		public partial class MenuState : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/actionbarsherlock/view/MenuInflater$MenuState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MenuState); }
			}

			protected MenuState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_actionbarsherlock_view_MenuInflater_Lcom_actionbarsherlock_view_Menu_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']/constructor[@name='MenuInflater.MenuState' and count(parameter)=2 and parameter[1][@type='com.actionbarsherlock.view.MenuInflater'] and parameter[2][@type='com.actionbarsherlock.view.Menu']]"
			[Register (".ctor", "(Lcom/actionbarsherlock/view/MenuInflater;Lcom/actionbarsherlock/view/Menu;)V", "")]
			public MenuState (global::Com.Actionbarsherlock.View.MenuInflater __self, global::Com.Actionbarsherlock.View.IMenu p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MenuState)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/actionbarsherlock/view/Menu;)V", new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_actionbarsherlock_view_MenuInflater_Lcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
					id_ctor_Lcom_actionbarsherlock_view_MenuInflater_Lcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/actionbarsherlock/view/MenuInflater;Lcom/actionbarsherlock/view/Menu;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_actionbarsherlock_view_MenuInflater_Lcom_actionbarsherlock_view_Menu_, new JValue (__self), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_hasAddedItem;
#pragma warning disable 0169
			static Delegate GetHasAddedItemHandler ()
			{
				if (cb_hasAddedItem == null)
					cb_hasAddedItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAddedItem);
				return cb_hasAddedItem;
			}

			static bool n_HasAddedItem (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Actionbarsherlock.View.MenuInflater.MenuState __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater.MenuState> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasAddedItem;
			}
#pragma warning restore 0169

			static IntPtr id_hasAddedItem;
			public virtual bool HasAddedItem {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']/method[@name='hasAddedItem' and count(parameter)=0]"
				[Register ("hasAddedItem", "()Z", "GetHasAddedItemHandler")]
				get {
					if (id_hasAddedItem == IntPtr.Zero)
						id_hasAddedItem = JNIEnv.GetMethodID (class_ref, "hasAddedItem", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasAddedItem);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasAddedItem);
				}
			}

			static Delegate cb_addItem;
#pragma warning disable 0169
			static Delegate GetAddItemHandler ()
			{
				if (cb_addItem == null)
					cb_addItem = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddItem);
				return cb_addItem;
			}

			static void n_AddItem (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Actionbarsherlock.View.MenuInflater.MenuState __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater.MenuState> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.AddItem ();
			}
#pragma warning restore 0169

			static IntPtr id_addItem;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']/method[@name='addItem' and count(parameter)=0]"
			[Register ("addItem", "()V", "GetAddItemHandler")]
			public virtual void AddItem ()
			{
				if (id_addItem == IntPtr.Zero)
					id_addItem = JNIEnv.GetMethodID (class_ref, "addItem", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addItem);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addItem);
			}

			static Delegate cb_addSubMenuItem;
#pragma warning disable 0169
			static Delegate GetAddSubMenuItemHandler ()
			{
				if (cb_addSubMenuItem == null)
					cb_addSubMenuItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AddSubMenuItem);
				return cb_addSubMenuItem;
			}

			static IntPtr n_AddSubMenuItem (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Actionbarsherlock.View.MenuInflater.MenuState __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater.MenuState> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AddSubMenuItem ());
			}
#pragma warning restore 0169

			static IntPtr id_addSubMenuItem;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']/method[@name='addSubMenuItem' and count(parameter)=0]"
			[Register ("addSubMenuItem", "()Lcom/actionbarsherlock/view/SubMenu;", "GetAddSubMenuItemHandler")]
			public virtual global::Com.Actionbarsherlock.View.ISubMenu AddSubMenuItem ()
			{
				if (id_addSubMenuItem == IntPtr.Zero)
					id_addSubMenuItem = JNIEnv.GetMethodID (class_ref, "addSubMenuItem", "()Lcom/actionbarsherlock/view/SubMenu;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ISubMenu> (JNIEnv.CallObjectMethod  (Handle, id_addSubMenuItem), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.ISubMenu> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_addSubMenuItem), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_readGroup_Landroid_util_AttributeSet_;
#pragma warning disable 0169
			static Delegate GetReadGroup_Landroid_util_AttributeSet_Handler ()
			{
				if (cb_readGroup_Landroid_util_AttributeSet_ == null)
					cb_readGroup_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadGroup_Landroid_util_AttributeSet_);
				return cb_readGroup_Landroid_util_AttributeSet_;
			}

			static void n_ReadGroup_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Actionbarsherlock.View.MenuInflater.MenuState __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater.MenuState> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.IAttributeSet p0 = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ReadGroup (p0);
			}
#pragma warning restore 0169

			static IntPtr id_readGroup_Landroid_util_AttributeSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']/method[@name='readGroup' and count(parameter)=1 and parameter[1][@type='android.util.AttributeSet']]"
			[Register ("readGroup", "(Landroid/util/AttributeSet;)V", "GetReadGroup_Landroid_util_AttributeSet_Handler")]
			public virtual void ReadGroup (global::Android.Util.IAttributeSet p0)
			{
				if (id_readGroup_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_readGroup_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "readGroup", "(Landroid/util/AttributeSet;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_readGroup_Landroid_util_AttributeSet_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_readGroup_Landroid_util_AttributeSet_, new JValue (p0));
			}

			static Delegate cb_readItem_Landroid_util_AttributeSet_;
#pragma warning disable 0169
			static Delegate GetReadItem_Landroid_util_AttributeSet_Handler ()
			{
				if (cb_readItem_Landroid_util_AttributeSet_ == null)
					cb_readItem_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadItem_Landroid_util_AttributeSet_);
				return cb_readItem_Landroid_util_AttributeSet_;
			}

			static void n_ReadItem_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Actionbarsherlock.View.MenuInflater.MenuState __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater.MenuState> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.IAttributeSet p0 = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ReadItem (p0);
			}
#pragma warning restore 0169

			static IntPtr id_readItem_Landroid_util_AttributeSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']/method[@name='readItem' and count(parameter)=1 and parameter[1][@type='android.util.AttributeSet']]"
			[Register ("readItem", "(Landroid/util/AttributeSet;)V", "GetReadItem_Landroid_util_AttributeSet_Handler")]
			public virtual void ReadItem (global::Android.Util.IAttributeSet p0)
			{
				if (id_readItem_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_readItem_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "readItem", "(Landroid/util/AttributeSet;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_readItem_Landroid_util_AttributeSet_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_readItem_Landroid_util_AttributeSet_, new JValue (p0));
			}

			static Delegate cb_resetGroup;
#pragma warning disable 0169
			static Delegate GetResetGroupHandler ()
			{
				if (cb_resetGroup == null)
					cb_resetGroup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetGroup);
				return cb_resetGroup;
			}

			static void n_ResetGroup (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Actionbarsherlock.View.MenuInflater.MenuState __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater.MenuState> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.ResetGroup ();
			}
#pragma warning restore 0169

			static IntPtr id_resetGroup;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater.MenuState']/method[@name='resetGroup' and count(parameter)=0]"
			[Register ("resetGroup", "()V", "GetResetGroupHandler")]
			public virtual void ResetGroup ()
			{
				if (id_resetGroup == IntPtr.Zero)
					id_resetGroup = JNIEnv.GetMethodID (class_ref, "resetGroup", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resetGroup);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resetGroup);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/actionbarsherlock/view/MenuInflater", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MenuInflater); }
		}

		protected MenuInflater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater']/constructor[@name='MenuInflater' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MenuInflater (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MenuInflater)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_inflate_ILcom_actionbarsherlock_view_Menu_;
#pragma warning disable 0169
		static Delegate GetInflate_ILcom_actionbarsherlock_view_Menu_Handler ()
		{
			if (cb_inflate_ILcom_actionbarsherlock_view_Menu_ == null)
				cb_inflate_ILcom_actionbarsherlock_view_Menu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Inflate_ILcom_actionbarsherlock_view_Menu_);
			return cb_inflate_ILcom_actionbarsherlock_view_Menu_;
		}

		static void n_Inflate_ILcom_actionbarsherlock_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Actionbarsherlock.View.MenuInflater __this = global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.MenuInflater> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Actionbarsherlock.View.IMenu p1 = (global::Com.Actionbarsherlock.View.IMenu)global::Java.Lang.Object.GetObject<global::Com.Actionbarsherlock.View.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Inflate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_inflate_ILcom_actionbarsherlock_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.actionbarsherlock.view']/class[@name='MenuInflater']/method[@name='inflate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.actionbarsherlock.view.Menu']]"
		[Register ("inflate", "(ILcom/actionbarsherlock/view/Menu;)V", "GetInflate_ILcom_actionbarsherlock_view_Menu_Handler")]
		public virtual void Inflate (int p0, global::Com.Actionbarsherlock.View.IMenu p1)
		{
			if (id_inflate_ILcom_actionbarsherlock_view_Menu_ == IntPtr.Zero)
				id_inflate_ILcom_actionbarsherlock_view_Menu_ = JNIEnv.GetMethodID (class_ref, "inflate", "(ILcom/actionbarsherlock/view/Menu;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_inflate_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_inflate_ILcom_actionbarsherlock_view_Menu_, new JValue (p0), new JValue (p1));
		}

	}
}
