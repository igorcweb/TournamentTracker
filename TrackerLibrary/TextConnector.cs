using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
  public class TextConnector : IDataConnection
  {
    public PrizeModel CreatePrize(PrizeModel model)
    {
      //TODO - Make the CreatePrize method actually save to the textfile
      model.Id = 1;
      return model;
    }
  }
}