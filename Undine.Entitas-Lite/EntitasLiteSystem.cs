using Entitas;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Entitas.Lite
{
    internal class EntitasLiteSystem<A> : Core.ISystem, IExecuteSystem
         where A : struct
    {
        public UnifiedSystem<A> System { get; set; }

        public void Execute()
        {
            var entities = Context<Default>.AllOf<EntitasComponentWrapper<A>>().GetEntities();
            foreach (var e in entities)
            {
                System.ProcessSingleEntity(e.GetHashCode(), ref e.Get<EntitasComponentWrapper<A>>().Component);
            }
        }

        public void ProcessAll()
        {
            Execute();
        }
    }

    internal class EntitasLiteSystem<A, B> : Core.ISystem, IExecuteSystem
         where A : struct
         where B : struct
    {
        public UnifiedSystem<A, B> System { get; set; }

        public void Execute()
        {
            var entities = Context<Default>.AllOf<
                EntitasComponentWrapper<A>,
                EntitasComponentWrapper<B>>().GetEntities();
            foreach (var e in entities)
            {
                var ac = e.Get<EntitasComponentWrapper<A>>();
                var bc = e.Get<EntitasComponentWrapper<B>>();

                System.ProcessSingleEntity(
                    e.GetHashCode(),
                    ref ac.Component,
                    ref bc.Component);
            }
        }

        public void ProcessAll()
        {
            Execute();
        }
    }

    internal class EntitasLiteSystem<A, B, C> : Core.ISystem, IExecuteSystem
         where A : struct
         where B : struct
         where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; set; }

        public void Execute()
        {
            var entities = Context<Default>.AllOf<
                EntitasComponentWrapper<A>,
                EntitasComponentWrapper<B>,
                EntitasComponentWrapper<C>>().GetEntities();
            foreach (var e in entities)
            {
                var ac = e.Get<EntitasComponentWrapper<A>>();
                var bc = e.Get<EntitasComponentWrapper<B>>();
                var cc = e.Get<EntitasComponentWrapper<C>>();

                System.ProcessSingleEntity(
                    e.GetHashCode(),
                    ref ac.Component,
                    ref bc.Component,
                    ref cc.Component);
            }
        }

        public void ProcessAll()
        {
            Execute();
        }
    }

    internal class EntitasLiteSystem<A, B, C, D> : Core.ISystem, IExecuteSystem
         where A : struct
         where B : struct
         where C : struct
         where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; set; }

        public void Execute()
        {
            var entities = Context<Default>.AllOf<
                EntitasComponentWrapper<A>,
                EntitasComponentWrapper<B>,
                EntitasComponentWrapper<C>,
                EntitasComponentWrapper<D>>().GetEntities();
            foreach (var e in entities)
            {
                var ac = e.Get<EntitasComponentWrapper<A>>();
                var bc = e.Get<EntitasComponentWrapper<B>>();
                var cc = e.Get<EntitasComponentWrapper<C>>();
                var dc = e.Get<EntitasComponentWrapper<D>>();

                System.ProcessSingleEntity(
                    e.GetHashCode(),
                    ref ac.Component,
                    ref bc.Component,
                    ref cc.Component,
                    ref dc.Component);
            }
        }

        public void ProcessAll()
        {
            Execute();
        }
    }
}