using UnityEngine;
using UnityEngine.Rendering.Universal;

// Basic FlashLight Mechanic: USE THIS FOR PROTOTYPE
public class flashlightscript : MonoBehaviour
{
    [SerializeField] private Light2D lightFlash;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            lightFlash.enabled = !lightFlash.enabled;
        }
    }
}
