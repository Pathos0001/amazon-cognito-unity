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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// This is the response object from the DescribeJobExecution operation.
    /// </summary>
    public partial class DescribeJobExecutionResponse : AmazonWebServiceResponse
    {
        private JobExecution _execution;

        /// <summary>
        /// Gets and sets the property Execution. 
        /// <para>
        /// Contains data about a job execution.
        /// </para>
        /// </summary>
        public JobExecution Execution
        {
            get { return this._execution; }
            set { this._execution = value; }
        }

        // Check to see if Execution property is set
        internal bool IsSetExecution()
        {
            return this._execution != null;
        }

    }
}