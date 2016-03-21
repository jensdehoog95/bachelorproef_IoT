using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttConnectOptions", DoNotGenerateAcw=true)]
	public partial class MqttConnectOptions : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='CLEAN_SESSION_DEFAULT']"
		[Register ("CLEAN_SESSION_DEFAULT")]
		public const bool CleanSessionDefault = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='CONNECTION_TIMEOUT_DEFAULT']"
		[Register ("CONNECTION_TIMEOUT_DEFAULT")]
		public const int ConnectionTimeoutDefault = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='KEEP_ALIVE_INTERVAL_DEFAULT']"
		[Register ("KEEP_ALIVE_INTERVAL_DEFAULT")]
		public const int KeepAliveIntervalDefault = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='MQTT_VERSION_3_1']"
		[Register ("MQTT_VERSION_3_1")]
		public const int MqttVersion31 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='MQTT_VERSION_3_1_1']"
		[Register ("MQTT_VERSION_3_1_1")]
		public const int MqttVersion311 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='MQTT_VERSION_DEFAULT']"
		[Register ("MQTT_VERSION_DEFAULT")]
		public const int MqttVersionDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='URI_TYPE_LOCAL']"
		[Register ("URI_TYPE_LOCAL")]
		protected const int UriTypeLocal = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='URI_TYPE_SSL']"
		[Register ("URI_TYPE_SSL")]
		protected const int UriTypeSsl = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/field[@name='URI_TYPE_TCP']"
		[Register ("URI_TYPE_TCP")]
		protected const int UriTypeTcp = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/MqttConnectOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttConnectOptions); }
		}

		protected MqttConnectOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/constructor[@name='MqttConnectOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttConnectOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MqttConnectOptions)) {
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

		static Delegate cb_isCleanSession;
#pragma warning disable 0169
		static Delegate GetIsCleanSessionHandler ()
		{
			if (cb_isCleanSession == null)
				cb_isCleanSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCleanSession);
			return cb_isCleanSession;
		}

		static bool n_IsCleanSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CleanSession;
		}
#pragma warning restore 0169

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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanSession = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCleanSession;
		static IntPtr id_setCleanSession_Z;
		public virtual unsafe bool CleanSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='isCleanSession' and count(parameter)=0]"
			[Register ("isCleanSession", "()Z", "GetIsCleanSessionHandler")]
			get {
				if (id_isCleanSession == IntPtr.Zero)
					id_isCleanSession = JNIEnv.GetMethodID (class_ref, "isCleanSession", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCleanSession);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCleanSession", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setCleanSession' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCleanSession", "(Z)V", "GetSetCleanSession_ZHandler")]
			set {
				if (id_setCleanSession_Z == IntPtr.Zero)
					id_setCleanSession_Z = JNIEnv.GetMethodID (class_ref, "setCleanSession", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCleanSession_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCleanSession", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectionTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectionTimeoutHandler ()
		{
			if (cb_getConnectionTimeout == null)
				cb_getConnectionTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectionTimeout);
			return cb_getConnectionTimeout;
		}

		static int n_GetConnectionTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectionTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectionTimeout_IHandler ()
		{
			if (cb_setConnectionTimeout_I == null)
				cb_setConnectionTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectionTimeout_I);
			return cb_setConnectionTimeout_I;
		}

		static void n_SetConnectionTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionTimeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionTimeout;
		static IntPtr id_setConnectionTimeout_I;
		public virtual unsafe int ConnectionTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getConnectionTimeout' and count(parameter)=0]"
			[Register ("getConnectionTimeout", "()I", "GetGetConnectionTimeoutHandler")]
			get {
				if (id_getConnectionTimeout == IntPtr.Zero)
					id_getConnectionTimeout = JNIEnv.GetMethodID (class_ref, "getConnectionTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getConnectionTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setConnectionTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectionTimeout", "(I)V", "GetSetConnectionTimeout_IHandler")]
			set {
				if (id_setConnectionTimeout_I == IntPtr.Zero)
					id_setConnectionTimeout_I = JNIEnv.GetMethodID (class_ref, "setConnectionTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setConnectionTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectionTimeout", "(I)V"), __args);
				} finally {
				}
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Debug);
		}
