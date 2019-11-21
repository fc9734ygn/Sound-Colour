using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutLeaf : MonoBehaviour
{

    public Transform PrefabLeafCut;

    Transform leafCut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MacheteBlade")
        {
           
            leafCut = Instantiate(PrefabLeafCut, transform.position, Quaternion.identity) as Transform;
            leafCut.parent = gameObject.transform;
            leafCut.localRotation = Quaternion.identity;
            
            //Destroy(this.gameObject);
        }
    }
}
