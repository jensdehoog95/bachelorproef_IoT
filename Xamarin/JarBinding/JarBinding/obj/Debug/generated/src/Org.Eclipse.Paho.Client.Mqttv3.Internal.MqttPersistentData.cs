using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/MqttPersistentData", DoNotGenerateAcw=true)]
	public partial class MqttPersistentData : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/MqttPersistentData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttPersistentData); }
		}

		protected MqttPersistentData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayBIIarrayBII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/constructor[@name='MqttPersistentData' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;[BII[BII)V", "")]
		public unsafe MqttPersistentData (string p0, byte[] p1, int p2, int p3, byte[] p4, int p5, int p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (MqttPersistentData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[BII[BII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[BII[BII)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayBIIarrayBII == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayBIIarrayBII = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[BII[BII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayBIIarrayBII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayBIIarrayBII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static Delegate cb_getHeaderLength;
#pragma warning disable 0169
		static Delegate GetGetHeaderLengthHandler ()
		{
			if (cb_getHeaderLength == null)
				cb_getHeaderLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderLength);
			return cb_getHeaderLength;
		}

		static int n_GetHeaderLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderLength;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderLength;
		public virtual unsafe int HeaderLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getHeaderLength' and count(parameter)=0]"
			[Register ("getHeaderLength", "()I", "GetGetHeaderLengthHandler")]
			get {
				if (id_getHeaderLength == IntPtr.Zero)
					id_getHeaderLength = JNIEnv.GetMethodID (class_ref, "getHeaderLength", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeaderLength);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderOffset;
#pragma warning disable 0169
		static Delegate GetGetHeaderOffsetHandler ()
		{
			if (cb_getHeaderOffset == null)
				cb_getHeaderOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderOffset);
			return cb_getHeaderOffset;
		}

		static int n_GetHeaderOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderOffset;
		public virtual unsafe int HeaderOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getHeaderOffset' and count(parameter)=0]"
			[Register ("getHeaderOffset", "()I", "GetGetHeaderOffsetHandler")]
			get {
				if (id_getHeaderOffset == IntPtr.Zero)
					id_getHeaderOffset = JNIEnv.GetMethodID (class_ref, "getHeaderOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeaderOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadLength;
#pragma warning disable 0169
		static Delegate GetGetPayloadLengthHandler ()
		{
			if (cb_getPayloadLength == null)
				cb_getPayloadLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayloadLength);
			return cb_getPayloadLength;
		}

		static int n_GetPayloadLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadLength;
		}
#pragma warning restore 0169

		static IntPtr id_getPayloadLength;
		public virtual unsafe int PayloadLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getPayloadLength' and count(parameter)=0]"
			[Register ("getPayloadLength", "()I", "GetGetPayloadLengthHandler")]
			get {
				if (id_getPayloadLength == IntPtr.Zero)
					id_getPayloadLength = JNIEnv.GetMethodID (class_ref, "getPayloadLength", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPayloadLength);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPayloadLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadOffset;
#pragma warning disable 0169
		static Delegate GetGetPayloadOffsetHandler ()
		{
			if (cb_getPayloadOffset == null)
				cb_getPayloadOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayloadOffset);
			return cb_getPayloadOffset;
		}

		static int n_GetPayloadOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getPayloadOffset;
		public virtual unsafe int PayloadOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getPayloadOffset' and count(parameter)=0]"
			[Register ("getPayloadOffset", "()I", "GetGetPayloadOffsetHandler")]
			get {
				if (id_getPayloadOffset == IntPtr.Zero)
					id_getPayloadOffset = JNIEnv.GetMethodID (class_ref, "getPayloadOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPayloadOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPayloadOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderBytes;
#pragma warning disable 0169
		static Delegate GetGetHeaderBytesHandler ()
		{
			if (cb_getHeaderBytes == null)
				cb_getHeaderBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderBytes);
			return cb_getHeaderBytes;
		}

		static IntPtr n_GetHeaderBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeaderBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getHeaderBytes' and count(parameter)=0]"
		[Register ("getHeaderBytes", "()[B", "GetGetHeaderBytesHandler")]
		public virtual unsafe byte[] GetHeaderBytes ()
		{
			if (id_getHeaderBytes == IntPtr.Zero)
				id_getHeaderBytes = JNIEnv.GetMethodID (class_ref, "getHeaderBytes", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getHeaderBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getPayloadBytes;
#pragma warning disable 0169
		static Delegate GetGetPayloadBytesHandler ()
		{
			if (cb_getPayloadBytes == null)
				cb_getPayloadBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayloadBytes);
			return cb_getPayloadBytes;
		}

		static IntPtr n_GetPayloadBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayloadBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getPayloadBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getPayloadBytes' and count(parameter)=0]"
		[Register ("getPayloadBytes", "()[B", "GetGetPayloadBytesHandler")]
		public virtual unsafe byte[] GetPayloadBytes ()
		{
			if (id_getPayloadBytes == IntPtr.Zero)
				id_getPayloadBytes = JNIEnv.GetMethodID (class_ref, "getPayloadBytes", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPayloadBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPayloadBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
