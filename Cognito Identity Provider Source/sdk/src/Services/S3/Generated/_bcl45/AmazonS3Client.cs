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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3
{
    /// <summary>
    /// Implementation for accessing S3
    ///
    /// 
    /// </summary>
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonS3Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config()) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AmazonS3Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3Client(AWSCredentials credentials)
            : this(credentials, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new Amazon.S3.Internal.S3Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PreMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3KmsHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3ResponseHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.S3.Internal.AmazonS3ExceptionHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3RedirectHandler());
            pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3RetryPolicy(this.Config)));
        }    

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AbortMultipartUpload


        /// <summary>
        /// Aborts a multipart upload.
        /// 
        /// 
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the List Parts operation and ensure the parts list is empty.
        /// </para>
        /// </summary>
        /// <param name="bucketName">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="key">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="uploadId">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public virtual AbortMultipartUploadResponse AbortMultipartUpload(string bucketName, string key, string uploadId)
        {
            var request = new AbortMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return AbortMultipartUpload(request);
        }


        /// <summary>
        /// Aborts a multipart upload.
        /// 
        /// 
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the List Parts operation and ensure the parts list is empty.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public virtual AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Aborts a multipart upload.
        /// 
        /// 
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the List Parts operation and ensure the parts list is empty.
        /// </para>
        /// </summary>
        /// <param name="bucketName">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="key">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="uploadId">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AbortMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return AbortMultipartUploadAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload


        /// <summary>
        /// Completes a multipart upload by assembling previously uploaded parts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by S3.</returns>
        public virtual CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyObject


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual CopyObjectResponse CopyObject(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObject(request);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceVersionId">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual CopyObjectResponse CopyObject(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObject(request);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyObject service method.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return Invoke<CopyObjectRequest,CopyObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceVersionId">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObjectAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CopyObjectRequest,CopyObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyPart


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual CopyPartResponse CopyPart(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPart(request);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceVersionId">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual CopyPartResponse CopyPart(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPart(request);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyPart service method.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual CopyPartResponse CopyPart(CopyPartRequest request)
        {
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.Instance;

            return Invoke<CopyPartRequest,CopyPartResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual Task<CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPartAsync(request, cancellationToken);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceVersionId">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual Task<CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPartAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CopyPartResponse> CopyPartAsync(CopyPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.Instance;

            return InvokeAsync<CopyPartRequest,CopyPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucket


        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and Delete Markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketRequest used to execute the DeleteBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public virtual DeleteBucketResponse DeleteBucket(string bucketName)
        {
            var request = new DeleteBucketRequest();
            request.BucketName = bucketName;
            return DeleteBucket(request);
        }


        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and Delete Markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public virtual DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketRequest,DeleteBucketResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and Delete Markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketRequest used to execute the DeleteBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketRequest();
            request.BucketName = bucketName;
            return DeleteBucketAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketRequest,DeleteBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketAnalyticsConfiguration


        /// <summary>
        /// Deletes an analytics configuration for the bucket (specified by the analytics configuration
        /// ID).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAnalyticsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        public virtual DeleteBucketAnalyticsConfigurationResponse DeleteBucketAnalyticsConfiguration(DeleteBucketAnalyticsConfigurationRequest request)
        {
            var marshaller = new DeleteBucketAnalyticsConfigurationRequestMarshaller();
            var unmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketAnalyticsConfigurationRequest,DeleteBucketAnalyticsConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAnalyticsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketAnalyticsConfigurationResponse> DeleteBucketAnalyticsConfigurationAsync(DeleteBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketAnalyticsConfigurationRequestMarshaller();
            var unmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketAnalyticsConfigurationRequest,DeleteBucketAnalyticsConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketEncryption


        /// <summary>
        /// Deletes the server-side encryption configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketEncryption service method, as returned by S3.</returns>
        public virtual DeleteBucketEncryptionResponse DeleteBucketEncryption(DeleteBucketEncryptionRequest request)
        {
            var marshaller = new DeleteBucketEncryptionRequestMarshaller();
            var unmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketEncryptionRequest,DeleteBucketEncryptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(DeleteBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketEncryptionRequestMarshaller();
            var unmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketEncryptionRequest,DeleteBucketEncryptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketInventoryConfiguration


        /// <summary>
        /// Deletes an inventory configuration (identified by the inventory ID) from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketInventoryConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketInventoryConfiguration service method, as returned by S3.</returns>
        public virtual DeleteBucketInventoryConfigurationResponse DeleteBucketInventoryConfiguration(DeleteBucketInventoryConfigurationRequest request)
        {
            var marshaller = new DeleteBucketInventoryConfigurationRequestMarshaller();
            var unmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketInventoryConfigurationRequest,DeleteBucketInventoryConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketInventoryConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketInventoryConfigurationResponse> DeleteBucketInventoryConfigurationAsync(DeleteBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketInventoryConfigurationRequestMarshaller();
            var unmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketInventoryConfigurationRequest,DeleteBucketInventoryConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketMetricsConfiguration


        /// <summary>
        /// Deletes a metrics configuration (specified by the metrics configuration ID) from the
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketMetricsConfiguration service method, as returned by S3.</returns>
        public virtual DeleteBucketMetricsConfigurationResponse DeleteBucketMetricsConfiguration(DeleteBucketMetricsConfigurationRequest request)
        {
            var marshaller = new DeleteBucketMetricsConfigurationRequestMarshaller();
            var unmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketMetricsConfigurationRequest,DeleteBucketMetricsConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketMetricsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketMetricsConfigurationResponse> DeleteBucketMetricsConfigurationAsync(DeleteBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketMetricsConfigurationRequestMarshaller();
            var unmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketMetricsConfigurationRequest,DeleteBucketMetricsConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketPolicy


        /// <summary>
        /// Deletes the policy from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketPolicyRequest used to execute the DeleteBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public virtual DeleteBucketPolicyResponse DeleteBucketPolicy(string bucketName)
        {
            var request = new DeleteBucketPolicyRequest();
            request.BucketName = bucketName;
            return DeleteBucketPolicy(request);
        }


        /// <summary>
        /// Deletes the policy from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public virtual DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the policy from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketPolicyRequest used to execute the DeleteBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketPolicyRequest();
            request.BucketName = bucketName;
            return DeleteBucketPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketReplication


        /// <summary>
        /// Deletes the replication configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketReplication service method, as returned by S3.</returns>
        public virtual DeleteBucketReplicationResponse DeleteBucketReplication(DeleteBucketReplicationRequest request)
        {
            var marshaller = new DeleteBucketReplicationRequestMarshaller();
            var unmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketReplicationRequest,DeleteBucketReplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketReplicationResponse> DeleteBucketReplicationAsync(DeleteBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketReplicationRequestMarshaller();
            var unmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketReplicationRequest,DeleteBucketReplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketTagging


        /// <summary>
        /// Deletes the tags from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketTaggingRequest used to execute the DeleteBucketTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public virtual DeleteBucketTaggingResponse DeleteBucketTagging(string bucketName)
        {
            var request = new DeleteBucketTaggingRequest();
            request.BucketName = bucketName;
            return DeleteBucketTagging(request);
        }


        /// <summary>
        /// Deletes the tags from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public virtual DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the tags from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketTaggingRequest used to execute the DeleteBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketTaggingRequest();
            request.BucketName = bucketName;
            return DeleteBucketTaggingAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketWebsite


        /// <summary>
        /// This operation removes the website configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketWebsiteRequest used to execute the DeleteBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public virtual DeleteBucketWebsiteResponse DeleteBucketWebsite(string bucketName)
        {
            var request = new DeleteBucketWebsiteRequest();
            request.BucketName = bucketName;
            return DeleteBucketWebsite(request);
        }


        /// <summary>
        /// This operation removes the website configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public virtual DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation removes the website configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketWebsiteRequest used to execute the DeleteBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketWebsiteRequest();
            request.BucketName = bucketName;
            return DeleteBucketWebsiteAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCORSConfiguration


        /// <summary>
        /// Deletes the cors configuration information set for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteCORSConfigurationRequest used to execute the DeleteCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public virtual DeleteCORSConfigurationResponse DeleteCORSConfiguration(string bucketName)
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteCORSConfiguration(request);
        }


        /// <summary>
        /// Deletes the cors configuration information set for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public virtual DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the cors configuration information set for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteCORSConfigurationRequest used to execute the DeleteCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public virtual Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteCORSConfigurationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecycleConfiguration


        /// <summary>
        /// Deletes the lifecycle configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteLifecycleConfigurationRequest used to execute the DeleteLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(string bucketName)
        {
            var request = new DeleteLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteLifecycleConfiguration(request);
        }


        /// <summary>
        /// Deletes the lifecycle configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the lifecycle configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteLifecycleConfigurationRequest used to execute the DeleteLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteLifecycleConfigurationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteObject


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual DeleteObjectResponse DeleteObject(string bucketName, string key)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return DeleteObject(request);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual DeleteObjectResponse DeleteObject(string bucketName, string key, string versionId)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return DeleteObject(request);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return DeleteObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return DeleteObjectAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteObjects


        /// <summary>
        /// This operation enables you to delete multiple objects from a bucket using a single
        /// HTTP request. You may specify up to 1000 keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects service method.</param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by S3.</returns>
        public virtual DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsRequest,DeleteObjectsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectsRequest,DeleteObjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteObjectTagging


        /// <summary>
        /// Removes the tag-set from an existing object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteObjectTagging service method, as returned by S3.</returns>
        public virtual DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request)
        {
            var marshaller = new DeleteObjectTaggingRequestMarshaller();
            var unmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectTaggingRequest,DeleteObjectTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(DeleteObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectTaggingRequestMarshaller();
            var unmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectTaggingRequest,DeleteObjectTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetACL


        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetACLRequest used to execute the GetACL service method.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public virtual GetACLResponse GetACL(string bucketName)
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            return GetACL(request);
        }


        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetACL service method.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public virtual GetACLResponse GetACL(GetACLRequest request)
        {
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.Instance;

            return Invoke<GetACLRequest,GetACLResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetACLRequest used to execute the GetACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public virtual Task<GetACLResponse> GetACLAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            return GetACLAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetACLResponse> GetACLAsync(GetACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetACLRequest,GetACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketAccelerateConfiguration


        /// <summary>
        /// Returns the accelerate configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which the accelerate configuration is retrieved.</param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(string bucketName)
        {
            var request = new GetBucketAccelerateConfigurationRequest();
            request.BucketName = bucketName;
            return GetBucketAccelerateConfiguration(request);
        }


        /// <summary>
        /// Returns the accelerate configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(GetBucketAccelerateConfigurationRequest request)
        {
            var marshaller = new GetBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAccelerateConfigurationRequest,GetBucketAccelerateConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the accelerate configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which the accelerate configuration is retrieved.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public virtual Task<GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketAccelerateConfigurationRequest();
            request.BucketName = bucketName;
            return GetBucketAccelerateConfigurationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(GetBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketAccelerateConfigurationRequest,GetBucketAccelerateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketAnalyticsConfiguration


        /// <summary>
        /// Gets an analytics configuration for the bucket (specified by the analytics configuration
        /// ID).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAnalyticsConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketAnalyticsConfigurationResponse GetBucketAnalyticsConfiguration(GetBucketAnalyticsConfigurationRequest request)
        {
            var marshaller = new GetBucketAnalyticsConfigurationRequestMarshaller();
            var unmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAnalyticsConfigurationRequest,GetBucketAnalyticsConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAnalyticsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketAnalyticsConfigurationResponse> GetBucketAnalyticsConfigurationAsync(GetBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketAnalyticsConfigurationRequestMarshaller();
            var unmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketAnalyticsConfigurationRequest,GetBucketAnalyticsConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketEncryption


        /// <summary>
        /// Returns the server-side encryption configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the GetBucketEncryption service method, as returned by S3.</returns>
        public virtual GetBucketEncryptionResponse GetBucketEncryption(GetBucketEncryptionRequest request)
        {
            var marshaller = new GetBucketEncryptionRequestMarshaller();
            var unmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetBucketEncryptionRequest,GetBucketEncryptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketEncryptionResponse> GetBucketEncryptionAsync(GetBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketEncryptionRequestMarshaller();
            var unmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketEncryptionRequest,GetBucketEncryptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketInventoryConfiguration


        /// <summary>
        /// Returns an inventory configuration (identified by the inventory ID) from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketInventoryConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketInventoryConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketInventoryConfigurationResponse GetBucketInventoryConfiguration(GetBucketInventoryConfigurationRequest request)
        {
            var marshaller = new GetBucketInventoryConfigurationRequestMarshaller();
            var unmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketInventoryConfigurationRequest,GetBucketInventoryConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketInventoryConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketInventoryConfigurationResponse> GetBucketInventoryConfigurationAsync(GetBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketInventoryConfigurationRequestMarshaller();
            var unmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketInventoryConfigurationRequest,GetBucketInventoryConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLocation


        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLocationRequest used to execute the GetBucketLocation service method.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public virtual GetBucketLocationResponse GetBucketLocation(string bucketName)
        {
            var request = new GetBucketLocationRequest();
            request.BucketName = bucketName;
            return GetBucketLocation(request);
        }


        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation service method.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public virtual GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return Invoke<GetBucketLocationRequest,GetBucketLocationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLocationRequest used to execute the GetBucketLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public virtual Task<GetBucketLocationResponse> GetBucketLocationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketLocationRequest();
            request.BucketName = bucketName;
            return GetBucketLocationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLocationRequest,GetBucketLocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLogging


        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLoggingRequest used to execute the GetBucketLogging service method.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public virtual GetBucketLoggingResponse GetBucketLogging(string bucketName)
        {
            var request = new GetBucketLoggingRequest();
            request.BucketName = bucketName;
            return GetBucketLogging(request);
        }


        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging service method.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public virtual GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketLoggingRequest,GetBucketLoggingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLoggingRequest used to execute the GetBucketLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public virtual Task<GetBucketLoggingResponse> GetBucketLoggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketLoggingRequest();
            request.BucketName = bucketName;
            return GetBucketLoggingAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLoggingRequest,GetBucketLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketMetricsConfiguration


        /// <summary>
        /// Gets a metrics configuration (specified by the metrics configuration ID) from the
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketMetricsConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketMetricsConfigurationResponse GetBucketMetricsConfiguration(GetBucketMetricsConfigurationRequest request)
        {
            var marshaller = new GetBucketMetricsConfigurationRequestMarshaller();
            var unmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketMetricsConfigurationRequest,GetBucketMetricsConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketMetricsConfigurationResponse> GetBucketMetricsConfigurationAsync(GetBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketMetricsConfigurationRequestMarshaller();
            var unmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketMetricsConfigurationRequest,GetBucketMetricsConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketNotification


        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket to get the notification configuration for.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public virtual GetBucketNotificationResponse GetBucketNotification(string bucketName)
        {
            var request = new GetBucketNotificationRequest();
            request.BucketName = bucketName;
            return GetBucketNotification(request);
        }


        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification service method.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public virtual GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request)
        {
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<GetBucketNotificationRequest,GetBucketNotificationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket to get the notification configuration for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public virtual Task<GetBucketNotificationResponse> GetBucketNotificationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketNotificationRequest();
            request.BucketName = bucketName;
            return GetBucketNotificationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketNotificationRequest,GetBucketNotificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketPolicy


        /// <summary>
        /// Returns the policy of a specified bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketPolicyRequest used to execute the GetBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public virtual GetBucketPolicyResponse GetBucketPolicy(string bucketName)
        {
            var request = new GetBucketPolicyRequest();
            request.BucketName = bucketName;
            return GetBucketPolicy(request);
        }


        /// <summary>
        /// Returns the policy of a specified bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public virtual GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyRequest,GetBucketPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the policy of a specified bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketPolicyRequest used to execute the GetBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<GetBucketPolicyResponse> GetBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketPolicyRequest();
            request.BucketName = bucketName;
            return GetBucketPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketPolicyRequest,GetBucketPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketReplication


        /// <summary>
        /// Retrieves the replication configuration for the given Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication service method.</param>
        /// 
        /// <returns>The response from the GetBucketReplication service method, as returned by S3.</returns>
        public virtual GetBucketReplicationResponse GetBucketReplication(GetBucketReplicationRequest request)
        {
            var marshaller = new GetBucketReplicationRequestMarshaller();
            var unmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<GetBucketReplicationRequest,GetBucketReplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketReplicationResponse> GetBucketReplicationAsync(GetBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketReplicationRequestMarshaller();
            var unmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketReplicationRequest,GetBucketReplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketRequestPayment


        /// <summary>
        /// Returns the request payment configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketRequestPaymentRequest used to execute the GetBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public virtual GetBucketRequestPaymentResponse GetBucketRequestPayment(string bucketName)
        {
            var request = new GetBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            return GetBucketRequestPayment(request);
        }


        /// <summary>
        /// Returns the request payment configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public virtual GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request)
        {
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the request payment configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketRequestPaymentRequest used to execute the GetBucketRequestPayment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public virtual Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            return GetBucketRequestPaymentAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketTagging


        /// <summary>
        /// Returns the tag set associated with the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging service method.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by S3.</returns>
        public virtual GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketTaggingRequest,GetBucketTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketTaggingRequest,GetBucketTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketVersioning


        /// <summary>
        /// Returns the versioning state of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketVersioningRequest used to execute the GetBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public virtual GetBucketVersioningResponse GetBucketVersioning(string bucketName)
        {
            var request = new GetBucketVersioningRequest();
            request.BucketName = bucketName;
            return GetBucketVersioning(request);
        }


        /// <summary>
        /// Returns the versioning state of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public virtual GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<GetBucketVersioningRequest,GetBucketVersioningResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the versioning state of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketVersioningRequest used to execute the GetBucketVersioning service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public virtual Task<GetBucketVersioningResponse> GetBucketVersioningAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketVersioningRequest();
            request.BucketName = bucketName;
            return GetBucketVersioningAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketVersioningRequest,GetBucketVersioningResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketWebsite


        /// <summary>
        /// Returns the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketWebsiteRequest used to execute the GetBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public virtual GetBucketWebsiteResponse GetBucketWebsite(string bucketName)
        {
            var request = new GetBucketWebsiteRequest();
            request.BucketName = bucketName;
            return GetBucketWebsite(request);
        }


        /// <summary>
        /// Returns the website configuration for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public virtual GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<GetBucketWebsiteRequest,GetBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketWebsiteRequest used to execute the GetBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public virtual Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketWebsiteRequest();
            request.BucketName = bucketName;
            return GetBucketWebsiteAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketWebsiteRequest,GetBucketWebsiteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCORSConfiguration


        /// <summary>
        /// Returns the cors configuration for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetCORSConfigurationRequest used to execute the GetCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public virtual GetCORSConfigurationResponse GetCORSConfiguration(string bucketName)
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            return GetCORSConfiguration(request);
        }


        /// <summary>
        /// Returns the cors configuration for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public virtual GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCORSConfigurationRequest,GetCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the cors configuration for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetCORSConfigurationRequest used to execute the GetCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public virtual Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            return GetCORSConfigurationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCORSConfigurationRequest,GetCORSConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLifecycleConfiguration


        /// <summary>
        /// Returns the lifecycle configuration information set on the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetLifecycleConfigurationRequest used to execute the GetLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual GetLifecycleConfigurationResponse GetLifecycleConfiguration(string bucketName)
        {
            var request = new GetLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return GetLifecycleConfiguration(request);
        }


        /// <summary>
        /// Returns the lifecycle configuration information set on the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the lifecycle configuration information set on the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetLifecycleConfigurationRequest used to execute the GetLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return GetLifecycleConfigurationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObject


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual GetObjectResponse GetObject(string bucketName, string key)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObject(request);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual GetObjectResponse GetObject(string bucketName, string key, string versionId)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObject(request);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual GetObjectResponse GetObject(GetObjectRequest request)
        {
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectRequest,GetObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual Task<GetObjectResponse> GetObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual Task<GetObjectResponse> GetObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectRequest,GetObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectMetadata


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual GetObjectMetadataResponse GetObjectMetadata(string bucketName, string key)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectMetadata(request);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual GetObjectMetadataResponse GetObjectMetadata(string bucketName, string key, string versionId)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectMetadata(request);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata service method.</param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return Invoke<GetObjectMetadataRequest,GetObjectMetadataResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectMetadataAsync(request, cancellationToken);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectMetadataAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectMetadataRequest,GetObjectMetadataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectTagging


        /// <summary>
        /// Returns the tag-set of an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTagging service method.</param>
        /// 
        /// <returns>The response from the GetObjectTagging service method, as returned by S3.</returns>
        public virtual GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request)
        {
            var marshaller = new GetObjectTaggingRequestMarshaller();
            var unmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<GetObjectTaggingRequest,GetObjectTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectTaggingResponse> GetObjectTaggingAsync(GetObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectTaggingRequestMarshaller();
            var unmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectTaggingRequest,GetObjectTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectTorrent


        /// <summary>
        /// Return torrent files from a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="key">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public virtual GetObjectTorrentResponse GetObjectTorrent(string bucketName, string key)
        {
            var request = new GetObjectTorrentRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectTorrent(request);
        }


        /// <summary>
        /// Return torrent files from a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent service method.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public virtual GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request)
        {
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return Invoke<GetObjectTorrentRequest,GetObjectTorrentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Return torrent files from a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="key">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public virtual Task<GetObjectTorrentResponse> GetObjectTorrentAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectTorrentRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectTorrentAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectTorrentRequest,GetObjectTorrentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  HeadBucket


        /// <summary>
        /// This operation is useful to determine if a bucket exists and you have permission to
        /// access it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket service method.</param>
        /// 
        /// <returns>The response from the HeadBucket service method, as returned by S3.</returns>
        internal virtual HeadBucketResponse HeadBucket(HeadBucketRequest request)
        {
            var marshaller = new HeadBucketRequestMarshaller();
            var unmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return Invoke<HeadBucketRequest,HeadBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HeadBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        internal virtual Task<HeadBucketResponse> HeadBucketAsync(HeadBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new HeadBucketRequestMarshaller();
            var unmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return InvokeAsync<HeadBucketRequest,HeadBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload


        /// <summary>
        /// Initiates a multipart upload and returns an upload ID.
        /// 
        /// 
        /// <para>
        /// <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="bucketName">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="key">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public virtual InitiateMultipartUploadResponse InitiateMultipartUpload(string bucketName, string key)
        {
            var request = new InitiateMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return InitiateMultipartUpload(request);
        }


        /// <summary>
        /// Initiates a multipart upload and returns an upload ID.
        /// 
        /// 
        /// <para>
        /// <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public virtual InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates a multipart upload and returns an upload ID.
        /// 
        /// 
        /// <para>
        /// <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="bucketName">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="key">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new InitiateMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return InitiateMultipartUploadAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBucketAnalyticsConfigurations


        /// <summary>
        /// Lists the analytics configurations for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketAnalyticsConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListBucketAnalyticsConfigurations service method, as returned by S3.</returns>
        public virtual ListBucketAnalyticsConfigurationsResponse ListBucketAnalyticsConfigurations(ListBucketAnalyticsConfigurationsRequest request)
        {
            var marshaller = new ListBucketAnalyticsConfigurationsRequestMarshaller();
            var unmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketAnalyticsConfigurationsRequest,ListBucketAnalyticsConfigurationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketAnalyticsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketAnalyticsConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketAnalyticsConfigurationsResponse> ListBucketAnalyticsConfigurationsAsync(ListBucketAnalyticsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBucketAnalyticsConfigurationsRequestMarshaller();
            var unmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketAnalyticsConfigurationsRequest,ListBucketAnalyticsConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBucketInventoryConfigurations


        /// <summary>
        /// Returns a list of inventory configurations for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketInventoryConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListBucketInventoryConfigurations service method, as returned by S3.</returns>
        public virtual ListBucketInventoryConfigurationsResponse ListBucketInventoryConfigurations(ListBucketInventoryConfigurationsRequest request)
        {
            var marshaller = new ListBucketInventoryConfigurationsRequestMarshaller();
            var unmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketInventoryConfigurationsRequest,ListBucketInventoryConfigurationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketInventoryConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketInventoryConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketInventoryConfigurationsResponse> ListBucketInventoryConfigurationsAsync(ListBucketInventoryConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBucketInventoryConfigurationsRequestMarshaller();
            var unmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketInventoryConfigurationsRequest,ListBucketInventoryConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBucketMetricsConfigurations


        /// <summary>
        /// Lists the metrics configurations for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketMetricsConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListBucketMetricsConfigurations service method, as returned by S3.</returns>
        public virtual ListBucketMetricsConfigurationsResponse ListBucketMetricsConfigurations(ListBucketMetricsConfigurationsRequest request)
        {
            var marshaller = new ListBucketMetricsConfigurationsRequestMarshaller();
            var unmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketMetricsConfigurationsRequest,ListBucketMetricsConfigurationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketMetricsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketMetricsConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketMetricsConfigurationsResponse> ListBucketMetricsConfigurationsAsync(ListBucketMetricsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBucketMetricsConfigurationsRequestMarshaller();
            var unmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketMetricsConfigurationsRequest,ListBucketMetricsConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBuckets


        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public virtual ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }


        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets service method.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public virtual ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return Invoke<ListBucketsRequest,ListBucketsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public virtual Task<ListBucketsResponse> ListBucketsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListBucketsAsync(new ListBucketsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketsRequest,ListBucketsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual ListMultipartUploadsResponse ListMultipartUploads(string bucketName)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            return ListMultipartUploads(request);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="prefix">Lists in-progress uploads only for those keys that begin with the specified prefix.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual ListMultipartUploadsResponse ListMultipartUploads(string bucketName, string prefix)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListMultipartUploads(request);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            return ListMultipartUploadsAsync(request, cancellationToken);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="prefix">Lists in-progress uploads only for those keys that begin with the specified prefix.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListMultipartUploadsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjects


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual ListObjectsResponse ListObjects(string bucketName)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            return ListObjects(request);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual ListObjectsResponse ListObjects(string bucketName, string prefix)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListObjects(request);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjects service method.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return Invoke<ListObjectsRequest,ListObjectsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            return ListObjectsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListObjectsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectsRequest,ListObjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjectsV2


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. Note:
        /// ListObjectsV2 is the revised List Objects API and we recommend you use this revised
        /// API for new application development.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 service method.</param>
        /// 
        /// <returns>The response from the ListObjectsV2 service method, as returned by S3.</returns>
        public virtual ListObjectsV2Response ListObjectsV2(ListObjectsV2Request request)
        {
            var marshaller = new ListObjectsV2RequestMarshaller();
            var unmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return Invoke<ListObjectsV2Request,ListObjectsV2Response>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListObjectsV2Response> ListObjectsV2Async(ListObjectsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectsV2RequestMarshaller();
            var unmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectsV2Request,ListObjectsV2Response>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListParts


        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload.
        /// </summary>
        /// <param name="bucketName">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="key">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose parts are being listed.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public virtual ListPartsResponse ListParts(string bucketName, string key, string uploadId)
        {
            var request = new ListPartsRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return ListParts(request);
        }


        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public virtual ListPartsResponse ListParts(ListPartsRequest request)
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsRequest,ListPartsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload.
        /// </summary>
        /// <param name="bucketName">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="key">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose parts are being listed.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public virtual Task<ListPartsResponse> ListPartsAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPartsRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return ListPartsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartsRequest,ListPartsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVersions


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual ListVersionsResponse ListVersions(string bucketName)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            return ListVersions(request);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual ListVersionsResponse ListVersions(string bucketName, string prefix)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListVersions(request);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsRequest,ListVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            return ListVersionsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListVersionsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVersionsRequest,ListVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutACL


        /// <summary>
        /// Sets the permissions on a bucket using access control lists (ACL).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutACL service method.</param>
        /// 
        /// <returns>The response from the PutACL service method, as returned by S3.</returns>
        public virtual PutACLResponse PutACL(PutACLRequest request)
        {
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.Instance;

            return Invoke<PutACLRequest,PutACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutACLResponse> PutACLAsync(PutACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.Instance;

            return InvokeAsync<PutACLRequest,PutACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucket


        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequest used to execute the PutBucket service method.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public virtual PutBucketResponse PutBucket(string bucketName)
        {
            var request = new PutBucketRequest();
            request.BucketName = bucketName;
            return PutBucket(request);
        }


        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucket service method.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public virtual PutBucketResponse PutBucket(PutBucketRequest request)
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequest,PutBucketResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequest used to execute the PutBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public virtual Task<PutBucketResponse> PutBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketRequest();
            request.BucketName = bucketName;
            return PutBucketAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketRequest,PutBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketAccelerateConfiguration


        /// <summary>
        /// Sets the accelerate configuration of an existing bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public virtual PutBucketAccelerateConfigurationResponse PutBucketAccelerateConfiguration(PutBucketAccelerateConfigurationRequest request)
        {
            var marshaller = new PutBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAccelerateConfigurationRequest,PutBucketAccelerateConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketAccelerateConfigurationResponse> PutBucketAccelerateConfigurationAsync(PutBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketAccelerateConfigurationRequest,PutBucketAccelerateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketAnalyticsConfiguration


        /// <summary>
        /// Sets an analytics configuration for the bucket (specified by the analytics configuration
        /// ID).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAnalyticsConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        public virtual PutBucketAnalyticsConfigurationResponse PutBucketAnalyticsConfiguration(PutBucketAnalyticsConfigurationRequest request)
        {
            var marshaller = new PutBucketAnalyticsConfigurationRequestMarshaller();
            var unmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAnalyticsConfigurationRequest,PutBucketAnalyticsConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAnalyticsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketAnalyticsConfigurationResponse> PutBucketAnalyticsConfigurationAsync(PutBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketAnalyticsConfigurationRequestMarshaller();
            var unmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketAnalyticsConfigurationRequest,PutBucketAnalyticsConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketEncryption


        /// <summary>
        /// Creates a new server-side encryption configuration (or replaces an existing one, if
        /// present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the PutBucketEncryption service method, as returned by S3.</returns>
        public virtual PutBucketEncryptionResponse PutBucketEncryption(PutBucketEncryptionRequest request)
        {
            var marshaller = new PutBucketEncryptionRequestMarshaller();
            var unmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<PutBucketEncryptionRequest,PutBucketEncryptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketEncryptionResponse> PutBucketEncryptionAsync(PutBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketEncryptionRequestMarshaller();
            var unmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketEncryptionRequest,PutBucketEncryptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketInventoryConfiguration


        /// <summary>
        /// Adds an inventory configuration (identified by the inventory ID) from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketInventoryConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketInventoryConfiguration service method, as returned by S3.</returns>
        public virtual PutBucketInventoryConfigurationResponse PutBucketInventoryConfiguration(PutBucketInventoryConfigurationRequest request)
        {
            var marshaller = new PutBucketInventoryConfigurationRequestMarshaller();
            var unmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketInventoryConfigurationRequest,PutBucketInventoryConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketInventoryConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketInventoryConfigurationResponse> PutBucketInventoryConfigurationAsync(PutBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketInventoryConfigurationRequestMarshaller();
            var unmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketInventoryConfigurationRequest,PutBucketInventoryConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketLogging


        /// <summary>
        /// Set the logging parameters for a bucket and to specify permissions for who can view
        /// and modify the logging parameters. To set the logging status of a bucket, you must
        /// be the bucket owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging service method.</param>
        /// 
        /// <returns>The response from the PutBucketLogging service method, as returned by S3.</returns>
        public virtual PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request)
        {
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketLoggingRequest,PutBucketLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketLoggingRequest,PutBucketLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketMetricsConfiguration


        /// <summary>
        /// Sets a metrics configuration (specified by the metrics configuration ID) for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketMetricsConfiguration service method, as returned by S3.</returns>
        public virtual PutBucketMetricsConfigurationResponse PutBucketMetricsConfiguration(PutBucketMetricsConfigurationRequest request)
        {
            var marshaller = new PutBucketMetricsConfigurationRequestMarshaller();
            var unmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketMetricsConfigurationRequest,PutBucketMetricsConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketMetricsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketMetricsConfigurationResponse> PutBucketMetricsConfigurationAsync(PutBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketMetricsConfigurationRequestMarshaller();
            var unmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketMetricsConfigurationRequest,PutBucketMetricsConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketNotification


        /// <summary>
        /// Enables notifications of specified events for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification service method.</param>
        /// 
        /// <returns>The response from the PutBucketNotification service method, as returned by S3.</returns>
        public virtual PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request)
        {
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<PutBucketNotificationRequest,PutBucketNotificationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketNotificationRequest,PutBucketNotificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketPolicy


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual PutBucketPolicyResponse PutBucketPolicy(string bucketName, string policy)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            return PutBucketPolicy(request);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="contentMD5">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual PutBucketPolicyResponse PutBucketPolicy(string bucketName, string policy, string contentMD5)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            request.ContentMD5 = contentMD5;
            return PutBucketPolicy(request);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBucketPolicyRequest,PutBucketPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            return PutBucketPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="contentMD5">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, string contentMD5, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            request.ContentMD5 = contentMD5;
            return PutBucketPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketPolicyRequest,PutBucketPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketReplication


        /// <summary>
        /// Creates a new replication configuration (or replaces an existing one, if present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication service method.</param>
        /// 
        /// <returns>The response from the PutBucketReplication service method, as returned by S3.</returns>
        public virtual PutBucketReplicationResponse PutBucketReplication(PutBucketReplicationRequest request)
        {
            var marshaller = new PutBucketReplicationRequestMarshaller();
            var unmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<PutBucketReplicationRequest,PutBucketReplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketReplicationResponse> PutBucketReplicationAsync(PutBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketReplicationRequestMarshaller();
            var unmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketReplicationRequest,PutBucketReplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketRequestPayment


        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. Documentation on requester pays buckets can be found at http://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="requestPaymentConfiguration">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public virtual PutBucketRequestPaymentResponse PutBucketRequestPayment(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration)
        {
            var request = new PutBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            request.RequestPaymentConfiguration = requestPaymentConfiguration;
            return PutBucketRequestPayment(request);
        }


        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. Documentation on requester pays buckets can be found at http://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public virtual PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request)
        {
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. Documentation on requester pays buckets can be found at http://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="requestPaymentConfiguration">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public virtual Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            request.RequestPaymentConfiguration = requestPaymentConfiguration;
            return PutBucketRequestPaymentAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketTagging


        /// <summary>
        /// Sets the tags for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="tagSet">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public virtual PutBucketTaggingResponse PutBucketTagging(string bucketName, List<Tag> tagSet)
        {
            var request = new PutBucketTaggingRequest();
            request.BucketName = bucketName;
            request.TagSet = tagSet;
            return PutBucketTagging(request);
        }


        /// <summary>
        /// Sets the tags for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging service method.</param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public virtual PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketTaggingRequest,PutBucketTaggingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets the tags for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="tagSet">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public virtual Task<PutBucketTaggingResponse> PutBucketTaggingAsync(string bucketName, List<Tag> tagSet, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketTaggingRequest();
            request.BucketName = bucketName;
            request.TagSet = tagSet;
            return PutBucketTaggingAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketTaggingRequest,PutBucketTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketVersioning


        /// <summary>
        /// Sets the versioning state of an existing bucket. To set the versioning state, you
        /// must be the bucket owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the PutBucketVersioning service method, as returned by S3.</returns>
        public virtual PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request)
        {
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<PutBucketVersioningRequest,PutBucketVersioningResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketVersioningRequest,PutBucketVersioningResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketWebsite


        /// <summary>
        /// Set the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="websiteConfiguration">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public virtual PutBucketWebsiteResponse PutBucketWebsite(string bucketName, WebsiteConfiguration websiteConfiguration)
        {
            var request = new PutBucketWebsiteRequest();
            request.BucketName = bucketName;
            request.WebsiteConfiguration = websiteConfiguration;
            return PutBucketWebsite(request);
        }


        /// <summary>
        /// Set the website configuration for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public virtual PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<PutBucketWebsiteRequest,PutBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Set the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="websiteConfiguration">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public virtual Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(string bucketName, WebsiteConfiguration websiteConfiguration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketWebsiteRequest();
            request.BucketName = bucketName;
            request.WebsiteConfiguration = websiteConfiguration;
            return PutBucketWebsiteAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketWebsiteRequest,PutBucketWebsiteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutCORSConfiguration


        /// <summary>
        /// Sets the cors configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="configuration">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public virtual PutCORSConfigurationResponse PutCORSConfiguration(string bucketName, CORSConfiguration configuration)
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutCORSConfiguration(request);
        }


        /// <summary>
        /// Sets the cors configuration for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public virtual PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutCORSConfigurationRequest,PutCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets the cors configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="configuration">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public virtual Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(string bucketName, CORSConfiguration configuration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutCORSConfigurationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutCORSConfigurationRequest,PutCORSConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleConfiguration


        /// <summary>
        /// Sets lifecycle configuration for your bucket. If a lifecycle configuration exists,
        /// it replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="configuration">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual PutLifecycleConfigurationResponse PutLifecycleConfiguration(string bucketName, LifecycleConfiguration configuration)
        {
            var request = new PutLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutLifecycleConfiguration(request);
        }


        /// <summary>
        /// Sets lifecycle configuration for your bucket. If a lifecycle configuration exists,
        /// it replaces it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets lifecycle configuration for your bucket. If a lifecycle configuration exists,
        /// it replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="configuration">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(string bucketName, LifecycleConfiguration configuration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutLifecycleConfigurationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutObject


        /// <summary>
        /// Adds an object to a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by S3.</returns>
        public virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectRequest,PutObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectRequest,PutObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutObjectTagging


        /// <summary>
        /// Sets the supplied tag-set to an object that already exists in a bucket
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectTagging service method.</param>
        /// 
        /// <returns>The response from the PutObjectTagging service method, as returned by S3.</returns>
        public virtual PutObjectTaggingResponse PutObjectTagging(PutObjectTaggingRequest request)
        {
            var marshaller = new PutObjectTaggingRequestMarshaller();
            var unmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<PutObjectTaggingRequest,PutObjectTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutObjectTaggingResponse> PutObjectTaggingAsync(PutObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutObjectTaggingRequestMarshaller();
            var unmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectTaggingRequest,PutObjectTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreObject


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key, int days)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.Days = days;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key, string versionId)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key, string versionId, int days)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            request.Days = days;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return Invoke<RestoreObjectRequest,RestoreObjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, int days, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.Days = days;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, int days, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            request.Days = days;
            return RestoreObjectAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreObjectRequest,RestoreObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadPart


        /// <summary>
        /// Uploads a part in a multipart upload.
        /// 
        /// 
        /// <para>
        /// <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadPart service method.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by S3.</returns>
        public virtual UploadPartResponse UploadPart(UploadPartRequest request)
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.Instance;

            return Invoke<UploadPartRequest,UploadPartResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadPartRequest,UploadPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}