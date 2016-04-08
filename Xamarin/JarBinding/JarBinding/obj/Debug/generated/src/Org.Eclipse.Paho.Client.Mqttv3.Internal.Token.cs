using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/Token", DoNotGenerateAcw=true)]
	public partial class Token : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/Token", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Token); }
		}

		protected Token (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/constructor[@name='Token' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Token (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Token)) {
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

		static Delegate cb_getActionCallback;
#pragma warning disable 0169
		static Delegate GetGetActionCallbackHandler ()
		{
			if (cb_getActionCallback == null)
				cb_getActionCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionCallback);
			return cb_getActionCallback;
		}

		static IntPtr n_GetActionCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static void n_SetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActionCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActionCallback;
		static IntPtr id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener ActionCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getActionCallback' and count(parameter)=0]"
			[Register ("getActionCallback", "()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;", "GetGetActionCallbackHandler")]
			get {
				if (id_getActionCallback == IntPtr.Zero)
					id_getActionCallback = JNIEnv.GetMethodID (class_ref, "getActionCallback", "()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (JNIEnv.CallObjectMethod  (Handle, id_getActionCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionCallback", "()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setActionCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
			[Register ("setActionCallback", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V", "GetSetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
			set {
				if (id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
					id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "setActionCallback", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionCallback", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		static IntPtr id_getClient;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;", "GetGetClientHandler")]
			get {
				if (id_getClient == IntPtr.Zero)
					id_getClient = JNIEnv.GetMethodID (class_ref, "getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (JNIEnv.CallObjectMethod  (Handle, id_getClient), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		static Delegate cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetSetException_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetException_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_SetException_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Exception = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getException;
		static IntPtr id_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Lorg/eclipse/paho/client/mqttv3/MqttException;", "GetGetExceptionHandler")]
			get {
				if (id_getException == IntPtr.Zero)
					id_getException = JNIEnv.GetMethodID (class_ref, "getException", "()Lorg/eclipse/paho/client/mqttv3/MqttException;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (JNIEnv.CallObjectMethod  (Handle, id_getException), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getException", "()Lorg/eclipse/paho/client/mqttv3/MqttException;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setException' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
			[Register ("setException", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetSetException_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
			set {
				if (id_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
					id_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "setException", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setException", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isComplete;
#pragma warning disable 0169
		static Delegate GetIsCompleteHandler ()
		{
			if (cb_isComplete == null)
				cb_isComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsComplete);
			return cb_isComplete;
		}

		static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		static IntPtr id_isComplete;
		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				if (id_isComplete == IntPtr.Zero)
					id_isComplete = JNIEnv.GetMethodID (class_ref, "isComplete", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isComplete);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isComplete", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isCompletePending;
#pragma warning disable 0169
		static Delegate GetIsCompletePendingHandler ()
		{
			if (cb_isCompletePending == null)
				cb_isCompletePending = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompletePending);
			return cb_isCompletePending;
		}

		static bool n_IsCompletePending (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompletePending;
		}
#pragma warning restore 0169

		static IntPtr id_isCompletePending;
		protected virtual unsafe bool IsCompletePending {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isCompletePending' and count(parameter)=0]"
			[Register ("isCompletePending", "()Z", "GetIsCompletePendingHandler")]
			get {
				if (id_isCompletePending == IntPtr.Zero)
					id_isCompletePending = JNIEnv.GetMethodID (class_ref, "isCompletePending", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCompletePending);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCompletePending", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInUse;
#pragma warning disable 0169
		static Delegate GetIsInUseHandler ()
		{
			if (cb_isInUse == null)
				cb_isInUse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInUse);
			return cb_isInUse;
		}

		static bool n_IsInUse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInUse;
		}
#pragma warning restore 0169

		static IntPtr id_isInUse;
		protected virtual unsafe bool IsInUse {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isInUse' and count(parameter)=0]"
			[Register ("isInUse", "()Z", "GetIsInUseHandler")]
			get {
				if (id_isInUse == IntPtr.Zero)
					id_isInUse = JNIEnv.GetMethodID (class_ref, "isInUse", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInUse);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInUse", "()Z"));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_String_Handler ()
		{
			if (cb_setKey_Ljava_lang_String_ == null)
				cb_setKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_String_);
			return cb_setKey_Ljava_lang_String_;
		}

		static void n_SetKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Key = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		static IntPtr id_setKey_Ljava_lang_String_;
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getKey' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKey", "(Ljava/lang/String;)V", "GetSetKey_Ljava_lang_String_Handler")]
			set {
				if (id_setKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static void n_SetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
			[Register ("setMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetSetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
			set {
				if (id_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
					id_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageID;
#pragma warning disable 0169
		static Delegate GetGetMessageIDHandler ()
		{
			if (cb_getMessageID == null)
				cb_getMessageID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageID);
			return cb_getMessageID;
		}

		static int n_GetMessageID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageID;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageID_I;
#pragma warning disable 0169
		static Delegate GetSetMessageID_IHandler ()
		{
			if (cb_setMessageID_I == null)
				cb_setMessageID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageID_I);
			return cb_setMessageID_I;
		}

		static void n_SetMessageID_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageID;
		static IntPtr id_setMessageID_I;
		public virtual unsafe int MessageID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getMessageID' and count(parameter)=0]"
			[Register ("getMessageID", "()I", "GetGetMessageIDHandler")]
			get {
				if (id_getMessageID == IntPtr.Zero)
					id_getMessageID = JNIEnv.GetMethodID (class_ref, "getMessageID", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMessageID);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageID", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setMessageID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessageID", "(I)V", "GetSetMessageID_IHandler")]
			set {
				if (id_setMessageID_I == IntPtr.Zero)
					id_setMessageID_I = JNIEnv.GetMethodID (class_ref, "setMessageID", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMessageID_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageID", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNotified;
#pragma warning disable 0169
		static Delegate GetIsNotifiedHandler ()
		{
			if (cb_isNotified == null)
				cb_isNotified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotified);
			return cb_isNotified;
		}

		static bool n_IsNotified (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Notified;
		}
#pragma warning restore 0169

		static Delegate cb_setNotified_Z;
#pragma warning disable 0169
		static Delegate GetSetNotified_ZHandler ()
		{
			if (cb_setNotified_Z == null)
				cb_setNotified_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNotified_Z);
			return cb_setNotified_Z;
		}

		static void n_SetNotified_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Notified = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isNotified;
		static IntPtr id_setNotified_Z;
		public virtual unsafe bool Notified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isNotified' and count(parameter)=0]"
			[Register ("isNotified", "()Z", "GetIsNotifiedHandler")]
			get {
				if (id_isNotified == IntPtr.Zero)
					id_isNotified = JNIEnv.GetMethodID (class_ref, "isNotified", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isNotified);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotified", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setNotified' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNotified", "(Z)V", "GetSetNotified_ZHandler")]
			set {
				if (id_setNotified_Z == IntPtr.Zero)
					id_setNotified_Z = JNIEnv.GetMethodID (class_ref, "setNotified", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNotified_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotified", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallObjectMethod  (Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSessionPresent;
#pragma warning disable 0169
		static Delegate GetGetSessionPresentHandler ()
		{
			if (cb_getSessionPresent == null)
				cb_getSessionPresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSessionPresent);
			return cb_getSessionPresent;
		}

		static bool n_GetSessionPresent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionPresent;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionPresent;
		public virtual unsafe bool SessionPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getSessionPresent' and count(parameter)=0]"
			[Register ("getSessionPresent", "()Z", "GetGetSessionPresentHandler")]
			get {
				if (id_getSessionPresent == IntPtr.Zero)
					id_getSessionPresent = JNIEnv.GetMethodID (class_ref, "getSessionPresent", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getSessionPresent);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionPresent", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getUserContext;
#pragma warning disable 0169
		static Delegate GetGetUserContextHandler ()
		{
			if (cb_getUserContext == null)
				cb_getUserContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserContext);
			return cb_getUserContext;
		}

		static IntPtr n_GetUserContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserContext);
		}
#pragma warning restore 0169

		static Delegate cb_setUserContext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetUserContext_Ljava_lang_Object_Handler ()
		{
			if (cb_setUserContext_Ljava_lang_Object_ == null)
				cb_setUserContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserContext_Ljava_lang_Object_);
			return cb_setUserContext_Ljava_lang_Object_;
		}

		static void n_SetUserContext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserContext = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserContext;
		static IntPtr id_setUserContext_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object UserContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getUserContext' and count(parameter)=0]"
			[Register ("getUserContext", "()Ljava/lang/Object;", "GetGetUserContextHandler")]
			get {
				if (id_getUserContext == IntPtr.Zero)
					id_getUserContext = JNIEnv.GetMethodID (class_ref, "getUserContext", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getUserContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserContext", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setUserContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setUserContext", "(Ljava/lang/Object;)V", "GetSetUserContext_Ljava_lang_Object_Handler")]
			set {
				if (id_setUserContext_Ljava_lang_Object_ == IntPtr.Zero)
					id_setUserContext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setUserContext", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUserContext_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserContext", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWireMessage;
#pragma warning disable 0169
		static Delegate GetGetWireMessageHandler ()
		{
			if (cb_getWireMessage == null)
				cb_getWireMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWireMessage);
			return cb_getWireMessage;
		}

		static IntPtr n_GetWireMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WireMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getWireMessage;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage WireMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getWireMessage' and count(parameter)=0]"
			[Register ("getWireMessage", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetGetWireMessageHandler")]
			get {
				if (id_getWireMessage == IntPtr.Zero)
					id_getWireMessage = JNIEnv.GetMethodID (class_ref, "getWireMessage", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallObjectMethod  (Handle, id_getWireMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWireMessage", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkResult;
#pragma warning disable 0169
		static Delegate GetCheckResultHandler ()
		{
			if (cb_checkResult == null)
				cb_checkResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckResult);
			return cb_checkResult;
		}

		static bool n_CheckResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckResult ();
		}
#pragma warning restore 0169

		static IntPtr id_checkResult;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='checkResult' and count(parameter)=0]"
		[Register ("checkResult", "()Z", "GetCheckResultHandler")]
		public virtual unsafe bool CheckResult ()
		{
			if (id_checkResult == IntPtr.Zero)
				id_checkResult = JNIEnv.GetMethodID (class_ref, "checkResult", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_checkResult);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkResult", "()Z"));
			} finally {
			}
		}

		static Delegate cb_getGrantedQos;
#pragma warning disable 0169
		static Delegate GetGetGrantedQosHandler ()
		{
			if (cb_getGrantedQos == null)
				cb_getGrantedQos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantedQos);
			return cb_getGrantedQos;
		}

		static IntPtr n_GetGrantedQos (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGrantedQos ());
		}
#pragma warning restore 0169

		static IntPtr id_getGrantedQos;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getGrantedQos' and count(parameter)=0]"
		[Register ("getGrantedQos", "()[I", "GetGetGrantedQosHandler")]
		public virtual unsafe int[] GetGrantedQos ()
		{
			if (id_getGrantedQos == IntPtr.Zero)
				id_getGrantedQos = JNIEnv.GetMethodID (class_ref, "getGrantedQos", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getGrantedQos), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGrantedQos", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getTopics;
#pragma warning disable 0169
		static Delegate GetGetTopicsHandler ()
		{
			if (cb_getTopics == null)
				cb_getTopics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopics);
			return cb_getTopics;
		}

		static IntPtr n_GetTopics (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTopics ());
		}
#pragma warning restore 0169

		static IntPtr id_getTopics;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getTopics' and count(parameter)=0]"
		[Register ("getTopics", "()[Ljava/lang/String;", "GetGetTopicsHandler")]
		public virtual unsafe string[] GetTopics ()
		{
			if (id_getTopics == IntPtr.Zero)
				id_getTopics = JNIEnv.GetMethodID (class_ref, "getTopics", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTopics), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopics", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetMarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_MarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MarkComplete (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='markComplete' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("markComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetMarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		protected virtual unsafe void MarkComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException p1)
		{
			if (id_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "markComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyComplete;
#pragma warning disable 0169
		static Delegate GetNotifyCompleteHandler ()
		{
			if (cb_notifyComplete == null)
				cb_notifyComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyComplete);
			return cb_notifyComplete;
		}

		static void n_NotifyComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='notifyComplete' and count(parameter)=0]"
		[Register ("notifyComplete", "()V", "GetNotifyCompleteHandler")]
		protected virtual unsafe void NotifyComplete ()
		{
			if (id_notifyComplete == IntPtr.Zero)
				id_notifyComplete = JNIEnv.GetMethodID (class_ref, "notifyComplete", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyComplete);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyComplete", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifySent;
#pragma warning disable 0169
		static Delegate GetNotifySentHandler ()
		{
			if (cb_notifySent == null)
				cb_notifySent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifySent);
			return cb_notifySent;
		}

		static void n_NotifySent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifySent ();
		}
#pragma warning restore 0169

		static IntPtr id_notifySent;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='notifySent' and count(parameter)=0]"
		[Register ("notifySent", "()V", "GetNotifySentHandler")]
		protected virtual unsafe void NotifySent ()
		{
			if (id_notifySent == IntPtr.Zero)
				id_notifySent = JNIEnv.GetMethodID (class_ref, "notifySent", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifySent);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifySent", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_;
#pragma warning disable 0169
		static Delegate GetSetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Handler ()
		{
			if (cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ == null)
				cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_);
			return cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_;
		}

		static void n_SetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setClient' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttAsyncClient']]"
		[Register ("setClient", "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;)V", "GetSetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Handler")]
		protected virtual unsafe void SetClient (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient p0)
		{
			if (id_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ == IntPtr.Zero)
				id_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ = JNIEnv.GetMethodID (class_ref, "setClient", "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClient", "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTopics_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopics_arrayLjava_lang_String_Handler ()
		{
			if (cb_setTopics_arrayLjava_lang_String_ == null)
				cb_setTopics_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopics_arrayLjava_lang_String_);
			return cb_setTopics_arrayLjava_lang_String_;
		}

		static void n_SetTopics_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetTopics (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTopics_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setTopics' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setTopics", "([Ljava/lang/String;)V", "GetSetTopics_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetTopics (string[] p0)
		{
			if (id_setTopics_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setTopics_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTopics", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTopics_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopics", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_waitForCompletion;
#pragma warning disable 0169
		static Delegate GetWaitForCompletionHandler ()
		{
			if (cb_waitForCompletion == null)
				cb_waitForCompletion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaitForCompletion);
			return cb_waitForCompletion;
		}

		static void n_WaitForCompletion (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion ();
		}
#pragma warning restore 0169

		static IntPtr id_waitForCompletion;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForCompletion' and count(parameter)=0]"
		[Register ("waitForCompletion", "()V", "GetWaitForCompletionHandler")]
		public virtual unsafe void WaitForCompletion ()
		{
			if (id_waitForCompletion == IntPtr.Zero)
				id_waitForCompletion = JNIEnv.GetMethodID (class_ref, "waitForCompletion", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waitForCompletion);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForCompletion", "()V"));
			} finally {
			}
		}

		static Delegate cb_waitForCompletion_J;
#pragma warning disable 0169
		static Delegate GetWaitForCompletion_JHandler ()
		{
			if (cb_waitForCompletion_J == null)
				cb_waitForCompletion_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WaitForCompletion_J);
			return cb_waitForCompletion_J;
		}

		static void n_WaitForCompletion_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_waitForCompletion_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForCompletion' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("waitForCompletion", "(J)V", "GetWaitForCompletion_JHandler")]
		public virtual unsafe void WaitForCompletion (long p0)
		{
			if (id_waitForCompletion_J == IntPtr.Zero)
				id_waitForCompletion_J = JNIEnv.GetMethodID (class_ref, "waitForCompletion", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waitForCompletion_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForCompletion", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waitForResponse;
#pragma warning disable 0169
		static Delegate GetWaitForResponseHandler ()
		{
			if (cb_waitForResponse == null)
				cb_waitForResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_WaitForResponse);
			return cb_waitForResponse;
		}

		static IntPtr n_WaitForResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WaitForResponse ());
		}
#pragma warning restore 0169

		static IntPtr id_waitForResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForResponse' and count(parameter)=0]"
		[Register ("waitForResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetWaitForResponseHandler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage WaitForResponse ()
		{
			if (id_waitForResponse == IntPtr.Zero)
				id_waitForResponse = JNIEnv.GetMethodID (class_ref, "waitForResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallObjectMethod  (Handle, id_waitForResponse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_waitForResponse_J;
#pragma warning disable 0169
		static Delegate GetWaitForResponse_JHandler ()
		{
			if (cb_waitForResponse_J == null)
				cb_waitForResponse_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WaitForResponse_J);
			return cb_waitForResponse_J;
		}

		static IntPtr n_WaitForResponse_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WaitForResponse (p0));
		}
#pragma warning restore 0169

		static IntPtr id_waitForResponse_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForResponse' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("waitForResponse", "(J)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetWaitForResponse_JHandler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage WaitForResponse (long p0)
		{
			if (id_waitForResponse_J == IntPtr.Zero)
				id_waitForResponse_J = JNIEnv.GetMethodID (class_ref, "waitForResponse", "(J)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallObjectMethod  (Handle, id_waitForResponse_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForResponse", "(J)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_waitUntilSent;
#pragma warning disable 0169
		static Delegate GetWaitUntilSentHandler ()
		{
			if (cb_waitUntilSent == null)
				cb_waitUntilSent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaitUntilSent);
			return cb_waitUntilSent;
		}

		static void n_WaitUntilSent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitUntilSent ();
		}
#pragma warning restore 0169

		static IntPtr id_waitUntilSent;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitUntilSent' and count(parameter)=0]"
		[Register ("waitUntilSent", "()V", "GetWaitUntilSentHandler")]
		public virtual unsafe void WaitUntilSent ()
		{
			if (id_waitUntilSent == IntPtr.Zero)
				id_waitUntilSent = JNIEnv.GetMethodID (class_ref, "waitUntilSent", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waitUntilSent);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitUntilSent", "()V"));
			} finally {
			}
		}

#region "Event implementation for Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener"
		public event EventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.FailureEventArgs> Failure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						__CreateIMqttActionListenerImplementor,
						__v => ActionCallback = __v,
						__h => __h.OnFailureHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor.__IsEmpty,
						__v => ActionCallback = null,
						__h => __h.OnFailureHandler -= value);
			}
		}

		public event EventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.SuccessEventArgs> Success {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						__CreateIMqttActionListenerImplementor,
						__v => ActionCallback = __v,
						__h => __h.OnSuccessHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor.__IsEmpty,
						__v => ActionCallback = null,
						__h => __h.OnSuccessHandler -= value);
			}
		}

		WeakReference weak_implementor___SetActionCallback;

		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor __CreateIMqttActionListenerImplementor ()
		{
			return new global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor (this);
		}
#endregion
	}
}
