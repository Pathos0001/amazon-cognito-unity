/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HostedZone Object
    /// </summary>  
    public class HostedZoneUnmarshaller : IUnmarshaller<HostedZone, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HostedZone Unmarshall(XmlUnmarshallerContext context)
        {
            HostedZone unmarshalledObject = new HostedZone();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CallerReference", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CallerReference = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Config", targetDepth))
                    {
                        var unmarshaller = HostedZoneConfigUnmarshaller.Instance;
                        unmarshalledObject.Config = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceRecordSetCount", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.ResourceRecordSetCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LinkedService", targetDepth))
                    {
                        var unmarshaller = LinkedServiceUnmarshaller.Instance;
                        unmarshalledObject.LinkedService = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }

        private static HostedZoneUnmarshaller _instance = new HostedZoneUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HostedZoneUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}