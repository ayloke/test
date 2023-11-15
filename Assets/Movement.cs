using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForse = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //pupu
    }

    // Update is called once per frame
    void FixedUpdate()//��� ������� ���������� � �������� ������������� ������ (fixed framerate), ���� MonoBehaviour �������.
    {

        if (Input.GetKey("d"))//�������� ������
        {
            rb.AddForce(forwardForse * Time.deltaTime , 0, 0);
        }

        if (Input.GetKey("a"))//�������� �����
        {
            rb.AddForce(-forwardForse * Time.deltaTime, 0,0);
        }
        if (Input.GetKey("w"))//�������� �����
        {
            rb.AddForce( 0,0,forwardForse * Time.deltaTime);
        }
        if (Input.GetKey("s"))//�������� �����
        {
            rb.AddForce(0, 0, -forwardForse * Time.deltaTime);
        }
        if (Input.GetKey("v"))//���������
        {
            forwardForse=2500 ;//��� �������� ���� ������� 
        }
        else
        {
            forwardForse = 500 ;//��� ��������� ���� �������� ������� ������ � unity
        }

    }
}