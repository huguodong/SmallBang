package mono.Com.XamarinSmallBang;


public class SmallBangListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		Com.XamarinSmallBang.SmallBangListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationEnd:()V:GetOnAnimationEndHandler:Com.XamarinSmallBang.ISmallBangListenerInvoker, SmallBang\n" +
			"n_onAnimationStart:()V:GetOnAnimationStartHandler:Com.XamarinSmallBang.ISmallBangListenerInvoker, SmallBang\n" +
			"";
		mono.android.Runtime.register ("Com.XamarinSmallBang.ISmallBangListenerImplementor, SmallBang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SmallBangListenerImplementor.class, __md_methods);
	}


	public SmallBangListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SmallBangListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.XamarinSmallBang.ISmallBangListenerImplementor, SmallBang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationEnd ()
	{
		n_onAnimationEnd ();
	}

	private native void n_onAnimationEnd ();


	public void onAnimationStart ()
	{
		n_onAnimationStart ();
	}

	private native void n_onAnimationStart ();

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
