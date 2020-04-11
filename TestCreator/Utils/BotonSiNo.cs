using System.Drawing;
using System.Windows.Forms;
using static TestCreator.Properties.Resources;

namespace TestCreator.Utils
{
    public class BotonSiNo
    {
        Image BotonSi { get; set; }
        Image BotonNo { get; set; }
        public bool BoolInterruptor { get; set; }

        public BotonSiNo()
        {
            BotonSi = icons8_alternar_encendido_text_si_96;
            BotonNo = icons8_alternar_apagado_text_no_96;
            BoolInterruptor = true;
        }

        public void Interruptor(PictureBox picture)
        {
            if (picture != null)
            {
                BoolInterruptor = !BoolInterruptor;
                picture.Image = BoolInterruptor ? BotonSi : BotonNo;
            }
        }
    }
}
