using UnityEngine;
using System.Collections;

public class BuildModeController : MonoBehaviour {

    private GameObject gridObject;
    
    void Awake () // Function runs once before start
    {
        gridObject = GameObject.FindGameObjectWithTag("Grid"); // Finds the grid object
    }

	void Start () // Function runs once 
    {
        gridObject.SetActive(false); // Deactivates the grid object in the scene
	}
	
	void Update () // Function runs every frame
    {
        if (Input.GetKeyDown(KeyCode.B)) // Checks for input
        {
            gridObject.SetActive(!gridObject.activeSelf); // Sets the current active state to the opposite value
        }
	}
}
