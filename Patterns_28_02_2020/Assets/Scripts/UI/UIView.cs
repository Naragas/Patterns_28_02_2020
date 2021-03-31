using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
        internal sealed class UIView : MonoBehaviour
        {
            [SerializeField] private MenuPannel _menuPannel;
            [SerializeField] private SettingsPanel _settingsPanel;
            [SerializeField] private GameObject _score;

            private Text _scoreText;

            
            //private readonly Stack<StateUI> _stateUi = new Stack<StateUI>();
            private BaseUI _currentPanel;

            private void Start()
            {
                
                _settingsPanel.uiView = this;   
                _menuPannel.uiView = this;
                _settingsPanel.Hide();
                _menuPannel.Hide();
                _scoreText = _score.GetComponent<Text>();
            }

            public void ShowMenuWindow(StateUI _stateUi)
            {

                if (_currentPanel != null)
                {
                    _currentPanel.Hide();
                }

                switch (_stateUi)
                {
                    case StateUI.MenuPanel:
                        _currentPanel = _menuPannel;
                        break;
                    case StateUI.SettingsPanel:
                        _currentPanel = _settingsPanel;
                        break;
                }
                
                _currentPanel.Show();
            }

            public void SetScore(string score)
            {
                _scoreText.text = score;
            }
        }
        

    
}