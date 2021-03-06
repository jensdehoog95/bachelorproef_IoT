package md5ee6321c8da64fad3cebec2618c6db874;


public class Accelerometer
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		java.io.Serializable,
		android.hardware.SensorEventListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAccuracyChanged:(Landroid/hardware/Sensor;I)V:GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler:Android.Hardware.ISensorEventListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onSensorChanged:(Landroid/hardware/SensorEvent;)V:GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler:Android.Hardware.ISensorEventListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Gigabyke.Accelerometer, Gigabyke, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Accelerometer.class, __md_methods);
	}


	public Accelerometer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Accelerometer.class)
			mono.android.TypeManager.Activate ("Gigabyke.Accelerometer, Gigabyke, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public Accelerometer (android.hardware.SensorManager p0, android.widget.TextView p1, android.widget.TextView p2, android.widget.TextView p3, boolean p4, boolean p5) throws java.lang.Throwable
	{
		super ();
		if (getClass () == Accelerometer.class)
			mono.android.TypeManager.Activate ("Gigabyke.Accelerometer, Gigabyke, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Hardware.SensorManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.TextView, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.TextView, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.TextView, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3, p4, p5 });
	}

	public Accelerometer (android.hardware.SensorManager p0, boolean p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == Accelerometer.class)
			mono.android.TypeManager.Activate ("Gigabyke.Accelerometer, Gigabyke, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Hardware.SensorManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void onAccuracyChanged (android.hardware.Sensor p0, int p1)
	{
		n_onAccuracyChanged (p0, p1);
	}

	private native void n_onAccuracyChanged (android.hardware.Sensor p0, int p1);


	public void onSensorChanged (android.hardware.SensorEvent p0)
	{
		n_onSensorChanged (p0);
	}

	private native void n_onSensorChanged (android.hardware.SensorEvent p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