#pragma warning restore 0169

		static IntPtr id_getDebug;
		public virtual unsafe global::Java.Util.Properties Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getDebug' and count(parameter)=0]"
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

		static Delegate cb_getKeepAliveInterval;
#pragma warning disable 0169
		static Delegate GetGetKeepAliveIntervalHandler ()
		{
			if (cb_getKeepAliveInterval == null)
				cb_getKeepAliveInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKeepAliveInterval);
			return cb_getKeepAliveInterval;
		}

		static int n_GetKeepAliveInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepAliveInterval;
		}
#pragma warning restore 0169

		static Delegate cb_setKeepAliveInterval_I;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveInterval_IHandler ()
		{
			if (cb_setKeepAliveInterval_I == null)
				cb_setKeepAliveInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetKeepAliveInterval_I);
			return cb_setKeepAliveInterval_I;
		}

		static void n_SetKeepAliveInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KeepAliveInterval = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKeepAliveInterval;
		static IntPtr id_setKeepAliveInterval_I;
		public virtual unsafe int KeepAliveInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getKeepAliveInterval' and count(parameter)=0]"
			[Register ("getKeepAliveInterval", "()I", "GetGetKeepAliveIntervalHandler")]
			get {
				if (id_getKeepAliveInterval == IntPtr.Zero)
					id_getKeepAliveInterval = JNIEnv.GetMethodID (class_ref, "getKeepAliveInterval", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getKeepAliveInterval);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeepAliveInterval", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setKeepAliveInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setKeepAliveInterval", "(I)V", "GetSetKeepAliveInterval_IHandler")]
			set {
				if (id_setKeepAliveInterval_I == IntPtr.Zero)
					id_setKeepAliveInterval_I = JNIEnv.GetMethodID (class_ref, "setKeepAliveInterval", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setKeepAliveInterval_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAliveInterval", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMqttVersion;
#pragma warning disable 0169
		static Delegate GetGetMqttVersionHandler ()
		{
			if (cb_getMqttVersion == null)
				cb_getMqttVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMqttVersion);
			return cb_getMqttVersion;
		}

		static int n_GetMqttVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MqttVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setMqttVersion_I;
#pragma warning disable 0169
		static Delegate GetSetMqttVersion_IHandler ()
		{
			if (cb_setMqttVersion_I == null)
				cb_setMqttVersion_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMqttVersion_I);
			return cb_setMqttVersion_I;
		}

		static void n_SetMqttVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MqttVersion = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMqttVersion;
		static IntPtr id_setMqttVersion_I;
		public virtual unsafe int MqttVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getMqttVersion' and count(parameter)=0]"
			[Register ("getMqttVersion", "()I", "GetGetMqttVersionHandler")]
			get {
				if (id_getMqttVersion == IntPtr.Zero)
					id_getMqttVersion = JNIEnv.GetMethodID (class_ref, "getMqttVersion", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMqttVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMqttVersion", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setMqttVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMqttVersion", "(I)V", "GetSetMqttVersion_IHandler")]
			set {
				if (id_setMqttVersion_I == IntPtr.Zero)
					id_setMqttVersion_I = JNIEnv.GetMethodID (class_ref, "setMqttVersion", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMqttVersion_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMqttVersion", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSSLProperties;
#pragma warning disable 0169
		static Delegate GetGetSSLPropertiesHandler ()
		{
			if (cb_getSSLProperties == null)
				cb_getSSLProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSSLProperties);
			return cb_getSSLProperties;
		}

		static IntPtr n_GetSSLProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SSLProperties);
		}
