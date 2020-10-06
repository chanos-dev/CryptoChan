using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptChan
{
    public partial class FormDashBoard : UserControl
    {
        const int PANEL_TOP = 298;

        Timer timer;
        object _thislock = new object();

        public FormDashBoard()
        {
            InitializeComponent();
            InitializeControl();

            this.SetStyle(ControlStyles.DoubleBuffer | 
                          ControlStyles.UserPaint | 
                          ControlStyles.AllPaintingInWmPaint, true);

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.UpdateStyles();
             
        }

        private void InitializeControl()
        {
            SettingLabel();

            timer = new Timer(); 
            timer.Interval = 1000;
            timer.Tick += (sender, e) =>
            {
                SettingLabel();

                DB db = new DB();

                try
                {
                    if (db.ConnectionDataBase())
                    {
                        List<string> files = db.GetCurrentFiles();

                        if(files.Count != 0)
                        { 
                            int label_i = 1;

                            foreach (string file in files)
                            {
                                Controls.Find($"label_task{label_i}", true).FirstOrDefault().Text = $"{label_i}. {file}";
                                label_i++;
                            } 
                        }

                        Dictionary<string, int> totalFiles = db.GetTotalFiles();

                        if(totalFiles.Count != 0)
                        {
                            int label_i = 1;
                            int panel_i = 1;
                            int height; 

                            int maxFiles = totalFiles.Values.Max();

                            string sub_title = string.Empty;

                            foreach (var file in totalFiles)
                            {
                                if (file.Value == 1)
                                    sub_title = "file";
                                else
                                    sub_title = "files";                                

                                Controls.Find($"label_total{label_i}", true).FirstOrDefault().Text = $"{file.Key} : {file.Value} {sub_title}";

                                Controls.Find($"label_stick{label_i}", true).FirstOrDefault().Text = $"{file.Key}";

                                if (file.Value == maxFiles)
                                    Controls.Find($"label_total{label_i}", true).FirstOrDefault().ForeColor = Color.LightCoral;
                                else
                                    Controls.Find($"label_total{label_i}", true).FirstOrDefault().ForeColor = Color.Silver; 

                                height = file.Value * 2; 

                                Controls.Find($"panel_stick{panel_i}", true).FirstOrDefault().Height = height;
                                Controls.Find($"panel_stick{panel_i}", true).FirstOrDefault().Top = PANEL_TOP - height;

                                label_i++;
                                panel_i++;
                            } 
                        }
                    }
                    else
                    {
                        SettingLabel();
                    }
                }
                finally
                {
                    db.CloseConnection();
                }
            };

            timer.Start(); 
        }

        private void SettingLabel()
        {
            int label_i;
            int panel_i;

            for (label_i = 1; label_i <= 6; label_i++)
            {                
                Controls.Find($"label_task{label_i}",true).FirstOrDefault().Text = $"{label_i}. -";
            }

            for (label_i = 1; label_i <= 5; label_i++)
            {
                Controls.Find($"label_total{label_i}", true).FirstOrDefault().Text = "-";
                Controls.Find($"label_total{label_i}", true).FirstOrDefault().ForeColor = Color.Silver;
            }

            for (label_i = 1; label_i <= 5; label_i++)
            {
                Controls.Find($"label_stick{label_i}", true).FirstOrDefault().Text = "-";
            }

            for (panel_i = 1; panel_i <= 5; panel_i++)
            {
                Controls.Find($"panel_stick{panel_i}", true).FirstOrDefault().Height = 0;
                Controls.Find($"panel_stick{panel_i}", true).FirstOrDefault().Top = PANEL_TOP;
            }
        }
    }

    //class Custom_Panel : Panel
    //{
    //    public Custom_Panel() 
    //    { 
    //        this.SetStyle(ControlStyles.OptimizedDoubleBuffer | 
    //                      ControlStyles.UserPaint | 
    //                      ControlStyles.AllPaintingInWmPaint, true); 

    //        this.UpdateStyles(); 
    //    } 
    //}
}
