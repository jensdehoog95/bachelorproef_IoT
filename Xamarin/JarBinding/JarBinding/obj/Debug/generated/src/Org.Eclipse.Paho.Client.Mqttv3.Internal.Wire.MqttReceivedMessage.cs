using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttReceivedMessage", DoNotGenerateAcw=true)]
	public partial class MqttReceivedMessage : global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MqttReceivedMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttReceivedMessage); }
		}

		protected MqttReceivedMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/constructor[@name='MqttReceivedMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttReceivedMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MqttReceivedMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageId);
			return cb_getMessageId;
		}

		static int n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageId;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageId_I;
#pragma warning disable 0169
		static Delegate GetSetMessageId_IHandler ()
		{
			if (cb_setMessageId_I == null)
				cb_setMessageId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageId_I);
			return cb_setMessageId_I;
		}

		static void n_SetMessageId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		static IntPtr id_setMessageId_I;
		public virtual unsafe int MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()I", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMessageId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageId", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessageId", "(I)V", "GetSetMessageId_IHandler")]
			set {
				if (id_setMessageId_I == IntPtr.Zero)
					id_setMessageId_I = JNIEnv.GetMethodID (class_ref, "setMessageId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMessageId_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageId", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_setDuplicate_Z;
#pragma warning disable 0169
		static Delegate GetSetDuplicate_ZHandler ()
		{
			if (cb_setDuplicate_Z == null)
				cb_setDuplicate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDuplicate_Z);
			return cb_setDuplicate_Z;
		}

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuplicate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDuplicate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
		public virtual unsafe void SetDuplicate (bool p0)
		{
			if (id_setDuplicate_Z == IntPtr.Zero)
				id_setDuplicate_Z = JNIEnv.GetMethodID (class_ref, "setDuplicate", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDuplicate_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuplicate", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
