using System.Collections;
using UnityEngine;

public class ExplosionColorControler : MonoBehaviour
{
    [SerializeField] private float _lifeTime;
    [SerializeField] private Material _material;
    [SerializeField] private AnimationCurve _tranparencyOverLifeTime;
    [GradientUsage(true, ColorSpace.Linear)]
    [SerializeField] private Gradient _innerColorOverLifeTime;
    [SerializeField] private AnimationCurve _innerDisolveOverLifetime;
    [GradientUsage(true, ColorSpace.Linear)]
    [SerializeField] private Gradient _outerColorOverLifeTime;
    [SerializeField] private AnimationCurve _outerDisolveOverLifetime;
    public void StartLifetime()
    {
        StopAllCoroutines();
        StartCoroutine(LifeTime());
    }
    IEnumerator LifeTime() 
    {
        float ellapstedTime = 0;
        while (ellapstedTime <= _lifeTime)
        {
            ellapstedTime += Time.deltaTime;
            float value = ellapstedTime / _lifeTime;
            _material.SetColor("_Outer_Color",_outerColorOverLifeTime.Evaluate(value));
            _material.SetFloat("_Outer_Disolve",_outerDisolveOverLifetime.Evaluate(value));
            _material.SetColor("_Inner_Color", _innerColorOverLifeTime.Evaluate(value));
            _material.SetFloat("_Inner_Disolve", _innerDisolveOverLifetime.Evaluate(value));
            _material.SetFloat("_Transparency", _tranparencyOverLifeTime.Evaluate(value));
            yield return null;
        }
    }
}
