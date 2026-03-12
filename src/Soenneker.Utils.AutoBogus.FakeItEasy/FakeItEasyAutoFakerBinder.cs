using Soenneker.Reflection.Cache.Methods;
using Soenneker.Reflection.Cache.Types;
using Soenneker.Utils.AutoBogus.Context;
using System;
using FakeItEasy;

namespace Soenneker.Utils.AutoBogus.FakeItEasy;

/// <summary>
/// An AutoFakerBinder for interfaces and abstract objects using FakeItEasy
/// </summary>
public class FakeItEasyAutoFakerBinder : AutoFakerBinder
{
    private CachedMethod? _fakeMethod;

    public override TType? CreateInstance<TType>(AutoFakerContext context, CachedType cachedType) where TType : default
    {
        if (cachedType.IsInterface || cachedType.IsAbstract)
        {
            if (_fakeMethod == null)
            {
                CachedType mockType = context.CacheService.Cache.GetCachedType(typeof(A));
                _fakeMethod = mockType.GetCachedMethod("Fake", Type.EmptyTypes);
            }

            CachedMethod? fakeGenericMethod = _fakeMethod!.MakeCachedGenericMethod(cachedType);

            return (TType)fakeGenericMethod!.Invoke(null, []);
        }

        return base.CreateInstance<TType>(context, cachedType);
    }
}