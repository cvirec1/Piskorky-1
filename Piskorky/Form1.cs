﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskorky
{
    public partial class Form1 : Form
    {
        private int sizeArea = 0;
        public int _players = 0;
        public int _body = 3;
        public string _playerName = "";
        string tick;
        public int lastMove = 0;
        public int RowIndex = 0;
        public int ColIndex = 0;

        public int SizeArea { get => GetPointsToWin(); set => sizeArea = value; }

        public Form1()
        {
            InitializeComponent();            
            //počiatočné stavy
            cbPlayer1.SelectedIndex = 0;
            cbPlayer2.SelectedIndex = 1;
            cbPlayer3.SelectedIndex = 2;
            cbPlayer4.SelectedIndex = 3;
            cbWin.SelectedIndex = 0;
            cbSize.SelectedIndex = 0;
            cbNumPlayer.SelectedIndex = 0;
        }

        public int GetArenaAray()
        {
            string playArenaText = cbSize.SelectedItem.ToString();
            return int.Parse(playArenaText.Remove(1));
        }

        public int GetPointsToWin()
        {
            string pointsToWin = cbWin.SelectedItem.ToString();
            return int.Parse(pointsToWin);
        }

        public int Players()
        {
            string players = cbNumPlayer.SelectedItem.ToString();
            return int.Parse(players);
        }

        public int Player1()
        {
            return cbPlayer1.SelectedIndex;
        }

        public int Player2()
        {
            return cbPlayer2.SelectedIndex;
        }

        public int Player3()
        {
            return cbPlayer3.SelectedIndex;
        }

        public int Player4()
        {
            return cbPlayer4.SelectedIndex;
        }
               

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Vynulujem si debug lbl pre ďalšie informácie
            lblDebug.Text = "";

            //nastavím správne body
            string tickToWint = cbWin.SelectedItem.ToString();
            _body = int.Parse(tickToWint);


            //Pozerám sa, či políčko je už obsadené
            if (dgwPlayground.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                //Ak políčko nie je obsadené, idem ho obsadiť
                switch (lastMove % _players)
                {
                    case 0:
                        {
                            dgwPlayground.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbPlayer1.SelectedItem;
                            tick = cbPlayer1.SelectedItem.ToString();
                            _playerName = "1";
                        }
                        break;
                    case 1:
                        {
                            dgwPlayground.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbPlayer2.SelectedItem;
                            tick = cbPlayer2.SelectedItem.ToString();
                            _playerName = "2";
                        }
                        break;
                    case 2:
                        {
                            dgwPlayground.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbPlayer3.SelectedItem;
                            tick = cbPlayer3.SelectedItem.ToString();
                            _playerName = "3";
                        }
                        break;
                    case 3:
                        {
                            dgwPlayground.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbPlayer4.SelectedItem;
                            tick = cbPlayer4.SelectedItem.ToString();
                            _playerName = "4";
                        }
                        break;
                }

                //obsadenie políčka do logiky
                int RowIndex = e.RowIndex;
                int ColIndex = e.ColumnIndex;
                Logic.AddTick(SizeArea, RowIndex, ColIndex, tick);

                //Pozriem sa, či už hráč vyhral
                if (Logic.CheckWin(SizeArea, tick, _body))
                {
                    lblDebug.Visible = true;
                    lblDebug.ForeColor = Color.Black;

                    lblDebug.Text = $"Vyhráva hráč č.{_playerName} so znakom {tick}";
                    dgwPlayground.CancelEdit();
                    dgwPlayground.ReadOnly = false;

                }

                //posuniem na ďalšieho hráča
                lastMove++;
                lblTick.Text = lastMove.ToString();
            }

            //ošetrenie že dané políčko je už obsadené
            else
            {
                lblDebug.ForeColor = Color.Red;
                lblDebug.Text = "Toto políčko je už obsadené";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            //vyčistím si plochu
            dgwPlayground.Columns.Clear();
            dgwPlayground.Rows.Clear();
            lblDebug.Text = "";
            lblTick.Text = "";

            //lastmove nastavím na nula
            lastMove = 0;

            //vytiahnem si veľkosť plochy
            string playArenaText = cbSize.SelectedItem.ToString();
            int _playArea = int.Parse(playArenaText.Remove(1));

            //vytvorím si hraciu plochu v datagridview
            for (int i = 0; i < _playArea; i++)
            {
                dgwPlayground.Columns.Add("i", $"{i}");
            }
            for (int i = 0; i < _playArea-1; i++)
            {
                dgwPlayground.Rows.Add();
            }

            //vytvorím si plochu v logike
            Logic.CreatePlayground(_playArea);

            //vytiahnem si na koľko sa má vyhrať
            string tickToWint = cbWin.SelectedItem.ToString();
            _body = int.Parse(tickToWint);

        }

        private void cbNumPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PlayersText = cbNumPlayer.SelectedItem.ToString();
            _players = int.Parse(PlayersText);

            switch (_players)
            {

                case 2:
                    lbPlayer2.Visible = true;
                    lbPlayer3.Visible = false;
                    lbPlayer4.Visible = false;
                    cbPlayer2.Visible = true;
                    cbPlayer3.Visible = false;
                    cbPlayer4.Visible = false;
                    break;
                case 3:
                    lbPlayer2.Visible = true;
                    lbPlayer3.Visible = true;
                    lbPlayer4.Visible = false;
                    cbPlayer2.Visible = true;
                    cbPlayer3.Visible = true;
                    cbPlayer4.Visible = false;
                    break;
                case 4:
                    lbPlayer2.Visible = true;
                    lbPlayer3.Visible = true;
                    lbPlayer4.Visible = true;
                    cbPlayer2.Visible = true;
                    cbPlayer3.Visible = true;
                    cbPlayer4.Visible = true;
                    break;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cbWin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string point = cbWin.SelectedItem.ToString();
            _body = int.Parse(point);
        }
    }
}
