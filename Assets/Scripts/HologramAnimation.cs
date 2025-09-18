using System.Collections;
using UnityEngine;

public class HologramAnimation : MonoBehaviour
{
    [SerializeField] private Material _hologramMaterial;
    [SerializeField] private Animator _logoAnimator;
    [SerializeField] private float _activationTime, _activeTime;
    void Start()
    {
        StartCoroutine(HologramAnimating());
    }
    IEnumerator HologramAnimating()
    {
        float ellapsteTime = 0;
        while(ellapsteTime <= _activationTime)
        {
            ellapsteTime += Time.deltaTime;
            float value = Mathf.Lerp(1, 0, ellapsteTime / _activationTime);
            _hologramMaterial.SetFloat("_Transition", value);

            yield return null;
        }

        _logoAnimator.SetBool("IsRotating", true);
        ellapsteTime = 0;

        while(ellapsteTime <= _activeTime)
        {
            ellapsteTime += Time.deltaTime;
            yield return null;
        }
        _logoAnimator.SetBool("IsRotating", false);
        ellapsteTime = 0;
        while (ellapsteTime <= _activationTime)
        {
            ellapsteTime += Time.deltaTime;
            _hologramMaterial.SetFloat("_Transition", ellapsteTime/_activationTime);

            yield return null;
        }

    }

    
    void Update()
    {
        
    }
}
