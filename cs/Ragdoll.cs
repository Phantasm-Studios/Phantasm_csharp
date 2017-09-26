using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Lumix
{
	public class Ragdoll : NativeComponent
	{
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int getRagdollLayer(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setRagdollLayer(IntPtr scene, int cmp, int value);


		public static string GetCmpType{ get { return "ragdoll"; } }


		/// <summary>
		/// Gets or sets the Layer
		/// </summary>
		public int Layer
		{
			get { return getRagdollLayer(scene_, componentId_); }
			set { setRagdollLayer(scene_, componentId_, value); }
		}

	}//end class

}//end namespace
