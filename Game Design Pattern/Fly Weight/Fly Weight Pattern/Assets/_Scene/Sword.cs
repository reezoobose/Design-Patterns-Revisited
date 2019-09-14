using UnityEngine;

namespace _Scene
{
    [CreateAssetMenu(fileName = "Sword_Data",menuName = "Sword_Art_Online",order = 51)]
    public class Sword : ScriptableObject
    {
        [SerializeField]private  string swordName;
        [SerializeField]private  int swordWeight;
        [SerializeField]private  Color swordColor;

        public string SwordName
        {
            get => swordName;

            private set => swordName = value;
        }

        public int SwordWeight
        {
            get => swordWeight;

            private set => swordWeight = value;
        }

        public Color SwordColor
        {
            get => swordColor;

            private set => swordColor = value;
        }



    }
}
