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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePlacementGroup operation.
    /// Creates a placement group in which to launch instances. The strategy of the placement
    /// group determines how the instances are organized within the group. 
    /// 
    ///  
    /// <para>
    /// A <code>cluster</code> placement group is a logical grouping of instances within a
    /// single Availability Zone that benefit from low network latency, high network throughput.
    /// A <code>spread</code> placement group places instances on distinct hardware.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
    /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreatePlacementGroupRequest : AmazonEC2Request
    {
        private string _groupName;
        private PlacementStrategy _strategy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreatePlacementGroupRequest() { }

        /// <summary>
        /// Instantiates CreatePlacementGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">A name for the placement group. Must be unique within the scope of your account for the region. Constraints: Up to 255 ASCII characters</param>
        /// <param name="strategy">The placement strategy.</param>
        public CreatePlacementGroupRequest(string groupName, PlacementStrategy strategy)
        {
            _groupName = groupName;
            _strategy = strategy;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// A name for the placement group. Must be unique within the scope of your account for
        /// the region.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 ASCII characters
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The placement strategy.
        /// </para>
        /// </summary>
        public PlacementStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}