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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <code>RecordMarkerFailed</code> event.
    /// </summary>
    public partial class RecordMarkerFailedEventAttributes
    {
        private RecordMarkerFailedCause _cause;
        private long? _decisionTaskCompletedEventId;
        private string _markerName;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// The cause of the failure. This information is generated by the system and can be useful
        /// for diagnostic purposes.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>cause</code> is set to <code>OPERATION_NOT_PERMITTED</code>, the decision
        /// failed because it lacked sufficient permissions. For details and example IAM policies,
        /// see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public RecordMarkerFailedCause Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <code>DecisionTaskCompleted</code> event corresponding to the decision
        /// task that resulted in the <code>RecordMarkerFailed</code> decision for this cancellation
        /// request. This information can be useful for diagnosing problems by tracing back the
        /// chain of events leading up to this event.
        /// </para>
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId.GetValueOrDefault(); }
            set { this._decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this._decisionTaskCompletedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MarkerName. 
        /// <para>
        /// The marker's name.
        /// </para>
        /// </summary>
        public string MarkerName
        {
            get { return this._markerName; }
            set { this._markerName = value; }
        }

        // Check to see if MarkerName property is set
        internal bool IsSetMarkerName()
        {
            return this._markerName != null;
        }

    }
}