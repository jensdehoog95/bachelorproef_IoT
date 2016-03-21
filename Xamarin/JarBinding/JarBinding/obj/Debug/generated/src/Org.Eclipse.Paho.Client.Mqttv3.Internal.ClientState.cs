using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ClientState", DoNotGenerateAcw=true)]
	public partial class ClientState : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/ClientState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientState); }
		}

		protected ClientState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Lorg_eclipse_paho_client_mqttv3_internal_CommsCallback_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/constructor[@name='ClientState' and count(parameter)=5 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.CommsTokenStore'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.internal.CommsCallback'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.MqttPingSender']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Lorg/eclipse/paho/client/mqttv3/internal/CommsCallback;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", "")]
		protected unsafe ClientState (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence p0, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore p1, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback p2, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p3, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (ClientState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Lorg/eclipse/paho/client/mqttv3/internal/CommsCallback;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Lorg/eclipse/paho/client/mqttv3/internal/CommsCallback;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Lorg_eclipse_paho_client_mqttv3_internal_CommsCallback_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Lorg_eclipse_paho_client_mqttv3_internal_CommsCallback_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Lorg/eclipse/paho/client/mqttv3/internal/CommsCallback;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Lorg_eclipse_paho_client_mqttv3_internal_CommsCallback_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Lorg_eclipse_paho_client_mqttv3_internal_CommsCallback_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_, __args);
			} finally {
			}
		}

		static Delegate cb_getDebug;
#pragma warning disable 0169
		static Delegate GetGetDebugHandler ()
		{
			if (cb_getDebug == null)
				cb_getDebug = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDebug);
			return cb_getDebug;
		}

		static IntPtr n_GetDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Debug);
		}
#pragma warning restore 0169

		static IntPtr id_getDebug;
		public virtual unsafe global::Java.Util.Properties Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='getDebug' and count(parameter)=0]"
			[Register ("getDebug", "()Ljava/util/Properties;", "GetGetDebugHandler")]
			get {
				if (id_getDebug == IntPtr.Zero)
					id_getDebug = JNIEnv.GetMethodID (class_ref, "getDebug", "()Ljava/util/Properties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallObjectMethod  (Handle, id_getDebug), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDebug", "()Ljava/util/Properties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKeepAlive;
#pragma warning disable 0169
		static Delegate GetGetKeepAliveHandler ()
		{
			if (cb_getKeepAlive == null)
				cb_getKeepAlive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetKeepAlive);
			return cb_getKeepAlive;
		}

		static long n_GetKeepAlive (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepAlive;
		}
#pragma warning restore 0169

		static IntPtr id_getKeepAlive;
		protected virtual unsafe long KeepAlive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='getKeepAlive' and count(parameter)=0]"
			[Register ("getKeepAlive", "()J", "GetGetKeepAliveHandler")]
			get {
				if (id_getKeepAlive == IntPtr.Zero)
					id_getKeepAlive = JNIEnv.GetMethodID (class_ref, "getKeepAlive", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getKeepAlive);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeepAlive", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_checkForActivity;
#pragma warning disable 0169
		static Delegate GetCheckForActivityHandler ()
		{
			if (cb_checkForActivity == null)
				cb_checkForActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CheckForActivity);
			return cb_checkForActivity;
		}

		static IntPtr n_CheckForActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckForActivity ());
		}
#pragma warning restore 0169

		static IntPtr id_checkForActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='checkForActivity' and count(parameter)=0]"
		[Register ("checkForActivity", "()Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetCheckForActivityHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken CheckForActivity ()
		{
			if (id_checkForActivity == IntPtr.Zero)
				id_checkForActivity = JNIEnv.GetMethodID (class_ref, "checkForActivity", "()Lorg/eclipse/paho/client/mqttv3/MqttToken;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallObjectMethod  (Handle, id_checkForActivity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkForActivity", "()Lorg/eclipse/paho/client/mqttv3/MqttToken;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_checkQuiesceLock;
#pragma warning disable 0169
		static Delegate GetCheckQuiesceLockHandler ()
		{
			if (cb_checkQuiesceLock == null)
				cb_checkQuiesceLock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckQuiesceLock);
			return cb_checkQuiesceLock;
		}

		static bool n_CheckQuiesceLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckQuiesceLock ();
		}
#pragma warning restore 0169

		static IntPtr id_checkQuiesceLock;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='checkQuiesceLock' and count(parameter)=0]"
		[Register ("checkQuiesceLock", "()Z", "GetCheckQuiesceLockHandler")]
		protected virtual unsafe bool CheckQuiesceLock ()
		{
			if (id_checkQuiesceLock == IntPtr.Zero)
				id_checkQuiesceLock = JNIEnv.GetMethodID (class_ref, "checkQuiesceLock", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_checkQuiesceLock);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkQuiesceLock", "()Z"));
			} finally {
			}
		}

		static Delegate cb_clearState;
