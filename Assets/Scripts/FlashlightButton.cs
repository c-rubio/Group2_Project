using UnityEngine;

public class FlashlightButton : MonoBehaviour
{
    public Light light;
    public GameObject bulb;
    public bool status;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void btnSwitch() {
        light.enabled = !status;
        bulb.SetActive(!status);
        status = !status;
    }

}
