using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void AppleDestroyed() { // 2
//// Destroy all of the falling Apples
GameObject[] tAppleArray=GameObject.FindGameObjectsWithTag("Apple");// 3
foreach ( GameObject tGO in tAppleArray ) {
Destroy( tGO );
}
}
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>
        (); // 1
            // Call the public AppleDestroyed() method of apScript
        apScript.AppleDestroyed();
        }
        // Get a reference to the ApplePicker component of Main Camera
        
    }
    
}
