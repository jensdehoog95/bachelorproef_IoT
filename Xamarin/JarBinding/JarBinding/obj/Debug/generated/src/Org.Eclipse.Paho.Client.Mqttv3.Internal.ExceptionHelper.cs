using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ExceptionHelper", DoNotGenerateAcw=true)]
	public partial class ExceptionHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/ExceptionHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionHelper); }
		}

		protected ExceptionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createMqttException_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']/method[@name='createMqttException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createMqttException", "(I)Lorg/eclipse/paho/client/mqttv3/MqttException;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException CreateMqttException (int p0)
		{
			if (id_createMqttException_I == IntPtr.Zero)
				id_createMqttException_I = JNIEnv.GetStaticMethodID (class_ref, "createMqttException", "(I)Lorg/eclipse/paho/client/mqttv3/MqttException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMqttException_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMqttException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']/method[@name='createMqttException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("createMqttException", "(Ljava/lang/Throwable;)Lorg/eclipse/paho/client/mqttv3/MqttException;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException CreateMqttException (global::Java.Lang.Throwable p0)
		{
			if (id_createMqttException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_createMqttException_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "createMqttException", "(Ljava/lang/Throwable;)Lorg/eclipse/paho/client/mqttv3/MqttException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttException __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMqttException_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isClassAvailable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']/method[@name='isClassAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isClassAvailable", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsClassAvailable (string p0)
		{
			if (id_isClassAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_isClassAvailable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isClassAvailable", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isClassAvailable_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
