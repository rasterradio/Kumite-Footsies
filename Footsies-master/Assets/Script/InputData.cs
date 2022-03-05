using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Footsies
{

    public enum InputDefine
    {
        None = 0,
        Left = 1 << 0,
        Right = 1 << 1,
        Up = 2 << 1,
        Down = 3 << 2,
        Attack = 4 << 4,
        Evade = 5 << 5,
    }

    public class InputData
    {
        public int input;
        public float time;
        
        public InputData ShallowCopy()
        {
            return (InputData)this.MemberwiseClone();
        }
    }
}