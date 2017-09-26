using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Lumix
{
	public class MeshRigidActor : NativeComponent
	{
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static string getShapeSource(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setShapeSource(IntPtr scene, int cmp, string value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int getDynamicType(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setDynamicType(IntPtr scene, int cmp, int value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int getActorLayer(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setActorLayer(IntPtr scene, int cmp, int value);


		public static string GetCmpType{ get { return "mesh_rigid_actor"; } }


		/// <summary>
		/// Gets or sets the Source
		/// </summary>
		public string Source
		{
			get { return getShapeSource(scene_, componentId_); }
			set { setShapeSource(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the Dynamic
		/// </summary>
		public int Dynamic
		{
			get { return getDynamicType(scene_, componentId_); }
			set { setDynamicType(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the Layer
		/// </summary>
		public int Layer
		{
			get { return getActorLayer(scene_, componentId_); }
			set { setActorLayer(scene_, componentId_, value); }
		}

	}//end class

}//end namespace
