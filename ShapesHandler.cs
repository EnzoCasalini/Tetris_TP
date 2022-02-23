using System;
using System.Drawing;

namespace Tetris_Toxiques
{
    // On met en static pour que le constructor soit forcément de type ShapesHandler.
    static class ShapesHandler
    {
        private static Shape[] shapesArray;
        
        // Tableau qui contient différentes couleurs pour l'aléatoire.
        //private static Brush[] colors = { Brushes.Lime, Brushes.Yellow, Brushes.Red, Brushes.DarkViolet, Brushes.Aqua, Brushes.DeepPink, Brushes.Snow };

        // Mettre le constructeur en static permet de forcer le type, ici ShapesHandler.
        static ShapesHandler()
        {
            // On crée les différents types de formes que l'on ajoute dans notre tableau shapesArray.
            shapesArray = new Shape[]
            {
                // Le carré.
                new Shape
                {
                    width = 2,
                    height = 2,
                    cases = new int[,]
                    {
                        { 1, 1 },
                        { 1, 1 }
                    },
                    color = Brushes.Red
                },
                // La barre verticale / horizontale.
                new Shape
                {
                    width = 1,
                    height = 4,
                    cases = new int[,]
                    {
                        { 1 },
                        { 1 },
                        { 1 },
                        { 1 }
                    },
                    color = Brushes.Lime
                },
                // La couronne.
                new Shape
                {
                    width = 3,
                    height = 2,
                    cases = new int[,]
                    {
                        { 0, 1, 0 },
                        { 1, 1, 1 }
                    },
                    color = Brushes.DeepSkyBlue
                },
                // Les L.
                new Shape
                {
                    width = 3,
                    height = 2,
                    cases = new int[,]
                    {
                        { 0, 0, 1 },
                        { 1, 1, 1 }
                    },
                    color = Brushes.Purple
                },
                new Shape
                {
                    width = 3,
                    height = 2,
                    cases = new int[,]
                    {
                        { 1, 0, 0 },
                        { 1, 1, 1 }
                    },
                    color = Brushes.Yellow
                },
                // Les serpents.
                new Shape
                {
                    width = 3,
                    height = 2,
                    cases = new int[,]
                    {
                        { 1, 1, 0 },
                        { 0, 1, 1 }
                    },
                    color = Brushes.DeepPink
                },
                new Shape
                {
                    width = 3,
                    height = 2,
                    cases = new int[,]
                    {
                        { 0, 1, 1 },
                        { 1, 1, 0 }
                    },
                    color = Brushes.DarkOrange
                }
            };
        }

        // Cette méthode permet de renvoyer une forme aléatoire du tableau créé juste au-dessus.
        public static Shape GetRandomShape()
        {
            var shape = shapesArray[new Random().Next(shapesArray.Length)];
            /*shape.color = GetColorRandomly();*/
            return shape;
        }

        /*public static Brush GetColorRandomly()
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, colors.Length);
            return colors[rand];
        }*/
    }
}

