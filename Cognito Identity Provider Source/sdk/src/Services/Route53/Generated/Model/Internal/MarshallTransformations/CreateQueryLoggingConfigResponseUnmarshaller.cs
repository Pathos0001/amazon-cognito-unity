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
    /// Response Unmarshaller for CreateQueryLoggingConfig operation
    /// </summary>  
    public class CreateQueryLoggingConfigResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CreateQueryLoggingConfigResponse response = new CreateQueryLoggingConfigResponse();
            UnmarshallResult(context,response);
            if (context.ResponseData.IsHeaderPresent("Location"))
                response.Location = context.ResponseData.GetHeaderValue("Location");
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, CreateQueryLoggingConfigResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("QueryLoggingConfig", targetDepth))
                    {
                        var unmarshaller = QueryLoggingConfigUnmarshaller.Instance;
                        response.QueryLoggingConfig = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
          
            return;
        }
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ConcurrentModification"))
            {
                return new ConcurrentModificationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientCloudWatchLogsResourcePolicy"))
            {
                return new InsufficientCloudWatchLogsResourcePolicyException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInput"))
            {
                return new InvalidInputException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchCloudWatchLogsLogGroup"))
            {
                return new NoSuchCloudWatchLogsLogGroupException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchHostedZone"))
            {
                return new NoSuchHostedZoneException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("QueryLoggingConfigAlreadyExists"))
            {
                return new QueryLoggingConfigAlreadyExistsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonRoute53Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateQueryLoggingConfigResponseUnmarshaller _instance = new CreateQueryLoggingConfigResponseUnmarshaller();        

        internal static CreateQueryLoggingConfigResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateQueryLoggingConfigResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}