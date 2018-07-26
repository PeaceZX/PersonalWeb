using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class GameManager : MonoBehaviour
{
    void Start()
    {
        UnityAction<BaseEventData> click = new UnityAction<BaseEventData>(MyClick);
        EventTrigger.Entry myclick = new EventTrigger.Entry();
        myclick.eventID = EventTriggerType.PointerClick;
        myclick.callback.AddListener(click);

        EventTrigger trigger = gameObject.AddComponent<EventTrigger>();
        trigger.triggers.Add(myclick);
    }


    public void MyClick(BaseEventData data)
    {
        Debug.Log("点击");
    }
}