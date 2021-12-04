using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamehandler : MonoBehaviour
{
    public List<GameObject> obj;
    public float offset_cas; //distancia de casilleros
    public Color color_b;
    public Color color_n;

    public GameObject p_target; // piezza actual seleccionada

    // Start is called before the first frame update
    void Start()
    {
        iniciar_partida();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void iniciar_partida()
    {
        bool p_color = false;
        for (int i = 0; i < 8; i++)
        {
            string nombre = "";
            switch(i)
            {
                case 0:
                    nombre += "A";
                    break;

                case 1:
                    nombre += "B";
                    break;

                case 2:
                    nombre += "C";
                    break;

                case 3:
                    nombre += "D";
                    break;

                case 4:
                    nombre += "E";
                    break;

                case 5:
                    nombre += "F";
                    break;

                case 6:
                    nombre += "G";
                    break;

                case 7:
                    nombre += "H";
                    break;
            }

            p_color = !p_color;
            for (int j = 0; j < 8; j++)
            {
               
               string nombre_provis = nombre + (j + 1).ToString();
                p_color = !p_color;
                GameObject newCas = Instantiate(obj[0]); // se crea una copia del casillero
                newCas.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(j*offset_cas,0,i*offset_cas);
                if (p_color)
                {
                    newCas.GetComponent<MeshRenderer>().material.SetColor("_Color", color_n);
                }
                else
                {
                    newCas.GetComponent<MeshRenderer>().material.SetColor("_Color", color_b);
                }

                newCas.name = nombre_provis;
            }
        }
        crear_piezas();
    }
    void crear_piezas()
    {
        //peones
        for (int i = 0; i < 8; i++)
        {
            GameObject newPeon = Instantiate(obj[1]);
            newPeon.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(offset_cas * 1, 0.02f, offset_cas * i);
        }

        for (int i = 0; i < 8; i++)
        {
            //peon blanco
            GameObject newPeon = Instantiate(obj[1]);
            newPeon.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(offset_cas * 6, 0.02f, offset_cas * i);
            foreach (Transform hijo in newPeon.transform)
            {
                foreach(Material mat in hijo.GetComponent<MeshRenderer>().materials)
                {
                    mat.SetColor("_Color", color_n);
                }
              
            }
        }
        //Torres A
        GameObject newTorre = Instantiate(obj[2]);
        newTorre.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, 0);
        newTorre = Instantiate(obj[2]);
        newTorre.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, offset_cas*7);

        //Torres B
        newTorre = Instantiate(obj[2]);
        newTorre.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7*offset_cas, 0.02f, 0);
        foreach (Transform hijo in newTorre.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }

        newTorre = Instantiate(obj[2]);
        newTorre.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7 * offset_cas, 0.02f, offset_cas * 7);
        foreach (Transform hijo in newTorre.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }

        //Caballos A
        GameObject newCaballo = Instantiate(obj[3]);
        newCaballo.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, offset_cas*1);
        newCaballo = Instantiate(obj[3]);
        newCaballo.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, offset_cas * 6);

        //Caballos B
        newCaballo = Instantiate(obj[3]);
        newCaballo.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7* offset_cas, 0.02f, offset_cas * 1);
        foreach (Transform hijo in newCaballo.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }
        newCaballo = Instantiate(obj[3]);
        newCaballo.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7* offset_cas, 0.02f, offset_cas * 6);

        foreach (Transform hijo in newCaballo.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }
        //Alfiles A

        GameObject newAlfiles = Instantiate(obj[4]);
        newAlfiles.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, offset_cas * 2);
        newAlfiles = Instantiate(obj[4]);
        newAlfiles.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, offset_cas * 5);

        //Alfiles B
        newAlfiles = Instantiate(obj[4]);
        newAlfiles.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7* offset_cas, 0.02f, offset_cas * 2);
        foreach (Transform hijo in newAlfiles.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }
        newAlfiles = Instantiate(obj[4]);
        newAlfiles.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7* offset_cas, 0.02f, offset_cas * 5);

        foreach (Transform hijo in newAlfiles.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }

        //Reina A
        GameObject newReina = Instantiate(obj[6]);
        newReina.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, offset_cas * 3);


        //Reina B
        newReina = Instantiate(obj[6]);
        newReina.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7 * offset_cas, 0.02f, offset_cas * 3);

        foreach (Transform hijo in newReina.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }
        //REY A
        GameObject newRey = Instantiate(obj[5]);
        newRey.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(0, 0.02f, offset_cas * 4);

        //REY B
        newRey = Instantiate(obj[5]);
        newRey.transform.position = GameObject.Find("Spawn_C").transform.position + new Vector3(7* offset_cas, 0.02f, offset_cas * 4);
        foreach (Transform hijo in newRey.transform)
        {
            foreach (Material mat in hijo.GetComponent<MeshRenderer>().materials)
            {
                mat.SetColor("_Color", color_n);
            }

        }
    }
}
