using MacroApp.DbDataContext;
using MacroApp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;


namespace MacroApp
{
    public partial class Form1 : Form
    {
        private DataContext DbContext;
        private bool Running = true;
        private bool EnabledRecoil = false;
        private bool EnableRapidFire = false;
        private int VlThead { get; set; }
        private int XValue { get; set; }
        private int YValue { get; set; }
        private int VThread { get; set; }

        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DbContext = new DataContext();
            DbContext.Database.EnsureCreated();
            DbContext.Operators.Load();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            DbContext.Dispose();
            DbContext = null;
        }

        // Trabalha sobre o recoio da arma
        public void MouseMove()
        {

            while (Running)
            {
                VlThead = Convert.ToInt32(nThreadValue.Value);
                XValue = Convert.ToInt32(nHorValue.Value);
                YValue = Convert.ToInt32(nVertValue.Value);

                if (MouseClass.bGetAsyncKeyState(Keys.LButton) && EnabledRecoil)
                {
                    MouseClass.Move(XValue, YValue);
                    Thread.Sleep(VlThead);
                }
            }
        }

        // Em Construção
        /*        public void RapidFireClick()
        {

            while (Running)
            {
                VThread = Convert.ToInt32(nVThreadRF.Value);

                if (MouseClass.bGetAsyncKeyState(Keys.LButton) && EnableRapidFire)
                    while (Running && MouseClass.bGetAsyncKeyState(Keys.LButton))
                    {
                        MouseClass.RapidFire(VThread);

                        if (MouseClass.bGetAsyncKeyState(Keys.R))
                        {
                            EnableRapidFire = false;
                            break;
                        }
                    }
            }

        }*/

        public void Refresh_R()
        {
            while (Running)
            {
                Thread.Sleep(1);

                bool buffer = true;

                while (MouseClass.bGetAsyncKeyState(Keys.F2))
                {
                    if (buffer)
                    {
                        EnabledRecoil = !EnabledRecoil;
                        buffer = false;
                    }
                }

                // Em construção
                /*                while (MouseClass.bGetAsyncKeyState(Keys.F3))
                {
                    if (buffer)
                    {
                        EnableRapidFire = !EnableRapidFire;
                        buffer = false;
                    }
                }
*/
                if (EnabledRecoil)
                {
                    radioButton2.Enabled = true;
                    radioButton2.Checked = true;
                    radioButton1.Enabled = false;
                    comboBox1.Enabled = false;
                    cBoxAttack.Enabled = false;
                    cBoxDefense.Enabled = false;
                    groupBoxY.Enabled = false;
                    groupBoxX.Enabled = false;
                    nVertValue.Enabled = false;
                    nThreadValue.Enabled = false;
                    nHorValue.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnReset.Enabled = false;
                }
                /*else if (EnableRapidFire)
                {
                    radioButton4.Enabled = true;
                    radioButton4.Checked = true;
                    radioButton3.Enabled = false;
                    comboBox1.Enabled = false;
                    cBoxAttack.Enabled = false;
                    cBoxDefense.Enabled = false;
                    groupBoxY.Enabled = false;
                    groupBoxX.Enabled = false;
                    nVertValue.Enabled = false;
                    nThreadValue.Enabled = false;
                    nHorValue.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnReset.Enabled = false;
                }*/
                else
                {
                    radioButton2.Enabled = false;
                    radioButton1.Enabled = true;
                    radioButton1.Checked = true;
                    comboBox1.Enabled = true;
                    cBoxAttack.Enabled = true;
                    cBoxDefense.Enabled = true;
                    groupBoxY.Enabled = true;
                    groupBoxX.Enabled = true;
                    nVertValue.Enabled = true;
                    nThreadValue.Enabled = true;
                    nHorValue.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnReset.Enabled = true;
                }

                Thread.Sleep(1);
                buffer = true;
            }
        }

        // Notificações no sistema
        public void ShowNotification(string title, string message)
        {
            notify1.ShowBalloonTip(5000, title, message, ToolTipIcon.Info);
        }

