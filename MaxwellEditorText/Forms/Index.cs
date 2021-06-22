using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MaxwellEditorText.Forms;

namespace MaxwellEditorText
{
    public partial class Index : Form
    {
        #region Useless Code
        /// <summary>
        /// El codigo no es obsoleto, sino que nunca la llegamos a usar directamente
        /// aunque este sea el responsable de que el codigo funcione porque lógicamente
        /// es la funcion que inicializa el programa
        /// </summary>
        public Index()
        { InitializeComponent(); }
        #endregion

        //-----------------Variables-----------------\\
        string 
            Archivo = "",
            Filtro = "Texto|*.txt";

        FontSizeForm SetSize = new FontSizeForm();

        //Salir
        private void ExitApp()
        {
            DialogResult Dialogo = MessageBox.Show("¿Está seguro que desea salir del programa?", "¡Está saliendo del programa!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (Dialogo == DialogResult.Yes)
                Application.Exit();
        }

        private void Clear()
        {
            RitchTextBoxControl.Text = string.Empty;
            Archivo = String.Empty;
        }

        private void SaveEditedFile()
        {
            using (StreamWriter EscrituraDelArchivo = new StreamWriter(Archivo))
            { EscrituraDelArchivo.Write(RitchTextBoxControl.Text); }

            MessageBox.Show("Acción aplicada correctamente", "Todo correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Este será el codigo que se encargará de abrir un achivo ya creado en
        /// el equipo
        /// </summary>
        private void OpenFileEvent()
        {
            //Crear una variable del tipo OpenFileDialog
            OpenFileDialog Dialog = new OpenFileDialog();

            //Extencion que manejará el programa.
            Dialog.Filter = Filtro;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                //Pasandole el parametro, nombre y ubicación del archivo.
                Archivo = Dialog.FileName;

                //Leyendo y seteando La caja de texto enriquecida.
                using (StreamReader Reader = new StreamReader(Archivo))
                { RitchTextBoxControl.Text = Reader.ReadToEnd(); }
            }
        }

        private void SaveCurrentFile()
        {
            //Crear una variable del tipo SaveFileDialog
            SaveFileDialog SaveFile = new SaveFileDialog();

            //Seteando la extensión
            SaveFile.Filter = Filtro;

            //Intento de guardar el archivo
            try
            {
                if (Archivo != "")
                { SaveEditedFile(); }
                else
                {
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    { 
                        Archivo = SaveFile.FileName;
                        SaveEditedFile();
                    }
                }
            }
            catch (Exception error)
            { MessageBox.Show("Ocurrió un error grave\n\nDetalles del error: " + error.Message + "\nCódigo del error: " + error.HResult, "¡Ocurrió un error inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region Codigo de controles

        //Boton Salir
        private void ExitButton_Click(object sender, EventArgs e)
        { ExitApp(); }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        { ExitApp(); }

        //Boton Maximizar
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        //Boton Minimizar
        private void MiminizeButton_Click(object sender, EventArgs e)
        { WindowState = FormWindowState.Minimized; }

        private void Index_Load(object sender, EventArgs e)
        {
            TitleLabel.Text = "MaxwellEditorText";
            Clear();

            if (Properties.Settings.Default.LastDoc != "")
            {
                //Pasandole el parametro, nombre y ubicación del archivo.
                Archivo = Properties.Settings.Default.LastDoc;

                //Leyendo y seteando La caja de texto enriquecida.
                using (StreamReader Reader = new StreamReader(Archivo))
                { RitchTextBoxControl.Text = Reader.ReadToEnd(); }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        { OpenFileEvent(); }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("¿Está seguro que desea crear un nuevo archivo, Los cambios no se guardarán?", "Guarde para no perder los archivos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
            if (Dialog == DialogResult.Yes)
                Clear();
        }

        private void acercarToolStripMenuItem_Click(object sender, EventArgs e)
        { RitchTextBoxControl.Font = new Font(RitchTextBoxControl.Font.Name, RitchTextBoxControl.Font.Size + 1); }

        private void alejarToolStripMenuItem_Click(object sender, EventArgs e)
        { RitchTextBoxControl.Font = new Font(RitchTextBoxControl.Font.Name, RitchTextBoxControl.Font.Size - 1); }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSize.ShowDialog();

            //Output
            RitchTextBoxControl.Font = new Font(RitchTextBoxControl.Font.Name, SetSize.SizeValueTrackBar.Value);
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Properties.Settings.Default.LastDoc = Archivo;
            Properties.Settings.Default.Save();
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        { SaveCurrentFile(); }
        #endregion
    }
}
