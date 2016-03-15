using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Sample.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='SubPanel']"
	[global::Android.Runtime.Register ("org/eclipse/paho/sample/utility/SubPanel", DoNotGenerateAcw=true)]
	public partial class SubPanel : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/sample/utility/SubPanel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubPanel); }
		}

		protected SubPanel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Eclipse.Paho.Sample.Utility.SubPanel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.SubPanel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableButtons (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableButtons_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='SubPanel']/method[@name='enableButtons' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Org.Eclipse.Paho.Sample.Utility.SubPanel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.SubPanel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='SubPanel']/method[@name='init' and count(parameter)=0]"
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

		static Delegate cb_updateReceivedData_Ljava_lang_String_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetUpdateReceivedData_Ljava_lang_String_arrayBIZHandler ()
		{
			if (cb_updateReceivedData_Ljava_lang_String_arrayBIZ == null)
				cb_updateReceivedData_Ljava_lang_String_arrayBIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_UpdateReceivedData_Ljava_lang_String_arrayBIZ);
			return cb_updateReceivedData_Ljava_lang_String_arrayBIZ;
		}

		static void n_UpdateReceivedData_Ljava_lang_String_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Org.Eclipse.Paho.Sample.Utility.SubPanel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.SubPanel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.UpdateReceivedData (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateReceivedData_Ljava_lang_String_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='SubPanel']/method[@name='updateReceivedData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("updateReceivedData", "(Ljava/lang/String;[BIZ)V", "GetUpdateReceivedData_Ljava_lang_String_arrayBIZHandler")]
		public virtual unsafe void UpdateReceivedData (string p0, byte[] p1, int p2, bool p3)
		{
			if (id_updateReceivedData_Ljava_lang_String_arrayBIZ == IntPtr.Zero)
				id_updateReceivedData_Ljava_lang_String_arrayBIZ = JNIEnv.GetMethodID (class_ref, "updateReceivedData", "(Ljava/lang/String;[BIZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateReceivedData_Ljava_lang_String_arrayBIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReceivedData", "(Ljava/lang/String;[BIZ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Org.Eclipse.Paho.Sample.Utility.SubPanel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Sample.Utility.SubPanel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateTopicList (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateTopicList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.sample.utility']/class[@name='SubPanel']/method[@name='updateTopicList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
