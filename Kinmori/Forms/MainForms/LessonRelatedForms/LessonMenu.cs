﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinmori.Forms.MainForms.LessonRelatedForms
{
    public partial class LessonMenu : Form
    {
        public LessonMenu()
        {
            InitializeComponent();
            LessonCreator creator = new LessonCreator();
            this.Hide();
            creator.ShowDialog();
        }
    }
}
