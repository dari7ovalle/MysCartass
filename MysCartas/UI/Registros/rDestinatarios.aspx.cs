using Entidades;
using MysCartas.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MysCartas.UI.Registros
{
    public partial class rDestinatarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            DestinatarioIdTextBox.Text = "";
            FechaTextBox.Text = "";
            NombreTextBox.Text = "";
            DireccionTextBox.Text = "";
        }
        private Destinatarios LlenaClase(Destinatarios Dest)
        {
            Dest.DestinatarioId = Util.ToInt(DestinatarioIdTextBox.Text);
            Dest.Fecha = Convert.ToDateTime(FechaTextBox.Text).Date;
            Dest.Nombre = NombreTextBox.Text;
            Dest.Direccion = DireccionTextBox.Text;
            Dest.Total = Util.ToInt(TotalTextBox.Text);

            return Dest;
        }

        protected void GuadarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Destinatarios> repositorio = new BLL.RepositorioBase<Destinatarios>();
            Destinatarios destinatarios = new Destinatarios();
            bool paso = false;


            LlenaClase(destinatarios);

            if (IsValid)
            {
                if (destinatarios.DestinatarioId == 0)
                {
                    if (paso = repositorio.Guardar(destinatarios))
                    {

                        Util.ShowToastr(this, "saved successfully", "Success", "success");
                        Limpiar();
                    }

                    else
                    {
                        Util.ShowToastr(this, "Error al Guardar", "Error", "error");


                    }
                  
                }

                else
                {
                    if (paso = repositorio.Modificar(destinatarios))
                    {
                        Util.ShowToastr(this, "Modificado  successfully", "Success", "success");
                        Limpiar();
                    }
                    else
                    {
                        Util.ShowToastr(this, "Error al Modificar", "Error", "error");


                    }
                }
            }
        }
        private void LlenaCampos(Destinatarios destinatarios)
        { 
            DestinatarioIdTextBox.Text = destinatarios.DestinatarioId.ToString();
            FechaTextBox.Text = destinatarios.Fecha.ToString();
            NombreTextBox.Text = destinatarios.Nombre.ToString();
            DireccionTextBox.Text = destinatarios.Direccion.ToString();
            TotalTextBox.Text = destinatarios.Total.ToString();

        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Destinatarios> repositorio = new BLL.RepositorioBase<Destinatarios>();
            Destinatarios destinatarios = repositorio.Buscar(Util.ToInt(DestinatarioIdTextBox.Text));

            if (destinatarios != null)
            {
                LlenaCampos(destinatarios);
            }
            else
            {
                Util.ShowToastr(this, "No Existe en la Base de datos", "Error", "error");

            }

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Destinatarios> repositorio = new BLL.RepositorioBase<Destinatarios>();
            int id = Util.ToInt(DestinatarioIdTextBox.Text);

            var destinatarios = repositorio.Buscar(id);

            if (destinatarios == null)
                Util.ShowToastr(this, "No se puede elliminar Error  ", "Error", "error");

            else
                repositorio.Eliminar(id);
            Util.ShowToastr(this, " Eliminado ", "Success", "success");
            Limpiar();
        }
    }
}