using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp() // si se suelta boton mouse sobre esta pieza
    {
        GameObject.Find("GameHandler").GetComponent<gamehandler>().p_target = gameObject;

        if (GameObject.Find("GameHandler"))
        {
            Destroy(GameObject.Find("select"));
        }

        GameObject newSelect = Instantiate (GameObject.Find("GameHandler").GetComponent<gamehandler>().obj[7]);
        newSelect.name = "select";
        newSelect.transform.position = transform.position + new Vector3(0, 4.0f, 0);
    }
}
