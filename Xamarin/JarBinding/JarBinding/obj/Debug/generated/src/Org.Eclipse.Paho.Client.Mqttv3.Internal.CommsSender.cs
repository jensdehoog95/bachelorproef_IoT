using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsSender", DoNotGenerateAcw=true)]
	public partial class CommsSender : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/CommsSender", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommsSender); }
		}

		protected CommsSender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/constructor[@name='CommsSender' and count(parameter)=4 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.ClientState'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.internal.CommsTokenStore'] and parameter[4][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/OutputStream;)V", "")]
		public unsafe CommsSender (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p0, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState p1, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore p2, global::System.IO.Stream p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (CommsSender)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/method[@name='run' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0);
		}
#pragma warning restore 0169

		static IntPtr id_start_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/method[@name='stop' and count(parameter)=0]"
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
