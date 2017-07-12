using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feature.Events
{
  public struct Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{E795D8D0-091D-42FC-B754-6CA7DA864216}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{4DA3A620-C673-4CFD-A73E-CCF97307BE3E}");
        public static readonly ID Description = new ID("{BD5037C5-154D-4E12-B3AD-D0B1FB9724A0}");
        public static readonly ID Date = new ID("{C3E21485-615D-4DA6-A2A1-BD61528B0679}");
        public static readonly ID Venue = new ID("{DA43F956-970D-4D08-9F05-81CBD2371769}");
        public static readonly ID VenueAddress = new ID("{7E16CDFD-245D-4812-9425-DDCC9420326E}");
      }
    }
  }
}