using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/TimerPingSender", DoNotGenerateAcw=true)]
	public partial class TimerPingSender : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender.PingTask']"
		[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/TimerPingSender$PingTask", DoNotGenerateAcw=true)]
		public partial class PingTask : global::Java.Util.TimerTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/TimerPingSender$PingTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PingTask); }
			}

			protected PingTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender.PingTask __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender.PingTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender.PingTask']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override unsafe void Run ()
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/TimerPingSender", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimerPingSender); }
		}

		protected TimerPingSender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/constructor[@name='TimerPingSender' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimerPingSender ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TimerPingSender)) {
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

		static Delegate cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Handler ()
		{
			if (cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ == null)
				cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_);
			return cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
		}

		static void n_Init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='init' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms']]"
		[Register ("init", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", "GetInit_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Handler")]
		public virtual unsafe void Init (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p0)
		{
			if (id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ == IntPtr.Zero)
				id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ = JNIEnv.GetMethodID (class_ref, "init", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_schedule_J;
#pragma warning disable 0169
		static Delegate GetSchedule_JHandler ()
		{
			if (cb_schedule_J == null)
				cb_schedule_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Schedule_J);
			return cb_schedule_J;
		}

		static void n_Schedule_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Schedule (p0);
		}
#pragma warning restore 0169

		static IntPtr id_schedule_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='schedule' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("schedule", "(J)V", "GetSchedule_JHandler")]
		public virtual unsafe void Schedule (long p0)
		{
			if (id_schedule_J == IntPtr.Zero)
				id_schedule_J = JNIEnv.GetMethodID (class_ref, "schedule", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_schedule_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "schedule", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='stop' and count(parameter)=0]"
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
