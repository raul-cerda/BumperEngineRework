using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWater : MonoBehaviour {
	
	Vector2 uvScaler = new Vector2(10.0f, 5.0f);
	int materialIndex = 0;
	string textureName = "_MainTex";
	int inversionCounter = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(inversionCounter < 120 )
		{
			inversionCounter++;
			uvScaler.x += 0.005f;
			uvScaler.y += 0.005f;
			GetComponent<MeshRenderer>().materials[materialIndex].SetTextureScale(textureName, uvScaler);
			
		}
		else if(inversionCounter < 240)
		{
			inversionCounter++;
			uvScaler.x -= 0.003f;
			uvScaler.y -= 0.003f;
			GetComponent<MeshRenderer>().materials[materialIndex].SetTextureScale(textureName, uvScaler);
		}
		else
		{
			inversionCounter = 0;
			GetComponent<MeshRenderer>().materials[materialIndex].SetTextureScale(textureName, uvScaler);
		}
		
	}
}