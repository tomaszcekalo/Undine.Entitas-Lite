using Entitas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Entitas.Lite
{
    internal class EntitasComponentWrapper<A> : IComponent
    {
        public A Component;
    }
}