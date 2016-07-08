using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenère_Chiffre
{
    public partial class Vigenere : Form
    {
        //Globale Variabeln
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); //Alphabet Array für Ver- / Entschlüsselung

        public Vigenere()
        {
            InitializeComponent();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            //Variabeln
            string text_input = box_input.Text.ToUpper(); //Speichere Eingabe Text in Variable und transferiere alles in Großbuchstaben
            string text_output = ""; //Lege Variable für Ausgabe Text fest
            char[] text_chars = text_input.ToCharArray(); //Wandle 'Text Eingabe String'(text_input) in Char Array (Array das aus den Zeichen des Strings besteht) um
            char[] text_key = box_key.Text.ToUpper().ToCharArray(); //Speichere Schlüssel in char Array und transferiere alles in Großbuchstaben
            int[] num_key = new int[text_key.Length]; //Erstelle leeres Array für Schlüssel in Zahlen

            //transferiere Schlüsselbuchstaben in Zahlen, die die Verschiebung der Buchstaben im Alphabet angeben
            for (int i = 0; i < text_key.Length; i++)
            {
                num_key[i] = Array.IndexOf(alphabet, text_key[i]);
            }

            //Ver- & Entschlüsselung
            int num_key_index = 0; //Variabel für den Index des Schlüsselbuchstabens 
            for (int i = 0; i < text_chars.Length; i++)
            {
                char curChar = text_chars[i];
                bool charInArray = Array.Exists(alphabet, element => element == curChar); //Bool ob char im Alphabet ist oder nicht

                if (charInArray) //Char ist im Alphabet vorhanden und wird verschlüsselt
                {
                    int curChar_Index = Array.IndexOf(alphabet, curChar); //Wandle Zeichen aus dem Char Array in Alphabet Nummer um (A=0, B=1, C=2, ...)
                    int verschiebung = num_key[num_key_index]; //Lege Verschiebung für Buchstaben fest
                    int newCharNum = 0; //Variable für Char Nummber die Verschlüsselt bzw Entschlüsselt wurde

                    //Verschiebe Buchstabe im Alphabet um den Faktor 'key' (A+2=C, wird hier jedoch in Zahlen gemacht also: 0+2 = 2 -> C)
                    //Text wird Entschlüsselt
                    if (rad_decrypt.Checked == true && rad_encrypt.Checked == false) //Überprüfen welcher RadioButton ausgewählt wurde
                    {
                        newCharNum = (26 + (curChar_Index - verschiebung)) % 26; //Verschiebung des Buchstabens um 'verschiebung' nach links
                    }
                    //Text wird Verschlüsselt
                    else if (rad_decrypt.Checked == false && rad_encrypt.Checked == true) //Überprüfen welcher RadioButton ausgewählt wurde
                    {
                        newCharNum = (curChar_Index + verschiebung) % 26; //Verschiebung des Buchstabens um 'verschiebung' nach rechts
                    }

                    text_output += alphabet[Convert.ToInt32(newCharNum)]; //text_output String wird um das verschlüsselte Zeichen verlängert

                    //Verschiebung für nächsten Buchstaben anhand des Schlüssels bestimmen
                    if (num_key_index < text_key.Length - 1)
                    {
                        num_key_index++; //Nachster Buchstabe des Schlüssels wird für Verschiebung verwendet
                    }
                    else
                    {
                        num_key_index = 0; //Trifft max. länge des Schlüssels => Schlüssel wird wieder von 0 benutzt
                    }
                }
                else //Char ist im Alphabet nicht vorhanden und wird nicht verschlüsselt
                {
                    //Leer-, Satz- und Sonderzeichen "verbrauchen" Schlüsselbuchstaben
                    if (check_settings.Checked)
                    {
                        if (num_key_index < text_key.Length - 1)
                        {
                            num_key_index++; //Nachster Buchstabe des Schlüssels wird für Verschiebung verwendet
                        }
                        else
                        {
                            num_key_index = 0; //Trifft max. länge des Schlüssels => Schlüssel wird wieder von 0 benutzt
                        }
                    }

                    text_output += curChar; //text_output String wird um das unverschlüsselte Zeichen verlängert, da es nicht im Standardalphabet vorhanden ist
                }
            }

            box_output.Text = text_output;//Text in Text_Box einfügen
        }
    }
}
