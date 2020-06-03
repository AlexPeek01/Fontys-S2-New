﻿using AdditionalFiles.Interfaces.IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ServiceDB : IServiceDB
    {
        public void InsertNewServiceData(Service service, string datestring)
        {
            List<string[]> parameters = new List<string[]>()
            {
                new string[] { "@ServiceID", service.ServiceID},
                new string[] { "@NetworkID", service.NetworkID},
                new string[] { "@UserID", service.PostersID},
                new string[] { "@Title", service.Title},
                new string[] { "@Description", service.Description},
                new string[] { "@Image", service.Images},
                new string[] { "@Date", service.Date.ToString()},
                new string[] { "@Visibility", Convert.ToInt32(service.Visibility).ToString()},
                new string[] { "@Category", service.Category}
            };
            SQLConnection.ExecuteNonSearchQuery($"INSERT INTO services (ServiceID,NetworkID,UserID,Title,Description,Image,Date,Visibility,Category) VALUES(@ServiceID,@NetworkID,@UserID,@Title,@Description,@Image,@Date,@Visibility,@Category)", parameters);
        }
        public Service GetServiceDataById(string serviceID)
        {
            List<string[]> parameters = new List<string[]>()
            {
                new string[] { "@ServiceID", serviceID },
            };
            string[] serviceData = SQLConnection.ExecuteSearchQuery("SELECT * FROM services WHERE ServiceID = @ServiceID", parameters).ToArray();
            return new Service()
            {
                ServiceID = serviceData[0],
                NetworkID = serviceData[1],
                PostersID = serviceData[2],
                Title = serviceData[3],
                Description = serviceData[4],
                Images = serviceData[5],
                Date = DateTime.Parse(serviceData[6]),
                Visibility = Convert.ToBoolean(Int32.Parse(serviceData[7])),
                Category = serviceData[8],
            };
        }
    }
}
