using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ResourceBundleCatalog']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ResourceBundleCatalog", DoNotGenerateAcw=true)]
	public partial class ResourceBundleCatalog : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MessageCatalog {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/ResourceBundleCatalog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceBundleCatalog); }
		}

		protected ResourceBundleCatalog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ResourceBundleCatalog']/constructor[@name='ResourceBundleCatalog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceBundleCatalog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResourceBundleCatalog)) {
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

		static Delegate cb_getLocalizedMessage_I;
#pragma warning disable 0169
		static Delegate GetGetLocalizedMessage_IHandler ()
		{
			if (cb_getLocalizedMessage_I == null)
				cb_getLocalizedMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetLocalizedMessage_I);
			return cb_getLocalizedMessage_I;
		}

		static IntPtr n_GetLocalizedMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ResourceBundleCatalog __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ResourceBundleCatalog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetLocalizedMessage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getLocalizedMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ResourceBundleCatalog']/method[@name='getLocalizedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLocalizedMessage", "(I)Ljava/lang/String;", "GetGetLocalizedMessage_IHandler")]
		protected override unsafe string GetLocalizedMessage (int p0)
		{
			if (id_getLocalizedMessage_I == IntPtr.Zero)
				id_getLocalizedMessage_I = JNIEnv.GetMethodID (class_ref, "getLocalizedMessage", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLocalizedMessage_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalizedMessage", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
