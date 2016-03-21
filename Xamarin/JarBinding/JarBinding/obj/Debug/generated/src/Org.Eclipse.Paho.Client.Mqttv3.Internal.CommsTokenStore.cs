using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsTokenStore", DoNotGenerateAcw=true)]
	public partial class CommsTokenStore : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/CommsTokenStore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommsTokenStore); }
		}

		protected CommsTokenStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/constructor[@name='CommsTokenStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CommsTokenStore (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (CommsTokenStore)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getOutstandingTokens;
#pragma warning disable 0169
		static Delegate GetGetOutstandingTokensHandler ()
		{
			if (cb_getOutstandingTokens == null)
				cb_getOutstandingTokens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutstandingTokens);
			return cb_getOutstandingTokens;
		}

		static IntPtr n_GetOutstandingTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OutstandingTokens);
		}
#pragma warning restore 0169

		static IntPtr id_getOutstandingTokens;
		public virtual unsafe global::Java.Util.Vector OutstandingTokens {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getOutstandingTokens' and count(parameter)=0]"
			[Register ("getOutstandingTokens", "()Ljava/util/Vector;", "GetGetOutstandingTokensHandler")]
			get {
				if (id_getOutstandingTokens == IntPtr.Zero)
					id_getOutstandingTokens = JNIEnv.GetMethodID (class_ref, "getOutstandingTokens", "()Ljava/util/Vector;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod  (Handle, id_getOutstandingTokens), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutstandingTokens", "()Ljava/util/Vector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_count;
#pragma warning disable 0169
		static Delegate GetCountHandler ()
		{
			if (cb_count == null)
				cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count);
			return cb_count;
		}

		static int n_Count (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count ();
		}
#pragma warning restore 0169

		static IntPtr id_count;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()I", "GetCountHandler")]
		public virtual unsafe int Count ()
		{
			if (id_count == IntPtr.Zero)
				id_count = JNIEnv.GetMethodID (class_ref, "count", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_count);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "()I"));
			} finally {
			}
		}

		static Delegate cb_getOutstandingDelTokens;
#pragma warning disable 0169
		static Delegate GetGetOutstandingDelTokensHandler ()
		{
			if (cb_getOutstandingDelTokens == null)
				cb_getOutstandingDelTokens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutstandingDelTokens);
			return cb_getOutstandingDelTokens;
		}

		static IntPtr n_GetOutstandingDelTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOutstandingDelTokens ());
		}
#pragma warning restore 0169

		static IntPtr id_getOutstandingDelTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getOutstandingDelTokens' and count(parameter)=0]"
		[Register ("getOutstandingDelTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetGetOutstandingDelTokensHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[] GetOutstandingDelTokens ()
		{
			if (id_getOutstandingDelTokens == IntPtr.Zero)
				id_getOutstandingDelTokens = JNIEnv.GetMethodID (class_ref, "getOutstandingDelTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOutstandingDelTokens), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken));
				else
					return (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutstandingDelTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken));
			} finally {
			}
		}

		static Delegate cb_getToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Ljava_lang_String_Handler ()
		{
			if (cb_getToken_Ljava_lang_String_ == null)
				cb_getToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Ljava_lang_String_);
			return cb_getToken_Ljava_lang_String_;
		}

		static IntPtr n_GetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetGetToken_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken GetToken (string p0)
		{
			if (id_getToken_Ljava_lang_String_ == IntPtr.Zero)
				id_getToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallObjectMethod  (Handle, id_getToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetGetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static IntPtr n_GetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("getToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetGetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken GetToken (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0)
		{
			if (id_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == IntPtr.Zero)
				id_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNIEnv.GetMethodID (class_ref, "getToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallObjectMethod  (Handle, id_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public virtual unsafe void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_open);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()V"));
			} finally {
			}
		}

		static Delegate cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetQuiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_Quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Quiesce (p0);
		}
#pragma warning restore 0169

		static IntPtr id_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='quiesce' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("quiesce", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetQuiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		protected virtual unsafe void Quiesce (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0)
		{
			if (id_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "quiesce", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "quiesce", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveToken_Ljava_lang_String_Handler ()
		{
			if (cb_removeToken_Ljava_lang_String_ == null)
				cb_removeToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveToken_Ljava_lang_String_);
			return cb_removeToken_Ljava_lang_String_;
		}

		static IntPtr n_RemoveToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='removeToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetRemoveToken_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken RemoveToken (string p0)
		{
			if (id_removeToken_Ljava_lang_String_ == IntPtr.Zero)
				id_removeToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallObjectMethod  (Handle, id_removeToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetRemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static IntPtr n_RemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='removeToken' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("removeToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetRemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken RemoveToken (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0)
		{
			if (id_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == IntPtr.Zero)
				id_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNIEnv.GetMethodID (class_ref, "removeToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallObjectMethod  (Handle, id_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetRestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static IntPtr n_RestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RestoreToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='restoreToken' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("restoreToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetRestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken RestoreToken (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish p0)
		{
			if (id_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == IntPtr.Zero)
				id_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNIEnv.GetMethodID (class_ref, "restoreToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (JNIEnv.CallObjectMethod  (Handle, id_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ == null)
				cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_);
			return cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_;
		}

		static void n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='saveToken' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/String;)V", "GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_Handler")]
		protected virtual unsafe void SaveToken (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0, string p1)
		{
			if (id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ == IntPtr.Zero)
				id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='saveToken' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		protected virtual unsafe void SaveToken (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken p0, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p1)
		{
			if (id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == IntPtr.Zero)
				id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNIEnv.GetMethodID (class_ref, "saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V"), __args);
			} finally {
			}
		}

	}
}
