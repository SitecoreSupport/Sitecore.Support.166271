using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;


namespace Sitecore.Support.Initialize
{
  public class ReConfigureCORS
  {

    public virtual void Process(PipelineArgs args)
    {
      /*var route = System.Web.Routing.RouteTable.Routes.MapHttpRoute(
        name: "FxmBeaconCustom",
        routeTemplate: "sitecore/api/ssc/Beacon/Service/beacon/{action}",
        defaults: new { controller = "CustomBeacon" } 
        );*/
      GlobalConfiguration.Configuration.EnableCors();
    }
  }
}