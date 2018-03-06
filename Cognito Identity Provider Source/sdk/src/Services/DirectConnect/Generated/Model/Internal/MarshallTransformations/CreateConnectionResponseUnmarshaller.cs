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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateConnection operation
    /// </summary>  
    public class CreateConnectionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateConnectionResponse response = new CreateConnectionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("awsDevice", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AwsDevice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bandwidth", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Bandwidth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lagId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LagId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loaIssueTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LoaIssueTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ownerAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OwnerAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("partnerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PartnerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vlan", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Vlan = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectClientException"))
            {
                return new DirectConnectClientException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectServerException"))
            {
                return new DirectConnectServerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonDirectConnectException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateConnectionResponseUnmarshaller _instance = new CreateConnectionResponseUnmarshaller();        

        internal static CreateConnectionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConnectionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}