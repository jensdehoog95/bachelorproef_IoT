using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger", DoNotGenerateAcw=true)]
	public partial class MultiByteInteger : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiByteInteger); }
		}

		protected MultiByteInteger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/constructor[@name='MultiByteInteger' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MultiByteInteger (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MultiByteInteger)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/constructor[@name='MultiByteInteger' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register (".ctor", "(JI)V", "")]
		public unsafe MultiByteInteger (long p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MultiByteInteger)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JI)V", __args);
					return;
				}

				if (id_ctor_JI == IntPtr.Zero)
					id_ctor_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(JI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JI, __args);
			} finally {
			}
		}

		static Delegate cb_getEncodedLength;
#pragma warning disable 0169
		static Delegate GetGetEncodedLengthHandler ()
		{
			if (cb_getEncodedLength == null)
				cb_getEncodedLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEncodedLength);
			return cb_getEncodedLength;
		}

		static int n_GetEncodedLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EncodedLength;
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedLength;
		public virtual unsafe int EncodedLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/method[@name='getEncodedLength' and count(parameter)=0]"
			[Register ("getEncodedLength", "()I", "GetGetEncodedLengthHandler")]
			get {
				if (id_getEncodedLength == IntPtr.Zero)
					id_getEncodedLength = JNIEnv.GetMethodID (class_ref, "getEncodedLength", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getEncodedLength);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodedLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetValue);
			return cb_getValue;
		}

		static long n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe long Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteInteger']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()J", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getValue);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()J"));
				} finally {
				}
			}
		}

	}
}
