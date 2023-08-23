using Entitas;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Entitas.Lite
{
    public class EntitasLiteEntity : IUnifiedEntity
    {
        public Entity Entity { get; }

        public EntitasLiteEntity(Entity entity)
        {
            Entity = entity;
        }

        public void AddComponent<A>(in A component) where A : struct
        {
            var entitasComponent = Entity.Add<EntitasComponentWrapper<A>>();
            entitasComponent.Component = component;
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref Entity.Get<EntitasComponentWrapper<A>>().Component;
        }
    }
}