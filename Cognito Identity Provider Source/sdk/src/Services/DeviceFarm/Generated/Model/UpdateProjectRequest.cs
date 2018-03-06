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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProject operation.
    /// Modifies the specified project name, given the project ARN and a new name.
    /// </summary>
    public partial class UpdateProjectRequest : AmazonDeviceFarmRequest
    {
        private string _arn;
        private int? _defaultJobTimeoutMinutes;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project whose name you wish to update.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultJobTimeoutMinutes. 
        /// <para>
        /// The number of minutes a test run in the project will execute before it times out.
        /// </para>
        /// </summary>
        public int DefaultJobTimeoutMinutes
        {
            get { return this._defaultJobTimeoutMinutes.GetValueOrDefault(); }
            set { this._defaultJobTimeoutMinutes = value; }
        }

        // Check to see if DefaultJobTimeoutMinutes property is set
        internal bool IsSetDefaultJobTimeoutMinutes()
        {
            return this._defaultJobTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A string representing the new name of the project that you are updating.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}