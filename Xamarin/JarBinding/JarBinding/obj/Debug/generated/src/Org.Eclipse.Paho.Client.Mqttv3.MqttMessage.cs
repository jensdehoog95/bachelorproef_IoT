using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttMessage", DoNotGenerateAcw=true)]
	public partial class MqttMessage : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/MqttMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttMessage); }
		}

		protected MqttMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/constructor[@name='MqttMessage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe MqttMessage (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MqttMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/constructor[@name='MqttMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MqttMessage)) {
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

		static Delegate cb_isDuplicate;
#pragma warning disable 0169
		static Delegate GetIsDuplicateHandler ()
		{
			if (cb_isDuplicate == null)
				cb_isDuplicate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDuplicate);
			return cb_isDuplicate;
		}

		static bool n_IsDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDuplicate;
		}
#pragma warning restore 0169

		static IntPtr id_isDuplicate;
		public virtual unsafe bool IsDuplicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='isDuplicate' and count(parameter)=0]"
			[Register ("isDuplicate", "()Z", "GetIsDuplicateHandler")]
			get {
				if (id_isDuplicate == IntPtr.Zero)
					id_isDuplicate = JNIEnv.GetMethodID (class_ref, "isDuplicate", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDuplicate);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDuplicate", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getQos;
#pragma warning disable 0169
		static Delegate GetGetQosHandler ()
		{
			if (cb_getQos == null)
				cb_getQos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQos);
			return cb_getQos;
		}

		static int n_GetQos (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qos;
		}
#pragma warning restore 0169

		static Delegate cb_setQos_I;
#pragma warning disable 0169
		static Delegate GetSetQos_IHandler ()
		{
			if (cb_setQos_I == null)
				cb_setQos_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQos_I);
			return cb_setQos_I;
		}

		static void n_SetQos_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Qos = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getQos;
		static IntPtr id_setQos_I;
		public virtual unsafe int Qos {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getQos' and count(parameter)=0]"
			[Register ("getQos", "()I", "GetGetQosHandler")]
			get {
				if (id_getQos == IntPtr.Zero)
					id_getQos = JNIEnv.GetMethodID (class_ref, "getQos", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getQos);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQos", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setQos' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setQos", "(I)V", "GetSetQos_IHandler")]
			set {
				if (id_setQos_I == IntPtr.Zero)
					id_setQos_I = JNIEnv.GetMethodID (class_ref, "setQos", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setQos_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQos", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRetained;
#pragma warning disable 0169
		static Delegate GetIsRetainedHandler ()
		{
			if (cb_isRetained == null)
				cb_isRetained = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRetained);
			return cb_isRetained;
		}

		static bool n_IsRetained (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Retained;
		}
#pragma warning restore 0169

		static Delegate cb_setRetained_Z;
#pragma warning disable 0169
		static Delegate GetSetRetained_ZHandler ()
		{
			if (cb_setRetained_Z == null)
				cb_setRetained_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRetained_Z);
			return cb_setRetained_Z;
		}

		static void n_SetRetained_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retained = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isRetained;
		static IntPtr id_setRetained_Z;
		public virtual unsafe bool Retained {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='isRetained' and count(parameter)=0]"
			[Register ("isRetained", "()Z", "GetIsRetainedHandler")]
			get {
				if (id_isRetained == IntPtr.Zero)
					id_isRetained = JNIEnv.GetMethodID (class_ref, "isRetained", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRetained);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRetained", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setRetained' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRetained", "(Z)V", "GetSetRetained_ZHandler")]
			set {
				if (id_setRetained_Z == IntPtr.Zero)
					id_setRetained_Z = JNIEnv.GetMethodID (class_ref, "setRetained", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRetained_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetained", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkMutable;
#pragma warning disable 0169
		static Delegate GetCheckMutableHandler ()
		{
			if (cb_checkMutable == null)
				cb_checkMutable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckMutable);
			return cb_checkMutable;
		}

		static void n_CheckMutable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckMutable ();
		}
#pragma warning restore 0169

		static IntPtr id_checkMutable;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='checkMutable' and count(parameter)=0]"
		[Register ("checkMutable", "()V", "GetCheckMutableHandler")]
		protected virtual unsafe void CheckMutable ()
		{
			if (id_checkMutable == IntPtr.Zero)
				id_checkMutable = JNIEnv.GetMethodID (class_ref, "checkMutable", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_checkMutable);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkMutable", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearPayload;
#pragma warning disable 0169
		static Delegate GetClearPayloadHandler ()
		{
			if (cb_clearPayload == null)
				cb_clearPayload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPayload);
			return cb_clearPayload;
		}

		static void n_ClearPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPayload ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPayload;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='clearPayload' and count(parameter)=0]"
		[Register ("clearPayload", "()V", "GetClearPayloadHandler")]
		public virtual unsafe void ClearPayload ()
		{
			if (id_clearPayload == IntPtr.Zero)
				id_clearPayload = JNIEnv.GetMethodID (class_ref, "clearPayload", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearPayload);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPayload", "()V"));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		static IntPtr id_getPayload;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getPayload' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuplicate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDuplicate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
		protected virtual unsafe void SetDuplicate (bool p0)
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

		static Delegate cb_setMutable_Z;
#pragma warning disable 0169
		static Delegate GetSetMutable_ZHandler ()
		{
			if (cb_setMutable_Z == null)
				cb_setMutable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMutable_Z);
			return cb_setMutable_Z;
		}

		static void n_SetMutable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMutable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMutable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setMutable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMutable", "(Z)V", "GetSetMutable_ZHandler")]
		protected virtual unsafe void SetMutable (bool p0)
		{
			if (id_setMutable_Z == IntPtr.Zero)
				id_setMutable_Z = JNIEnv.GetMethodID (class_ref, "setMutable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMutable_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMutable", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPayload_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPayload_arrayBHandler ()
		{
			if (cb_setPayload_arrayB == null)
				cb_setPayload_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_arrayB);
			return cb_setPayload_arrayB;
		}

		static void n_SetPayload_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPayload (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPayload_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPayload", "([B)V", "GetSetPayload_arrayBHandler")]
		public virtual unsafe void SetPayload (byte[] p0)
		{
			if (id_setPayload_arrayB == IntPtr.Zero)
				id_setPayload_arrayB = JNIEnv.GetMethodID (class_ref, "setPayload", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPayload_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPayload", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_validateQos_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='validateQos' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("validateQos", "(I)V", "")]
		public static unsafe void ValidateQos (int p0)
		{
			if (id_validateQos_I == IntPtr.Zero)
				id_validateQos_I = JNIEnv.GetStaticMethodID (class_ref, "validateQos", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validateQos_I, __args);
			} finally {
			}
		}

	}
}
