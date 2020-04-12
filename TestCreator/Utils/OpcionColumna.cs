using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreator.Utils
{
    public static class OpcionColumna
    {
        public static void ActvarElementos(RadioButton radioColumna, NumericUpDown numeric) 
        {
            if(radioColumna != null && numeric != null)
            {
                if(radioColumna.Checked)
                {
                    numeric.Enabled = true;
                }
                else
                {
                    numeric.Enabled = false;
                }
            }
        }

        public static void ActvarElementos(RadioButton radioColumna, NumericUpDown numeric1, NumericUpDown numeric2, NumericUpDown numeric3)
        {
            if (radioColumna != null && numeric1 != null && numeric2 != null && numeric3 != null)
            {
                if (radioColumna.Checked)
                {
                    numeric1.Enabled = true;
                    numeric2.Enabled = true;
                    numeric3.Enabled = true;
                }
                else
                {
                    numeric1.Enabled = false;
                    numeric2.Enabled = false;
                    numeric3.Enabled = false;
                }
            }
        }

        public static void ColumnasResultantes(NumericUpDown numeric, Label label)
        {
            int offsetText = 9;
            if(numeric != null && label != null)
            {
                switch (numeric.Value)
                {
                    case 1:
                        label.Text = "a)\nb)";
                        break;
                    case 2:
                        label.Text = "a)".PadRight(offsetText) + "c)\n" + "b)".PadRight(offsetText) + "d)";
                        break;
                    case 3:
                        label.Text = "a)".PadRight(offsetText) + "c)".PadRight(offsetText) + "e)\n" + "b)".PadRight(offsetText) + "d)".PadRight(offsetText) + "f)";
                        break;
                    case 4:
                        label.Text = "a)".PadRight(offsetText) + "c)".PadRight(offsetText) + "e)".PadRight(offsetText) + "g)\n" + "b)".PadRight(offsetText) + "d)".PadRight(offsetText) + "f)".PadRight(offsetText+1) + "h)";
                        break;
                    default:
                        break;
                }

            }
        }
        public static void ColumnasSolucion(NumericUpDown numeric, Label label)
        {
            int offsetText = 11;
            if (numeric != null && label != null)
            {
                switch (numeric.Value)
                {
                    case 1:
                        label.Text = "1.a\n2.b";
                        break;
                    case 2:
                        label.Text = "1.a".PadRight(offsetText) + "3.c\n" + "2.b".PadRight(offsetText) + "4.d";
                        break;
                    case 3:
                        label.Text = "1.a".PadRight(offsetText) + "3.c".PadRight(offsetText) + "5.c\n" + "2.b".PadRight(offsetText) + "4.d".PadRight(offsetText) + "6.d";
                        break;
                    case 4:
                        label.Text = "1.a".PadRight(offsetText) + "3.c".PadRight(offsetText) + "5.c".PadRight(offsetText) + "7.a\n" + "2.b".PadRight(offsetText) + "4.d".PadRight(offsetText) + "6.d".PadRight(offsetText) + "8.c";
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
