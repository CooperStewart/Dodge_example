﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge_example
{
    class Titan2
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle titanrec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Titan2(int spacing)
        {
            x = spacing;
            y = 180;
            width = 150;
            height = 180;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.planet1;
            titanrec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawTitan2(Graphics g)
        {

            g.DrawImage(planetImage, titanrec);
            titanrec = new Rectangle(x, y, width, height);
        }
        public void MoveTitan2()
        {

            titanrec.Location = new Point(y, x -10);
        }
        public void ChangeSprite()
        {
            planetImage = Properties.Resources.planet1;

        }
        public void ChangeSprite2()
        {
            planetImage = Properties.Resources.planet1;

        }

    }
}
