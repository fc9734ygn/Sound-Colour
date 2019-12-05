using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardBall : MonoBehaviour
{

    public Roomtype roomtype;

    // Start is called before the first frame update
    void Start()
    {
        SetColour(roomtype);
    }

    private void SetColour(Roomtype type)
    {
        Color color;
        switch (type)
        {
            case Roomtype.Arctic:
                color = new Color(0, 204, 255);
                break;
            case Roomtype.Coastal:
                color = new Color(255, 204, 0);
                break;
            case Roomtype.Jungle:
                color = new Color(0, 153, 0);
                break;
            case Roomtype.Space:
                color = new Color(204, 0, 204);
                break;
            default:
                color = new Color(255, 255, 255);
                break;
        }
        gameObject.GetComponent<MeshRenderer>().material.color = color;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public enum Roomtype
    {
        Jungle,
        Arctic,
        Coastal,
        Space
    }
}
