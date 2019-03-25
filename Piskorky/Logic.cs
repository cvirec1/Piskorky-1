using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace Piskorky
{
    public static class Logic
    {
        public static int PocetHracov;
        public static string[,] Gameboard;
        public static int bod;
        public static string lastTick;

        public static void CreatePlayground(int _sizeArea)
        {
            string[,] HraciaPlocha = new string[_sizeArea, _sizeArea];
            Gameboard = HraciaPlocha;
            for (int i = 0; i < _sizeArea; i++)
            {
                for (int j = 0; j < _sizeArea; j++)
                {
                    Gameboard[i, j] = " ";
                }
            }
        }
                
        /// Manuálne klikanie do hracieho poľa
        /// </summary>
        /// <param name="lenght"></param>
        /// <param name="RowIndex"></param>
        /// <param name="ColIndex"></param>
        /// <param name="tick"></param>
        public static void AddTick(int lenght, int RowIndex, int ColIndex, string tick)
        {
            //vloženie ticku
            Gameboard[RowIndex, ColIndex] = tick;

            //zobrazenie v debug
            Debug.Write($"\n\nHráč: {tick}\n");
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Debug.Write(Gameboard[i, j]);
                }
                Debug.Write("\n");
            }
        }

        public static void AddTick(int RowIndex, int ColIndex, string tick)
        {
            //vloženie ticku
            Gameboard[RowIndex, ColIndex] = tick;
        }

        public static bool CheckWin(int lenght, string tick, int body)
        {
            //Zadefinovanie
            lastTick = tick;

            //Zistovanie vyhry po riadkoch
            #region
            //prechádzam riadky
            for (int i = 0; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[i, j] == tick)
                    {

                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        if (lastTick == tick)
                        {
                            bod++;
                            Debug.Write($"\nBody v riadku {i}: {bod}");
                            lastTick = tick;
                        }
                        else
                        {
                            lastTick = "";
                        }
                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
                bod = 0;
            }
            #endregion

            //Zistovanie vyhry po stĺpcoch
            #region 
            //prechádzam riadky
            for (int i = 0; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[j, i] == tick)
                    {
                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        if (lastTick == tick)
                        {
                            bod++;
                            Debug.Write($"\nBody v stĺpci {i}: {bod}");
                            lastTick = tick;
                        }
                        else
                        {
                            lastTick = "";
                        }
                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
                bod = 0;
            }
            #endregion

            //Zistovanie vyhry po diagonále zľava doprava
            #region 
            for (int i = 0; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[i, j] == tick)
                    {
                        bod = 0;
                        int k = i;
                        int l = j;
                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        do
                        {
                            //Prepožičal som hodnoty kde sa nachádza aktuálne check a pozerám, či sa vpravo dole diagonálne nič nenachádza
                            if (Gameboard[k, l] == tick)
                            {
                                bod++;
                                Debug.Write($"\nBody v diag L {i}: {bod}");
                            }
                            else
                            {
                                break;
                            }
                            k++;
                            l++;
                        } while (k < lenght && l < lenght);

                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
            }
            #endregion

            //Zistovanie vyhry po diagonále sprava dolava
            #region 
            for (int i = 0; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[i, j] == tick)
                    {
                        Debug.Write($"\nNašiel bod v diag P {i}{j}: {bod}");
                        int k = i;
                        int l = j;
                        bod = 0;
                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        do
                        {
                            //Prepožičal som hodnoty kde sa nachádza aktuálne check a pozerám, či sa vpravo dole diagonálne nič nenachádza
                            if (Gameboard[k, l] == tick)
                            {
                                bod++;
                                Debug.Write($"\nPokračuje v diag P {k}{l}: {bod}");
                            }
                            else
                            {
                                break;
                            }
                            k++;
                            l--;
                        } while (k < lenght && l < lenght && l >= 0);

                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
            }
            #endregion

            //Nulovanie bodov po každom riadku
            bod = 0;
            lastTick = "";
            return false;
        }

        /// <summary>
        /// Získaj pole gameboardu
        /// </summary>
        /// <param name="dlzka"></param>
        /// <returns></returns>
        public static string[,] GetGameboard(int dlzka)
        {
            string[,] board = new string[dlzka, dlzka];
            for (int i = 0; i < dlzka; i++)
            {
                for (int j = 0; j < dlzka; j++)
                {
                    board[i, j] = Gameboard[i, j];
                }
            }
            return board;
        }
    }
}