#pragma warning disable 0169
		static Delegate GetClearStateHandler ()
		{
			if (cb_clearState == null)
				cb_clearState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearState);
			return cb_clearState;
		}

		static void n_ClearState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearState ();
		}
#pragma warning restore 0169

		static IntPtr id_clearState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='clearState' and count(parameter)=0]"
		[Register ("clearState", "()V", "GetClearStateHandler")]
		protected virtual unsafe void ClearState ()
		{
			if (id_clearState == IntPtr.Zero)
				id_clearState = JNIEnv.GetMethodID (class_ref, "clearState", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearState);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearState", "()V"));
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		protected virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_connected;
#pragma warning disable 0169
		static Delegate GetConnectedHandler ()
		{
			if (cb_connected == null)
				cb_connected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connected);
			return cb_connected;
		}

		static void n_Connected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connected ();
		}
#pragma warning restore 0169

		static IntPtr id_connected;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='connected' and count(parameter)=0]"
		[Register ("connected", "()V", "GetConnectedHandler")]
		public virtual unsafe void Connected ()
		{
			if (id_connected == IntPtr.Zero)
				id_connected = JNIEnv.GetMethodID (class_ref, "connected", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connected);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connected", "()V"));
			} finally {
			}
		}

		static Delegate cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0)
		{
			if (id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == IntPtr.Zero)
				id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNIEnv.GetMethodID (class_ref, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetDisconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_Disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='disconnected' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("disconnected", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetDisconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void Disconnected (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0)
		{
			if (id_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "disconnected", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnected", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetGetHandler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetNotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_NotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("notifyComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetNotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		protected virtual unsafe void NotifyComplete (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0)
		{
			if (id_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "notifyComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyQueueLock;
#pragma warning disable 0169
		static Delegate GetNotifyQueueLockHandler ()
		{
			if (cb_notifyQueueLock == null)
				cb_notifyQueueLock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyQueueLock);
			return cb_notifyQueueLock;
		}

		static void n_NotifyQueueLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyQueueLock ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyQueueLock;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyQueueLock' and count(parameter)=0]"
		[Register ("notifyQueueLock", "()V", "GetNotifyQueueLockHandler")]
		public virtual unsafe void NotifyQueueLock ()
		{
			if (id_notifyQueueLock == IntPtr.Zero)
				id_notifyQueueLock = JNIEnv.GetMethodID (class_ref, "notifyQueueLock", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyQueueLock);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyQueueLock", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_;
#pragma warning disable 0169
		static Delegate GetNotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_Handler ()
		{
			if (cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ == null)
				cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_);
			return cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_;
		}

		static void n_NotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyReceivedAck (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyReceivedAck' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttAck']]"
		[Register ("notifyReceivedAck", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttAck;)V", "GetNotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_Handler")]
		protected virtual unsafe void NotifyReceivedAck (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck p0)
		{
			if (id_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ == IntPtr.Zero)
				id_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ = JNIEnv.GetMethodID (class_ref, "notifyReceivedAck", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttAck;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyReceivedAck", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttAck;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyReceivedBytes_I;
#pragma warning disable 0169
		static Delegate GetNotifyReceivedBytes_IHandler ()
		{
			if (cb_notifyReceivedBytes_I == null)
				cb_notifyReceivedBytes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifyReceivedBytes_I);
			return cb_notifyReceivedBytes_I;
		}

		static void n_NotifyReceivedBytes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyReceivedBytes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyReceivedBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyReceivedBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyReceivedBytes", "(I)V", "GetNotifyReceivedBytes_IHandler")]
		public virtual unsafe void NotifyReceivedBytes (int p0)
		{
			if (id_notifyReceivedBytes_I == IntPtr.Zero)
				id_notifyReceivedBytes_I = JNIEnv.GetMethodID (class_ref, "notifyReceivedBytes", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyReceivedBytes_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyReceivedBytes", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetNotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_NotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyReceivedMsg (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyReceivedMsg' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("notifyReceivedMsg", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetNotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		protected virtual unsafe void NotifyReceivedMsg (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0)
		{
			if (id_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == IntPtr.Zero)
				id_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNIEnv.GetMethodID (class_ref, "notifyReceivedMsg", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyReceivedMsg", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetNotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_NotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p2 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.NotifyResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyResult' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("notifyResult", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetNotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		protected virtual unsafe void NotifyResult (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p1, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p2)
		{
			if (id_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "notifyResult", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyResult", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetNotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_NotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifySent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifySent' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("notifySent", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetNotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		protected virtual unsafe void NotifySent (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0)
		{
			if (id_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == IntPtr.Zero)
				id_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNIEnv.GetMethodID (class_ref, "notifySent", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifySent", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifySentBytes_I;
#pragma warning disable 0169
		static Delegate GetNotifySentBytes_IHandler ()
		{
			if (cb_notifySentBytes_I == null)
				cb_notifySentBytes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifySentBytes_I);
			return cb_notifySentBytes_I;
		}

		static void n_NotifySentBytes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifySentBytes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifySentBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifySentBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifySentBytes", "(I)V", "GetNotifySentBytes_IHandler")]
		public virtual unsafe void NotifySentBytes (int p0)
		{
			if (id_notifySentBytes_I == IntPtr.Zero)
				id_notifySentBytes_I = JNIEnv.GetMethodID (class_ref, "notifySentBytes", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifySentBytes_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifySentBytes", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_quiesce_J;
#pragma warning disable 0169
		static Delegate GetQuiesce_JHandler ()
		{
			if (cb_quiesce_J == null)
				cb_quiesce_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Quiesce_J);
			return cb_quiesce_J;
		}

		static void n_Quiesce_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quiesce (p0);
		}
#pragma warning restore 0169

		static IntPtr id_quiesce_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='quiesce' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("quiesce", "(J)V", "GetQuiesce_JHandler")]
		public virtual unsafe void Quiesce (long p0)
		{
			if (id_quiesce_J == IntPtr.Zero)
				id_quiesce_J = JNIEnv.GetMethodID (class_ref, "quiesce", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_quiesce_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "quiesce", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static IntPtr n_ResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResolveOldTokens (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='resolveOldTokens' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("resolveOldTokens", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)Ljava/util/Vector;", "GetResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe global::Java.Util.Vector ResolveOldTokens (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0)
		{
			if (id_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "resolveOldTokens", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)Ljava/util/Vector;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Util.Vector __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod  (Handle, id_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resolveOldTokens", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)Ljava/util/Vector;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_restoreState;
#pragma warning disable 0169
		static Delegate GetRestoreStateHandler ()
		{
			if (cb_restoreState == null)
				cb_restoreState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RestoreState);
			return cb_restoreState;
		}

		static void n_RestoreState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState ();
		}
#pragma warning restore 0169

		static IntPtr id_restoreState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='restoreState' and count(parameter)=0]"
		[Register ("restoreState", "()V", "GetRestoreStateHandler")]
		protected virtual unsafe void RestoreState ()
		{
			if (id_restoreState == IntPtr.Zero)
				id_restoreState = JNIEnv.GetMethodID (class_ref, "restoreState", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_restoreState);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreState", "()V"));
			} finally {
			}
		}

		static Delegate cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetSend_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_Send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='send' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("send", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetSend_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void Send (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p1)
		{
			if (id_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "send", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCleanSession_Z;
#pragma warning disable 0169
		static Delegate GetSetCleanSession_ZHandler ()
		{
			if (cb_setCleanSession_Z == null)
				cb_setCleanSession_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCleanSession_Z);
			return cb_setCleanSession_Z;
		}

		static void n_SetCleanSession_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCleanSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCleanSession_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='setCleanSession' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCleanSession", "(Z)V", "GetSetCleanSession_ZHandler")]
		protected virtual unsafe void SetCleanSession (bool p0)
		{
			if (id_setCleanSession_Z == IntPtr.Zero)
				id_setCleanSession_Z = JNIEnv.GetMethodID (class_ref, "setCleanSession", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCleanSession_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCleanSession", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setKeepAliveInterval_J;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveInterval_JHandler ()
		{
			if (cb_setKeepAliveInterval_J == null)
				cb_setKeepAliveInterval_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetKeepAliveInterval_J);
			return cb_setKeepAliveInterval_J;
		}

		static void n_SetKeepAliveInterval_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepAliveInterval (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeepAliveInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='setKeepAliveInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setKeepAliveInterval", "(J)V", "GetSetKeepAliveInterval_JHandler")]
		public virtual unsafe void SetKeepAliveInterval (long p0)
		{
			if (id_setKeepAliveInterval_J == IntPtr.Zero)
				id_setKeepAliveInterval_J = JNIEnv.GetMethodID (class_ref, "setKeepAliveInterval", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setKeepAliveInterval_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAliveInterval", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setKeepAliveSecs_J;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveSecs_JHandler ()
		{
			if (cb_setKeepAliveSecs_J == null)
				cb_setKeepAliveSecs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetKeepAliveSecs_J);
			return cb_setKeepAliveSecs_J;
		}

		static void n_SetKeepAliveSecs_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepAliveSecs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeepAliveSecs_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='setKeepAliveSecs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setKeepAliveSecs", "(J)V", "GetSetKeepAliveSecs_JHandler")]
		protected virtual unsafe void SetKeepAliveSecs (long p0)
		{
			if (id_setKeepAliveSecs_J == IntPtr.Zero)
				id_setKeepAliveSecs_J = JNIEnv.GetMethodID (class_ref, "setKeepAliveSecs", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setKeepAliveSecs_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAliveSecs", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetUndo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_Undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Undo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='undo' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("undo", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetUndo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe void Undo (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0)
		{
			if (id_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == IntPtr.Zero)
				id_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNIEnv.GetMethodID (class_ref, "undo", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "undo", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V"), __args);
			} finally {
			}
		}

	}
}
