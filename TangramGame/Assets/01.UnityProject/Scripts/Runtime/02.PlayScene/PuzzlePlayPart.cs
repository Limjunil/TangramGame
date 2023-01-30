using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler,
    IPointerUpHandler, IPointerMoveHandler
{

    private bool isClicked = false;


    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //! ���콺 ��ư�� ������ �� �����ϴ� �Լ�
    public void OnPointerDown(PointerEventData eventData)
    {
        isClicked = true;

        
        // DEBUG :
        //GFunc.Log($"{gameObject.name} �� �����ߴ�.");
    }   // OnPointerDown()

    //! ���콺 ��ư���� ���� ���� �� �����ϴ� �Լ�
    public void OnPointerUp(PointerEventData eventData)
    {
        isClicked = false;

        // DEBUG :
        //GFunc.Log($"{gameObject.name} �� ���� �����ߴ�.");

    }   // OnPointerUp()

    //! ���콺�� �巡�� ���� �� �����ϴ� �Լ�
    public void OnPointerMove(PointerEventData eventData)
    {
        if(isClicked == true)
        {
            gameObject.SetLocalPos(eventData.position.x, eventData.position.y, 0f);

            GFunc.Log($"���콺�� �������� ������ Ȯ�� : ({eventData.position.x}, {eventData.position.y})");
        }   // if : ���� ������Ʈ�� ������ ���
    }   // OnPointerMove()
}
