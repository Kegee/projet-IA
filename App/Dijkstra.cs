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

namespace App
{
    public partial class Dijkstra : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;
        static public int etapeCorrection = 0;  //existe pour donner au correcteur le moyen de savoir à quelle ligne il doit comparer.
        static public List<bool> justeOuPas; // si verification donne que le resultat est juste : justeoupas.append(true) sinon justeoupas.append(false);
        public Dijkstra()
        {
            InitializeComponent();
            initialisationMatrice();
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);
            g.GetVoidSearchTree(trvTravail);

            trvTravail.LabelEdit = true;
        }

        private void btnCorrection_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);
            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }
            g.GetSearchTree(treeView1);

            CompareTreeNodes(trvTravail, treeView1);
        }

        private void initialisationMatrice()
        {
            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a la tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }

        private void btnValideEtape_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            lbFerme.Items.Add(txtBFerme.Text);
            lbOuvert.Items.Add(txtBOuvert.Text);
            justeOuPas = new List<bool>();
            SearchTree validation = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;

            // On vérifie si les ouverts et les fermés donnés sont bien les mêmes à l'étape donné
            if (validation.RechercheSolutionAEtoileValidation(N0, etapeCorrection, txtBOuvert.Text, txtBFerme.Text)) justeOuPas.Add(true);
            else justeOuPas.Add(false);

            etapeCorrection++; //existe pour donner au correcteur le moyen de savoir à quelle ligne il doit comparer.
            txtBFerme.Text = "";  // On nettoie la zone de travail
            txtBOuvert.Text = "";
        }

        private void btnValideExercice_Click(object sender, EventArgs e)
        {
            bool resultat = true;
            foreach (bool verification in justeOuPas) if (!verification) resultat = false;

            if (resultat)
            {
                txtBResultat.ForeColor = Color.Green;
                txtBResultat.Text = "Bravo, vous avez réussi !";
            }
            else
            {
                txtBResultat.ForeColor = Color.Red;
                txtBResultat.Text = "Dommage, vous avez fait une erreur...";
            }
            //etapeCorrection = 0;
        }

        private void btnNettoyer_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            listBox1.Items.Clear();
            lbFerme.Items.Clear();
            lbOuvert.Items.Clear();
            txtBFerme.Text = "";
            txtBOuvert.Text = "";
            txtBResultat.Text = "";
            etapeCorrection = 0;
        }
        void CompareRecursiveTree(TreeNode tn1, TreeNode tn2)
        {
            if (tn1.Text != tn2.Text)
            {
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Red;
            }
            else
            {
                tn1.ForeColor = Color.Green;
                tn2.ForeColor = Color.Green;
            }
            int compare = Math.Min(tn1.Nodes.Count, tn2.Nodes.Count);
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i]);
            }
        }
        void CompareTreeNodes(TreeView tv1, TreeView tv2)
        {
            int compare = Math.Min(tv1.Nodes.Count, tv2.Nodes.Count);
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tv1.Nodes[i], tv2.Nodes[i]);
            }

        }
    }
}
