using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Lumix
{
	[NativeComponent( Type = "rigid_actor")]
	public class RigidActor :RigidActor
	{
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int getDynamicType(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setDynamicType(IntPtr scene, int cmp, int value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static bool getIsTrigger(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setIsTrigger(IntPtr scene, int cmp, bool value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int getActorLayer(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setActorLayer(IntPtr scene, int cmp, int value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void applyForceToActor(IntPtr instance, int cmp, Vec3 force);


		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static float getActorSpeed(IntPtr instance, int cmp);


		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void putToSleep(IntPtr instance, int cmp);



		public static string GetCmpType{ get { return "rigid_actor"; } }


		public PhysicsScene Scene
		{
			 get { return new PhysicsScene(scene_); }
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
		/// Gets or sets the Trigger
		/// </summary>
		public bool IsTrigger
		{
			get { return getIsTrigger(scene_, componentId_); }
			set { setIsTrigger(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the Layer
		/// </summary>
		public int Layer
		{
			get { return getActorLayer(scene_, componentId_); }
			set { setActorLayer(scene_, componentId_, value); }
		}

		public RigidActor(Entity _entity, int _cmpId)
			: base(_entity, _cmpId, getScene(_entity.instance_, GetCmpType)) { }

		public void ApplyForceToActor(Vec3 force)
		{
			applyForceToActor(scene_, componentId_, force);
		}

		public float ActorSpeed
		{
			get
			{
				return getActorSpeed(scene_, componentId_);
			}
		}

		public void PutToSleep()
		{
			putToSleep(scene_, componentId_);
		}

	}//end class

}//end namespace
