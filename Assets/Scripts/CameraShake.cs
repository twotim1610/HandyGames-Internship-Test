using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    Vector3 _originalPos;

    private void Start()
    {
        _originalPos = transform.localPosition;
    }
    public void ShakeInput(float duration, float magnitude)
    {
        
        StopAllCoroutines();// make sure the privius one has stoped
        StartCoroutine(Shake(duration, magnitude));
    }

    private IEnumerator Shake(float duration, float magnitude)
    {

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = _originalPos + new Vector3(x, y, 0);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = _originalPos;
    }
}
