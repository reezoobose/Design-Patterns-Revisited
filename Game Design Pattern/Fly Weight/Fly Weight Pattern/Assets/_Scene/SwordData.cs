using UnityEngine;
using UnityEngine.UI;

namespace _Scene
{
    [RequireComponent(typeof(Button))]
    public class SwordData : MonoBehaviour
    {
        public Sword swordDataContainer;
        public Text swordText;
        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() =>
            {
                swordText.color = swordDataContainer.SwordColor;
                swordText.text = "Sword Name : " + swordDataContainer.SwordName +" Sword Weight :" + swordDataContainer.SwordWeight;
            });
        }
    }
}
