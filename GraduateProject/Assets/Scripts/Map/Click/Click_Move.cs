using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Move : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform movePoint;

    public LayerMask Stopmovement;  //�ֺ��� �ִ��� Ȯ�� �ϱ� ���� �� layer�� �޾� ���� ����
    public bool click = false;
    public GameObject[] button = new GameObject[4]; //�̵� ��ư���� �޾ƿ�
    // Start is called before the first frame update
    void Start()    //���� �Ҷ� ��� �̵� ��ư ��Ȱ��ȭ
    {
        movePoint.parent = null;
        for (int i = 0; i < 4; i++)
        {
            button[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        button[0].transform.position = movePoint.position + new Vector3(1, 0, 0);
        button[1].transform.position = movePoint.position + new Vector3(-1, 0, 0);
        button[2].transform.position = movePoint.position + new Vector3(0, 1, 0);
        button[3].transform.position = movePoint.position + new Vector3(0, -1, 0);  //��� ��ư�� ��ġ ����
        if (click)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
            if (player_random.move_point > 0)
            {

                if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(1, 0f, 0f), .2f, Stopmovement)) // �÷��̾� ������ ���� ���� �ÿ� �̵� ��ư ����
                    {
                        button[0].SetActive(true);
                    }
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(-1, 0f, 0f), .2f, Stopmovement)) // �÷��̾� ������ ���� ���� �ÿ� �̵� ��ư ����
                    {
                        button[1].SetActive(true);
                    }
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, 1, 0f), .2f, Stopmovement)) // �÷��̾� ���� ���� ���� �ÿ� �̵� ��ư ����
                    {
                        button[2].SetActive(true);
                    }
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, -1, 0f), .2f, Stopmovement)) // �÷��̾� �Ʒ��� ���� ���� �ÿ� �̵� ��ư ����
                    {
                        button[3].SetActive(true);
                    }

                }
            }
        }
        else
        {
            Buttonoff();
        }
    }

    public void Buttonoff() // �ϳ��� ��ư�� Ŭ�� ���� �� Ȱ��ȭ �Ǿ��ִ� ��ư���� ���� ���� �Լ� 
    {
        for (int i = 0; i < 4; i++)
        {
            button[i].SetActive(false);
        }
    }
    public void ButtonRight()
    {
        movePoint.transform.position += new Vector3(1, 0, 0);//Ŭ���ÿ� movepoint�� ��ġ �̵�, movepoint�̵��� �÷��̾� �̵� ��ũ��Ʈ�� ���� �÷��̾� �̵�
        player_random.move_point--; // �̵��� ����
        Buttonoff();
    }
    public void ButtonLeft()
    {
        movePoint.transform.position += new Vector3(-1, 0, 0);  //Ŭ���ÿ� movepoint�� ��ġ �̵�, movepoint�̵��� �÷��̾� �̵� ��ũ��Ʈ�� ���� �÷��̾� �̵�
        player_random.move_point--; // �̵��� ����
        Buttonoff();
    }
    public void ButtonUp()
    {
        movePoint.transform.position += new Vector3(0, 1, 0);//Ŭ���ÿ� movepoint�� ��ġ �̵�, movepoint�̵��� �÷��̾� �̵� ��ũ��Ʈ�� ���� �÷��̾� �̵�
        player_random.move_point--; // �̵��� ����
        Buttonoff();
    }
    public void ButtonDown()
    {
        movePoint.transform.position += new Vector3(0, -1, 0);//Ŭ���ÿ� movepoint�� ��ġ �̵�, movepoint�̵��� �÷��̾� �̵� ��ũ��Ʈ�� ���� �÷��̾� �̵�
        player_random.move_point--; // �̵��� ����
        Buttonoff();
    }
    public void ButtonSetFalse()
    {
        for (int i=0; i<4; i++)
        {
            button[i].SetActive(false);
        }
    }
}
