using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissiveOscillator : MonoBehaviour
{
    MeshRenderer emissiveRenderer;
    Material emissiveMaterial;

    // Start is called before the first frame update
    void Start()
    {
        emissiveRenderer = GetComponent<MeshRenderer>();
        emissiveMaterial = emissiveRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        Color c = Color.Lerp(Color.white, Color.black, Mathf.Sin(Time.time * Mathf.PI) * 0.5f + 0.5f);
        emissiveMaterial.SetColor("_Emission", c);
        //emissiveRenderer.UpdateGIMaterials();
        //简单纯色使用这种方式，效率更高
        DynamicGI.SetEmissive(emissiveRenderer, c);
    }
}
