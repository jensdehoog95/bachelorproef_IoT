using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/util/Strings", DoNotGenerateAcw=true)]
	public sealed partial class Strings : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/util/Strings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Strings); }
		}

		internal Strings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_containsAny_Ljava_lang_CharSequence_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char[]']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;[C)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence p0, char[] p1)
		{
			if (id_containsAny_Ljava_lang_CharSequence_arrayC == IntPtr.Zero)
				id_containsAny_Ljava_lang_CharSequence_arrayC = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/CharSequence;[C)Z");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_CharSequence_arrayC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		public static bool ContainsAny (string p0, char[] p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			bool __result = ContainsAny (jls_p0, p1);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

		static IntPtr id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence p0, global::Java.Lang.ICharSequence p1)
		{
			if (id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public static bool ContainsAny (string p0, string p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			bool __result = ContainsAny (jls_p0, jls_p1);
			if (jls_p0 != null) jls_p0.Dispose ();
			if (jls_p1 != null) jls_p1.Dispose ();
			return __result;
		}

		static IntPtr id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='countMatches' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("countMatches", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int CountMatches (global::Java.Lang.ICharSequence p0, global::Java.Lang.ICharSequence p1)
		{
			if (id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "countMatches", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public static int CountMatches (string p0, string p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			int __result = CountMatches (jls_p0, jls_p1);
			if (jls_p0 != null) jls_p0.Dispose ();
			if (jls_p1 != null) jls_p1.Dispose ();
			return __result;
		}

		static IntPtr id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='equalsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence[]']]"
		[Register ("equalsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EqualsAny (global::Java.Lang.ICharSequence p0, global::Java.Lang.ICharSequence[] p1)
		{
			if (id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "equalsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		public static bool EqualsAny (string p0, string[] p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			global::Java.Lang.ICharSequence[] jlca_p1 = CharSequence.ArrayFromStringArray(p1);
			bool __result = EqualsAny (jls_p0, jlca_p1);
			if (jls_p0 != null) jls_p0.Dispose ();
			if (jlca_p1 != null) foreach (global::Java.Lang.String s in jlca_p1) if (s != null) s.Dispose ();
			return __result;
		}

		static IntPtr id_isEmpty_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsEmpty (global::Java.Lang.ICharSequence p0)
		{
			if (id_isEmpty_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static bool IsEmpty (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			bool __result = IsEmpty (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

	}
}
