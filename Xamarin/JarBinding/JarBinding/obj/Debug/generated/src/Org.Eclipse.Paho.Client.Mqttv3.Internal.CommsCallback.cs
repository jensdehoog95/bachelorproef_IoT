using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsCallback", DoNotGenerateAcw=true)]
	public partial class CommsCallback : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr running_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/field[@name='running']"
		[Register ("running")]
		public bool Running {
			get {
				if (running_jfieldId == IntPtr.Zero)
					running_jfieldId = JNIEnv.GetFieldID (class_ref, "running", "Z");
				return JNIEnv.GetBooleanField (Handle, running_jfieldId);
			}
			set {
				if (running_jfieldId == IntPtr.Zero)
					running_jfieldId = JNIEnv.GetFieldID (class_ref, "running", "Z");
				try {
					JNIEnv.SetField (Handle, running_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/CommsCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommsCallback); }
		}

		protected CommsCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isQuiesced;
#pragma warning disable 0169
		static Delegate GetIsQuiescedHandler ()
		{
			if (cb_isQuiesced == null)
				cb_isQuiesced = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsQuiesced);
			return cb_isQuiesced;
		}

		static bool n_IsQuiesced (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsQuiesced;
		}
#pragma warning restore 0169

		static IntPtr id_isQuiesced;
		public virtual unsafe bool IsQuiesced {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='isQuiesced' and count(parameter)=0]"
			[Register ("isQuiesced", "()Z", "GetIsQuiescedHandler")]
			get {
				if (id_isQuiesced == IntPtr.Zero)
					id_isQuiesced = JNIEnv.GetMethodID (class_ref, "isQuiesced", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isQuiesced);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isQuiesced", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getThread;
#pragma warning disable 0169
		static Delegate GetGetThreadHandler ()
		{
			if (cb_getThread == null)
				cb_getThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThread);
			return cb_getThread;
		}

		static IntPtr n_GetThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Thread);
		}
#pragma warning restore 0169

		static IntPtr id_getThread;
		protected virtual unsafe global::Java.Lang.Thread Thread {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='getThread' and count(parameter)=0]"
			[Register ("getThread", "()Ljava/lang/Thread;", "GetGetThreadHandler")]
			get {
				if (id_getThread == IntPtr.Zero)
					id_getThread = JNIEnv.GetMethodID (class_ref, "getThread", "()Ljava/lang/Thread;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_getThread), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThread", "()Ljava/lang/Thread;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetAsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_AsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AsyncOperationComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='asyncOperationComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("asyncOperationComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetAsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void AsyncOperationComplete (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0)
		{
			if (id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "asyncOperationComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asyncOperationComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_ConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='connectionLost' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("connectionLost", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void ConnectionLost (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0)
		{
			if (id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "connectionLost", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectionLost", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetFireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_FireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FireActionEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='fireActionEvent' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("fireActionEvent", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetFireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void FireActionEvent (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0)
		{
			if (id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "fireActionEvent", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fireActionEvent", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetMessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_MessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrived (p0);
		}
#pragma warning restore 0169

		static IntPtr id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='messageArrived' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("messageArrived", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetMessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		public virtual unsafe void MessageArrived (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0)
		{
			if (id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == IntPtr.Zero)
				id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNIEnv.GetMethodID (class_ref, "messageArrived", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "messageArrived", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_quiesce;
#pragma warning disable 0169
		static Delegate GetQuiesceHandler ()
		{
			if (cb_quiesce == null)
				cb_quiesce = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Quiesce);
			return cb_quiesce;
		}

		static void n_Quiesce (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quiesce ();
		}
#pragma warning restore 0169

		static IntPtr id_quiesce;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='quiesce' and count(parameter)=0]"
		[Register ("quiesce", "()V", "GetQuiesceHandler")]
		public virtual unsafe void Quiesce ()
		{
			if (id_quiesce == IntPtr.Zero)
				id_quiesce = JNIEnv.GetMethodID (class_ref, "quiesce", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_quiesce);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "quiesce", "()V"));
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler ()
		{
			if (cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == null)
				cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_);
			return cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		}

		static void n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
		[Register ("setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V", "GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler")]
		public virtual unsafe void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback p0)
		{
			if (id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == IntPtr.Zero)
				id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
#pragma warning disable 0169
		static Delegate GetSetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Handler ()
		{
			if (cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ == null)
				cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_);
			return cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
		}

		static void n_SetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClientState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setClientState' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientState']]"
		[Register ("setClientState", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V", "GetSetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Handler")]
		public virtual unsafe void SetClientState (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState p0)
		{
			if (id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ == IntPtr.Zero)
				id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ = JNIEnv.GetMethodID (class_ref, "setClientState", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientState", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_lang_String_Handler ()
		{
			if (cb_start_Ljava_lang_String_ == null)
				cb_start_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Start_Ljava_lang_String_);
			return cb_start_Ljava_lang_String_;
		}

		static void n_Start_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0);
		}
#pragma warning restore 0169

		static IntPtr id_start_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("start", "(Ljava/lang/String;)V", "GetStart_Ljava_lang_String_Handler")]
		public virtual unsafe void Start (string p0)
		{
			if (id_start_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "start", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
