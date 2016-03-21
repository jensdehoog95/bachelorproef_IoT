using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage", DoNotGenerateAcw=true)]
	public abstract partial class MqttWireMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_CONNACK']"
		[Register ("MESSAGE_TYPE_CONNACK")]
		public const sbyte MessageTypeConnack = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_CONNECT']"
		[Register ("MESSAGE_TYPE_CONNECT")]
		public const sbyte MessageTypeConnect = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_DISCONNECT']"
		[Register ("MESSAGE_TYPE_DISCONNECT")]
		public const sbyte MessageTypeDisconnect = (sbyte) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PINGREQ']"
		[Register ("MESSAGE_TYPE_PINGREQ")]
		public const sbyte MessageTypePingreq = (sbyte) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PINGRESP']"
		[Register ("MESSAGE_TYPE_PINGRESP")]
		public const sbyte MessageTypePingresp = (sbyte) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBACK']"
		[Register ("MESSAGE_TYPE_PUBACK")]
		public const sbyte MessageTypePuback = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBCOMP']"
		[Register ("MESSAGE_TYPE_PUBCOMP")]
		public const sbyte MessageTypePubcomp = (sbyte) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBLISH']"
		[Register ("MESSAGE_TYPE_PUBLISH")]
		public const sbyte MessageTypePublish = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBREC']"
		[Register ("MESSAGE_TYPE_PUBREC")]
		public const sbyte MessageTypePubrec = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBREL']"
		[Register ("MESSAGE_TYPE_PUBREL")]
		public const sbyte MessageTypePubrel = (sbyte) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_SUBACK']"
		[Register ("MESSAGE_TYPE_SUBACK")]
		public const sbyte MessageTypeSuback = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_SUBSCRIBE']"
		[Register ("MESSAGE_TYPE_SUBSCRIBE")]
		public const sbyte MessageTypeSubscribe = (sbyte) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_UNSUBACK']"
		[Register ("MESSAGE_TYPE_UNSUBACK")]
		public const sbyte MessageTypeUnsuback = (sbyte) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_UNSUBSCRIBE']"
		[Register ("MESSAGE_TYPE_UNSUBSCRIBE")]
		public const sbyte MessageTypeUnsubscribe = (sbyte) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='STRING_ENCODING']"
		[Register ("STRING_ENCODING")]
		protected const string StringEncoding = (string) "UTF-8";

		static IntPtr duplicate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='duplicate']"
		[Register ("duplicate")]
		protected bool Duplicate {
			get {
				if (duplicate_jfieldId == IntPtr.Zero)
					duplicate_jfieldId = JNIEnv.GetFieldID (class_ref, "duplicate", "Z");
				return JNIEnv.GetBooleanField (Handle, duplicate_jfieldId);
			}
			set {
				if (duplicate_jfieldId == IntPtr.Zero)
					duplicate_jfieldId = JNIEnv.GetFieldID (class_ref, "duplicate", "Z");
				try {
					JNIEnv.SetField (Handle, duplicate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr msgId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='msgId']"
		[Register ("msgId")]
		protected int MsgId {
			get {
				if (msgId_jfieldId == IntPtr.Zero)
					msgId_jfieldId = JNIEnv.GetFieldID (class_ref, "msgId", "I");
				return JNIEnv.GetIntField (Handle, msgId_jfieldId);
			}
			set {
				if (msgId_jfieldId == IntPtr.Zero)
					msgId_jfieldId = JNIEnv.GetFieldID (class_ref, "msgId", "I");
				try {
					JNIEnv.SetField (Handle, msgId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttWireMessage); }
		}

		protected MqttWireMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_B;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/constructor[@name='MqttWireMessage' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe MqttWireMessage (sbyte p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MqttWireMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(B)V", __args);
					return;
				}

				if (id_ctor_B == IntPtr.Zero)
					id_ctor_B = JNIEnv.GetMethodID (class_ref, "<init>", "(B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_B, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_B, __args);
			} finally {
			}
		}

		static Delegate cb_isMessageIdRequired;
#pragma warning disable 0169
		static Delegate GetIsMessageIdRequiredHandler ()
		{
			if (cb_isMessageIdRequired == null)
				cb_isMessageIdRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMessageIdRequired);
			return cb_isMessageIdRequired;
		}

		static bool n_IsMessageIdRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMessageIdRequired;
		}
#pragma warning restore 0169

		static IntPtr id_isMessageIdRequired;
		public virtual unsafe bool IsMessageIdRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='isMessageIdRequired' and count(parameter)=0]"
			[Register ("isMessageIdRequired", "()Z", "GetIsMessageIdRequiredHandler")]
			get {
				if (id_isMessageIdRequired == IntPtr.Zero)
					id_isMessageIdRequired = JNIEnv.GetMethodID (class_ref, "isMessageIdRequired", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMessageIdRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMessageIdRequired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRetryable;
#pragma warning disable 0169
		static Delegate GetIsRetryableHandler ()
		{
			if (cb_isRetryable == null)
				cb_isRetryable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRetryable);
			return cb_isRetryable;
		}

		static bool n_IsRetryable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRetryable;
		}
#pragma warning restore 0169

		static IntPtr id_isRetryable;
		public virtual unsafe bool IsRetryable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='isRetryable' and count(parameter)=0]"
			[Register ("isRetryable", "()Z", "GetIsRetryableHandler")]
			get {
				if (id_isRetryable == IntPtr.Zero)
					id_isRetryable = JNIEnv.GetMethodID (class_ref, "isRetryable", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRetryable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRetryable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageId);
			return cb_getMessageId;
		}

		static int n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageId;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageId_I;
