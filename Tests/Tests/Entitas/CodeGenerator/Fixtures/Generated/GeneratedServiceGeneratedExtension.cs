//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public class GeneratedService : IComponent {
    public SomeService value;
}

namespace Entitas {

    public partial class Entity {

        public GeneratedService generatedService { get { return (GeneratedService)GetComponent(ServicePoolComponentIds.GeneratedService); } }

        public bool hasGeneratedService { get { return HasComponent(ServicePoolComponentIds.GeneratedService); } }

        public Entity AddGeneratedService(SomeService newValue) {
            var component = CreateComponent<GeneratedService>(ServicePoolComponentIds.GeneratedService);
            component.value = newValue;
            return AddComponent(ServicePoolComponentIds.GeneratedService, component);
        }

        public Entity ReplaceGeneratedService(SomeService newValue) {
            var component = CreateComponent<GeneratedService>(ServicePoolComponentIds.GeneratedService);
            component.value = newValue;
            ReplaceComponent(ServicePoolComponentIds.GeneratedService, component);
            return this;
        }

        public Entity RemoveGeneratedService() {
            return RemoveComponent(ServicePoolComponentIds.GeneratedService);
        }
    }
}

    public partial class ServicePoolMatcher {

        static IMatcher _matcherGeneratedService;

        public static IMatcher GeneratedService {
            get {
                if (_matcherGeneratedService == null) {
                    var matcher = (Matcher)Matcher.AllOf(ServicePoolComponentIds.GeneratedService);
                    matcher.componentNames = ServicePoolComponentIds.componentNames;
                    _matcherGeneratedService = matcher;
                }

                return _matcherGeneratedService;
            }
        }
    }