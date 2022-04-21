using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class GameController : MonoBehaviour
    {
        public GameObject sphereObj;
        public GameObject[] boxes;

        Subject subject = new Subject();

        // Start is called before the first frame update
        void Start()
        {
            Box box1 = new Box(boxes[0]);
            Box box2 = new Box(boxes[1]);
            Box box3 = new Box(boxes[2]);

            subject.AddObserver(box1);
            subject.AddObserver(box2);
            subject.AddObserver(box3);
        }

        // Update is called once per frame
        void Update()
        {
            if(sphereObj.transform.position.magnitude < 0.5f)
            {
                subject.Notify();
            }
        }
    }
}

