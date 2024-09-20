using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introducao : MonoBehaviour
{
    [SerializeField] int vida = 100;
    private MeshRenderer meshRenderer;
    private float horizontal;
    private float vertical;
    [SerializeField] private int velocidade;


    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MudarCor();
        Mover();
     
    }

    void MudarCor()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            meshRenderer.material.color = Random.ColorHSV();
        }
    }

    void Mover()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, vertical, 0) * Time.deltaTime * velocidade);
    }
}
