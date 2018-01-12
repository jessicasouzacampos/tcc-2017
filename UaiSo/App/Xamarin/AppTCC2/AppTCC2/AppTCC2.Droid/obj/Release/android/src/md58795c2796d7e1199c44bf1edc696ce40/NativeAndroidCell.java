package md58795c2796d7e1199c44bf1edc696ce40;


public class NativeAndroidCell
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AppTCC2.Droid.CustomRenderer.NativeAndroidCell, AppTCC2.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NativeAndroidCell.class, __md_methods);
	}


	public NativeAndroidCell (android.content.Context p0)
	{
		super (p0);
		if (getClass () == NativeAndroidCell.class)
			mono.android.TypeManager.Activate ("AppTCC2.Droid.CustomRenderer.NativeAndroidCell, AppTCC2.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public NativeAndroidCell (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == NativeAndroidCell.class)
			mono.android.TypeManager.Activate ("AppTCC2.Droid.CustomRenderer.NativeAndroidCell, AppTCC2.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public NativeAndroidCell (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == NativeAndroidCell.class)
			mono.android.TypeManager.Activate ("AppTCC2.Droid.CustomRenderer.NativeAndroidCell, AppTCC2.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
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
