using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public abstract class Observer
    {
        public abstract void OnNotify();
    }

   
        public class salto : Observer
        {
        GameObject obj;
            public override void OnNotify()
            {
                Jump();
            }

            void Jump()
            {
                if (obj.transform.position.y < 0.55f)
                {
                    obj.GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
                }

                
            }
        }

        public class Box : salto
        {
            GameObject boxObj;
            salto Jump = new salto();

        public Box(GameObject boxObj)
            {
                this.boxObj = boxObj;
            }
        

    }
        public class Sphere : Observer
        {
            GameObject sphObj;

            public Sphere(GameObject sphObj)
            {
                this.sphObj = sphObj;
            }

        //Este método será llamado por la clase Subject
            public override void OnNotify()
            {
                Jump();
            }

            void Jump()
            {
                if (sphObj.transform.position.y < 0.55f)
                {
                    sphObj.GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
                }


            }
        }
        
    
}
