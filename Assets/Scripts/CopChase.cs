using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopChase : MonoBehaviour
{
    [SerializeField]
    private bool playercar = false;
    [SerializeField]
    private float speed = 25f, rotationspeed = 100f;

    private Rigidbody mybody;

    private GameObject target;

    private float translation, rotation;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    private void Awake()
    {
        mybody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!playercar && !target)
            return;
        if (playercar)
        {
            if(Mathf.Abs(Input.GetAxis("Vertical")) > 0)
            {
               rotation = Input.GetAxis("Horizontal") * rotationspeed * Time.deltaTime;
                translation = Input.GetAxis("Vertical") * speed;
            }
            else
            {
                rotation = 0f;
                translation= 0f;
            }
        }
        else
        {
            Vector3 targetDirection = transform.position - target.transform.position;
            targetDirection.Normalize();

            rotation = Vector3.Cross(targetDirection, transform.forward).y;
        }
    }
    private void FixedUpdate()
    {
        if (playercar)
        {
            mybody.velocity = transform.forward * translation;
            transform.Rotate(Vector3.up * rotation);
        }
        else
        {
            mybody.angularVelocity = rotationspeed * rotation * new Vector3(0, 1, 0);
            mybody.velocity = transform.forward * speed;
        }
    }
}
