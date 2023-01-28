using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENUCOMIDACHINA
{
    public partial class Form1 : Form
    {
        int baseTotal = 0;
        int toppingTotal = 0;
        int proteinaTotal = 0;
        int crujientesTotal = 0;
        int aderezosTotal = 0;
        bool b_ase = false;
        bool p_roteina = false;
        bool c_rujientes = false;
        bool f_altante = false;
        bool f_altantedos = false;
        string[] baseDescripcion = { "", "", "", ""};
        string[] toppingDescripcion = { "", "", "", "",""};
        string[] proteinaDescripcion = { "", "", "", "" };
        string[] crujientesDescripcion = { "", "", "", "" };
        string[] aderezosDescripcion = { "", "", "", "" };

        public Form1()
        {
            InitializeComponent();
        }

        private void ordenar_Click(object sender, EventArgs e)
        {

            if (baseTotal == 1)
            {
                avisoBase.Text = "BASE OK";
                b_ase = true;
            }
            else if (baseTotal == 0)
            {
                avisoBase.Text = "Tiene que elegir una base";
                b_ase = false;
            }
            else
            {
                avisoBase.Text = "Solo puede elegir una base";
                b_ase = false;
            }

            if (toppingTotal >= 1 && toppingTotal <= 3)
            {
                avisoTopping.Text = "TOPPING OK";
                f_altantedos = true;
            }
            else if (toppingTotal == 0)
            {
                avisoTopping.Text = "Tiene que elegir un topping";
                f_altantedos = false;
            }
            else
            {
                avisoTopping.Text = "Solo puede elegir 3 topping";
                f_altantedos = false;
            }
            if (proteinaTotal == 1)
            {
                avisoProteina.Text = "PROTEINA OK";
                p_roteina = true;
            }
            else if (proteinaTotal == 0)
            {
                avisoProteina.Text = "Tiene que elegir una proteina";
                p_roteina = false;
            }
            else
            {
                avisoProteina.Text = "Solo puede elegir una proteina";
                p_roteina = false;
            }
            if (crujientesTotal >= 1 && crujientesTotal <= 2)
            {
                avisoCrujientes.Text = "CRUJIENTES OK";
                c_rujientes = true;
            }
            else if (crujientesTotal == 0)
            {
                avisoCrujientes.Text = "Tiene que elegir dos crujientes";
                c_rujientes = false;
            }
            else
            {
                avisoCrujientes.Text = "Solo puede elegir dos crujientes";
                c_rujientes = false;
            }
            if (aderezosTotal >= 1 && aderezosTotal <= 2)
            {
                avisoAderezos.Text = "ADEREZOS OK";
                f_altante = true;
            }
            else if (aderezosTotal == 0)
            {
                avisoAderezos.Text = "Tiene que elegir un aderezo";
                f_altante = false;
            }
            else
            {
                avisoAderezos.Text = "Solo puede elegir dos aderezos";
                f_altante = false;
            }

            if (b_ase == true && f_altantedos == true && p_roteina == true && c_rujientes == true && f_altante == true)
            {
                MessageBox.Show("Tu orden ha sido generada");
                string ordenBase = "";
                for (int i=0; i<4; i++)
                {
                    if (baseDescripcion[i] != "")
                    {
                        ordenBase = ordenBase + baseDescripcion[i];
                    }
                }
                string ordenTopping = "";
                for (int i=0; i<5;i++)
                {
                    if (toppingDescripcion[i] != "")
                    {
                        ordenTopping = ordenTopping + "\n" + toppingDescripcion[i];
                    }
                }
                string ordenProteina = "";
                for (int i = 0; i < 4; i++)
                {
                    if (proteinaDescripcion[i] != "")
                    {
                        ordenProteina = ordenProteina + "\n" +proteinaDescripcion[i];
                    }
                }
                string ordenCrujientes = "";
                for (int i = 0; i < 4; i++)
                {
                    if (crujientesDescripcion[i] != "")
                    {
                        ordenCrujientes = ordenCrujientes + "\n" + crujientesDescripcion[i];
                    }
                }
                string ordenAderezos = "";
                for (int i = 0; i < 4; i++)
                {
                    if (aderezosDescripcion[i] != "")
                    {
                        ordenAderezos = ordenAderezos + "\n" + aderezosDescripcion[i];
                    }
                }
                MessageBox.Show("Base:\n" + ordenBase + "\n\n  Topping:" + ordenTopping + "\n\n Proteina:" + ordenProteina + "\n\n Crujiente:" + ordenCrujientes + "\n\n Aderezos:" + ordenAderezos);
            }
        }

        private void arroz_CheckedChanged(object sender, EventArgs e)
        {
            if (arroz.CheckState == CheckState.Checked)
            {
                baseTotal++;
                baseDescripcion[0] = "Arroz";
            }
            else
            {
                baseTotal--;
                baseDescripcion[0] = "";
            }
        }

        private void tallarines_CheckedChanged(object sender, EventArgs e)
        {
            if (tallarines.CheckState == CheckState.Checked)
            {
                baseTotal++;
                baseDescripcion[1] = "Tallarines";
            }
            else
            {
                baseTotal--;
                baseDescripcion[1] = "";
            }
        }

        private void fideosdepepino_CheckedChanged(object sender, EventArgs e)
        {
            if (fideosdepepino.CheckState == CheckState.Checked)
            {
                baseTotal++;
                baseDescripcion[2] = "Fideos de pepino";
            }
            else
            {
                baseTotal--;
                baseDescripcion[2] = "";
            }
        }

        private void lechuga_CheckedChanged(object sender, EventArgs e)
        {
            if (lechuga.CheckState == CheckState.Checked)
            {
                baseTotal++;
                baseDescripcion[3] = "Lechuga";
            }
            else
            {
                baseTotal--;
                baseDescripcion[3] = "";
            }
        }

        private void mango_CheckedChanged(object sender, EventArgs e)
        {
            if (mango.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[0] = "Mango";
            }
            else
            {
                toppingTotal--;
                toppingDescripcion[0] = "";
            }
        }

        private void durazno_CheckedChanged(object sender, EventArgs e)
        {
            if (durazno.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[1] = "Durazno";
            }
            else
            {
                toppingTotal--;
                toppingDescripcion[1] = "";
            }
        }

        private void tomate_CheckedChanged(object sender, EventArgs e)
        {
            if (tomate.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[2] = "Tomate";
            }
            else
            {
                toppingTotal--;
                toppingDescripcion[2] = "";
            }
        }

        private void edamame_CheckedChanged(object sender, EventArgs e)
        {
            if (edamame.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[3] = "Edamame";
            }
            else
            {
                toppingTotal--;
                toppingDescripcion[3] = "";
            }
        }

        private void champinones_CheckedChanged(object sender, EventArgs e)
        {
            if (champinones.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[4] = "Champiñones";
            }
            else
            {
                toppingTotal--;
                toppingDescripcion[4] = "";
            }
        }

        private void pollo_CheckedChanged(object sender, EventArgs e)
        {
            if (pollo.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[0] = "Pollo";
            }
            else
            {
                proteinaTotal--;
                proteinaDescripcion[0] = "";
            }
        }

        private void cerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (cerdo.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[1] = "Cerdo";
            }
            else
            {
                proteinaTotal--;
                proteinaDescripcion[1] = "";
            }
        }

        private void rolloprimavera_CheckedChanged(object sender, EventArgs e)
        {
            if (rolloprimavera.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[2] = "Rollo primavera";
            }
            else
            {
                proteinaTotal--;
                proteinaDescripcion[2] = "";
            }
        }

        private void surimi_CheckedChanged(object sender, EventArgs e)
        {
            if (surimi.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[3] = "Surimi";
            }
            else
            {
                proteinaTotal--;
                proteinaDescripcion[3] = "";
            }
        }

        private void arandanos_CheckedChanged(object sender, EventArgs e)
        {
            if (arandanos.CheckState == CheckState.Checked)
            {
                crujientesTotal++;
                crujientesDescripcion[0] = "Arándanos";
            }
            else
            {
                crujientesTotal--;
                crujientesDescripcion[0] = "";
            }
        }

        private void amaranto_CheckedChanged(object sender, EventArgs e)
        {
            if (amaranto.CheckState == CheckState.Checked)
            {
                crujientesTotal++;
                crujientesDescripcion[1] = "Amaranto";
            }
            else
            {
                crujientesTotal--;
                crujientesDescripcion[1] = "";
            }
        }

        private void cacahuate_CheckedChanged(object sender, EventArgs e)
        {
            if (cacahuate.CheckState == CheckState.Checked)
            {
                crujientesTotal++;
                crujientesDescripcion[2] = "Cacahuate";
            }
            else
            {
                crujientesTotal--;
                crujientesDescripcion[2] = "";
            }
        }

        private void semilladegirasol_CheckedChanged(object sender, EventArgs e)
        {
            if (semilladegirasol.CheckState == CheckState.Checked)
            {
                crujientesTotal++;
                crujientesDescripcion[3] = "Semilla de girasol";
            }
            else
            {
                crujientesTotal--;
                crujientesDescripcion[3] = "";
            }
        }

        private void hke_CheckedChanged(object sender, EventArgs e)
        {
            if (hke.CheckState == CheckState.Checked)
            {
                aderezosTotal++;
                aderezosDescripcion[0] = "HKE";
            }
            else
            {
                aderezosTotal--;
                aderezosDescripcion[0] = "";
            }
        }

        private void agridulce_CheckedChanged(object sender, EventArgs e)
        {
            if (agridulce.CheckState == CheckState.Checked)
            {
                aderezosTotal++;
                aderezosDescripcion[1] = "Agridulce";
            }
            else
            {
                aderezosTotal--;
                aderezosDescripcion[1] = "";
            }
        }

        private void soya_CheckedChanged(object sender, EventArgs e)
        {
            if (soya.CheckState == CheckState.Checked)
            {
                aderezosTotal++;
                aderezosDescripcion[2] = "Soya";
            }
            else
            {
                aderezosTotal--;
                aderezosDescripcion[2] = "";
            }
        }

        private void chileseco_CheckedChanged(object sender, EventArgs e)
        {
            if (chileseco.CheckState == CheckState.Checked)
            {
                aderezosTotal++;
                aderezosDescripcion[3] = "Chile seco";
            }
            else
            {
                aderezosTotal--;
                aderezosDescripcion[3] = "";
            }
        }
    }
}
