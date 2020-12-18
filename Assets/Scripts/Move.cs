using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private GameObject targetHolder;
	private GameObject target;
    [SerializeField]
	private float speed = 1.5F;
	private Transform blackShapeObject;
	
	// Start is called before the first frame update
	void Start()
	{
        targetHolder = GameObject.Find("Target Holder");
        int count = targetHolder.transform.childCount;
        int index = Random.Range(0, count - 1);
        target = targetHolder.transform.GetChild(index).gameObject;
	}
	
	// Update is called once per frame
	void Update()
	{
        Vector3 deltaPosition = target.transform.position - transform.position;           // get the direction vector from bug to target
        float angle = Mathf.Atan2(deltaPosition.y, deltaPosition.x) * Mathf.Rad2Deg;      // calculate tan inverse to find appropriate angle and convert to degree
        transform.eulerAngles = new Vector3(                                              // sets this angle on z axis. and thus it faces towards the target
            transform.eulerAngles.x,
            transform.eulerAngles.y,
            angle
        );
		transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
	}
}