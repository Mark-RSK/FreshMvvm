﻿using System;
using System.Collections.Generic;
using FreshMvvm.IoC;
using FreshMvvm.IoC.TinyIoC;
using TinyIoC;

namespace FreshMvvm.IOC
{
    /// <summary>
    /// Built in TinyIOC for ease of use
    /// </summary>
    public class FreshTinyIoCBuiltIn : IFreshIoC
    {
        internal static TinyIoCContainer Current => TinyIoCContainer.Current;

        public TResolveType Resolve<TResolveType>(string name) where TResolveType : class
        {
            return TinyIoCContainer.Current.Resolve<TResolveType>(name);
        }

        public TResolveType Resolve<TResolveType>() where TResolveType : class
        {
            return TinyIoCContainer.Current.Resolve<TResolveType>();
        }

        public IRegisterOptions Register<TRegisterType>(TRegisterType instance, string name) where TRegisterType : class
        {
            return TinyIoCContainer.Current.Register(instance, name);
        }

        public IRegisterOptions Register<TRegisterType>(TRegisterType instance) where TRegisterType : class
        {
            return TinyIoCContainer.Current.Register(instance);
        }

        public IRegisterOptions Register<TRegisterType, TRegisterImplementation>()
            where TRegisterType : class
            where TRegisterImplementation : class, TRegisterType
        {
            return TinyIoCContainer.Current.Register<TRegisterType, TRegisterImplementation>();
        }

        public IRegisterOptions RegisterMultiple<TRegisterType>(IEnumerable<Type> instances) where TRegisterType : class
        {
            return TinyIoCContainer.Current.RegisterMultiple<TRegisterType>(instances);
        }

        public IRegisterOptions RegisterMultiple(Type registrationType, IEnumerable<Type> implementationTypes)
        {
            return TinyIoCContainer.Current.RegisterMultiple(registrationType, implementationTypes);
        }

        public object Resolve(Type resolveType)
        {
            return TinyIoCContainer.Current.Resolve(resolveType);
        }

        public void Unregister<TRegisterType>()
        {
            TinyIoCContainer.Current.Unregister<TRegisterType>();
        }

        public void Unregister<TRegisterType>(string name)
        {
            TinyIoCContainer.Current.Unregister<TRegisterType>(name);
        }
    }
}

