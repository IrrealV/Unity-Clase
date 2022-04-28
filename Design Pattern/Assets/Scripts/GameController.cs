using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class GameController : MonoBehaviour
    {
        public GameObject sphereObj;
        public GameObject[] boxes;
        public GameObject[] sphere;
        

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

            Sphere circle1 = new Sphere(sphere[0]);
            Sphere circle2 = new Sphere(sphere[1]);
            Sphere circle3 = new Sphere(sphere[2]);

            subject.AddObserver(circle1);
            subject.AddObserver(circle2);
            subject.AddObserver(circle3);
        }

        // Update is called once per frame
        void Update()
        {
            if(sphereObj.transform.position.magnitude < 0.5f)
            {
                subject.Notify();
            }
            if (sphereObj.transform.position.x <= -7f)
            {
                subject.Notify();
            }

        }
    }
}

