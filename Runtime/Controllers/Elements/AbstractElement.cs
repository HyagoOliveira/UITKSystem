using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace ActionCode.UITKSystem
{
    public abstract class AbstractElement<T> : MonoBehaviour, IDisposable where T : VisualElement
    {
        private readonly List<UQueryBuilder<T>> builders = new(10);

        public virtual void Initialize(VisualElement root)
        {
            builders.Clear();

            foreach (var className in GetQueryClasses())
            {
                var builder = root.Query<T>(className: className);
                builder.ForEach(RegisterEvent);

                builders.Add(builder);
            }
        }

        public virtual void Dispose()
        {
            foreach (var builder in builders)
            {
                builder.ForEach(UnregisterEvent);
            }
            builders.Clear();
        }

        protected virtual string[] GetQueryClasses() => new[] { "unity-button" };

        protected abstract void RegisterEvent(T e);
        protected abstract void UnregisterEvent(T e);
    }
}