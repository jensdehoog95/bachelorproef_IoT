using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Sample.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='PubPanel']"
	[global::Android.Runtime.Register ("org/eclipse/paho/sample/utility/PubPanel", DoNotGenerateAcw=true)]
	public partial class PubPanel : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/sample/utility/PubPanel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PubPanel); }
		}

		protected PubPanel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_enableButtons_Z;
#pragma warning disable 0169
		static Delegate GetEnableButtons_ZHandler ()
		{
			if (cb_enableButtons_Z == null)
				cb_enableButtons_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableButtons_Z);
			return cb_enableButtons_Z;
		}

		static void n_EnableButtons_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.PubPanel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.PubPanel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableButtons (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableButtons_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='PubPanel']/method[@name='enableButtons' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableButtons", "(Z)V", "GetEnableButtons_ZHandler")]
		public virtual unsafe void EnableButtons (bool p0)
		{
			if (id_enableButtons_Z == IntPtr.Zero)
				id_enableButtons_Z = JNIEnv.GetMethodID (class_ref, "enableButtons", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableButtons_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableButtons", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Sample.Utility.PubPanel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.PubPanel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='PubPanel']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateTopicList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateTopicList_Ljava_lang_String_Handler ()
		{
			if (cb_updateTopicList_Ljava_lang_String_ == null)
				cb_updateTopicList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateTopicList_Ljava_lang_String_);
			return cb_updateTopicList_Ljava_lang_String_;
		}

		static bool n_UpdateTopicList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Sample.Utility.PubPanel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.PubPanel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateTopicList (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateTopicList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='PubPanel']/method[@name='updateTopicList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateTopicList", "(Ljava/lang/String;)Z", "GetUpdateTopicList_Ljava_lang_String_Handler")]
		public virtual unsafe bool UpdateTopicList (string p0)
		{
			if (id_updateTopicList_Ljava_lang_String_ == IntPtr.Zero)
				id_updateTopicList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateTopicList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateTopicList_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTopicList", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
