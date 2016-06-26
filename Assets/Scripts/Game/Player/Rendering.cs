using UnityEngine;
using System.Collections;

namespace Player
{
	public class Rendering : MonoBehaviour 
	{
		private Model compModel;

        public void Initialize()
        { 

		}

        public void SetModelReference(Model compModel)
        {
            this.compModel = compModel;
        }
	}
}

