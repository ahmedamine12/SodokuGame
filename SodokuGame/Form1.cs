using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            specificationCase();
            Commencer();


        }
        private void Commencer()
        {
            chargement_cases();
            blockerSomeCase(20);
            ViderSomeCase(18);
        }

        private void blockerSomeCase(int nbrCases)
        {
            for(int i =0; i < nbrCases;i++)
            {
                int x = random.Next(9);
                int y = random.Next(9);
                // travailler sur la case 
                matrice[x, y].Text = matrice[x, y].value.ToString();
                matrice[x, y].ForeColor = Color.Black;
                matrice[x, y].plein = true;


            }
        }
        private void ViderSomeCase(int nbrCases)
        {
            for (int i = 0; i < nbrCases; i++)
            {
                int x = random.Next(9);
                int y = random.Next(9);
                // travailler sur la case 
                matrice[x, y].Text = "";
                


            }
        }
        private void verifierButton_Click(object sender, EventArgs e)
        {
            var fauxcase = new List<Case>();

            // Parcourir toute la matrice et verifier
            foreach (var c in matrice)
            {
                if (!string.Equals(c.value.ToString(), c.Text))
                {
                    fauxcase.Add(c);
                }
            }

            // verifier est ce qu'il y des fautes sinon le joueur a gagné
            if (fauxcase.Any())
            {
                // Highlight the wrong inputs 
                fauxcase.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong inputs");
            }
            else
            {
                MessageBox.Show("felicitations tu as gagne");
            }
        }
        private void chargement_cases()
        {

            foreach (var c in matrice)
            {
                c.value = 0;
                c.Vide();
            }
            // l'apple de cette methode va ce refaire recurssivement pour chaque case
            trouveValNextCase(0, -1);
        }

        Random random = new Random();
        private bool trouveValNextCase(int i, int j)
        {
            // passer colone par colone et si on est dans la dernier colone 
            // on remis le j a 0 pour Commencer dans la ligne suivante
            if (++j > 8)
            {
                j = 0;

                // et on fini si on est dans la derniere ligne 
                if (++i > 8)
                    return true;

            }
            int val = 0;
            // une liste des nombre de 0 a 9 ou va choisir 
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // trouver une valuer aleatoir mais valide pour la case
            do
            {
                if (list.Count < 1)
                {
                    matrice[i, j].value = 0;
                    return false;

                }
                // choisir une valuer de la liste
                val = list[random.Next(0, list.Count)];
                matrice[i, j].value = val;
                // ensuite on supprime cette valuer de la liste
                list.Remove(val);
            } while (!ValeurValide(val, i, j) || !trouveValNextCase(i, j));

            matrice[i, j].Text = val.ToString();
            return true;
        }

        private bool ValeurValide(int val, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // verifier que val n'est pas repeter
                // dans la meme colone avec les diffrent ligne
                if (i != y && matrice[x, i].value == val)
                    return false;
                if (i != x && matrice[i, y].value == val)
                    return false;
            }
            // verifier dans la matrice 3*3
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && matrice[i, j].value == val)
                        return false;
                }
            }
            return true;
        }





        // creation de notre 81 case
        Case[,] matrice = new Case[9, 9];
        private void specificationCase()
        {
           for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create 81matrice for with styles and locations based on the index
                   matrice[i, j] = new Case();
                   matrice[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                   matrice[i, j].Size = new Size(40, 40);
                   matrice[i, j].ForeColor = SystemColors.ControlDarkDark;
                   matrice[i, j].Location = new Point(i * 40, j * 40);
                   matrice[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.Blue;
                   matrice[i, j].x = i;
                   matrice[i, j].y = j;

                    // Assign key press event for eachmatrice

                    matrice[i, j].KeyPress +=case_Clicked;
                    panel1.Controls.Add(matrice[i, j]);
                }    
        } 
    }
        private void case_Clicked( object sender , KeyPressEventArgs e)
        {
            var cellule = sender as Case;
            if (cellule.plein)// rien a faire
                return;
            // verifier que case est ramlie par un nombre 
            int verif;
            if(int.TryParse(e.KeyChar.ToString(),out verif))
            {
                if (verif == 0)
                    cellule.Vide();
                else
                    // remplir la case lorque on a verifie que l'entre est un nombre et c'est different de 0
                    cellule.Text = verif.ToString();

               

            }
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Commencer();
        }
    }
}
