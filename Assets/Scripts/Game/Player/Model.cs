using UnityEngine;
using System.Collections;

namespace Player
{
	public class Model : MonoBehaviour 
	{
        private Movement compMovement;
        private Rendering compRendering;

        void Awake()
        { 
			SetReferences();
		}

        void Start () 
		{
            compMovement.Initialize();
            compRendering.Initialize();
        }
		
		void Update () 
		{
		
		}

        private void SetReferences()
        {
            compMovement = gameObject.GetComponent<Movement>();
            compRendering = gameObject.GetComponent<Rendering>();

            compMovement.SetModelReference(this);
			compRendering.SetModelReference(this);
        }
    }
}
