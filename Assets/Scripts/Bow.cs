using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    [SerializeField]
    private Transform prefab;

    [SerializeField]
    private Transform conteneur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform clone = Instantiate(prefab);
            clone.SetParent(conteneur);
            clone.position = this.transform.position + this.transform.forward;
            clone.LookAt(this.transform);

        }
        
    }
}
