using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seoane.Negocio;

namespace Seoane.Presentacion
{
    public partial class FrmCategoria : Form
    {
        //CREAMOS LA VARIABLE NOMBRE ANTERIOR 
        private string NombreAnt;

        public FrmCategoria()
        {
            InitializeComponent();
        }
        // METODO LISTAR: ESTE METODO NOS PERMITE TRAER LOS REGISTROS DE LA BASE DE DATOS
        private void listar()
        {
            try
            {
                dgvListar.DataSource = NCategoria.Listar();
                this.Formato();
                lbltota.Text = "Total de Registros: " + Convert.ToString(dgvListar.Rows.Count);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }   
        //METODO FORMATO: ESTE METODO NOS FORMATEA(ANCHO Y NOMBRE DE LAS COLUMNAS)
        private void Formato()
        {
            //COLUMNA SELECIONAR
            dgvListar.Columns[0].Visible = false;
            //COLUMNA ID
            dgvListar.Columns[1].Visible = false;
            dgvListar.Columns[2].Width = 158;
            dgvListar.Columns[3].Width = 400;
            dgvListar.Columns[3].HeaderText = "Descripcion Categoria";
            dgvListar.Columns[4].Width = 100;
        }

        //METODO LISTAR: ESTE METODO NOS PERMITE BUSCAR LOS REGISTROS
        private void Buscar()
        {
            try
            {
                //DECLARO EL ORIGEN
                dgvListar.DataSource = NCategoria.Buscar(txtbusca.Text);
                //APLICO FORMATO A LA GRILLA
                this.Formato();
                //MOSTRAR LA CANTIDAD DE COINCIDENCIAS
                lbltota.Text = "Total de Registros: " + Convert.ToString(dgvListar.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }   
        //METODO MENSAJE ERROR: NOS MUESTRA UN MENSAJE DE ERROR 
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje,"Sistema de Ventas Seoane", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //METODO MENSAJE CONFIRMACION OK: NOS MUESTRA UN MENSAJE DE DE TODO SALIO BIEN OK
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas Seoane", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            txtbusca.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtID.Clear();

            btnElimina.Visible = false;
            btnActiva.Visible = false;
            btnDesactiva.Visible = false;
            chkSelec.Checked = false;
        }
        private void FrmCategoria_Load_1(object sender, EventArgs e)
        {
            this.listar();
            
        }

        private void btmBusca_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // TRY CATCH -> EJECUTAMOS O CAPTURAMOS EXCEPCION / ERRORES
            try
            {
                //DECLARO LA VARIABLES RPTA = STRING Y LA INICIALIZO EN BLANCO ""
                String Rpta = " ";
                //VALiDAR QUE EL txtNombre NO ESTE VACIO 
                if(txtNombre.Text == String.Empty)
                {
                    //ALERTAR CON MENSAJE DE ERROR = ALERTAR CON UN MENSAJE DE ERROR
                    this.MensajeError("Faltar ingresar algunas datos: Nombre Categoria");
                }
                else
                {
                    //VALIDACION VALIDA OK = ALERTAR CON MENSAJE DE INFORMACION
                    Rpta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    //SI LA VARIABLES RPTA ES IGUAL A OK, ENTONCES
                    if(Rpta.Equals("OK"))
                    {
                        this.MensajeOK("se inserto de manera Correcta");
                        //REFRESCAMOS/ACTUALIZAMOS LA GRILLA
                        this.listar();
                        this.Limpiar();
                    }
                    else
                    {
                        //SI HAY ALGUN ERROR, AVISAME DE QUE SE TRATA
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex )
            {
                //MOSTRAR UNA ALERTA Y TRAZAR DONDE SE PRODUCE UN ERROR
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //LIMPIAR LOS TEXTBOXT
                this.Limpiar();
                //ESTOY CAPTURANDO LOS VALORES DE LA GRILLA DGV LISTAR
                txtID.Text = dgvListar.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvListar.CurrentRow.Cells["Nombre"].Value.ToString();
                this.NombreAnt = dgvListar.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvListar.CurrentRow.Cells["Descripcion"].Value.ToString();
                //CON SELECCIONAMOS LA FICHA DE MANTENIMIENTO
                tabGeneral.SelectedIndex = 1;
            }
            catch(Exception)
            {
                MessageBox.Show("Selecione desde la celda nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //TRY CACTH >EJECUTAMOS O CAPTURAMOS EXCEPCION/ERRORES
            try
            {
                //DECLARO VARIABLE RPTA = STRING Y LA INICIALIZO EN BLANCO ""
                String Rpta = "";
                //VALIDAR QUE EL txtNOMBRE NO ESTE VACIO O EL ID ESTE VACIO
                if (txtNombre.Text == String.Empty || txtID.Text == String.Empty)
                {
                    //VALIDACION ERROR ALERTAR CON MENSAJE DE ERROR
                    this.MensajeError("Falta ingresar datos: Nombre Categoria o ID");
                }
                else
                    //VALIDACION VALIDA OK . ALERTAR CON MESAJE DE INFORMACION
                    //PROPIEDAD TRIM -> ELIMINAR LOS ESPACIOS EN BLANCO TANTO IZQ COMO A LA DER
                    //ESTOY PASANDO LOS 4 PARAMETROS SOLICITADOS PARA LA ACTUALIZACION
                    Rpta = NCategoria.Actualizar(Convert.ToInt32(txtID.Text), this.NombreAnt, txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                //SI LA VARIABLES RPTA ES IGUAL A OK, ENTONCES
                if (Rpta.Equals("OK"))
                {
                    this.MensajeOK("Se actualizo de Manera Correcta");
                    //REFRESCAMOS/ACTUALIZAMOS LA GRILLA
                    this.listar();
                    this.Limpiar();
                    tabGeneral.SelectedIndex = 0;
                }
                else
                {
                    //SI HAY ALGUN ERROR, AVISAME DE QUE SE TRATA
                    this.MensajeError(Rpta);
                }
            
            }
            catch (Exception ex )
            {
                //MOSTRAR UNA ALERTA Y TRAZAR DONDE SE PRODUCE UN ERROR
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            // SELECCIONANDO LA FICHA DE LA GRILLA (LISTADO)
            tabGeneral.SelectedIndex = 0;
        }

        private void chkSelec_CheckedChanged(object sender, EventArgs e)
        {
            //SI HEMOS SELECCIONADO
            if(chkSelec .Checked)
            {
                //MOSTRAMOS LA COLUMNA SELECCIONAR
                dgvListar.Columns[0].Visible = true;
                //VISUALIZAMOS LOS BOTONES ELIMINAR, ACTIVAR Y DESACTIVAR
                btnElimina.Visible = true;
                btnActiva.Visible = true;
                btnDesactiva.Visible = true;
            }
            else
            //SI ESTA DESACTIVADO
            {
                //OCULTAMOS LA COMUNMA SELECCIONAR
                dgvListar.Columns[0].Visible = false;
                //VISUALIZAMOS LOS BOTONES ELIMINAR, ACTIVAR Y DESACTIVAR
                btnElimina.Visible = false;
                btnActiva.Visible = false;
                btnDesactiva.Visible = false;

            }
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvListar.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                //MOSTRAR UNA CAJA DE DIALOGO CON LOS BOTONES SI o NO
                //GENERAMOS LA VARIABLE OPTION
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea eliminar los registro", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opcion == DialogResult.OK)
                {
                    string codigo;
                    string Rpta = "";
                    //RECORREMOS TODAS LAS FILAS, EVALUANDO
                    foreach(DataGridViewRow row in dgvListar.Rows)
                    {
                        //TENGO QUE RECORRER LA COLUMNA SELECCIONAR
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //RECORRIENDO LA COLUMNA SELECCIONAR CHECK = BOOLEAN V o F O 1 o 0
                            codigo = Convert.ToString(row.Cells[1].Value);
                            //PASAR EL CODIGO PERO LO CONVERTIMOS EN INTENGER 
                            Rpta = NCategoria.Eliminar(Convert.ToInt32(codigo));
                            if(Rpta.Equals("OK"))
                            {
                                //LE eSTOY AVISANDO EL NOMBRE DE LA CATEGORIA = CELLS[2]
                                this.MensajeOK("Se elimino el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                            
                        }
                    }
                    //UNA VEZ QUE RECORRE TODOS LOS REGISTROS TIENE QUE REFRESCAR LA GRILLA
                    this.listar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            
            }
        }

        private void btnDesactiva_Click(object sender, EventArgs e)
        {
            try
            {
                //MOSTRAR UNA CAJA DE DIALOGO CON LOS BOTONES SI o NO
                //GENERAMOS LA VARIABLE OPTION
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Desactivar los registro", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string codigo;
                    string Rpta = "";
                    //RECORREMOS TODAS LAS FILAS, EVALUANDO
                    foreach (DataGridViewRow row in dgvListar.Rows)
                    {
                        //TENGO QUE RECORRER LA COLUMNA SELECCIONAR
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //RECORRIENDO LA COLUMNA SELECCIONAR CHECK = BOOLEAN V o F O 1 o 0
                            codigo = Convert.ToString(row.Cells[1].Value);
                            //PASAR EL CODIGO PERO LO CONVERTIMOS EN INTENGER 
                            Rpta = NCategoria.Desactivar(Convert.ToInt32(codigo));
                            if (Rpta.Equals("OK"))
                            {
                                //LE eSTOY AVISANDO EL NOMBRE DE LA CATEGORIA = CELLS[2]
                                this.MensajeOK("Se Desactivo el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    //UNA VEZ QUE RECORRE TODOS LOS REGISTROS TIENE QUE REFRESCAR LA GRILLA
                    this.listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {
            try
            {
                //MOSTRAR UNA CAJA DE DIALOGO CON LOS BOTONES SI o NO
                //GENERAMOS LA VARIABLE OPTION
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Activar los registro", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string codigo;
                    string Rpta = "";
                    //RECORREMOS TODAS LAS FILAS, EVALUANDO
                    foreach (DataGridViewRow row in dgvListar.Rows)
                    {
                        //TENGO QUE RECORRER LA COLUMNA SELECCIONAR
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //RECORRIENDO LA COLUMNA SELECCIONAR CHECK = BOOLEAN V o F O 1 o 0
                            codigo = Convert.ToString(row.Cells[1].Value);
                            //PASAR EL CODIGO PERO LO CONVERTIMOS EN INTENGER 
                            Rpta = NCategoria.Activar(Convert.ToInt32(codigo));
                            if (Rpta.Equals("OK"))
                            {
                                //LE eSTOY AVISANDO EL NOMBRE DE LA CATEGORIA = CELLS[2]
                                this.MensajeOK("Se Activo el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    //UNA VEZ QUE RECORRE TODOS LOS REGISTROS TIENE QUE REFRESCAR LA GRILLA
                    this.listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

