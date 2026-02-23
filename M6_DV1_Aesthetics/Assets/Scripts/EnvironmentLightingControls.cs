using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class EnvironmentLightingControls : MonoBehaviour
{
    public Toggle useSkyboxToggle;

    public bool UseSkybox
    {
        get => (RenderSettings.ambientMode == AmbientMode.Skybox);
        set
        {
            RenderSettings.ambientMode = (value) ?
                AmbientMode.Skybox : AmbientMode.Flat;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        useSkyboxToggle.isOn = UseSkybox;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
