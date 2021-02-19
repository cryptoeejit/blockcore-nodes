using Blockcore.Configuration;

namespace Blockcore.Node
{
   public static class NetworkSelector
   {
      public static NodeSettings Create(string chain, string[] args)
      {
         chain = chain.ToUpperInvariant();

         NodeSettings nodeSettings = null;

         switch (chain)
         {
            case "AMS":
               nodeSettings = new NodeSettings(networksSelector: AMS.Networks.Networks.AMS, args: args);
               break;

            case "BCP":
               nodeSettings = new NodeSettings(networksSelector: Networks.BCP.Networks.Networks.BCP, args: args);
               break;

            case "BTC":
               nodeSettings = new NodeSettings(networksSelector: Blockcore.Networks.Bitcoin.Networks.Bitcoin, args: args);
               break;

            case "CITY":
               nodeSettings = new NodeSettings(networksSelector: Blockcore.Networks.City.Networks.Networks.City, args: args);
               break;

            case "STRAT":
               nodeSettings = new NodeSettings(networksSelector: Blockcore.Networks.Stratis.Networks.Stratis, args: args);
               break;

            case "X42":
               nodeSettings = new NodeSettings(networksSelector: Blockcore.Networks.x42.Networks.Networks.x42, args: args);
               break;

            case "XDS":
               nodeSettings = new NodeSettings(networksSelector: Blockcore.Networks.Xds.Networks.Xds, args: args);
               break;

            case "RUTA":
               nodeSettings = new NodeSettings(networksSelector: Rutanio.Networks.Networks.Rutanio, args: args);
               break;

            case "EXOS":
               nodeSettings = new NodeSettings(networksSelector: OpenExo.Networks.Networks.OpenExo, args: args);
               break;

            case "IMPLX":
               nodeSettings = new NodeSettings(networksSelector: Networks.Impleum.Networks.Impleum, args: args);
               break;

            case "XLR":
               nodeSettings = new NodeSettings(networksSelector: Solaris.Networks.Networks.Solaris, args: args);
               break;
         }

         return nodeSettings;
      }
   }
}
