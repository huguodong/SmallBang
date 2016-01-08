using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.XamarinSmallBang {

	// Metadata.xml XPath class reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']"
	[global::Android.Runtime.Register ("Com/XamarinSmallBang/SmallBang", DoNotGenerateAcw=true)]
	public partial class SmallBang : global::Android.Views.View {

		// Metadata.xml XPath class reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang.Dot']"
		[global::Android.Runtime.Register ("Com/XamarinSmallBang/SmallBang$Dot", DoNotGenerateAcw=true)]
		public partial class Dot : global::Java.Lang.Object {

			protected Dot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("Com/XamarinSmallBang/SmallBang", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmallBang); }
		}

		protected SmallBang (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/constructor[@name='SmallBang' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SmallBang (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SmallBang)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/constructor[@name='SmallBang' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SmallBang (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SmallBang)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/constructor[@name='SmallBang' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SmallBang (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SmallBang)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/constructor[@name='SmallBang' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe SmallBang (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (SmallBang)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static IntPtr id_attach2Window_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/method[@name='attach2Window' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("attach2Window", "(Landroid/app/Activity;)LCom/XamarinSmallBang/SmallBang;", "")]
		public static unsafe global::Com.XamarinSmallBang.SmallBang Attach2Window (global::Android.App.Activity p0)
		{
			if (id_attach2Window_Landroid_app_Activity_ == IntPtr.Zero)
				id_attach2Window_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "attach2Window", "(Landroid/app/Activity;)LCom/XamarinSmallBang/SmallBang;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.XamarinSmallBang.SmallBang __ret = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.SmallBang> (JNIEnv.CallStaticObjectMethod  (class_ref, id_attach2Window_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_bang_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetBang_Landroid_view_View_Handler ()
		{
			if (cb_bang_Landroid_view_View_ == null)
				cb_bang_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Bang_Landroid_view_View_);
			return cb_bang_Landroid_view_View_;
		}

		static void n_Bang_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.XamarinSmallBang.SmallBang __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.SmallBang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Bang (p0);
		}
#pragma warning restore 0169

		static IntPtr id_bang_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/method[@name='bang' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("bang", "(Landroid/view/View;)V", "GetBang_Landroid_view_View_Handler")]
		public virtual unsafe void Bang (global::Android.Views.View p0)
		{
			if (id_bang_Landroid_view_View_ == IntPtr.Zero)
				id_bang_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "bang", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_bang_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bang", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_;
#pragma warning disable 0169
		static Delegate GetBang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_Handler ()
		{
			if (cb_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_ == null)
				cb_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_);
			return cb_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_;
		}

		static void n_Bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.XamarinSmallBang.SmallBang __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.SmallBang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.XamarinSmallBang.ISmallBangListener p1 = (global::Com.XamarinSmallBang.ISmallBangListener)global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.ISmallBangListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Bang (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/method[@name='bang' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='Com.XamarinSmallBang.SmallBangListener']]"
		[Register ("bang", "(Landroid/view/View;LCom/XamarinSmallBang/SmallBangListener;)V", "GetBang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_Handler")]
		public virtual unsafe void Bang (global::Android.Views.View p0, global::Com.XamarinSmallBang.ISmallBangListener p1)
		{
			if (id_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_ == IntPtr.Zero)
				id_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_ = JNIEnv.GetMethodID (class_ref, "bang", "(Landroid/view/View;LCom/XamarinSmallBang/SmallBangListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_bang_Landroid_view_View_LCom_XamarinSmallBang_SmallBangListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bang", "(Landroid/view/View;LCom/XamarinSmallBang/SmallBangListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_;
#pragma warning disable 0169
		static Delegate GetBang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_Handler ()
		{
			if (cb_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_ == null)
				cb_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_Bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_);
			return cb_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_;
		}

		static void n_Bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, IntPtr native_p2)
		{
			global::Com.XamarinSmallBang.SmallBang __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.SmallBang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.XamarinSmallBang.ISmallBangListener p2 = (global::Com.XamarinSmallBang.ISmallBangListener)global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.ISmallBangListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Bang (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/method[@name='bang' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='Com.XamarinSmallBang.SmallBangListener']]"
		[Register ("bang", "(Landroid/view/View;FLCom/XamarinSmallBang/SmallBangListener;)V", "GetBang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_Handler")]
		public virtual unsafe void Bang (global::Android.Views.View p0, float p1, global::Com.XamarinSmallBang.ISmallBangListener p2)
		{
			if (id_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_ == IntPtr.Zero)
				id_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_ = JNIEnv.GetMethodID (class_ref, "bang", "(Landroid/view/View;FLCom/XamarinSmallBang/SmallBangListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_bang_Landroid_view_View_FLCom_XamarinSmallBang_SmallBangListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bang", "(Landroid/view/View;FLCom/XamarinSmallBang/SmallBangListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetColors_arrayIHandler ()
		{
			if (cb_setColors_arrayI == null)
				cb_setColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColors_arrayI);
			return cb_setColors_arrayI;
		}

		static void n_SetColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.XamarinSmallBang.SmallBang __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.SmallBang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColors (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColors_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/method[@name='setColors' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setColors", "([I)V", "GetSetColors_arrayIHandler")]
		public virtual unsafe void SetColors (int[] p0)
		{
			if (id_setColors_arrayI == IntPtr.Zero)
				id_setColors_arrayI = JNIEnv.GetMethodID (class_ref, "setColors", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColors_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColors", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDotNumber_I;
#pragma warning disable 0169
		static Delegate GetSetDotNumber_IHandler ()
		{
			if (cb_setDotNumber_I == null)
				cb_setDotNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDotNumber_I);
			return cb_setDotNumber_I;
		}

		static void n_SetDotNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.XamarinSmallBang.SmallBang __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.SmallBang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDotNumber (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDotNumber_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/method[@name='setDotNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDotNumber", "(I)V", "GetSetDotNumber_IHandler")]
		public virtual unsafe void SetDotNumber (int p0)
		{
			if (id_setDotNumber_I == IntPtr.Zero)
				id_setDotNumber_I = JNIEnv.GetMethodID (class_ref, "setDotNumber", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDotNumber_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDotNumber", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmListener_LCom_XamarinSmallBang_SmallBangListener_;
#pragma warning disable 0169
		static Delegate GetSetmListener_LCom_XamarinSmallBang_SmallBangListener_Handler ()
		{
			if (cb_setmListener_LCom_XamarinSmallBang_SmallBangListener_ == null)
				cb_setmListener_LCom_XamarinSmallBang_SmallBangListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetmListener_LCom_XamarinSmallBang_SmallBangListener_);
			return cb_setmListener_LCom_XamarinSmallBang_SmallBangListener_;
		}

		static void n_SetmListener_LCom_XamarinSmallBang_SmallBangListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.XamarinSmallBang.SmallBang __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.SmallBang> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.XamarinSmallBang.ISmallBangListener p0 = (global::Com.XamarinSmallBang.ISmallBangListener)global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.ISmallBangListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetmListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmListener_LCom_XamarinSmallBang_SmallBangListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/class[@name='SmallBang']/method[@name='setmListener' and count(parameter)=1 and parameter[1][@type='Com.XamarinSmallBang.SmallBangListener']]"
		[Register ("setmListener", "(LCom/XamarinSmallBang/SmallBangListener;)V", "GetSetmListener_LCom_XamarinSmallBang_SmallBangListener_Handler")]
		public virtual unsafe void SetmListener (global::Com.XamarinSmallBang.ISmallBangListener p0)
		{
			if (id_setmListener_LCom_XamarinSmallBang_SmallBangListener_ == IntPtr.Zero)
				id_setmListener_LCom_XamarinSmallBang_SmallBangListener_ = JNIEnv.GetMethodID (class_ref, "setmListener", "(LCom/XamarinSmallBang/SmallBangListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setmListener_LCom_XamarinSmallBang_SmallBangListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmListener", "(LCom/XamarinSmallBang/SmallBangListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.XamarinSmallBang.ISmallBangListener"
		public event EventHandler AnimationEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.XamarinSmallBang.ISmallBangListener, global::Com.XamarinSmallBang.ISmallBangListenerImplementor>(
						ref weak_implementor_SetmListener,
						__CreateISmallBangListenerImplementor,
						SetmListener,
						__h => __h.OnAnimationEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.XamarinSmallBang.ISmallBangListener, global::Com.XamarinSmallBang.ISmallBangListenerImplementor>(
						ref weak_implementor_SetmListener,
						global::Com.XamarinSmallBang.ISmallBangListenerImplementor.__IsEmpty,
						__v => SetmListener (null),
						__h => __h.OnAnimationEndHandler -= value);
			}
		}

		public event EventHandler AnimationStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.XamarinSmallBang.ISmallBangListener, global::Com.XamarinSmallBang.ISmallBangListenerImplementor>(
						ref weak_implementor_SetmListener,
						__CreateISmallBangListenerImplementor,
						SetmListener,
						__h => __h.OnAnimationStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.XamarinSmallBang.ISmallBangListener, global::Com.XamarinSmallBang.ISmallBangListenerImplementor>(
						ref weak_implementor_SetmListener,
						global::Com.XamarinSmallBang.ISmallBangListenerImplementor.__IsEmpty,
						__v => SetmListener (null),
						__h => __h.OnAnimationStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetmListener;

		global::Com.XamarinSmallBang.ISmallBangListenerImplementor __CreateISmallBangListenerImplementor ()
		{
			return new global::Com.XamarinSmallBang.ISmallBangListenerImplementor (this);
		}
#endregion
	}
}
