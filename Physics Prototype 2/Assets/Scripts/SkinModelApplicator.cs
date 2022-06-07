using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinModelApplicator : MonoBehaviour
{
    public Material blue1;
    public Material green1;
    void Update() {
        if (GameManager.instance.skinSelected == "blue1") {
        GetComponent<Renderer>().material = blue1; }
        else if (GameManager.instance.skinSelected == "green1") {
        GetComponent<Renderer>().material = green1; }
    }
    

}
