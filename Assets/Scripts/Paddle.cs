using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    private float mousePosition;
    private Vector3 paddlePosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mousePosition = Input.mousePosition.x / Screen.width * 16.0f;
        paddlePosition = new Vector3(Mathf.Clamp(mousePosition, 0.5f, 15.5f), 
                                     this.transform.position.y,
                                     this.transform.position.z);
        this.transform.position = paddlePosition;
        //print(mousePosition);
	}
}
