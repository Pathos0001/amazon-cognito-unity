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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ListKeyPolicies operation.
    /// Gets the names of the key policies that are attached to a customer master key (CMK).
    /// This operation is designed to get policy names that you can use in a <a>GetKeyPolicy</a>
    /// operation. However, the only valid policy name is <code>default</code>. You cannot
    /// perform this operation on a CMK in a different AWS account.
    /// </summary>
    public partial class ListKeyPoliciesRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private int? _limit;
        private string _marker;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// A unique identifier for the customer master key (CMK).
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or the Amazon Resource Name (ARN) of the CMK.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Use this parameter to specify the maximum number of items to return. When this value
        /// is present, AWS KMS does not return more than the specified number of items, but it
        /// might return fewer.
        /// </para>
        ///  
        /// <para>
        /// This value is optional. If you include a value, it must be between 1 and 1000, inclusive.
        /// If you do not include a value, it defaults to 100.
        /// </para>
        ///  
        /// <para>
        /// Currently only 1 policy can be attached to a key.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter in a subsequent request after you receive a response with truncated
        /// results. Set it to the value of <code>NextMarker</code> from the truncated response
        /// you just received.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}