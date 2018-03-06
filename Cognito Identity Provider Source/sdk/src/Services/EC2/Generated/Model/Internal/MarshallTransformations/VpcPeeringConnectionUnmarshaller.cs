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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VpcPeeringConnection Object
    /// </summary>  
    public class VpcPeeringConnectionUnmarshaller : IUnmarshaller<VpcPeeringConnection, XmlUnmarshallerContext>, IUnmarshaller<VpcPeeringConnection, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcPeeringConnection Unmarshall(XmlUnmarshallerContext context)
        {
            VpcPeeringConnection unmarshalledObject = new VpcPeeringConnection();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("accepterVpcInfo", targetDepth))
                    {
                        var unmarshaller = VpcPeeringConnectionVpcInfoUnmarshaller.Instance;
                        unmarshalledObject.AccepterVpcInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("expirationTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ExpirationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("requesterVpcInfo", targetDepth))
                    {
                        var unmarshaller = VpcPeeringConnectionVpcInfoUnmarshaller.Instance;
                        unmarshalledObject.RequesterVpcInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = VpcPeeringConnectionStateReasonUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("vpcPeeringConnectionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcPeeringConnectionId = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcPeeringConnection Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static VpcPeeringConnectionUnmarshaller _instance = new VpcPeeringConnectionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpcPeeringConnectionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}