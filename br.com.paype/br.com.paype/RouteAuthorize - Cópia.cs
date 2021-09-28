//using Microsoft.AspNetCore.Mvc.Filters;
//using System;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Http.Controllers;

//namespace br.com.paype
//{
//    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
//    public class RouteAuthorize : AuthorizeAttribute, IAuthorizationFilter
//    {
//        public override bool AllowMultiple => false;
//        private string _programa;
//        private string _acao;

//        public RouteAuthorize(string programa, string acao)
//        {
//            _programa = programa;
//            _acao = acao;
//        }

//        public void OnAuthorization(AuthorizationFilterContext context)
//        {

//            string programa = _programa;
//            string acao = _acao;
//            string usuario = context.HttpContext.User.Identity.Name;

//            HttpResponseMessage nao_autorizado = new HttpResponseMessage(HttpStatusCode.Forbidden);



//            HttpResponseException resposta = new HttpResponseException(nao_autorizado);





//        }

//    }
//}
