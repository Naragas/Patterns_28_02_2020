using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    internal sealed class MenuPannel : BaseUI
    {
        [SerializeField] private Button _settingsBtn;
        [SerializeField] private Button _backBtn;
        [SerializeField] private Button _exitBtn;

        public UIView uiView;
        
        private void Awake()
        {
            _settingsBtn.onClick.AddListener(ShowSettingsMenu);
        }

        public override void Show()
        {
            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }

        private void ShowSettingsMenu()
        {
            uiView.ShowMenuWindow(StateUI.SettingsPanel);
        }
    }
}