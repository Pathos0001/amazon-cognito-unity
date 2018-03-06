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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the ListOTAUpdates operation.
    /// </summary>
    public partial class ListOTAUpdatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OTAUpdateSummary> _otaUpdates = new List<OTAUpdateSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to use to get the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OtaUpdates. 
        /// <para>
        /// A list of OTA update jobs.
        /// </para>
        /// </summary>
        public List<OTAUpdateSummary> OtaUpdates
        {
            get { return this._otaUpdates; }
            set { this._otaUpdates = value; }
        }

        // Check to see if OtaUpdates property is set
        internal bool IsSetOtaUpdates()
        {
            return this._otaUpdates != null && this._otaUpdates.Count > 0; 
        }

    }
}