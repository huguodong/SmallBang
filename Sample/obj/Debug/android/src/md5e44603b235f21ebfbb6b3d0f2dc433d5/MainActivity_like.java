package md5e44603b235f21ebfbb6b3d0f2dc433d5;


public class MainActivity_like
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
		mono.android.Runtime.register ("Sample.MainActivity+like, Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_like.class, __md_methods);
	}


	public MainActivity_like () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_like.class)
			mono.android.TypeManager.Activate ("Sample.MainActivity+like, Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_like (md5e44603b235f21ebfbb6b3d0f2dc433d5.MainActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_like.class)
			mono.android.TypeManager.Activate ("Sample.MainActivity+like, Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Sample.MainActivity, Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
