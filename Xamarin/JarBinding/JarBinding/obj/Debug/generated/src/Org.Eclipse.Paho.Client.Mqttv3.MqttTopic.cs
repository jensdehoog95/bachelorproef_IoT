using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttTopic", DoNotGenerateAcw=true)]
	public partial class MqttTopic : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='MULTI_LEVEL_WILDCARD']"
		[Register ("MULTI_LEVEL_WILDCARD")]
		public const string MultiLevelWildcard = (string) "#";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='MULTI_LEVEL_WILDCARD_PATTERN']"
		[Register ("MULTI_LEVEL_WILDCARD_PATTERN")]
		public const string MultiLevelWildcardPattern = (string) "/#";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='SINGLE_LEVEL_WILDCARD']"
		[Register ("SINGLE_LEVEL_WILDCARD")]
		public const string SingleLevelWildcard = (string) "+";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='TOPIC_LEVEL_SEPARATOR']"
		[Register ("TOPIC_LEVEL_SEPARATOR")]
		public const string TopicLevelSeparator = (string) "/";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='TOPIC_WILDCARDS']"
		[Register ("TOPIC_WILDCARDS")]
		public const string TopicWildcards = (string) "#+";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/MqttTopic", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttTopic); }
		}

		protected MqttTopic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/constructor[@name='MqttTopic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", "")]
		public unsafe MqttTopic (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MqttTopic)) {
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_publish_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetPublish_arrayBIZHandler ()
		{
			if (cb_publish_arrayBIZ == null)
				cb_publish_arrayBIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_Publish_arrayBIZ);
			return cb_publish_arrayBIZ;
		}

		static IntPtr n_Publish_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='publish' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("publish", "([BIZ)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetPublish_arrayBIZHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken Publish (byte[] p0, int p1, bool p2)
		{
			if (id_publish_arrayBIZ == IntPtr.Zero)
				id_publish_arrayBIZ = JNIEnv.GetMethodID (class_ref, "publish", "([BIZ)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (JNIEnv.CallObjectMethod  (Handle, id_publish_arrayBIZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "([BIZ)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetPublish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static IntPtr n_Publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='publish' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("publish", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetPublish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken Publish (global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p0)
		{
			if (id_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "publish", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (JNIEnv.CallObjectMethod  (Handle, id_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_validate_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='validate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("validate", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void Validate (string p0, bool p1)
		{
			if (id_validate_Ljava_lang_String_Z == IntPtr.Zero)
				id_validate_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "validate", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validate_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
