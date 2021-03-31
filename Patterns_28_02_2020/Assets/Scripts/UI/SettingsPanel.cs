using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    internal sealed class SettingsPanel : BaseUI
    {
        [SerializeField] private Button _backBtn;
        [SerializeField] private Button _exitBtn;

        public UIView uiView;
        

        private void Awake()
        {
            _backBtn.onClick.AddListener(BackToMenu);
        }

        private void BackToMenu()
        {
            uiView.ShowMenuWindow(StateUI.MenuPanel);
        }

        public override void Show()
        {
            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}