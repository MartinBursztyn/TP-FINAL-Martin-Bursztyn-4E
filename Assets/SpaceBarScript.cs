using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarScript : MonoBehaviour
{
    public GameObject[] figuras;
    public int indiceArray = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int k = 0; k< figuras.Length; k++)
        {
            figuras[k].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            figuras[indiceArray].SetActive(false);
            indiceArray++;
            if(indiceArray == figuras.Length)
            {
                indiceArray = 0;
            }
            figuras[indiceArray].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            figuras[indiceArray].SetActive(false);
            indiceArray++;
            if(indiceArray == -1)
            {
                indiceArray = figuras.Length - 1;
            }
            figuras[indiceArray].SetActive(true);
        }
    }
}
