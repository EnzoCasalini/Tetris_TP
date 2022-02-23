using System;
using System.Drawing;

namespace Tetris_Toxiques
{
	public class Shape
	{
		// Les formes que nous créerons auront une hauteur et une largeur. Il faut aussi un tableau de case pour savoir quelles cases sont remplies par la forme.
		public int width;
		public int height;
		public int[,] cases;
		private int[,] backupCases;

		// Gestion de la couleur.
		public Brush color;

		// Cette méthode nous permettra de tourner la forme.
		public void turn()
        {
			// On fait une copie du tableau contenant les 0 et 1 de la forme afin de pouvoir revenir à la disposition précédente en cas de problème.
			backupCases = cases;

			cases = new int[width,height];
			for (int i = 0; i < width; i++)
            {
				for (int j = 0; j < height; j++)
                {
					// Ici, j'ai effectué de nombreux de tests pour bien comprendre ce qu'il se passait.
					// Déjà, on inverse i et j dans le cases[j,i] parce que, une fois la rotation effectuée, la largeur et la hauteur sont inversées.
					// Après, on peut mettre différentes choses dans le backupCases en fonction de ce qu'on souhaite faire, ici on faire une rotation vers la droite.
					// Par exemple, si on veut faire une rotation sur la gauche, il faudrait avoir ça : backupCases[i, width - 1 - j];
					cases[i, j] = backupCases[height - 1 - j, i];
                }
            }

			// On inverse la hauteur et la largeur puisqu'on a fait tourner la forme.
			var temp = height;
			height = width;
			width = temp;
        }

		// Cette méthode nous permettra de revenir en arrière si jamais le joueur veut tourner la forme mais que c'est impossible.
		public void rollback()
        {
			cases = backupCases;

			var temp = height;
			height = width;
			width = temp;
        }
	}
}

