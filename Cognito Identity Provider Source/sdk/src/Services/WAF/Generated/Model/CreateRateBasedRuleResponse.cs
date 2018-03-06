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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the CreateRateBasedRule operation.
    /// </summary>
    public partial class CreateRateBasedRuleResponse : AmazonWebServiceResponse
    {
        private string _changeToken;
        private RateBasedRule _rule;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The <code>ChangeToken</code> that you used to submit the <code>CreateRateBasedRule</code>
        /// request. You can also use this value to query the status of the request. For more
        /// information, see <a>GetChangeTokenStatus</a>.
        /// </para>
        /// </summary>
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The <a>RateBasedRule</a> that is returned in the <code>CreateRateBasedRule</code>
        /// response.
        /// </para>
        /// </summary>
        public RateBasedRule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

    }
}