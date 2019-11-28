using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutLeaf : MonoBehaviour
{

    //public Transform PrefabLeafCut;

    //Transform leafCut;
    //Transform leafWhole;
    GameObject  leafCut;
    public GameObject PrefabLeafCut;
    // Start is called before the first frame update
    void Start()
    {
        //leafWhole = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MacheteBlade")
        {

            leafCut = Instantiate(PrefabLeafCut, this.transform.position, this.transform.rotation);
            leafCut.transform.localScale = this.transform.localScale;
           
            //leafCut = Instantiate(PrefabLeafCut, transform.position, Quaternion.identity) as Transform;
            //leafCut.parent = gameObject.transform;
            //leafCut.localRotation = leafCut.parent.rotation;
            //leafCut.localScale = new Vector3(1,1,1);

            //leafCut.localRotation = Quaternion.identity;

            Destroy(this.gameObject);
        }
    }
}
