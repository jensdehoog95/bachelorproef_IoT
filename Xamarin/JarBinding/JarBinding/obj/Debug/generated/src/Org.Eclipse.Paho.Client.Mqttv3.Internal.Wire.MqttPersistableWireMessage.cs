using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPersistableWireMessage", DoNotGenerateAcw=true)]
	public abstract partial class MqttPersistableWireMessage : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPersistableWireMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttPersistableWireMessage); }
		}

		protected MqttPersistableWireMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_B;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/constructor[@name='MqttPersistableWireMessage' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe MqttPersistableWireMessage (sbyte p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MqttPersistableWireMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(B)V", __args);
					return;
				}

				if (id_ctor_B == IntPtr.Zero)
					id_ctor_B = JNIEnv.GetMethodID (class_ref, "<init>", "(B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_B, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_B, __args);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderLength;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderLength;
		public virtual unsafe int HeaderLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getHeaderLength' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderOffset;
		public virtual unsafe int HeaderOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getHeaderOffset' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadLength;
		}
#pragma warning restore 0169

		static IntPtr id_getPayloadLength;
		public virtual unsafe int PayloadLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getPayloadLength' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getPayloadOffset;
		public virtual unsafe int PayloadOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getPayloadOffset' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeaderBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getHeaderBytes' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayloadBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getPayloadBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getPayloadBytes' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPersistableWireMessage", DoNotGenerateAcw=true)]
	internal partial class MqttPersistableWireMessageInvoker : MqttPersistableWireMessage {

		public MqttPersistableWireMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttPersistableWireMessageInvoker); }
		}

		static IntPtr id_getMessageInfo;
		protected override unsafe sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getMessageInfo' and count(parameter)=0]"
			[Register ("getMessageInfo", "()B", "GetGetMessageInfoHandler")]
			get {
				if (id_getMessageInfo == IntPtr.Zero)
					id_getMessageInfo = JNIEnv.GetMethodID (class_ref, "getMessageInfo", "()B");
				try {
					return JNIEnv.CallByteMethod  (Handle, id_getMessageInfo);
				} finally {
				}
			}
		}

		static IntPtr id_getVariableHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getVariableHeader' and count(parameter)=0]"
		[Register ("getVariableHeader", "()[B", "GetGetVariableHeaderHandler")]
		protected override unsafe byte[] GetVariableHeader ()
		{
			if (id_getVariableHeader == IntPtr.Zero)
				id_getVariableHeader = JNIEnv.GetMethodID (class_ref, "getVariableHeader", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getVariableHeader), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

}
