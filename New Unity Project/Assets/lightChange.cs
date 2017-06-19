using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightChange : MonoBehaviour {
	GameObject player;
	public float intensity;
	public Color color;
	public float threshold;
      float origIntensity;
      Color origColor;
	Light lightComponent;
	float distance;
	// Use this for initialization
      void Start () {
            player = transform.root.parent.Find("player").gameObject;
            lightComponent = GetComponent<Light>();
            origIntensity = lightComponent.intensity;
            origColor = lightComponent.color;
	}
	
	// Update is called once per frame
      void Update () {
            distance = Vector3.Distance(player.transform.position, transform.position);

            if(distance < threshold){
                  lightComponent.intensity = intensity;
                  lightComponent.color = color;
            }else if(lightComponent.color != origColor){
                  lightComponent.intensity = origIntensity;
                  lightComponent.color = origColor; 
            }
      }
}
