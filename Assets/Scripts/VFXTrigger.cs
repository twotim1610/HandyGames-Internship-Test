using UnityEngine;
using UnityEngine.VFX;

public class VFXTrigger : MonoBehaviour
{
    [SerializeField] private VisualEffect _visualEffect;
    [SerializeField] private CameraShake _cameraShake;
    [SerializeField] private float _lightDuration, _lightMagnitude, _heavyDuration, _heavyMagnitude;
    public void StartVFX()
    {
        _visualEffect.SendEvent("Start");
    }
    public void LightCameraShake()
    {
        _cameraShake.ShakeInput(_lightDuration, _lightMagnitude);
    }
    public void HeavyCameraShake()
    {
        _cameraShake.ShakeInput(_heavyDuration, _heavyMagnitude);
    }
}
