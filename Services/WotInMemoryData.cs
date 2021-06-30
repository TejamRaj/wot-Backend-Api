using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public  static class WotInMemoryData
    {

       

        public  static List<TourDestination> GetTourDestinations()
        {
            return new List<TourDestination>()
             {
                 new TourDestination()
                 {
                     TourId= new Guid("fec0a4d6-5830-4eb8-8024-272bd5d6d2bb"),
                     Name=" Goa: Land of sand and beaches",
                     Details="Goa is definitely the best tourist place for India.The pearl of the east, Goa is known for its Gothic churches, crumbling forts, palm-fringed beaches,\n"+
                              "coconut groves, ferry rides, bubbly folk music… the list is endless! With its 131-km-long coastline, Goa is an important locale in every tourist's itinerary \n"+
                              "Sun,sand and sea being the major attractions, Goa trip is a perfect heaven for the ones who need and want relaxation",

                     PopularityRating="4/5",

                     CoverPhotoUrl="https://redsoilrockstorage.blob.core.windows.net/wotassets/goaCoverPhoto.png"


                 },
                 new TourDestination()
                 {
                     TourId= new Guid("c3b7f625-c07f-4d7d-9be1-ddff8ff93b4d"),
                     Name="Rome:A city of Marble,Itely",
                     Details="Rome is one of the world’s top tourist destinations,"+
                              "and is one of the most admired cities on the planet. Throughout the centuries"+
                              "Rome has impressed all sorts of visitors, poets, painters, celebrities and politicians.",

                     PopularityRating="4/5",
                     CoverPhotoUrl="https://redsoilrockstorage.blob.core.windows.net/wotassets/RomeCoverPhoto.jpg"

                 },
                 new TourDestination()
                 {
                     TourId= new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                     Name="Devbhoomi Himachal: Himachal Pradesh,India",
                     Details="Goa is definitely the best tourist place for India.The pearl of the east, Goa is known for its Gothic churches, crumbling forts, palm-fringed beaches,\n"+
                              "coconut groves, ferry rides, bubbly folk music… the list is endless! With its 131-km-long coastline, Goa is an important locale in every tourist's itinerary \n"+
                              "Sun,sand and sea being the major attractions, Goa trip is a perfect heaven for the ones who need and want relaxation",

                     PopularityRating="4/5",
                     CoverPhotoUrl="https://redsoilrockstorage.blob.core.windows.net/wotassets/HimachalCoverPhoto.jpg"

                 },
                 new TourDestination()
                 {
                     TourId=  new Guid("83b126b9-d7bf-4f50-96dc-860884155f8b"),
                     Name="Kerla,India",
                     Details="Goa is definitely the best tourist place for India.The pearl of the east, Goa is known for its Gothic churches, crumbling forts, palm-fringed beaches,\n"+
                              "coconut groves, ferry rides, bubbly folk music… the list is endless! With its 131-km-long coastline, Goa is an important locale in every tourist's itinerary \n"+
                              "Sun,sand and sea being the major attractions, Goa trip is a perfect heaven for the ones who need and want relaxation",

                     PopularityRating="4/5",
                     CoverPhotoUrl="https://redsoilrockstorage.blob.core.windows.net/wotassets/KerlaCoverphto.jpg"


                 }

             };
        }

        public static  List<Workplace> GetWorkplaces()
        {
            return new List<Workplace>()
            {
                         new Workplace()
                         {
                             TourId=new Guid("fec0a4d6-5830-4eb8-8024-272bd5d6d2bb"),

                             Address="201 Bakers street Goa 416507",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                             TourId=new Guid("fec0a4d6-5830-4eb8-8024-272bd5d6d2bb"),

                             Address="201 Bakers street Goa 416507",


                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },
                         new Workplace()
                         {
                              TourId=new Guid("fec0a4d6-5830-4eb8-8024-272bd5d6d2bb"),

                             Address="301 Main road  Panzim  Goa 416512",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                             TourId=new Guid("fec0a4d6-5830-4eb8-8024-272bd5d6d2bb"),

                             Address="201 Bakers street Goa 416507",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                             TourId=new Guid("c3b7f625-c07f-4d7d-9be1-ddff8ff93b4d"),

                             Address=" Post Office BUSSTAND (SUB OFFICE), SHIMLA, HIMACHAL PRADESH (HP), India (IN), Pin Code:- 171001",


                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                             TourId=new Guid("c3b7f625-c07f-4d7d-9be1-ddff8ff93b4d"),

                             Address="SHIMLA race course, HIMACHAL PRADESH (HP), India (IN), Pin Code:- 171003",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },
                         new Workplace()
                         {
                            TourId=new Guid("c3b7f625-c07f-4d7d-9be1-ddff8ff93b4d"),

                             Address="Postmaster, Post Office BUSSTAND (SUB OFFICE), SHIMLA, HIMACHAL PRADESH (HP), India (IN), Pin Code:- 171001",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                            TourId=new Guid("c3b7f625-c07f-4d7d-9be1-ddff8ff93b4d"),

                             Address="BUSSTAND (SUB OFFICE), SHIMLA, HIMACHAL PRADESH (HP), India (IN), Pin Code:- 17017",


                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                             TourId=  new Guid("83b126b9-d7bf-4f50-96dc-860884155f8b"),

                             Address="HIMACHAL PRADESH (HP), India (IN), Pin Code:- 171021",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                             TourId=  new Guid("83b126b9-d7bf-4f50-96dc-860884155f8b"),

                             Address="201 Bakers street Goa 416507",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },
                         new Workplace()
                         {
                            TourId=  new Guid("83b126b9-d7bf-4f50-96dc-860884155f8b"),

                             Address="301 Main road  Panzim  Goa 416512",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                           TourId=  new Guid("83b126b9-d7bf-4f50-96dc-860884155f8b"),

                             Address="201 Bakers street Goa 416507",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },
                          new Workplace()
                         {
                             TourId=new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),

                             Address="201 Bakers street Goa 416507",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                             TourId=new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),

                             Address="201  jump street,Rome,Itely",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },
                         new Workplace()
                         {
                            TourId=new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),

                             Address="205  sector 12,Rome,Itely",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         },

                         new Workplace()
                         {
                            TourId=new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),

                             Address="41 Bakers street Rome,Itely",

                             WorkplacePhotoUrl="~/wwwroot/WoTAssets/beach-summer.png"

                         }


            };

        }



        public static List<Activity> GetActivities()
        {
            return new List<Activity>()
           {
                 new Activity()
                 {
                     Name="Jetskie riding",
                     WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                 },
                  new Activity()
                  {
                      Name = "River Rafting",
                      WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                  },
                   new Activity()
                  {
                      Name = "Tides surfing",
                      WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                  },
                    new Activity()
                  {
                      Name = "Horse Riding",
                      WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                  },
                  new Activity()
                 {
                     Name="Forest Treaking",
                     WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                 },
                  new Activity()
                  {
                      Name = "River Rafting",
                      WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                  },
                   new Activity()
                  {
                      Name = "Tent Camping",
                      WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                  },
                    new Activity()
                  {
                      Name = "Horse Riding",
                      WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                  },
                   new Activity()
                 {
                     Name="Forest Treaking",
                     WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                 },
                  new Activity()
                  {
                      Name = "River Rafting",
                      WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                  },
                   new Activity()
                  {
                      Name = "Tides surfing",
                      WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                  },
                    new Activity()
                  {
                      Name = "Horse Riding",
                      WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                  },

                  new Activity()
                 {
                     Name="Water sports",
                     WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                 },
                  new Activity()
                  {
                      Name = "Cycling",
                      WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                  },
                   new Activity()
                  {
                      Name = "Sky diving",
                      WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                  },
                    new Activity()
                  {
                      Name = "Fishing",
                      WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                  },

           };
        }


        public static List<Amenties> GetAvailableAmenties()
        {

            return new List<Amenties>()
            {
                new Amenties()
                {
                    Name="Club House",
                    WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                },
                 new Amenties()
                {
                    Name="Club House",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                  new Amenties()
                {
                    Name="Club House",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                },
                   new Amenties()
                {
                    Name="Club House",
                    WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                },
                    new Amenties()
                {
                    Name="Swimming Pool",
                    WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                },
                     new Amenties()
                {
                    Name="Swimming Pool",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                      new Amenties()
                {
                    Name="Swimming Pool",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                },
                       new Amenties()
                {
                    Name="Swimming Pool",
                    WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                },
                        new Amenties()
                {
                    Name=" WiFi + LAN Coonection + 2 LED Desktops",
                    WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                },
                         new Amenties()
                {
                    Name="WiFi + LAN Coonection + 2 LED Desktops",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                  new Amenties()
                {
                    Name="WiFi + LAN Coonection + 2 LED Desktops",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                },
                 new Amenties()
                {
                    Name="WiFi + LAN Coonection + 2 LED Desktops",
                    WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                },
                new Amenties()
                {
                    Name="Office Room + Bed Room",
                    WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                },
                 new Amenties()
                {
                    Name="Office Room + Bed Room",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                  new Amenties()
                {
                    Name="Office Room + Bed Room",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                },
                   new Amenties()
                {
                    Name="Office Room + Bed Room",
                    WorkplaceId=new Guid("208e5043-67cb-4d22-ac89-e548ed503db1")
                },

            };
        }



        public static List<FamousSpots> GetFamousSpots()
        {
            return new List<FamousSpots>()
            {
                new FamousSpots()
                {
                    Name="Palloem Beach 20 Km",
                    WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                },
                new FamousSpots()
                {
                    Name="The Goa Musiam ",
                    WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                },
                new FamousSpots()
                {
                    Name="Amboli Waterfall",
                    WorkplaceId=new Guid("6d9e09c7-2822-47fe-a059-df466d26ea9e")
                },
                new FamousSpots()
                {
                    Name=" Old Goa Fort",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                 new FamousSpots()
                {
                    Name="Manali 45km",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                new FamousSpots()
                {
                    Name="Shimala ",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                new FamousSpots()
                {
                    Name="Prashar Lake",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },
                new FamousSpots()
                {
                    Name="Tosh",
                    WorkplaceId=new Guid("957feffe-59ae-4299-8a83-53ab1e307a42")
                },

                 new FamousSpots()
                {
                    Name="The Colosseum and the Arch of Constantine",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                },
                new FamousSpots()
                {
                    Name="Vatican City",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                },
                new FamousSpots()
                {
                    Name="The Pantheon",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                },
                new FamousSpots()
                {
                    Name=" Roman Forum",
                    WorkplaceId=new Guid("fd1bdba3-5419-4c9a-b5f8-e3b6ffb67a95")
                }
            };
        }





    }
}
