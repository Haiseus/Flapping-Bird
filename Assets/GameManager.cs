using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject firstPillar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(firstPillar, transform.position + new Vector3(0, 2, 0), transform.rotation);
    }
}
