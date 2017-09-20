using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";

        private Player _player;

        public SuperAdventure(bool newGameStarted)
        {
            InitializeComponent();

            if (newGameStarted)
            {
                try
                {
                    File.Delete(PLAYER_DATA_FILE_NAME);
                }
                catch
                {
                    //do nothing to avoid error
                }
            }

            if (File.Exists(PLAYER_DATA_FILE_NAME))
            {
                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
            }
            else
            {
                _player = Player.CreateDefaultPlayer();
            }

            lblHitPoints.DataBindings.Add("Text", _player, "CurrentHitPoints");
            lblGold.DataBindings.Add("Text", _player, "Gold");
            lblExperience.DataBindings.Add("Text", _player, "ExperiencePoints");
            lblLevel.DataBindings.Add("Text", _player, "Level");

            dgvInventory.RowHeadersVisible = false;
            dgvInventory.AutoGenerateColumns = false;

            dgvInventory.DataSource = _player.Inventory;

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 209,
                DataPropertyName = "Description"
            });

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });

            dgvQuests.RowHeadersVisible = false;
            dgvQuests.AutoGenerateColumns = false;

            dgvQuests.DataSource = _player.Quests;

            dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 209,
                DataPropertyName = "Name"
            });

            dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Done?",
                DataPropertyName = "IsCompleted"
            });

            cboWeapons.DataSource = _player.Weapons;
            cboWeapons.DisplayMember = "Name";
            cboWeapons.ValueMember = "Id";

            if (_player.CurrentWeapon != null)
            {
                cboWeapons.SelectedItem = _player.CurrentWeapon;
            }

            cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;

            cboSecondaryItem.DataSource = _player.SecondaryItem;
            cboSecondaryItem.DisplayMember = "Name";
            cboSecondaryItem.ValueMember = "Id";

            _player.PropertyChanged += PlayerOnPropertyChanged;
            _player.OnMessage += DisplayMessage;

            _player.MoveTo(_player.CurrentLocation);
        }

        private void DisplayMessage(object sender, MessageEventArgs messageEventArgs)
        {
            rtbMessages.Text += messageEventArgs.Message + Environment.NewLine;

            if (messageEventArgs.AddExtraNewLine)
            {
                rtbMessages.Text += Environment.NewLine;
            }

            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private void PlayerOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Weapons")
            {
                cboWeapons.DataSource = _player.Weapons;

                if (!_player.Weapons.Any())
                {
                    cboWeapons.Visible = false;
                    btnUseWeapon.Visible = false;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "SecondaryItem")
            {
                cboSecondaryItem.DataSource = _player.SecondaryItem;

                if (!_player.SecondaryItem.Any())
                {
                    cboSecondaryItem.Visible = false;
                    btnUseSecondaryItem.Visible = false;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "CurrentLocation")
            {
                // Show/hide available movement buttons
                btnNorth.Visible = (_player.CurrentLocation.LocationToNorth != null);
                btnEast.Visible = (_player.CurrentLocation.LocationToEast != null);
                btnSouth.Visible = (_player.CurrentLocation.LocationToSouth != null);
                btnWest.Visible = (_player.CurrentLocation.LocationToWest != null);
                btnTrade.Visible = (_player.CurrentLocation.VendorWorkingHere != null);

                // Display current location name and description
                rtbLocation.Text = _player.CurrentLocation.Name + Environment.NewLine;
                rtbLocation.Text += _player.CurrentLocation.Description + Environment.NewLine;

                if (!_player.CurrentLocation.HasAMonster)
                {
                    cboWeapons.Visible = false;
                    cboSecondaryItem.Visible = false;
                    btnUseWeapon.Visible = false;
                    btnUseSecondaryItem.Visible = false;
                }
                else
                {
                    cboWeapons.Visible = _player.Weapons.Any();
                    cboSecondaryItem.Visible = _player.SecondaryItem.Any();
                    btnUseWeapon.Visible = _player.Weapons.Any();
                    btnUseSecondaryItem.Visible = _player.SecondaryItem.Any();
                }
            }
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            _player.MoveNorth();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            _player.MoveEast();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            _player.MoveSouth();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            _player.MoveWest();
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            TradingScreen tradingScreen = new TradingScreen(_player);
            tradingScreen.StartPosition = FormStartPosition.CenterParent;
            tradingScreen._currentPlayer = _player;
            tradingScreen.ShowDialog(this);
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            // Get the currently selected weapon from the cboWeapons 
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            if (currentWeapon.MinLevel > _player.Level)
            {
                _player.RaiseMessage("You can't use this weapon.");
                _player.RaiseMessage("You need to be level " + currentWeapon.MinLevel + ".");
            }
            else
            {
                _player.UseWeapon(currentWeapon);
            }
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            //TODO check if potion or damage scroll or what
            SecondaryItem secondaryItem = ((SecondaryItem)cboSecondaryItem.SelectedItem);

            if(secondaryItem.isPotion == true)
            {
                // Get the currently selected potion from the combobox
                HealingPotion potion = (HealingPotion)cboSecondaryItem.SelectedItem;

                if(potion.MinLevel > _player.Level)
                {
                    _player.RaiseMessage("You can't drink this potion.");
                    _player.RaiseMessage("You need to be level " + potion.MinLevel + ".");
                    return;
                }
                _player.UsePotion(potion);
            }
            else if (secondaryItem.isMagic == true)
            {
                DamageMagicScroll scroll = (DamageMagicScroll)secondaryItem;

                if (scroll.MinLevel > _player.Level)
                {
                    _player.RaiseMessage("You can't cast this spell.");
                    _player.RaiseMessage("You need to be level " + scroll.MinLevel + ".");
                    return;
                }
                _player.UseScroll(scroll);
            }

            else
            {
                _player.RaiseMessage("Bug: This item isn't an item type at all!");
            }


        }

        private void SuperAdventure_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());
        }

        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentWeapon = (Weapon)cboWeapons.SelectedItem;
        }

        private void cboSecondaryItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentSecondaryItem = (SecondaryItem)cboSecondaryItem.SelectedItem;
        }
    }
}