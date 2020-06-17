using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Vector3 firstPosition;
    // Start is called before the first frame update
    void Start()
    {
        firstPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -10 * Time.deltaTime));

        if (Vector3.Distance(firstPosition, transform.position) > 20f)
        {
            Destroy(this.gameObject);
        }
    }
}
