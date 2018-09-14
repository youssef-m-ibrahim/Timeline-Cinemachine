using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCombiner : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		StaticBatchingUtility.Combine (gameObject);	
	}
}
