using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttToken", DoNotGenerateAcw=true)]
	public partial class MqttToken : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken {


		static IntPtr internalTok_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/field[@name='internalTok']"
		[Register ("internalTok")]
		public global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token InternalTok {
			get {
				if (internalTok_jfieldId == IntPtr.Zero)
					internalTok_jfieldId = JNIEnv.GetFieldID (class_ref, "internalTok", "Lorg/eclipse/paho/client/mqttv3/internal/Token;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, internalTok_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (internalTok_jfieldId == IntPtr.Zero)
					internalTok_jfieldId = JNIEnv.GetFieldID (class_ref, "internalTok", "Lorg/eclipse/paho/client/mqttv3/internal/Token;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, internalTok_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/MqttToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttToken); }
		}

		protected MqttToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/constructor[@name='MqttToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttToken ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MqttToken)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/constructor[@name='MqttToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MqttToken (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MqttToken)) {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActionCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActionCallback;
		static IntPtr id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener ActionCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getActionCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='setActionCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		static IntPtr id_getClient;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getClient' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		static IntPtr id_getException;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getException' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		static IntPtr id_isComplete;
		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='isComplete' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageId;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		public virtual unsafe int MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getMessageId' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getResponse' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionPresent;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionPresent;
		public virtual unsafe bool SessionPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getSessionPresent' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserContext = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserContext;
		static IntPtr id_setUserContext_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object UserContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getUserContext' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='setUserContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGrantedQos ());
		}
#pragma warning restore 0169

		static IntPtr id_getGrantedQos;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getGrantedQos' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTopics ());
		}
#pragma warning restore 0169

		static IntPtr id_getTopics;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getTopics' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion ();
		}
#pragma warning restore 0169

		static IntPtr id_waitForCompletion;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='waitForCompletion' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_waitForCompletion_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='waitForCompletion' and count(parameter)=1 and parameter[1][@type='long']]"
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
