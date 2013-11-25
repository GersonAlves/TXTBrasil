using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using FisrtWebApi.Models;



namespace ConsumindoWebApi
{
    public partial class _Default : Page
    {
        HttpClient client;
        Uri usuarioUri;

        public _Default()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:1580");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
             {
              getAll();
            }
         }

        private void getAll()
        {
            //chamando a api pela url
            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/usuario").Result;

            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {
                //pegando o cabeçalho
                usuarioUri = response.Headers.Location;

                //Pegando os dados do Rest e armazenando na variável usuários
                var usuarios = response.Content.ReadAsAsync<IEnumerable<Usuario>>().Result;

                //preenchendo a lista com os dados retornados da variável
                GridView1.DataSource = usuarios;
                GridView1.DataBind();
            }

              //Se der erro na chamada, mostra o status do código de erro.
            else
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                int _index = int.Parse((String)e.CommandArgument);
                string _chave = GridView1.DataKeys[_index]["Id"].ToString();

                delete(int.Parse(_chave));
            }
   
        }

        private void delete(int Id)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/usuario/" + Id).Result;
            response = client.DeleteAsync("api/usuario/" + Id).Result;

            if (response.IsSuccessStatusCode)
                usuarioUri = response.Headers.Location;
            else
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase.ToString());
            //chamar o método que pega todos os dados novamente, mostrado na parte 2.            
        }
    }
}