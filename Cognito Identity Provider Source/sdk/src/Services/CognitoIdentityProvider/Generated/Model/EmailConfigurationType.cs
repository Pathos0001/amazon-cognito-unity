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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The email configuration type.
    /// </summary>
    public partial class EmailConfigurationType
    {
        private string _replyToEmailAddress;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property ReplyToEmailAddress. 
        /// <para>
        /// The destination to which the receiver of the email should reply to.
        /// </para>
        /// </summary>
        public string ReplyToEmailAddress
        {
            get { return this._replyToEmailAddress; }
            set { this._replyToEmailAddress = value; }
        }

        // Check to see if ReplyToEmailAddress property is set
        internal bool IsSetReplyToEmailAddress()
        {
            return this._replyToEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the email source.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}