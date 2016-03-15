using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttInputStream']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttInputStream", DoNotGenerateAcw=true)]
	public partial class MqttInputStream : global::Java.IO.InputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MqttInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttInputStream); }
		}

		protected MqttInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttInputStream']/constructor[@name='MqttInputStream' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientState'] and parameter[2][@type='java.io.InputStream']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/InputStream;)V", "")]
		public unsafe MqttInputStream (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState p0, global::System.IO.Stream p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (MqttInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttInputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_read);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()I"));
			} finally {
			}
		}

		static Delegate cb_readMqttWireMessage;
#pragma warning disable 0169
		static Delegate GetReadMqttWireMessageHandler ()
		{
			if (cb_readMqttWireMessage == null)
				cb_readMqttWireMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadMqttWireMessage);
			return cb_readMqttWireMessage;
		}

		static IntPtr n_ReadMqttWireMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttInputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadMqttWireMessage ());
		}
#pragma warning restore 0169

		static IntPtr id_readMqttWireMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttInputStream']/method[@name='readMqttWireMessage' and count(parameter)=0]"
		[Register ("readMqttWireMessage", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetReadMqttWireMessageHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage ReadMqttWireMessage ()
		{
			if (id_readMqttWireMessage == IntPtr.Zero)
				id_readMqttWireMessage = JNIEnv.GetMethodID (class_ref, "readMqttWireMessage", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallObjectMethod  (Handle, id_readMqttWireMessage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readMqttWireMessage", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