        // sai da aplicação e mata o processo
        private static void ExitApplication()
        {
            Process[] pname = Process.GetProcessesByName("MacroApp");
            if (pname.Length != 0)
            {
                foreach (Process process in pname)
                {
                    process.Kill();
                }
            }

        }

        // Execução principal
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread MoveMouseTH = new Thread(MouseMove);
            Thread RefreshTH = new Thread(Refresh_R);
            /*Thread RapidFireTH = new Thread(RapidFireClick);
            RapidFireTH.Start();*/
            MoveMouseTH.Start();
            RefreshTH.Start();
        }

        // Sai da aplicação
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitApplication();
        }

        // Seleção de Operadores
        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            if (cBoxAttack.Checked)
            {
                comboBox1.Items.Clear();

                var result1 = DbContext.Operators.Where(x => x.Function == cBoxAttack.Text.Remove(cBoxAttack.Text.Length - 1))
                                                 .OrderBy(x => x.Name)
                                                 .Select(x => x.Name);


                foreach (var item in result1)
                {
                    comboBox1.Items.Add(item.ToString());
                }

            }
            else if (cBoxDefense.Checked)
            {
                comboBox1.Items.Clear();

                var result2 = DbContext.Operators.Where(x => x.Function == cBoxDefense.Text.Remove(cBoxDefense.Text.Length - 2))
                                                 .OrderBy(x => x.Name)
                                                 .Select(x => x.Name);

                foreach (var item in result2)
                {
                    comboBox1.Items.Add(item.ToString());
                }
            }
            if (cBoxAttack.Checked && cBoxDefense.Checked)
            {
                comboBox1.Items.Clear();

                var result3 = DbContext.Operators.OrderBy(x => x.Name)
                                                 .AsNoTracking()
                                                 .Select(x => x.Name);

                foreach (var item in result3)
                {
                    comboBox1.Items.Add(item.ToString());
                }
            }
            if (!cBoxAttack.Checked && !cBoxDefense.Checked)
            {
                comboBox1.Items.Clear();
            }

        }

        // Reseta valores dos controles do Formulario
        private void btnReset_Click(object sender, EventArgs e)
        {
            nVertValue.Value = 0;
            nThreadValue.Value = 1;
            nHorValue.Value = 0;
        }

        // Atualiza registro selecionado
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var func = cBoxAttack.Checked ? "Atacante" : "Defensor";

            var result = DbContext.Operators.FirstOrDefault(x => x.Name == comboBox1.SelectedItem && x.Function == func);

            result.YValue = Convert.ToInt32(nVertValue.Value);
            result.XValue = Convert.ToInt32(nHorValue.Value);
            result.ThreadValue = Convert.ToInt32(nThreadValue.Value);

            DbContext.Operators.Update(result);
            DbContext.SaveChanges();

            MessageBox.Show("Registro atualizado com sucesso");

        }

        // Remove o registros selecionado
        private void button2_Click(object sender, EventArgs e)
        {
            var func = cBoxAttack.Checked ? "Atacante" : "Defensor";

            var result = DbContext.Operators.FirstOrDefault(x => x.Name == comboBox1.SelectedItem && x.Function == func);                                         
            DbContext.Operators.Remove(result);
            DbContext.SaveChanges();

            comboBox1.SelectedIndex = -1;

            nVertValue.Value = 0;
            nHorValue.Value = 0;
            nThreadValue.Value = 1;

            MessageBox.Show("Excluido com sucesso");

        }

        // Seleciona registro corrente
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var result = DbContext.Operators.FirstOrDefault(x => x.Name == comboBox1.SelectedItem);
            nVertValue.Value = result.YValue;
            nHorValue.Value = result.XValue;
            nThreadValue.Value = result.ThreadValue == 0 ? 1 : result.ThreadValue;

        }

        // Insere novo Operador
        private void button1_Click_1(object sender, EventArgs e)
        {
            var newoperator = new Operator();

            newoperator.Name = tbOperator.Text;
            newoperator.Function = cBoxFunction.SelectedItem.ToString();

            DbContext.Add(newoperator);
            DbContext.SaveChanges();

            tbOperator.Text = "";
            cBoxFunction.SelectedIndex = -1;

            MessageBox.Show("Inserido com sucesso");
        }

    }
}
