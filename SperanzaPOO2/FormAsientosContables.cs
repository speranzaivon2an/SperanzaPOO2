using Controladora;
using Entidad;

namespace SperanzaPOO2
{
    public partial class FormAsientosContables : Form
    {
        public AsientosContables asientosContables;
        List<TimeSpan> TimeSpanList;
        List<AsientosContables> ListaAsientosContables;
        public FormAsientosContables()
        {
            InitializeComponent();
            TimeSpanList.Add(new TimeSpan(9, 0, 0));
            TimeSpanList.Add(new TimeSpan(9, 4, 0));
            cmbFechaAsientos.DataSource = TimeSpanList;

            this.asientosContables = new AsientosContables();
            this.asientosContables.Add(new AsientosContables(Concepto = "Alquiler"));
            this.asientosContables.Add(new AsientosContables(Concepto = "Alquiler"));
            cmbConcepto.DataSource = AsientosContables;

            this.asientosContables = new AsientosContables();
            this.asientosContables.Add(new AsientosContables(CapitalActual = "HABER"));
            this.asientosContables.Add(new AsientosContables(CapitalActual = "DEBER"));
            cmbCapitalActual.DataSource = AsientosContables;

            this.asientosContables = new AsientosContables();
            this.asientosContables.Add(new AsientosContables(AsientosContablesID = 102345));
            this.asientosContables.Add(new AsientosContables(AsientosContablesID = 87654));
            cmbAsientosID.DataSource = AsientosContables;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAsientosID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ActualizarGrilla()
        {
            dtgAsientoContables.DataSource = ControladoraAsientosContables.List < AsientosContables > ListaAsientosContables();

        }

        private void cmbCapitalActual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarAsiento_Click(object sender, EventArgs e)
        {

            ActualizarGrilla();
            var formAsientosContables = new FormAsientosContables();
            formAsientosContables.ShowDialog();
            ActualizarGrilla();
        }

        private void btnEliminarAsiento_Click(object sender, EventArgs e)
        {
            if (dtgAsientoContables.Rows.Count > 0)
            {
                var asientos = (AsientosContables)dtgAsientoContables.CurrentRow.DataBoundItem;
                var mensaje = ControladoraAsientosContables.Eliminar(asientos);
                ActualizarGrilla();
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Asiento");
            }
        }
    }
}