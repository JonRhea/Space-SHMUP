using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	private BoundsCheck bndCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake () {
		bndCheck = GetComponent<BoundsCheck>();
	}
	void Update () {
		if (bndCheck.offUp) { 
			Destroy( gameObject );
		}//end if
	}

}
