using Entitas;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Entitas.Lite
{
    public class EntitasLiteContainer : EcsContainer
    {
        public Context Context { get; }
        private Systems _feature;

        public EntitasLiteContainer()
        {
            Context = Contexts.Default;
        }

        public override void Init()
        {
            _feature = new Feature(null);
            _feature.Initialize();
            base.Init();
        }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new EntitasLiteEntity(Context.CreateEntity())
            {
            };
        }

        public override Core.ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            throw new NotImplementedException();
        }

        public override Core.ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override Core.ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override Core.ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            _feature.Execute();
            _feature.Cleanup();
        }
    }
}