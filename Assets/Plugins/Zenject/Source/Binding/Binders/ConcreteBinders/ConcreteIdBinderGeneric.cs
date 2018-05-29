using System;
using UnityEngine;

namespace Zenject
{
    public class ConcreteIdBinderGeneric<TContract> : ConcreteBinderGeneric<TContract>
    {
        public ConcreteIdBinderGeneric(
            BindInfo bindInfo,
            BindFinalizerWrapper finalizerWrapper)
            : base(bindInfo, finalizerWrapper)
        {
        }

        public ConcreteBinderGeneric<TContract> WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }

        public object To<T>(Material material)
        {
            throw new NotImplementedException();
        }
    }
}

