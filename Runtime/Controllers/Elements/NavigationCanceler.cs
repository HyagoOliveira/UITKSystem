using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace ActionCode.UISystem
{
    [DisallowMultipleComponent]
    public sealed class NavigationCanceler : AbstractElement<VisualElement>
    {
        public event Action OnCanceled;

        private VisualElement root;

        public override void Initialize(VisualElement root)
        {
            this.root = root;
            RegisterEvent(this.root);
        }

        public override void Dispose() => UnregisterEvent(root);

        protected override void RegisterEvent(VisualElement e) => e.RegisterCallback<NavigationCancelEvent>(HandleNavigationCancel);
        protected override void UnregisterEvent(VisualElement e) => e?.UnregisterCallback<NavigationCancelEvent>(HandleNavigationCancel);
        private void HandleNavigationCancel(NavigationCancelEvent _) => OnCanceled?.Invoke();
    }
}