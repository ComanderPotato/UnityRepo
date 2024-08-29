//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PrintAndHide : MonoBehaviour
//{
//    // Start is called before the first frame update
//    private int i = 3;
//    public Renderer rend;
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Debug.Log(gameObject.name + ":" + (++i));
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour {
    private int i = 3; // Initial value of i
    public Renderer rend;
    private int randomThreshold; // To store the random value for "Blue" tagged objects

    void Start() {
        // Generate a random number between 150 and 250, inclusive
        randomThreshold = Random.Range(150, 251); // Random.Range max is exclusive, so use 251

        // Assign the Renderer component
        rend = GetComponent<Renderer>();
    }

    void Update() {
        // Increment i and log the GameObject's name and the current value of i
        Debug.Log(gameObject.name + ": " + (++i));

        // Check if the GameObject's tag is "Red" and if i equals 100
        if(gameObject.CompareTag("Red") && i == 100) {
            gameObject.SetActive(false); // Deactivate the GameObject
        }

        // Check if the GameObject's tag is "Blue" and if i equals the random threshold
        if(gameObject.CompareTag("Blue") && i == randomThreshold) {
            if(rend != null) {
                rend.enabled = false; // Disable the Renderer component
            }
        }
    }
}
