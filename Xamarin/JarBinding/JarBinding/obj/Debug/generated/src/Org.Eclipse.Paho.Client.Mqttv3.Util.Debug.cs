using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/util/Debug", DoNotGenerateAcw=true)]
	public partial class Debug : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/util/Debug", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Debug); }
		}

		protected Debug (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/constructor[@name='Debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", "")]
		public unsafe Debug (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Debug)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_dumpBaseDebug;
#pragma warning disable 0169
		static Delegate GetDumpBaseDebugHandler ()
		{
			if (cb_dumpBaseDebug == null)
				cb_dumpBaseDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpBaseDebug);
			return cb_dumpBaseDebug;
		}

		static void n_DumpBaseDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpBaseDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpBaseDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpBaseDebug' and count(parameter)=0]"
		[Register ("dumpBaseDebug", "()V", "GetDumpBaseDebugHandler")]
		public virtual unsafe void DumpBaseDebug ()
		{
			if (id_dumpBaseDebug == IntPtr.Zero)
				id_dumpBaseDebug = JNIEnv.GetMethodID (class_ref, "dumpBaseDebug", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpBaseDebug);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpBaseDebug", "()V"));
			} finally {
			}
		}

		static Delegate cb_dumpClientComms;
#pragma warning disable 0169
		static Delegate GetDumpClientCommsHandler ()
		{
			if (cb_dumpClientComms == null)
				cb_dumpClientComms = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpClientComms);
			return cb_dumpClientComms;
		}

		static void n_DumpClientComms (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpClientComms ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpClientComms;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpClientComms' and count(parameter)=0]"
		[Register ("dumpClientComms", "()V", "GetDumpClientCommsHandler")]
		public virtual unsafe void DumpClientComms ()
		{
			if (id_dumpClientComms == IntPtr.Zero)
				id_dumpClientComms = JNIEnv.GetMethodID (class_ref, "dumpClientComms", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpClientComms);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpClientComms", "()V"));
			} finally {
			}
		}

		static Delegate cb_dumpClientDebug;
#pragma warning disable 0169
		static Delegate GetDumpClientDebugHandler ()
		{
			if (cb_dumpClientDebug == null)
				cb_dumpClientDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpClientDebug);
			return cb_dumpClientDebug;
		}

		static void n_DumpClientDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpClientDebug ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpClientDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpClientDebug' and count(parameter)=0]"
		[Register ("dumpClientDebug", "()V", "GetDumpClientDebugHandler")]
		public virtual unsafe void DumpClientDebug ()
		{
			if (id_dumpClientDebug == IntPtr.Zero)
				id_dumpClientDebug = JNIEnv.GetMethodID (class_ref, "dumpClientDebug", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpClientDebug);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpClientDebug", "()V"));
			} finally {
			}
		}

		static Delegate cb_dumpClientState;
#pragma warning disable 0169
		static Delegate GetDumpClientStateHandler ()
		{
			if (cb_dumpClientState == null)
				cb_dumpClientState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpClientState);
			return cb_dumpClientState;
		}

		static void n_DumpClientState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpClientState ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpClientState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpClientState' and count(parameter)=0]"
		[Register ("dumpClientState", "()V", "GetDumpClientStateHandler")]
		public virtual unsafe void DumpClientState ()
		{
			if (id_dumpClientState == IntPtr.Zero)
				id_dumpClientState = JNIEnv.GetMethodID (class_ref, "dumpClientState", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpClientState);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpClientState", "()V"));
			} finally {
			}
		}

		static Delegate cb_dumpConOptions;
