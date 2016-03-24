package mono.org.eclipse.paho.client.mqttv3;


public class IMqttActionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.eclipse.paho.client.mqttv3.IMqttActionListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V:GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerInvoker, JarBinding\n" +
			"n_onSuccess:(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V:GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerInvoker, JarBinding\n" +
			"";
		mono.android.Runtime.register ("Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor, JarBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", IMqttActionListenerImplementor.class, __md_methods);
	}


	public IMqttActionListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == IMqttActionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor, JarBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFailure (org.eclipse.paho.client.mqttv3.IMqttToken p0, java.lang.Throwable p1)
	{
		n_onFailure (p0, p1);
	}

	private native void n_onFailure (org.eclipse.paho.client.mqttv3.IMqttToken p0, java.lang.Throwable p1);


	public void onSuccess (org.eclipse.paho.client.mqttv3.IMqttToken p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (org.eclipse.paho.client.mqttv3.IMqttToken p0);

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
