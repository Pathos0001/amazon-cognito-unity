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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeWorkspaceDirectories operation.
    /// </summary>
    public partial class DescribeWorkspaceDirectoriesResponse : AmazonWebServiceResponse
    {
        private List<WorkspaceDirectory> _directories = new List<WorkspaceDirectory>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Directories. 
        /// <para>
        /// Information about the directories.
        /// </para>
        /// </summary>
        public List<WorkspaceDirectory> Directories
        {
            get { return this._directories; }
            set { this._directories = value; }
        }

        // Check to see if Directories property is set
        internal bool IsSetDirectories()
        {
            return this._directories != null && this._directories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next set of results, or null if there are no more
        /// results available. This token is valid for one day and must be used within that time
        /// frame.
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

    }
}