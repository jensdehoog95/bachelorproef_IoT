using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/security/SSLSocketFactoryFactory", DoNotGenerateAcw=true)]
	public partial class SSLSocketFactoryFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='CIPHERSUITES']"
		[Register ("CIPHERSUITES")]
		public const string Ciphersuites = (string) "com.ibm.ssl.enabledCipherSuites";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='CLIENTAUTH']"
		[Register ("CLIENTAUTH")]
		public const string Clientauth = (string) "com.ibm.ssl.clientAuthentication";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='DEFAULT_PROTOCOL']"
		[Register ("DEFAULT_PROTOCOL")]
		public const string DefaultProtocol = (string) "TLS";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='JSSEPROVIDER']"
		[Register ("JSSEPROVIDER")]
		public const string Jsseprovider = (string) "com.ibm.ssl.contextProvider";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTORE']"
		[Register ("KEYSTORE")]
		public const string Keystore = (string) "com.ibm.ssl.keyStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTOREMGR']"
		[Register ("KEYSTOREMGR")]
		public const string Keystoremgr = (string) "com.ibm.ssl.keyManager";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTOREPROVIDER']"
		[Register ("KEYSTOREPROVIDER")]
		public const string Keystoreprovider = (string) "com.ibm.ssl.keyStoreProvider";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTOREPWD']"
		[Register ("KEYSTOREPWD")]
		public const string Keystorepwd = (string) "com.ibm.ssl.keyStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTORETYPE']"
		[Register ("KEYSTORETYPE")]
		public const string Keystoretype = (string) "com.ibm.ssl.keyStoreType";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SSLPROTOCOL']"
		[Register ("SSLPROTOCOL")]
		public const string Sslprotocol = (string) "com.ibm.ssl.protocol";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYMGRALGO']"
		[Register ("SYSKEYMGRALGO")]
		public const string Syskeymgralgo = (string) "ssl.KeyManagerFactory.algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYSTORE']"
		[Register ("SYSKEYSTORE")]
		public const string Syskeystore = (string) "javax.net.ssl.keyStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYSTOREPWD']"
		[Register ("SYSKEYSTOREPWD")]
		public const string Syskeystorepwd = (string) "javax.net.ssl.keyStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYSTORETYPE']"
		[Register ("SYSKEYSTORETYPE")]
		public const string Syskeystoretype = (string) "javax.net.ssl.keyStoreType";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTMGRALGO']"
		[Register ("SYSTRUSTMGRALGO")]
		public const string Systrustmgralgo = (string) "ssl.TrustManagerFactory.algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTSTORE']"
		[Register ("SYSTRUSTSTORE")]
		public const string Systruststore = (string) "javax.net.ssl.trustStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTSTOREPWD']"
		[Register ("SYSTRUSTSTOREPWD")]
		public const string Systruststorepwd = (string) "javax.net.ssl.trustStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTSTORETYPE']"
		[Register ("SYSTRUSTSTORETYPE")]
		public const string Systruststoretype = (string) "javax.net.ssl.trustStoreType";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTORE']"
		[Register ("TRUSTSTORE")]
		public const string Truststore = (string) "com.ibm.ssl.trustStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTOREMGR']"
		[Register ("TRUSTSTOREMGR")]
		public const string Truststoremgr = (string) "com.ibm.ssl.trustManager";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTOREPROVIDER']"
		[Register ("TRUSTSTOREPROVIDER")]
		public const string Truststoreprovider = (string) "com.ibm.ssl.trustStoreProvider";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTOREPWD']"
		[Register ("TRUSTSTOREPWD")]
		public const string Truststorepwd = (string) "com.ibm.ssl.trustStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTORETYPE']"
		[Register ("TRUSTSTORETYPE")]
		public const string Truststoretype = (string) "com.ibm.ssl.trustStoreType";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/security/SSLSocketFactoryFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SSLSocketFactoryFactory); }
		}

		protected SSLSocketFactoryFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/constructor[@name='SSLSocketFactoryFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SSLSocketFactoryFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SSLSocketFactoryFactory)) {
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

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_logging_Logger_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/constructor[@name='SSLSocketFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.logging.Logger']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/logging/Logger;)V", "")]
		public unsafe SSLSocketFactoryFactory (global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SSLSocketFactoryFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/eclipse/paho/client/mqttv3/logging/Logger;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/eclipse/paho/client/mqttv3/logging/Logger;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_logging_Logger_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_logging_Logger_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/logging/Logger;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_logging_Logger_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_logging_Logger_, __args);
			} finally {
			}
		}

		static IntPtr id_isSupportedOnJVM;
		public static unsafe bool IsSupportedOnJVM {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='isSupportedOnJVM' and count(parameter)=0]"
			[Register ("isSupportedOnJVM", "()Z", "GetIsSupportedOnJVMHandler")]
			get {
				if (id_isSupportedOnJVM == IntPtr.Zero)
					id_isSupportedOnJVM = JNIEnv.GetStaticMethodID (class_ref, "isSupportedOnJVM", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSupportedOnJVM);
				} finally {
				}
			}
		}

		static Delegate cb_createSocketFactory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateSocketFactory_Ljava_lang_String_Handler ()
		{
			if (cb_createSocketFactory_Ljava_lang_String_ == null)
				cb_createSocketFactory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateSocketFactory_Ljava_lang_String_);
			return cb_createSocketFactory_Ljava_lang_String_;
		}

		static IntPtr n_CreateSocketFactory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocketFactory (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSocketFactory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='createSocketFactory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createSocketFactory", "(Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;", "GetCreateSocketFactory_Ljava_lang_String_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory CreateSocketFactory (string p0)
		{
			if (id_createSocketFactory_Ljava_lang_String_ == IntPtr.Zero)
				id_createSocketFactory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createSocketFactory", "(Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Javax.Net.Ssl.SSLSocketFactory __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod  (Handle, id_createSocketFactory_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSocketFactory", "(Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_deObfuscate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='deObfuscate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deObfuscate", "(Ljava/lang/String;)[C", "")]
		public static unsafe char[] DeObfuscate (string p0)
		{
			if (id_deObfuscate_Ljava_lang_String_ == IntPtr.Zero)
				id_deObfuscate_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deObfuscate", "(Ljava/lang/String;)[C");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_deObfuscate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getClientAuthentication_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetClientAuthentication_Ljava_lang_String_Handler ()
		{
			if (cb_getClientAuthentication_Ljava_lang_String_ == null)
				cb_getClientAuthentication_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetClientAuthentication_Ljava_lang_String_);
			return cb_getClientAuthentication_Ljava_lang_String_;
		}

		static bool n_GetClientAuthentication_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetClientAuthentication (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getClientAuthentication_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getClientAuthentication' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClientAuthentication", "(Ljava/lang/String;)Z", "GetGetClientAuthentication_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetClientAuthentication (string p0)
		{
			if (id_getClientAuthentication_Ljava_lang_String_ == IntPtr.Zero)
				id_getClientAuthentication_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getClientAuthentication", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_getClientAuthentication_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientAuthentication", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConfiguration_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConfiguration_Ljava_lang_String_Handler ()
		{
			if (cb_getConfiguration_Ljava_lang_String_ == null)
				cb_getConfiguration_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConfiguration_Ljava_lang_String_);
			return cb_getConfiguration_Ljava_lang_String_;
		}

		static IntPtr n_GetConfiguration_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConfiguration (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConfiguration_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getConfiguration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfiguration", "(Ljava/lang/String;)Ljava/util/Properties;", "GetGetConfiguration_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Util.Properties GetConfiguration (string p0)
		{
			if (id_getConfiguration_Ljava_lang_String_ == IntPtr.Zero)
				id_getConfiguration_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConfiguration", "(Ljava/lang/String;)Ljava/util/Properties;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Util.Properties __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallObjectMethod  (Handle, id_getConfiguration_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfiguration", "(Ljava/lang/String;)Ljava/util/Properties;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getEnabledCipherSuites_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEnabledCipherSuites_Ljava_lang_String_Handler ()
		{
			if (cb_getEnabledCipherSuites_Ljava_lang_String_ == null)
				cb_getEnabledCipherSuites_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEnabledCipherSuites_Ljava_lang_String_);
			return cb_getEnabledCipherSuites_Ljava_lang_String_;
		}

		static IntPtr n_GetEnabledCipherSuites_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetEnabledCipherSuites (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEnabledCipherSuites_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getEnabledCipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEnabledCipherSuites", "(Ljava/lang/String;)[Ljava/lang/String;", "GetGetEnabledCipherSuites_Ljava_lang_String_Handler")]
		public virtual unsafe string[] GetEnabledCipherSuites (string p0)
		{
			if (id_getEnabledCipherSuites_Ljava_lang_String_ == IntPtr.Zero)
				id_getEnabledCipherSuites_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEnabledCipherSuites", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string[] __ret;
				if (GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEnabledCipherSuites_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnabledCipherSuites", "(Ljava/lang/String;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getJSSEProvider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetJSSEProvider_Ljava_lang_String_Handler ()
		{
			if (cb_getJSSEProvider_Ljava_lang_String_ == null)
				cb_getJSSEProvider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetJSSEProvider_Ljava_lang_String_);
			return cb_getJSSEProvider_Ljava_lang_String_;
		}

		static IntPtr n_GetJSSEProvider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetJSSEProvider (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getJSSEProvider_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getJSSEProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getJSSEProvider", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetJSSEProvider_Ljava_lang_String_Handler")]
		public virtual unsafe string GetJSSEProvider (string p0)
		{
			if (id_getJSSEProvider_Ljava_lang_String_ == IntPtr.Zero)
				id_getJSSEProvider_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getJSSEProvider", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getJSSEProvider_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSSEProvider", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getKeyManager_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyManager_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyManager_Ljava_lang_String_ == null)
				cb_getKeyManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyManager_Ljava_lang_String_);
			return cb_getKeyManager_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyManager_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyManager (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKeyManager_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyManager' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyManager", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyManager_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyManager (string p0)
		{
			if (id_getKeyManager_Ljava_lang_String_ == IntPtr.Zero)
				id_getKeyManager_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getKeyManager", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeyManager_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyManager", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getKeyStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStore_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStore_Ljava_lang_String_ == null)
				cb_getKeyStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStore_Ljava_lang_String_);
			return cb_getKeyStore_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyStore (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKeyStore_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStore", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyStore_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyStore (string p0)
		{
			if (id_getKeyStore_Ljava_lang_String_ == IntPtr.Zero)
				id_getKeyStore_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getKeyStore", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeyStore_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyStore", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getKeyStorePassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStorePassword_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStorePassword_Ljava_lang_String_ == null)
				cb_getKeyStorePassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStorePassword_Ljava_lang_String_);
			return cb_getKeyStorePassword_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStorePassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetKeyStorePassword (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKeyStorePassword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStorePassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStorePassword", "(Ljava/lang/String;)[C", "GetGetKeyStorePassword_Ljava_lang_String_Handler")]
		public virtual unsafe char[] GetKeyStorePassword (string p0)
		{
			if (id_getKeyStorePassword_Ljava_lang_String_ == IntPtr.Zero)
				id_getKeyStorePassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getKeyStorePassword", "(Ljava/lang/String;)[C");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				char[] __ret;
				if (GetType () == ThresholdType)
					__ret = (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getKeyStorePassword_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					__ret = (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyStorePassword", "(Ljava/lang/String;)[C"), __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getKeyStoreProvider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStoreProvider_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStoreProvider_Ljava_lang_String_ == null)
				cb_getKeyStoreProvider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStoreProvider_Ljava_lang_String_);
			return cb_getKeyStoreProvider_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStoreProvider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyStoreProvider (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKeyStoreProvider_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStoreProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyStoreProvider_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyStoreProvider (string p0)
		{
			if (id_getKeyStoreProvider_Ljava_lang_String_ == IntPtr.Zero)
				id_getKeyStoreProvider_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getKeyStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeyStoreProvider_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getKeyStoreType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStoreType_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStoreType_Ljava_lang_String_ == null)
				cb_getKeyStoreType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStoreType_Ljava_lang_String_);
			return cb_getKeyStoreType_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStoreType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyStoreType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKeyStoreType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStoreType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStoreType", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyStoreType_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyStoreType (string p0)
		{
			if (id_getKeyStoreType_Ljava_lang_String_ == IntPtr.Zero)
				id_getKeyStoreType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getKeyStoreType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeyStoreType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyStoreType", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSSLProtocol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSSLProtocol_Ljava_lang_String_Handler ()
		{
			if (cb_getSSLProtocol_Ljava_lang_String_ == null)
				cb_getSSLProtocol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSSLProtocol_Ljava_lang_String_);
			return cb_getSSLProtocol_Ljava_lang_String_;
		}

		static IntPtr n_GetSSLProtocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSSLProtocol (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSSLProtocol_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getSSLProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSSLProtocol", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSSLProtocol_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSSLProtocol (string p0)
		{
			if (id_getSSLProtocol_Ljava_lang_String_ == IntPtr.Zero)
				id_getSSLProtocol_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSSLProtocol", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSSLProtocol_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLProtocol", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTrustManager_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustManager_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustManager_Ljava_lang_String_ == null)
				cb_getTrustManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustManager_Ljava_lang_String_);
			return cb_getTrustManager_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustManager_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustManager (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTrustManager_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustManager' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustManager", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustManager_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustManager (string p0)
		{
			if (id_getTrustManager_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrustManager_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTrustManager", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTrustManager_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrustManager", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTrustStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStore_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStore_Ljava_lang_String_ == null)
				cb_getTrustStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStore_Ljava_lang_String_);
			return cb_getTrustStore_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustStore (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTrustStore_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStore", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustStore_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustStore (string p0)
		{
			if (id_getTrustStore_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrustStore_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTrustStore", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTrustStore_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrustStore", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTrustStorePassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStorePassword_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStorePassword_Ljava_lang_String_ == null)
				cb_getTrustStorePassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStorePassword_Ljava_lang_String_);
			return cb_getTrustStorePassword_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStorePassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetTrustStorePassword (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTrustStorePassword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStorePassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStorePassword", "(Ljava/lang/String;)[C", "GetGetTrustStorePassword_Ljava_lang_String_Handler")]
		public virtual unsafe char[] GetTrustStorePassword (string p0)
		{
			if (id_getTrustStorePassword_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrustStorePassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTrustStorePassword", "(Ljava/lang/String;)[C");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				char[] __ret;
				if (GetType () == ThresholdType)
					__ret = (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTrustStorePassword_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					__ret = (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrustStorePassword", "(Ljava/lang/String;)[C"), __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTrustStoreProvider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStoreProvider_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStoreProvider_Ljava_lang_String_ == null)
				cb_getTrustStoreProvider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStoreProvider_Ljava_lang_String_);
			return cb_getTrustStoreProvider_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStoreProvider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustStoreProvider (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTrustStoreProvider_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStoreProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustStoreProvider_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustStoreProvider (string p0)
		{
			if (id_getTrustStoreProvider_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrustStoreProvider_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTrustStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTrustStoreProvider_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrustStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTrustStoreType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStoreType_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStoreType_Ljava_lang_String_ == null)
				cb_getTrustStoreType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStoreType_Ljava_lang_String_);
			return cb_getTrustStoreType_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStoreType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustStoreType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTrustStoreType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStoreType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStoreType", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustStoreType_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustStoreType (string p0)
		{
			if (id_getTrustStoreType_Ljava_lang_String_ == IntPtr.Zero)
				id_getTrustStoreType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTrustStoreType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTrustStoreType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrustStoreType", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_initialize_Ljava_util_Properties_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_util_Properties_Ljava_lang_String_Handler ()
		{
			if (cb_initialize_Ljava_util_Properties_Ljava_lang_String_ == null)
				cb_initialize_Ljava_util_Properties_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_util_Properties_Ljava_lang_String_);
			return cb_initialize_Ljava_util_Properties_Ljava_lang_String_;
		}

		static void n_Initialize_Ljava_util_Properties_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Properties p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Ljava_util_Properties_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.util.Properties'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Ljava/util/Properties;Ljava/lang/String;)V", "GetInitialize_Ljava_util_Properties_Ljava_lang_String_Handler")]
		public virtual unsafe void Initialize (global::Java.Util.Properties p0, string p1)
		{
			if (id_initialize_Ljava_util_Properties_Ljava_lang_String_ == IntPtr.Zero)
				id_initialize_Ljava_util_Properties_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Ljava/util/Properties;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initialize_Ljava_util_Properties_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Ljava/util/Properties;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_merge_Ljava_util_Properties_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMerge_Ljava_util_Properties_Ljava_lang_String_Handler ()
		{
			if (cb_merge_Ljava_util_Properties_Ljava_lang_String_ == null)
				cb_merge_Ljava_util_Properties_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Merge_Ljava_util_Properties_Ljava_lang_String_);
			return cb_merge_Ljava_util_Properties_Ljava_lang_String_;
		}

		static void n_Merge_Ljava_util_Properties_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Properties p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Merge (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_merge_Ljava_util_Properties_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='java.util.Properties'] and parameter[2][@type='java.lang.String']]"
		[Register ("merge", "(Ljava/util/Properties;Ljava/lang/String;)V", "GetMerge_Ljava_util_Properties_Ljava_lang_String_Handler")]
		public virtual unsafe void Merge (global::Java.Util.Properties p0, string p1)
		{
			if (id_merge_Ljava_util_Properties_Ljava_lang_String_ == IntPtr.Zero)
				id_merge_Ljava_util_Properties_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "merge", "(Ljava/util/Properties;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_merge_Ljava_util_Properties_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "merge", "(Ljava/util/Properties;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_obfuscate_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='obfuscate' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("obfuscate", "([C)Ljava/lang/String;", "")]
		public static unsafe string Obfuscate (char[] p0)
		{
			if (id_obfuscate_arrayC == IntPtr.Zero)
				id_obfuscate_arrayC = JNIEnv.GetStaticMethodID (class_ref, "obfuscate", "([C)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_obfuscate_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_packCipherSuites_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='packCipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("packCipherSuites", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PackCipherSuites (string[] p0)
		{
			if (id_packCipherSuites_arrayLjava_lang_String_ == IntPtr.Zero)
				id_packCipherSuites_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "packCipherSuites", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_packCipherSuites_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static bool n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe bool Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_remove_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toByte_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='toByte' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("toByte", "([C)[B", "")]
		public static unsafe byte[] ToByte (char[] p0)
		{
			if (id_toByte_arrayC == IntPtr.Zero)
				id_toByte_arrayC = JNIEnv.GetStaticMethodID (class_ref, "toByte", "([C)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toByte_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_toChar_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='toChar' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toChar", "([B)[C", "")]
		public static unsafe char[] ToChar (byte[] p0)
		{
			if (id_toChar_arrayB == IntPtr.Zero)
				id_toChar_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toChar", "([B)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toChar_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_unpackCipherSuites_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='unpackCipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unpackCipherSuites", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] UnpackCipherSuites (string p0)
		{
			if (id_unpackCipherSuites_Ljava_lang_String_ == IntPtr.Zero)
				id_unpackCipherSuites_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unpackCipherSuites", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_unpackCipherSuites_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
