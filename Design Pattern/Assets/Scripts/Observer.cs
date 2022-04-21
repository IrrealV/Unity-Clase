using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public abstract class Observer
    {
        public abstract void OnNotify();
    }

    public class Box : Observer
    {
        GameObject boxObj;

        public Box(GameObject boxObj)
        {
            this.boxObj = boxObj;
        }

        //Este método será llamado por la clase Subject
        public override void OnNotify()
        {
            Jump();
        }

        void Jump()
        {
            if (boxObj.transform.position.y < 0.55f)
            {
                boxObj.GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
            }
        }
    }
}
