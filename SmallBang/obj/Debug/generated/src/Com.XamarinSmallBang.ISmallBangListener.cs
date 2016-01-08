using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.XamarinSmallBang {

	// Metadata.xml XPath interface reference: path="/api/package[@name='Com.XamarinSmallBang']/interface[@name='SmallBangListener']"
	[Register ("Com/XamarinSmallBang/SmallBangListener", "", "Com.XamarinSmallBang.ISmallBangListenerInvoker")]
	public partial interface ISmallBangListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/interface[@name='SmallBangListener']/method[@name='onAnimationEnd' and count(parameter)=0]"
		[Register ("onAnimationEnd", "()V", "GetOnAnimationEndHandler:Com.XamarinSmallBang.ISmallBangListenerInvoker, SmallBang")]
		void OnAnimationEnd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='Com.XamarinSmallBang']/interface[@name='SmallBangListener']/method[@name='onAnimationStart' and count(parameter)=0]"
		[Register ("onAnimationStart", "()V", "GetOnAnimationStartHandler:Com.XamarinSmallBang.ISmallBangListenerInvoker, SmallBang")]
		void OnAnimationStart ();

	}

	[global::Android.Runtime.Register ("Com/XamarinSmallBang/SmallBangListener", DoNotGenerateAcw=true)]
	internal class ISmallBangListenerInvoker : global::Java.Lang.Object, ISmallBangListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("Com/XamarinSmallBang/SmallBangListener");
		IntPtr class_ref;

		public static ISmallBangListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISmallBangListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "Com.XamarinSmallBang.SmallBangListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISmallBangListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISmallBangListenerInvoker); }
		}

		static Delegate cb_onAnimationEnd;
#pragma warning disable 0169
		static Delegate GetOnAnimationEndHandler ()
		{
			if (cb_onAnimationEnd == null)
				cb_onAnimationEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationEnd);
			return cb_onAnimationEnd;
		}

		static void n_OnAnimationEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.XamarinSmallBang.ISmallBangListener __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.ISmallBangListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd ();
		}
#pragma warning restore 0169

		IntPtr id_onAnimationEnd;
		public unsafe void OnAnimationEnd ()
		{
			if (id_onAnimationEnd == IntPtr.Zero)
				id_onAnimationEnd = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onAnimationEnd);
		}

		static Delegate cb_onAnimationStart;
#pragma warning disable 0169
		static Delegate GetOnAnimationStartHandler ()
		{
			if (cb_onAnimationStart == null)
				cb_onAnimationStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationStart);
			return cb_onAnimationStart;
		}

		static void n_OnAnimationStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.XamarinSmallBang.ISmallBangListener __this = global::Java.Lang.Object.GetObject<global::Com.XamarinSmallBang.ISmallBangListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationStart ();
		}
#pragma warning restore 0169

		IntPtr id_onAnimationStart;
		public unsafe void OnAnimationStart ()
		{
			if (id_onAnimationStart == IntPtr.Zero)
				id_onAnimationStart = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onAnimationStart);
		}

	}

	[global::Android.Runtime.Register ("mono/Com/XamarinSmallBang/SmallBangListenerImplementor")]
	internal sealed partial class ISmallBangListenerImplementor : global::Java.Lang.Object, ISmallBangListener {

		object sender;

		public ISmallBangListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/Com/XamarinSmallBang/SmallBangListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnAnimationEndHandler;
#pragma warning restore 0649

		public void OnAnimationEnd ()
		{
			var __h = OnAnimationEndHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnAnimationStartHandler;
#pragma warning restore 0649

		public void OnAnimationStart ()
		{
			var __h = OnAnimationStartHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ISmallBangListenerImplementor value)
		{
			return value.OnAnimationEndHandler == null && value.OnAnimationStartHandler == null;
		}
	}

}
