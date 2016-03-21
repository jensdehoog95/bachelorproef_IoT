using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ConnectActionListener", DoNotGenerateAcw=true)]
	public partial class ConnectActionListener : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/ConnectActionListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectActionListener); }
		}

		protected ConnectActionListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/constructor[@name='ConnectActionListener' and count(parameter)=7 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttAsyncClient'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[6][@type='java.lang.Object'] and parameter[7][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/MqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V", "")]
		public unsafe ConnectActionListener (global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence p1, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p2, global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p3, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p4, global::Java.Lang.Object p5, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (ConnectActionListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/eclipse/paho/client/mqttv3/MqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/eclipse/paho/client/mqttv3/MqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/MqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args);
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual unsafe void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connect);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()V"));
			} finally {
			}
		}

		static Delegate cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ == null)
				cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_);
			return cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V", "GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnFailure (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0, global::Java.Lang.Throwable p1)
		{
			if (id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler ()
		{
			if (cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ == null)
				cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_);
			return cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
		}

		static void n_OnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken']]"
		[Register ("onSuccess", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V", "GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler")]
		public virtual unsafe void OnSuccess (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0)
		{
			if (id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ == IntPtr.Zero)
				id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V"), __args);
			} finally {
			}
		}

	}
}
