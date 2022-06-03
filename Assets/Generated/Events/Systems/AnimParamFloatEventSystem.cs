//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AnimParamFloatEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IAnimParamFloatListener> _listenerBuffer;

    public AnimParamFloatEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IAnimParamFloatListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.AnimParamFloat)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasAnimParamFloat && entity.hasAnimParamFloatListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.animParamFloat;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.animParamFloatListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnAnimParamFloat(e, component.name, component.value);
            }
        }
    }
}