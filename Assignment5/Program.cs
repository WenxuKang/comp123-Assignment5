﻿using Assignment5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public static class Program
    {
        //static numbers
        public static StartForm startForm;
        public static SplashForm splashForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm; 



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate all forms
            startForm = new StartForm();
            splashForm = new SplashForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            Application.Run(new StartForm());
        }
    }
}