#pragma warning disable 0169
		static Delegate GetSetMessageId_IHandler ()
		{
			if (cb_setMessageId_I == null)
				cb_setMessageId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageId_I);
			return cb_setMessageId_I;
		}

		static void n_SetMessageId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		static IntPtr id_setMessageId_I;
		public virtual unsafe int MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()I", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMessageId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageId", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessageId", "(I)V", "GetSetMessageId_IHandler")]
			set {
				if (id_setMessageId_I == IntPtr.Zero)
					id_setMessageId_I = JNIEnv.GetMethodID (class_ref, "setMessageId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMessageId_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageId", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageInfo;
#pragma warning disable 0169
		static Delegate GetGetMessageInfoHandler ()
		{
			if (cb_getMessageInfo == null)
				cb_getMessageInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetMessageInfo);
			return cb_getMessageInfo;
		}

		static sbyte n_GetMessageInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageInfo;
		}
#pragma warning restore 0169

		protected abstract sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getMessageInfo' and count(parameter)=0]"
			[Register ("getMessageInfo", "()B", "GetGetMessageInfoHandler")] get;
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetType);
			return cb_getType;
		}

		static sbyte n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe sbyte Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()B", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod  (Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()B"));
				} finally {
				}
			}
		}

		static IntPtr id_createWireMessage_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='createWireMessage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("createWireMessage", "([B)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage CreateWireMessage (byte[] p0)
		{
			if (id_createWireMessage_arrayB == IntPtr.Zero)
				id_createWireMessage_arrayB = JNIEnv.GetStaticMethodID (class_ref, "createWireMessage", "([B)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWireMessage_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_createWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='createWireMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttPersistable']]"
		[Register ("createWireMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage CreateWireMessage (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable p0)
		{
			if (id_createWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ == IntPtr.Zero)
				id_createWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ = JNIEnv.GetStaticMethodID (class_ref, "createWireMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decodeUTF8_Ljava_io_DataInputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeUTF8_Ljava_io_DataInputStream_Handler ()
		{
			if (cb_decodeUTF8_Ljava_io_DataInputStream_ == null)
				cb_decodeUTF8_Ljava_io_DataInputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeUTF8_Ljava_io_DataInputStream_);
			return cb_decodeUTF8_Ljava_io_DataInputStream_;
		}

		static IntPtr n_DecodeUTF8_Ljava_io_DataInputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.DataInputStream p0 = global::Java.Lang.Object.GetObject<global::Java.IO.DataInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DecodeUTF8 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeUTF8_Ljava_io_DataInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='decodeUTF8' and count(parameter)=1 and parameter[1][@type='java.io.DataInputStream']]"
		[Register ("decodeUTF8", "(Ljava/io/DataInputStream;)Ljava/lang/String;", "GetDecodeUTF8_Ljava_io_DataInputStream_Handler")]
		protected virtual unsafe string DecodeUTF8 (global::Java.IO.DataInputStream p0)
		{
			if (id_decodeUTF8_Ljava_io_DataInputStream_ == IntPtr.Zero)
				id_decodeUTF8_Ljava_io_DataInputStream_ = JNIEnv.GetMethodID (class_ref, "decodeUTF8", "(Ljava/io/DataInputStream;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_decodeUTF8_Ljava_io_DataInputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeUTF8", "(Ljava/io/DataInputStream;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encodeMBI_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='encodeMBI' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("encodeMBI", "(J)[B", "")]
		protected static unsafe byte[] EncodeMBI (long p0)
		{
			if (id_encodeMBI_J == IntPtr.Zero)
				id_encodeMBI_J = JNIEnv.GetStaticMethodID (class_ref, "encodeMBI", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeMBI_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_encodeMessageId;
#pragma warning disable 0169
		static Delegate GetEncodeMessageIdHandler ()
		{
			if (cb_encodeMessageId == null)
				cb_encodeMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EncodeMessageId);
			return cb_encodeMessageId;
		}

		static IntPtr n_EncodeMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.EncodeMessageId ());
		}
#pragma warning restore 0169

		static IntPtr id_encodeMessageId;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='encodeMessageId' and count(parameter)=0]"
		[Register ("encodeMessageId", "()[B", "GetEncodeMessageIdHandler")]
		protected virtual unsafe byte[] EncodeMessageId ()
		{
			if (id_encodeMessageId == IntPtr.Zero)
				id_encodeMessageId = JNIEnv.GetMethodID (class_ref, "encodeMessageId", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_encodeMessageId), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeMessageId", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_Handler ()
		{
			if (cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ == null)
				cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_);
			return cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_;
		}

		static void n_EncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.DataOutputStream p0 = global::Java.Lang.Object.GetObject<global::Java.IO.DataOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EncodeUTF8 (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='encodeUTF8' and count(parameter)=2 and parameter[1][@type='java.io.DataOutputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeUTF8", "(Ljava/io/DataOutputStream;Ljava/lang/String;)V", "GetEncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_Handler")]
		protected virtual unsafe void EncodeUTF8 (global::Java.IO.DataOutputStream p0, string p1)
		{
			if (id_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodeUTF8", "(Ljava/io/DataOutputStream;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeUTF8", "(Ljava/io/DataOutputStream;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeader ());
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getHeader' and count(parameter)=0]"
		[Register ("getHeader", "()[B", "GetGetHeaderHandler")]
		public virtual unsafe byte[] GetHeader ()
		{
			if (id_getHeader == IntPtr.Zero)
				id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getHeader), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getPayload;
#pragma warning disable 0169
		static Delegate GetGetPayloadHandler ()
		{
			if (cb_getPayload == null)
				cb_getPayload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayload);
			return cb_getPayload;
		}

		static IntPtr n_GetPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		static IntPtr id_getPayload;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getPayload' and count(parameter)=0]"
		[Register ("getPayload", "()[B", "GetGetPayloadHandler")]
		public virtual unsafe byte[] GetPayload ()
		{
			if (id_getPayload == IntPtr.Zero)
				id_getPayload = JNIEnv.GetMethodID (class_ref, "getPayload", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPayload), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPayload", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getVariableHeader;
#pragma warning disable 0169
		static Delegate GetGetVariableHeaderHandler ()
		{
			if (cb_getVariableHeader == null)
				cb_getVariableHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVariableHeader);
			return cb_getVariableHeader;
		}

		static IntPtr n_GetVariableHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetVariableHeader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getVariableHeader' and count(parameter)=0]"
		[Register ("getVariableHeader", "()[B", "GetGetVariableHeaderHandler")]
		protected abstract byte[] GetVariableHeader ();

		static IntPtr id_readMBI_Ljava_io_DataInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='readMBI' and count(parameter)=1 and parameter[1][@type='java.io.DataInputStream']]"
		[Register ("readMBI", "(Ljava/io/DataInputStream;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger;", "")]
		protected static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger ReadMBI (global::Java.IO.DataInputStream p0)
		{
			if (id_readMBI_Ljava_io_DataInputStream_ == IntPtr.Zero)
				id_readMBI_Ljava_io_DataInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readMBI", "(Ljava/io/DataInputStream;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readMBI_Ljava_io_DataInputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDuplicate_Z;
#pragma warning disable 0169
		static Delegate GetSetDuplicate_ZHandler ()
		{
			if (cb_setDuplicate_Z == null)
				cb_setDuplicate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDuplicate_Z);
			return cb_setDuplicate_Z;
		}

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuplicate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDuplicate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
		public virtual unsafe void SetDuplicate (bool p0)
		{
			if (id_setDuplicate_Z == IntPtr.Zero)
				id_setDuplicate_Z = JNIEnv.GetMethodID (class_ref, "setDuplicate", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDuplicate_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuplicate", "(Z)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage", DoNotGenerateAcw=true)]
	internal partial class MqttWireMessageInvoker : MqttWireMessage {

		public MqttWireMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttWireMessageInvoker); }
		}

		static IntPtr id_getMessageInfo;
		protected override unsafe sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getMessageInfo' and count(parameter)=0]"
			[Register ("getMessageInfo", "()B", "GetGetMessageInfoHandler")]
			get {
				if (id_getMessageInfo == IntPtr.Zero)
					id_getMessageInfo = JNIEnv.GetMethodID (class_ref, "getMessageInfo", "()B");
				try {
					return JNIEnv.CallByteMethod  (Handle, id_getMessageInfo);
				} finally {
				}
			}
		}

		static IntPtr id_getVariableHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getVariableHeader' and count(parameter)=0]"
		[Register ("getVariableHeader", "()[B", "GetGetVariableHeaderHandler")]
		protected override unsafe byte[] GetVariableHeader ()
		{
			if (id_getVariableHeader == IntPtr.Zero)
				id_getVariableHeader = JNIEnv.GetMethodID (class_ref, "getVariableHeader", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getVariableHeader), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

}