#pragma warning restore 0169

		static Delegate cb_setSSLProperties_Ljava_util_Properties_;
#pragma warning disable 0169
		static Delegate GetSetSSLProperties_Ljava_util_Properties_Handler ()
		{
			if (cb_setSSLProperties_Ljava_util_Properties_ == null)
				cb_setSSLProperties_Ljava_util_Properties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSSLProperties_Ljava_util_Properties_);
			return cb_setSSLProperties_Ljava_util_Properties_;
		}

		static void n_SetSSLProperties_Ljava_util_Properties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Properties p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SSLProperties = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSSLProperties;
		static IntPtr id_setSSLProperties_Ljava_util_Properties_;
		public virtual unsafe global::Java.Util.Properties SSLProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getSSLProperties' and count(parameter)=0]"
			[Register ("getSSLProperties", "()Ljava/util/Properties;", "GetGetSSLPropertiesHandler")]
			get {
				if (id_getSSLProperties == IntPtr.Zero)
					id_getSSLProperties = JNIEnv.GetMethodID (class_ref, "getSSLProperties", "()Ljava/util/Properties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallObjectMethod  (Handle, id_getSSLProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLProperties", "()Ljava/util/Properties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setSSLProperties' and count(parameter)=1 and parameter[1][@type='java.util.Properties']]"
			[Register ("setSSLProperties", "(Ljava/util/Properties;)V", "GetSetSSLProperties_Ljava_util_Properties_Handler")]
			set {
				if (id_setSSLProperties_Ljava_util_Properties_ == IntPtr.Zero)
					id_setSSLProperties_Ljava_util_Properties_ = JNIEnv.GetMethodID (class_ref, "setSSLProperties", "(Ljava/util/Properties;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSSLProperties_Ljava_util_Properties_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSSLProperties", "(Ljava/util/Properties;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSocketFactory;
#pragma warning disable 0169
		static Delegate GetGetSocketFactoryHandler ()
		{
			if (cb_getSocketFactory == null)
				cb_getSocketFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocketFactory);
			return cb_getSocketFactory;
		}

		static IntPtr n_GetSocketFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SocketFactory);
		}
#pragma warning restore 0169

		static Delegate cb_setSocketFactory_Ljavax_net_SocketFactory_;
#pragma warning disable 0169
		static Delegate GetSetSocketFactory_Ljavax_net_SocketFactory_Handler ()
		{
			if (cb_setSocketFactory_Ljavax_net_SocketFactory_ == null)
				cb_setSocketFactory_Ljavax_net_SocketFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSocketFactory_Ljavax_net_SocketFactory_);
			return cb_setSocketFactory_Ljavax_net_SocketFactory_;
		}

		static void n_SetSocketFactory_Ljavax_net_SocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.SocketFactory p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SocketFactory = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSocketFactory;
		static IntPtr id_setSocketFactory_Ljavax_net_SocketFactory_;
		public virtual unsafe global::Javax.Net.SocketFactory SocketFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getSocketFactory' and count(parameter)=0]"
			[Register ("getSocketFactory", "()Ljavax/net/SocketFactory;", "GetGetSocketFactoryHandler")]
			get {
				if (id_getSocketFactory == IntPtr.Zero)
					id_getSocketFactory = JNIEnv.GetMethodID (class_ref, "getSocketFactory", "()Ljavax/net/SocketFactory;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (JNIEnv.CallObjectMethod  (Handle, id_getSocketFactory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocketFactory", "()Ljavax/net/SocketFactory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setSocketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.SocketFactory']]"
			[Register ("setSocketFactory", "(Ljavax/net/SocketFactory;)V", "GetSetSocketFactory_Ljavax_net_SocketFactory_Handler")]
			set {
				if (id_setSocketFactory_Ljavax_net_SocketFactory_ == IntPtr.Zero)
					id_setSocketFactory_Ljavax_net_SocketFactory_ = JNIEnv.GetMethodID (class_ref, "setSocketFactory", "(Ljavax/net/SocketFactory;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSocketFactory_Ljavax_net_SocketFactory_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSocketFactory", "(Ljavax/net/SocketFactory;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		static Delegate cb_setUserName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserName_Ljava_lang_String_Handler ()
		{
			if (cb_setUserName_Ljava_lang_String_ == null)
				cb_setUserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserName_Ljava_lang_String_);
			return cb_setUserName_Ljava_lang_String_;
		}

		static void n_SetUserName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserName;
		static IntPtr id_setUserName_Ljava_lang_String_;
		public virtual unsafe string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")]
			get {
				if (id_getUserName == IntPtr.Zero)
					id_getUserName = JNIEnv.GetMethodID (class_ref, "getUserName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setUserName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserName", "(Ljava/lang/String;)V", "GetSetUserName_Ljava_lang_String_Handler")]
			set {
				if (id_setUserName_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUserName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWillDestination;
#pragma warning disable 0169
		static Delegate GetGetWillDestinationHandler ()
		{
			if (cb_getWillDestination == null)
				cb_getWillDestination = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWillDestination);
			return cb_getWillDestination;
		}

		static IntPtr n_GetWillDestination (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WillDestination);
		}
#pragma warning restore 0169

		static IntPtr id_getWillDestination;
		public virtual unsafe string WillDestination {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getWillDestination' and count(parameter)=0]"
			[Register ("getWillDestination", "()Ljava/lang/String;", "GetGetWillDestinationHandler")]
			get {
				if (id_getWillDestination == IntPtr.Zero)
					id_getWillDestination = JNIEnv.GetMethodID (class_ref, "getWillDestination", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getWillDestination), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWillDestination", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWillMessage;
#pragma warning disable 0169
		static Delegate GetGetWillMessageHandler ()
		{
			if (cb_getWillMessage == null)
				cb_getWillMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWillMessage);
			return cb_getWillMessage;
		}

		static IntPtr n_GetWillMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WillMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getWillMessage;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage WillMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getWillMessage' and count(parameter)=0]"
			[Register ("getWillMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;", "GetGetWillMessageHandler")]
			get {
				if (id_getWillMessage == IntPtr.Zero)
					id_getWillMessage = JNIEnv.GetMethodID (class_ref, "getWillMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (JNIEnv.CallObjectMethod  (Handle, id_getWillMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWillMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPassword ());
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getPassword' and count(parameter)=0]"
		[Register ("getPassword", "()[C", "GetGetPasswordHandler")]
		public virtual unsafe char[] GetPassword ()
		{
			if (id_getPassword == IntPtr.Zero)
				id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()[C");
			try {

				if (GetType () == ThresholdType)
					return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPassword), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					return (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()[C")), JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
			}
		}

		static Delegate cb_getServerURIs;
#pragma warning disable 0169
		static Delegate GetGetServerURIsHandler ()
		{
			if (cb_getServerURIs == null)
				cb_getServerURIs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerURIs);
			return cb_getServerURIs;
		}

		static IntPtr n_GetServerURIs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetServerURIs ());
		}
#pragma warning restore 0169

		static IntPtr id_getServerURIs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='getServerURIs' and count(parameter)=0]"
		[Register ("getServerURIs", "()[Ljava/lang/String;", "GetGetServerURIsHandler")]
		public virtual unsafe string[] GetServerURIs ()
		{
			if (id_getServerURIs == IntPtr.Zero)
				id_getServerURIs = JNIEnv.GetMethodID (class_ref, "getServerURIs", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getServerURIs), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerURIs", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setPassword_arrayC;
#pragma warning disable 0169
		static Delegate GetSetPassword_arrayCHandler ()
		{
			if (cb_setPassword_arrayC == null)
				cb_setPassword_arrayC = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_arrayC);
			return cb_setPassword_arrayC;
		}

		static void n_SetPassword_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			char[] p0 = (char[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.SetPassword (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPassword_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("setPassword", "([C)V", "GetSetPassword_arrayCHandler")]
		public virtual unsafe void SetPassword (char[] p0)
		{
			if (id_setPassword_arrayC == IntPtr.Zero)
				id_setPassword_arrayC = JNIEnv.GetMethodID (class_ref, "setPassword", "([C)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPassword_arrayC, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "([C)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setServerURIs_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerURIs_arrayLjava_lang_String_Handler ()
		{
			if (cb_setServerURIs_arrayLjava_lang_String_ == null)
				cb_setServerURIs_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerURIs_arrayLjava_lang_String_);
			return cb_setServerURIs_arrayLjava_lang_String_;
		}

		static void n_SetServerURIs_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetServerURIs (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setServerURIs_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setServerURIs' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setServerURIs", "([Ljava/lang/String;)V", "GetSetServerURIs_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetServerURIs (string[] p0)
		{
			if (id_setServerURIs_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setServerURIs_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServerURIs", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setServerURIs_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerURIs", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setWill_Ljava_lang_String_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetSetWill_Ljava_lang_String_arrayBIZHandler ()
		{
			if (cb_setWill_Ljava_lang_String_arrayBIZ == null)
				cb_setWill_Ljava_lang_String_arrayBIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_SetWill_Ljava_lang_String_arrayBIZ);
			return cb_setWill_Ljava_lang_String_arrayBIZ;
		}

		static void n_SetWill_Ljava_lang_String_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetWill (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWill_Ljava_lang_String_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setWill' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("setWill", "(Ljava/lang/String;[BIZ)V", "GetSetWill_Ljava_lang_String_arrayBIZHandler")]
		public virtual unsafe void SetWill (string p0, byte[] p1, int p2, bool p3)
		{
			if (id_setWill_Ljava_lang_String_arrayBIZ == IntPtr.Zero)
				id_setWill_Ljava_lang_String_arrayBIZ = JNIEnv.GetMethodID (class_ref, "setWill", "(Ljava/lang/String;[BIZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWill_Ljava_lang_String_arrayBIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWill", "(Ljava/lang/String;[BIZ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ;
#pragma warning disable 0169
		static Delegate GetSetWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZHandler ()
		{
			if (cb_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ == null)
				cb_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_SetWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ);
			return cb_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ;
		}

		static void n_SetWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetWill (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setWill' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("setWill", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;IZ)V", "GetSetWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZHandler")]
		protected virtual unsafe void SetWill (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1, int p2, bool p3)
		{
			if (id_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ == IntPtr.Zero)
				id_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ = JNIEnv.GetMethodID (class_ref, "setWill", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;IZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWill_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWill", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;IZ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetSetWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZHandler ()
		{
			if (cb_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ == null)
				cb_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_SetWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ);
			return cb_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ;
		}

		static void n_SetWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetWill (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='setWill' and count(parameter)=4 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttTopic'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("setWill", "(Lorg/eclipse/paho/client/mqttv3/MqttTopic;[BIZ)V", "GetSetWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZHandler")]
		public virtual unsafe void SetWill (global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic p0, byte[] p1, int p2, bool p3)
		{
			if (id_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ == IntPtr.Zero)
				id_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ = JNIEnv.GetMethodID (class_ref, "setWill", "(Lorg/eclipse/paho/client/mqttv3/MqttTopic;[BIZ)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWill_Lorg_eclipse_paho_client_mqttv3_MqttTopic_arrayBIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWill", "(Lorg/eclipse/paho/client/mqttv3/MqttTopic;[BIZ)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_validateURI_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttConnectOptions']/method[@name='validateURI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateURI", "(Ljava/lang/String;)I", "")]
		protected static unsafe int ValidateURI (string p0)
		{
			if (id_validateURI_Ljava_lang_String_ == IntPtr.Zero)
				id_validateURI_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validateURI", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_validateURI_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
