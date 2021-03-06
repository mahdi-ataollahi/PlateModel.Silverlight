﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PlateModel.Silverlight.Plates.Iran
{
    [ContentProperty("Plate")]
    public partial class SepahPlate : UserControl
    {
        #region Plate
        public readonly static DependencyProperty PlateProperty = DependencyProperty.Register("Plate", typeof(string), typeof(SepahPlate),
            new PropertyMetadata("", (obj, e) =>
            {
                var ir_plate = obj as SepahPlate;

                ir_plate.ResetPlate();

                if (e.NewValue != null)
                {
                    string plate = e.NewValue.ToString().Replace("_", "").Replace("-", "").Replace(",", "").Replace(".", "").ToUpper()
                        .Replace("P","");

                    if (plate.Length > 0)
                    {
                        int i = 0;
                        int l = plate.Length;

                        ir_plate.digit1.Text = plate[i].ToString();
                        if (++i >= l) return;

                        ir_plate.digit2.Text = plate[i].ToString();
                        if (++i >= l) return;

                        ir_plate.digit3.Text = plate[i].ToString();
                        if (++i >= l) return;

                        ir_plate.digit4.Text = plate[i].ToString();
                        if (++i >= l) return;

                        ir_plate.digit5.Text = plate[i].ToString();
                        if (++i >= l) return;

                        ir_plate.top_digit1.Text = plate[i].ToString();
                        if (++i >= l) return;

                        ir_plate.top_digit2.Text = plate[i].ToString();
                    }
                }
            }));

        [Category("Common")]
        public string Plate
        {
            get { return (string)GetValue(PlateProperty); }
            set { SetValue(PlateProperty, value); }
        }
        #endregion

        public SepahPlate()
        {
            InitializeComponent();
        }

        #region ResetPlate
        void ResetPlate()
        {
            this.top_digit1.Text = "";
            this.top_digit2.Text = "";
            this.digit1.Text = "";
            this.digit2.Text = "";
            this.digit3.Text = "";
            this.digit4.Text = "";
            this.digit5.Text = "";
        }
        #endregion

    }
}
