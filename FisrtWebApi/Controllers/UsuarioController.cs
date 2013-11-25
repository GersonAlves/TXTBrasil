using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using FisrtWebApi.Models;

namespace FisrtWebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        private MeuContext db = new MeuContext();

        // GET api/Usuario
        public IEnumerable<Usuario> GetUsuarios()
        {
            return db.Usuarios.AsEnumerable();
        }

        // GET api/Usuario/5
        public Usuario GetUsuario(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return usuario;
        }

        // PUT api/Usuario/5
        public HttpResponseMessage PutUsuario(int id, Usuario usuario)
        {
            if (ModelState.IsValid && id == usuario.Id)
            {
                db.Entry(usuario).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Usuario
        public HttpResponseMessage PostUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, usuario);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = usuario.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Usuario/5
        public HttpResponseMessage DeleteUsuario(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Usuarios.Remove(usuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, usuario);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}