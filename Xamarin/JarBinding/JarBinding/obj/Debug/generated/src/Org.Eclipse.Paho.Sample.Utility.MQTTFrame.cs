using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Sample.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']"
	[global::Android.Runtime.Register ("org/eclipse/paho/sample/utility/MQTTFrame", DoNotGenerateAcw=true)]
	public partial class MQTTFrame : global::Java.Lang.Object, global::Java.Lang.IRunnable, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/field[@name='FRAME_HEIGHT']"
		[Register ("FRAME_HEIGHT")]
		protected const int FrameHeight = (int) 450;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/field[@name='FRAME_WIDTH']"
		[Register ("FRAME_WIDTH")]
		protected const int FrameWidth = (int) 375;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/sample/utility/MQTTFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MQTTFrame); }
		}

		protected MQTTFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/constructor[@name='MQTTFrame' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MQTTFrame ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MQTTFrame)) {
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

		static Delegate cb_connect_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_ZHandler ()
		{
			if (cb_connect_Ljava_lang_String_Z == null)
				cb_connect_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_lang_String_Z);
			return cb_connect_Ljava_lang_String_Z;
		}

		static void n_Connect_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("connect", "(Ljava/lang/String;Z)V", "GetConnect_Ljava_lang_String_ZHandler")]
		public virtual unsafe void Connect (string p0, bool p1)
		{
			if (id_connect_Ljava_lang_String_Z == IntPtr.Zero)
				id_connect_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connect_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connectionLost_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetConnectionLost_Ljava_lang_Throwable_Handler ()
		{
			if (cb_connectionLost_Ljava_lang_Throwable_ == null)
				cb_connectionLost_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConnectionLost_Ljava_lang_Throwable_);
			return cb_connectionLost_Ljava_lang_Throwable_;
		}

		static void n_ConnectionLost_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connectionLost_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='connectionLost' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("connectionLost", "(Ljava/lang/Throwable;)V", "GetConnectionLost_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void ConnectionLost (global::Java.Lang.Throwable p0)
		{
			if (id_connectionLost_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_connectionLost_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "connectionLost", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connectionLost_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectionLost", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_constructPropertyValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConstructPropertyValue_Ljava_lang_String_Handler ()
		{
			if (cb_constructPropertyValue_Ljava_lang_String_ == null)
				cb_constructPropertyValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConstructPropertyValue_Ljava_lang_String_);
			return cb_constructPropertyValue_Ljava_lang_String_;
		}

		static IntPtr n_ConstructPropertyValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ConstructPropertyValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_constructPropertyValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='constructPropertyValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("constructPropertyValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetConstructPropertyValue_Ljava_lang_String_Handler")]
		public virtual unsafe string ConstructPropertyValue (string p0)
		{
			if (id_constructPropertyValue_Ljava_lang_String_ == IntPtr.Zero)
				id_constructPropertyValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "constructPropertyValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_constructPropertyValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "constructPropertyValue", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler ()
		{
			if (cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ == null)
				cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_);
			return cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
		}

		static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttDeliveryToken']]"
		[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler")]
		public virtual unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken p0)
		{
			if (id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ == IntPtr.Zero)
				id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ = JNIEnv.GetMethodID (class_ref, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static void n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='messageArrived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		public virtual unsafe void MessageArrived (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1)
		{
			if (id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_publish_Ljava_lang_String_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_arrayBIZHandler ()
		{
			if (cb_publish_Ljava_lang_String_arrayBIZ == null)
				cb_publish_Ljava_lang_String_arrayBIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_Publish_Ljava_lang_String_arrayBIZ);
			return cb_publish_Ljava_lang_String_arrayBIZ;
		}

		static void n_Publish_Ljava_lang_String_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Publish (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("publish", "(Ljava/lang/String;[BIZ)V", "GetPublish_Ljava_lang_String_arrayBIZHandler")]
		public virtual unsafe void Publish (string p0, byte[] p1, int p2, bool p3)
		{
			if (id_publish_Ljava_lang_String_arrayBIZ == IntPtr.Zero)
				id_publish_Ljava_lang_String_arrayBIZ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;[BIZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_publish_Ljava_lang_String_arrayBIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;[BIZ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='run' and count(parameter)=0]"
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

		static Delegate cb_setTitleText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleText_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleText_Ljava_lang_String_ == null)
				cb_setTitleText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitleText_Ljava_lang_String_);
			return cb_setTitleText_Ljava_lang_String_;
		}

		static void n_SetTitleText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleText (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitleText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='setTitleText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleText", "(Ljava/lang/String;)V", "GetSetTitleText_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTitleText (string p0)
		{
			if (id_setTitleText_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitleText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitleText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitleText_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitleText", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startTrace;
#pragma warning disable 0169
		static Delegate GetStartTraceHandler ()
		{
			if (cb_startTrace == null)
				cb_startTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartTrace);
			return cb_startTrace;
		}

		static void n_StartTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTrace ();
		}
#pragma warning restore 0169

		static IntPtr id_startTrace;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='startTrace' and count(parameter)=0]"
		[Register ("startTrace", "()V", "GetStartTraceHandler")]
		public virtual unsafe void StartTrace ()
		{
			if (id_startTrace == IntPtr.Zero)
				id_startTrace = JNIEnv.GetMethodID (class_ref, "startTrace", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startTrace);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startTrace", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopTrace;
#pragma warning disable 0169
		static Delegate GetStopTraceHandler ()
		{
			if (cb_stopTrace == null)
				cb_stopTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopTrace);
			return cb_stopTrace;
		}

		static void n_StopTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTrace ();
		}
#pragma warning restore 0169

		static IntPtr id_stopTrace;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='stopTrace' and count(parameter)=0]"
		[Register ("stopTrace", "()V", "GetStopTraceHandler")]
		public virtual unsafe void StopTrace ()
		{
			if (id_stopTrace == IntPtr.Zero)
				id_stopTrace = JNIEnv.GetMethodID (class_ref, "stopTrace", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopTrace);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopTrace", "()V"));
			} finally {
			}
		}

		static Delegate cb_subscription_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetSubscription_Ljava_lang_String_IZHandler ()
		{
			if (cb_subscription_Ljava_lang_String_IZ == null)
				cb_subscription_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_Subscription_Ljava_lang_String_IZ);
			return cb_subscription_Ljava_lang_String_IZ;
		}

		static void n_Subscription_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subscription (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_subscription_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='subscription' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("subscription", "(Ljava/lang/String;IZ)V", "GetSubscription_Ljava_lang_String_IZHandler")]
		public virtual unsafe void Subscription (string p0, int p1, bool p2)
		{
			if (id_subscription_Ljava_lang_String_IZ == IntPtr.Zero)
				id_subscription_Ljava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "subscription", "(Ljava/lang/String;IZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_subscription_Ljava_lang_String_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscription", "(Ljava/lang/String;IZ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updatePublishTopicList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdatePublishTopicList_Ljava_lang_String_Handler ()
		{
			if (cb_updatePublishTopicList_Ljava_lang_String_ == null)
				cb_updatePublishTopicList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdatePublishTopicList_Ljava_lang_String_);
			return cb_updatePublishTopicList_Ljava_lang_String_;
		}

		static void n_UpdatePublishTopicList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePublishTopicList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updatePublishTopicList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='updatePublishTopicList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updatePublishTopicList", "(Ljava/lang/String;)V", "GetUpdatePublishTopicList_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdatePublishTopicList (string p0)
		{
			if (id_updatePublishTopicList_Ljava_lang_String_ == IntPtr.Zero)
				id_updatePublishTopicList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updatePublishTopicList", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updatePublishTopicList_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePublishTopicList", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateSubscribeTopicList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSubscribeTopicList_Ljava_lang_String_Handler ()
		{
			if (cb_updateSubscribeTopicList_Ljava_lang_String_ == null)
				cb_updateSubscribeTopicList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateSubscribeTopicList_Ljava_lang_String_);
			return cb_updateSubscribeTopicList_Ljava_lang_String_;
		}

		static void n_UpdateSubscribeTopicList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSubscribeTopicList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateSubscribeTopicList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='updateSubscribeTopicList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateSubscribeTopicList", "(Ljava/lang/String;)V", "GetUpdateSubscribeTopicList_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateSubscribeTopicList (string p0)
		{
			if (id_updateSubscribeTopicList_Ljava_lang_String_ == IntPtr.Zero)
				id_updateSubscribeTopicList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateSubscribeTopicList", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateSubscribeTopicList_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSubscribeTopicList", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_writeLog_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteLog_Ljava_lang_String_Handler ()
		{
			if (cb_writeLog_Ljava_lang_String_ == null)
				cb_writeLog_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteLog_Ljava_lang_String_);
			return cb_writeLog_Ljava_lang_String_;
		}

		static void n_WriteLog_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteLog (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeLog_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='writeLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeLog", "(Ljava/lang/String;)V", "GetWriteLog_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteLog (string p0)
		{
			if (id_writeLog_Ljava_lang_String_ == IntPtr.Zero)
				id_writeLog_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeLog", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeLog_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLog", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_writeLogln_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteLogln_Ljava_lang_String_Handler ()
		{
			if (cb_writeLogln_Ljava_lang_String_ == null)
				cb_writeLogln_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteLogln_Ljava_lang_String_);
			return cb_writeLogln_Ljava_lang_String_;
		}

		static void n_WriteLogln_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.MQTTFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteLogln (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeLogln_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='MQTTFrame']/method[@name='writeLogln' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeLogln", "(Ljava/lang/String;)V", "GetWriteLogln_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteLogln (string p0)
		{
			if (id_writeLogln_Ljava_lang_String_ == IntPtr.Zero)
				id_writeLogln_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeLogln", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeLogln_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLogln", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
