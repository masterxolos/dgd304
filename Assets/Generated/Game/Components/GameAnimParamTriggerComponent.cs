//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnimParamTriggerComponent animParamTrigger { get { return (AnimParamTriggerComponent)GetComponent(GameComponentsLookup.AnimParamTrigger); } }
    public bool hasAnimParamTrigger { get { return HasComponent(GameComponentsLookup.AnimParamTrigger); } }

    public void AddAnimParamTrigger(string newName) {
        var index = GameComponentsLookup.AnimParamTrigger;
        var component = (AnimParamTriggerComponent)CreateComponent(index, typeof(AnimParamTriggerComponent));
        component.name = newName;
        AddComponent(index, component);
    }

    public void ReplaceAnimParamTrigger(string newName) {
        var index = GameComponentsLookup.AnimParamTrigger;
        var component = (AnimParamTriggerComponent)CreateComponent(index, typeof(AnimParamTriggerComponent));
        component.name = newName;
        ReplaceComponent(index, component);
    }

    public void RemoveAnimParamTrigger() {
        RemoveComponent(GameComponentsLookup.AnimParamTrigger);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnimParamTrigger;

    public static Entitas.IMatcher<GameEntity> AnimParamTrigger {
        get {
            if (_matcherAnimParamTrigger == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnimParamTrigger);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnimParamTrigger = matcher;
            }

            return _matcherAnimParamTrigger;
        }
    }
}