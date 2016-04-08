using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttException", DoNotGenerateAcw=true)]
	public partial class MqttException : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_BROKER_UNAVAILABLE']"
		[Register ("REASON_CODE_BROKER_UNAVAILABLE")]
		public const short ReasonCodeBrokerUnavailable = (short) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_ALREADY_DISCONNECTED']"
		[Register ("REASON_CODE_CLIENT_ALREADY_DISCONNECTED")]
		public const short ReasonCodeClientAlreadyDisconnected = (short) 32101;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_CLOSED']"
		[Register ("REASON_CODE_CLIENT_CLOSED")]
		public const short ReasonCodeClientClosed = (short) 32111;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_CONNECTED']"
		[Register ("REASON_CODE_CLIENT_CONNECTED")]
		public const short ReasonCodeClientConnected = (short) 32100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_DISCONNECTING']"
		[Register ("REASON_CODE_CLIENT_DISCONNECTING")]
		public const short ReasonCodeClientDisconnecting = (short) 32102;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_DISCONNECT_PROHIBITED']"
		[Register ("REASON_CODE_CLIENT_DISCONNECT_PROHIBITED")]
		public const short ReasonCodeClientDisconnectProhibited = (short) 32107;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_EXCEPTION']"
		[Register ("REASON_CODE_CLIENT_EXCEPTION")]
		public const short ReasonCodeClientException = (short) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_NOT_CONNECTED']"
		[Register ("REASON_CODE_CLIENT_NOT_CONNECTED")]
		public const short ReasonCodeClientNotConnected = (short) 32104;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CLIENT_TIMEOUT']"
		[Register ("REASON_CODE_CLIENT_TIMEOUT")]
		public const short ReasonCodeClientTimeout = (short) 32000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CONNECTION_LOST']"
		[Register ("REASON_CODE_CONNECTION_LOST")]
		public const short ReasonCodeConnectionLost = (short) 32109;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_CONNECT_IN_PROGRESS']"
		[Register ("REASON_CODE_CONNECT_IN_PROGRESS")]
		public const short ReasonCodeConnectInProgress = (short) 32110;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_FAILED_AUTHENTICATION']"
		[Register ("REASON_CODE_FAILED_AUTHENTICATION")]
		public const short ReasonCodeFailedAuthentication = (short) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_INVALID_CLIENT_ID']"
		[Register ("REASON_CODE_INVALID_CLIENT_ID")]
		public const short ReasonCodeInvalidClientId = (short) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_INVALID_MESSAGE']"
		[Register ("REASON_CODE_INVALID_MESSAGE")]
		public const short ReasonCodeInvalidMessage = (short) 32108;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_INVALID_PROTOCOL_VERSION']"
		[Register ("REASON_CODE_INVALID_PROTOCOL_VERSION")]
		public const short ReasonCodeInvalidProtocolVersion = (short) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_MAX_INFLIGHT']"
		[Register ("REASON_CODE_MAX_INFLIGHT")]
		public const short ReasonCodeMaxInflight = (short) 32202;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_NOT_AUTHORIZED']"
		[Register ("REASON_CODE_NOT_AUTHORIZED")]
		public const short ReasonCodeNotAuthorized = (short) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_NO_MESSAGE_IDS_AVAILABLE']"
		[Register ("REASON_CODE_NO_MESSAGE_IDS_AVAILABLE")]
		public const short ReasonCodeNoMessageIdsAvailable = (short) 32001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_SERVER_CONNECT_ERROR']"
		[Register ("REASON_CODE_SERVER_CONNECT_ERROR")]
		public const short ReasonCodeServerConnectError = (short) 32103;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_SOCKET_FACTORY_MISMATCH']"
		[Register ("REASON_CODE_SOCKET_FACTORY_MISMATCH")]
		public const short ReasonCodeSocketFactoryMismatch = (short) 32105;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_SSL_CONFIG_ERROR']"
		[Register ("REASON_CODE_SSL_CONFIG_ERROR")]
		public const short ReasonCodeSslConfigError = (short) 32106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_SUBSCRIBE_FAILED']"
		[Register ("REASON_CODE_SUBSCRIBE_FAILED")]
		public const short ReasonCodeSubscribeFailed = (short) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_TOKEN_INUSE']"
		[Register ("REASON_CODE_TOKEN_INUSE")]
		public const short ReasonCodeTokenInuse = (short) 32201;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_UNEXPECTED_ERROR']"
		[Register ("REASON_CODE_UNEXPECTED_ERROR")]
		public const short ReasonCodeUnexpectedError = (short) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/field[@name='REASON_CODE_WRITE_TIMEOUT']"
		[Register ("REASON_CODE_WRITE_TIMEOUT")]
		public const short ReasonCodeWriteTimeout = (short) 32002;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/MqttException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttException); }
		}

		protected MqttException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/constructor[@name='MqttException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(ILjava/lang/Throwable;)V", "")]
		public unsafe MqttException (int p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MqttException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_ILjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/constructor[@name='MqttException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe MqttException (global::Java.Lang.Throwable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MqttException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/constructor[@name='MqttException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MqttException (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MqttException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getReasonCode;
#pragma warning disable 0169
		static Delegate GetGetReasonCodeHandler ()
		{
			if (cb_getReasonCode == null)
				cb_getReasonCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReasonCode);
			return cb_getReasonCode;
		}

		static int n_GetReasonCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReasonCode;
		}
#pragma warning restore 0169

		static IntPtr id_getReasonCode;
		public virtual unsafe int ReasonCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttException']/method[@name='getReasonCode' and count(parameter)=0]"
			[Register ("getReasonCode", "()I", "GetGetReasonCodeHandler")]
			get {
				if (id_getReasonCode == IntPtr.Zero)
					id_getReasonCode = JNIEnv.GetMethodID (class_ref, "getReasonCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getReasonCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReasonCode", "()I"));
				} finally {
				}
			}
		}

	}
}
