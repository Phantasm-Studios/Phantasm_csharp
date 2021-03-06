using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Lumix
{
	[NativeComponent( Type = "particle_emitter")]
	public class ParticleEmitter :Component
	{
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static Vec2 getParticleEmitterInitialLife(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setParticleEmitterInitialLife(IntPtr scene, int cmp, Vec2 value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static Vec2 getParticleEmitterInitialSize(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setParticleEmitterInitialSize(IntPtr scene, int cmp, Vec2 value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static Vec2 getParticleEmitterSpawnPeriod(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setParticleEmitterSpawnPeriod(IntPtr scene, int cmp, Vec2 value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static Int2 getParticleEmitterSpawnCount(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setParticleEmitterSpawnCount(IntPtr scene, int cmp, Int2 value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static bool getParticleEmitterAutoemit(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setParticleEmitterAutoemit(IntPtr scene, int cmp, bool value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static bool getParticleEmitterLocalSpace(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setParticleEmitterLocalSpace(IntPtr scene, int cmp, bool value);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static string getParticleEmitterMaterialPath(IntPtr scene, int cmp);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void setParticleEmitterMaterialPath(IntPtr scene, int cmp, string value);


		public static string GetCmpType{ get { return "particle_emitter"; } }


		/// <summary>
		/// Gets or sets the Life
		/// </summary>
		public Vec2 Life
		{
			get { return getParticleEmitterInitialLife(scene_, componentId_); }
			set { setParticleEmitterInitialLife(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the InitialSize
		/// </summary>
		public Vec2 InitialSize
		{
			get { return getParticleEmitterInitialSize(scene_, componentId_); }
			set { setParticleEmitterInitialSize(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the SpawnPeriod
		/// </summary>
		public Vec2 SpawnPeriod
		{
			get { return getParticleEmitterSpawnPeriod(scene_, componentId_); }
			set { setParticleEmitterSpawnPeriod(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the SpawnCount
		/// </summary>
		public Int2 SpawnCount
		{
			get { return getParticleEmitterSpawnCount(scene_, componentId_); }
			set { setParticleEmitterSpawnCount(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the Autoemit
		/// </summary>
		public bool IsAutoemit
		{
			get { return getParticleEmitterAutoemit(scene_, componentId_); }
			set { setParticleEmitterAutoemit(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the LocalSpace
		/// </summary>
		public bool IsLocalSpace
		{
			get { return getParticleEmitterLocalSpace(scene_, componentId_); }
			set { setParticleEmitterLocalSpace(scene_, componentId_, value); }
		}

		/// <summary>
		/// Gets or sets the Material
		/// </summary>
		public string Material
		{
			get { return getParticleEmitterMaterialPath(scene_, componentId_); }
			set { setParticleEmitterMaterialPath(scene_, componentId_, value); }
		}

		public ParticleEmitter(Entity _entity, int _cmpId)
			: base(_entity, _cmpId, getScene(_entity.instance_, GetCmpType)) { }

	}//end class

}//end namespace
