﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
  public static class GlobalConfig
  {
    public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

    public static void InitializeConnections(bool database, bool textFiles)
    {
      if (database)
      {
        // TODO - Set up the SQL connector properly
        SqlConnector sql = new SqlConnector();
        Connections.Add((IDataConnection)sql);
      }
      if (textFiles)
      {
        TextConnector text = new TextConnector();
        // TODO - Create text connection
        Connections.Add(text);
      }
    }
  }
}
