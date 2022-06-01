//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AnimationEntity {

    public ValueAnimationComponent valueAnimation { get { return (ValueAnimationComponent)GetComponent(AnimationComponentsLookup.ValueAnimation); } }
    public bool hasValueAnimation { get { return HasComponent(AnimationComponentsLookup.ValueAnimation); } }

    public void AddValueAnimation(float newFrom, float newTo, Easing.Functions newEasing, System.Action<float> newOnUpdate) {
        var index = AnimationComponentsLookup.ValueAnimation;
        var component = (ValueAnimationComponent)CreateComponent(index, typeof(ValueAnimationComponent));
        component.from = newFrom;
        component.to = newTo;
        component.easing = newEasing;
        component.onUpdate = newOnUpdate;
        AddComponent(index, component);
    }

    public void ReplaceValueAnimation(float newFrom, float newTo, Easing.Functions newEasing, System.Action<float> newOnUpdate) {
        var index = AnimationComponentsLookup.ValueAnimation;
        var component = (ValueAnimationComponent)CreateComponent(index, typeof(ValueAnimationComponent));
        component.from = newFrom;
        component.to = newTo;
        component.easing = newEasing;
        component.onUpdate = newOnUpdate;
        ReplaceComponent(index, component);
    }

    public void RemoveValueAnimation() {
        RemoveComponent(AnimationComponentsLookup.ValueAnimation);
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
public sealed partial class AnimationMatcher {

    static Entitas.IMatcher<AnimationEntity> _matcherValueAnimation;

    public static Entitas.IMatcher<AnimationEntity> ValueAnimation {
        get {
            if (_matcherValueAnimation == null) {
                var matcher = (Entitas.Matcher<AnimationEntity>)Entitas.Matcher<AnimationEntity>.AllOf(AnimationComponentsLookup.ValueAnimation);
                matcher.componentNames = AnimationComponentsLookup.componentNames;
                _matcherValueAnimation = matcher;
            }

            return _matcherValueAnimation;
        }
    }
}
