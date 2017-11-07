using System;
using System.Collections.Generic;
using FreshMvvm.IoC.TinyIoC;

namespace FreshMvvm.IoC
{
    public interface IFreshIoC
    {
        object Resolve(Type resolveType);
        TResolveType Resolve<TResolveType>() where TResolveType : class;
        TResolveType Resolve<TResolveType>(string name) where TResolveType : class;
        IRegisterOptions Register<TRegisterType>(TRegisterType instance) where TRegisterType : class;
        IRegisterOptions Register<TRegisterType>(TRegisterType instance, string name) where TRegisterType : class;
        IRegisterOptions Register<TRegisterType, TRegisterImplementation> ()
            where TRegisterType : class
            where TRegisterImplementation : class, TRegisterType;
        IRegisterOptions RegisterMultiple<TRegisterType>(IEnumerable<Type> instances) where TRegisterType : class;
        IRegisterOptions RegisterMultiple(Type registrationType, IEnumerable<Type> implementationTypes);
        void Unregister<TRegisterType>();
        void Unregister<TRegisterType>(string name);
    }
}

