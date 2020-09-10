using System;

namespace Klasser
{
    public class Football
    {
        private float[] position ={0.0f,0.0f};
        public Football(float[] startPos){
            position = startPos;
        }
        public float[] GetPos(){
            return position;
        }
    }
}