#pragma warning disable 0169
		static Delegate GetDumpConOptionsHandler ()
		{
			if (cb_dumpConOptions == null)
				cb_dumpConOptions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpConOptions);
			return cb_dumpConOptions;
		}

		static void n_DumpConOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpConOptions ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpConOptions;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpConOptions' and count(parameter)=0]"
		[Register ("dumpConOptions", "()V", "GetDumpConOptionsHandler")]
		public virtual unsafe void DumpConOptions ()
		{
			if (id_dumpConOptions == IntPtr.Zero)
				id_dumpConOptions = JNIEnv.GetMethodID (class_ref, "dumpConOptions", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpConOptions);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpConOptions", "()V"));
			} finally {
			}
		}

		static Delegate cb_dumpMemoryTrace;
#pragma warning disable 0169
		static Delegate GetDumpMemoryTraceHandler ()
		{
			if (cb_dumpMemoryTrace == null)
				cb_dumpMemoryTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpMemoryTrace);
			return cb_dumpMemoryTrace;
		}

		static void n_DumpMemoryTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpMemoryTrace ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpMemoryTrace;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpMemoryTrace' and count(parameter)=0]"
		[Register ("dumpMemoryTrace", "()V", "GetDumpMemoryTraceHandler")]
		protected virtual unsafe void DumpMemoryTrace ()
		{
			if (id_dumpMemoryTrace == IntPtr.Zero)
				id_dumpMemoryTrace = JNIEnv.GetMethodID (class_ref, "dumpMemoryTrace", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpMemoryTrace);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpMemoryTrace", "()V"));
			} finally {
			}
		}

		static IntPtr id_dumpProperties_Ljava_util_Properties_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpProperties' and count(parameter)=2 and parameter[1][@type='java.util.Properties'] and parameter[2][@type='java.lang.String']]"
		[Register ("dumpProperties", "(Ljava/util/Properties;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DumpProperties (global::Java.Util.Properties p0, string p1)
		{
			if (id_dumpProperties_Ljava_util_Properties_Ljava_lang_String_ == IntPtr.Zero)
				id_dumpProperties_Ljava_util_Properties_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "dumpProperties", "(Ljava/util/Properties;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_dumpProperties_Ljava_util_Properties_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_dumpSystemProperties;
#pragma warning disable 0169
		static Delegate GetDumpSystemPropertiesHandler ()
		{
			if (cb_dumpSystemProperties == null)
				cb_dumpSystemProperties = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpSystemProperties);
			return cb_dumpSystemProperties;
		}

		static void n_DumpSystemProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpSystemProperties ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpSystemProperties;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpSystemProperties' and count(parameter)=0]"
		[Register ("dumpSystemProperties", "()V", "GetDumpSystemPropertiesHandler")]
		public virtual unsafe void DumpSystemProperties ()
		{
			if (id_dumpSystemProperties == IntPtr.Zero)
				id_dumpSystemProperties = JNIEnv.GetMethodID (class_ref, "dumpSystemProperties", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpSystemProperties);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpSystemProperties", "()V"));
			} finally {
			}
		}

		static Delegate cb_dumpVersion;
#pragma warning disable 0169
		static Delegate GetDumpVersionHandler ()
		{
			if (cb_dumpVersion == null)
				cb_dumpVersion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpVersion);
			return cb_dumpVersion;
		}

		static void n_DumpVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpVersion ();
		}
#pragma warning restore 0169

		static IntPtr id_dumpVersion;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpVersion' and count(parameter)=0]"
		[Register ("dumpVersion", "()V", "GetDumpVersionHandler")]
		protected virtual unsafe void DumpVersion ()
		{
			if (id_dumpVersion == IntPtr.Zero)
				id_dumpVersion = JNIEnv.GetMethodID (class_ref, "dumpVersion", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dumpVersion);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpVersion", "()V"));
			} finally {
			}
		}

		static IntPtr id_left_Ljava_lang_String_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='left' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("left", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static unsafe string Left (string p0, int p1, char p2)
		{
			if (id_left_Ljava_lang_String_IC == IntPtr.Zero)
				id_left_Ljava_lang_String_IC = JNIEnv.GetStaticMethodID (class_ref, "left", "(Ljava/lang/String;IC)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_left_Ljava_lang_String_IC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
