using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
  public class SqlConnector : IDataConnection
  {
    public PrizeModel CreatePrize(PrizeModel model)
    {
      //TODO - Make the CreatePrize method actually save to the database
      /// <summary>
      /// Saves a new prize to the database
      /// </summary>
      /// <param name="model">The prize information</param>
      /// <returns>The prize information, includijng unique identifier</returns>
      model.Id = 1;
      return model;
    }
  }
}
