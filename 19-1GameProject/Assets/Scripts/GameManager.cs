using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    MSscript MS;
    HCscript HC;
    YHscript YH;
    JWscript JW;
	// Use this for initialization
	void Start () {
        MS = GetComponent<MSscript>();
        HC = GetComponent<HCscript>();
        YH = GetComponent<YHscript>();
        JW = GetComponent<JWscript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
