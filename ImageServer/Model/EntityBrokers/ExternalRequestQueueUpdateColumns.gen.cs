#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.ImageServer.Enterprise;

   public class ExternalRequestQueueUpdateColumns : EntityUpdateColumns
   {
       public ExternalRequestQueueUpdateColumns()
       : base("ExternalRequestQueue")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestType")]
        public String RequestType
        {
            set { SubParameters["RequestType"] = new EntityUpdateColumn<String>("RequestType", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestXml")]
        public XmlDocument RequestXml
        {
            set { SubParameters["RequestXml"] = new EntityUpdateColumn<XmlDocument>("RequestXml", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="InsertTime")]
        public DateTime InsertTime
        {
            set { SubParameters["InsertTime"] = new EntityUpdateColumn<DateTime>("InsertTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="DeletionTime")]
        public DateTime DeletionTime
        {
            set { SubParameters["DeletionTime"] = new EntityUpdateColumn<DateTime>("DeletionTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="StateXml")]
        public XmlDocument StateXml
        {
            set { SubParameters["StateXml"] = new EntityUpdateColumn<XmlDocument>("StateXml", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="OperationToken")]
        public String OperationToken
        {
            set { SubParameters["OperationToken"] = new EntityUpdateColumn<String>("OperationToken", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="ExternalRequestQueueStatusEnum")]
        public ExternalRequestQueueStatusEnum ExternalRequestQueueStatusEnum
        {
            set { SubParameters["ExternalRequestQueueStatusEnum"] = new EntityUpdateColumn<ExternalRequestQueueStatusEnum>("ExternalRequestQueueStatusEnum", value); }
        }
    }
}