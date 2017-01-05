// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for TaskOperations.
    /// </summary>
    public static partial class TaskOperationsExtensions
    {
            /// <summary>
            /// Adds a task to the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job to which the task is to be added.
            /// </param>
            /// <param name='task'>
            /// The task to be added.
            /// </param>
            /// <param name='taskAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskAddHeaders Add(this ITaskOperations operations, string jobId, TaskAddParameter task, TaskAddOptions taskAddOptions = default(TaskAddOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).AddAsync(jobId, task, taskAddOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a task to the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job to which the task is to be added.
            /// </param>
            /// <param name='task'>
            /// The task to be added.
            /// </param>
            /// <param name='taskAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskAddHeaders> AddAsync(this ITaskOperations operations, string jobId, TaskAddParameter task, TaskAddOptions taskAddOptions = default(TaskAddOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(jobId, task, taskAddOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job.
            /// </param>
            /// <param name='taskListOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CloudTask> List(this ITaskOperations operations, string jobId, TaskListOptions taskListOptions = default(TaskListOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).ListAsync(jobId, taskListOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job.
            /// </param>
            /// <param name='taskListOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CloudTask>> ListAsync(this ITaskOperations operations, string jobId, TaskListOptions taskListOptions = default(TaskListOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(jobId, taskListOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a collection of tasks to the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job to which the task collection is to be added.
            /// </param>
            /// <param name='value'>
            /// The collection of tasks to add.
            /// </param>
            /// <param name='taskAddCollectionOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskAddCollectionResult AddCollection(this ITaskOperations operations, string jobId, System.Collections.Generic.IList<TaskAddParameter> value, TaskAddCollectionOptions taskAddCollectionOptions = default(TaskAddCollectionOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).AddCollectionAsync(jobId, value, taskAddCollectionOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a collection of tasks to the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job to which the task collection is to be added.
            /// </param>
            /// <param name='value'>
            /// The collection of tasks to add.
            /// </param>
            /// <param name='taskAddCollectionOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskAddCollectionResult> AddCollectionAsync(this ITaskOperations operations, string jobId, System.Collections.Generic.IList<TaskAddParameter> value, TaskAddCollectionOptions taskAddCollectionOptions = default(TaskAddCollectionOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.AddCollectionWithHttpMessagesAsync(jobId, value, taskAddCollectionOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a task from the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job from which to delete the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to delete.
            /// </param>
            /// <param name='taskDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskDeleteHeaders Delete(this ITaskOperations operations, string jobId, string taskId, TaskDeleteOptions taskDeleteOptions = default(TaskDeleteOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).DeleteAsync(jobId, taskId, taskDeleteOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a task from the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job from which to delete the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to delete.
            /// </param>
            /// <param name='taskDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskDeleteHeaders> DeleteAsync(this ITaskOperations operations, string jobId, string taskId, TaskDeleteOptions taskDeleteOptions = default(TaskDeleteOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(jobId, taskId, taskDeleteOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to get information about.
            /// </param>
            /// <param name='taskGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CloudTask Get(this ITaskOperations operations, string jobId, string taskId, TaskGetOptions taskGetOptions = default(TaskGetOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).GetAsync(jobId, taskId, taskGetOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to get information about.
            /// </param>
            /// <param name='taskGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CloudTask> GetAsync(this ITaskOperations operations, string jobId, string taskId, TaskGetOptions taskGetOptions = default(TaskGetOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(jobId, taskId, taskGetOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the properties of the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to update.
            /// </param>
            /// <param name='constraints'>
            /// Constraints that apply to this task. If omitted, the task is given the
            /// default constraints.
            /// </param>
            /// <param name='taskUpdateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskUpdateHeaders Update(this ITaskOperations operations, string jobId, string taskId, TaskConstraints constraints = default(TaskConstraints), TaskUpdateOptions taskUpdateOptions = default(TaskUpdateOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).UpdateAsync(jobId, taskId, constraints, taskUpdateOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to update.
            /// </param>
            /// <param name='constraints'>
            /// Constraints that apply to this task. If omitted, the task is given the
            /// default constraints.
            /// </param>
            /// <param name='taskUpdateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskUpdateHeaders> UpdateAsync(this ITaskOperations operations, string jobId, string taskId, TaskConstraints constraints = default(TaskConstraints), TaskUpdateOptions taskUpdateOptions = default(TaskUpdateOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(jobId, taskId, constraints, taskUpdateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the subtasks that are associated with the specified
            /// multi-instance task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task.
            /// </param>
            /// <param name='taskListSubtasksOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CloudTaskListSubtasksResult ListSubtasks(this ITaskOperations operations, string jobId, string taskId, TaskListSubtasksOptions taskListSubtasksOptions = default(TaskListSubtasksOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).ListSubtasksAsync(jobId, taskId, taskListSubtasksOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the subtasks that are associated with the specified
            /// multi-instance task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task.
            /// </param>
            /// <param name='taskListSubtasksOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CloudTaskListSubtasksResult> ListSubtasksAsync(this ITaskOperations operations, string jobId, string taskId, TaskListSubtasksOptions taskListSubtasksOptions = default(TaskListSubtasksOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListSubtasksWithHttpMessagesAsync(jobId, taskId, taskListSubtasksOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Terminates the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to terminate.
            /// </param>
            /// <param name='taskTerminateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskTerminateHeaders Terminate(this ITaskOperations operations, string jobId, string taskId, TaskTerminateOptions taskTerminateOptions = default(TaskTerminateOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).TerminateAsync(jobId, taskId, taskTerminateOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Terminates the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to terminate.
            /// </param>
            /// <param name='taskTerminateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskTerminateHeaders> TerminateAsync(this ITaskOperations operations, string jobId, string taskId, TaskTerminateOptions taskTerminateOptions = default(TaskTerminateOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.TerminateWithHttpMessagesAsync(jobId, taskId, taskTerminateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Reactivates the specified task.
            /// </summary>
            /// <remarks>
            /// Reactivation makes a task eligible to be retried again up to its maximum
            /// retry count. This will fail for tasks that are not completed or that
            /// previously completed successfully (with an exit code of 0). Additionally,
            /// this will fail if the job has completed (or is terminating or deleting).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to reactivate.
            /// </param>
            /// <param name='taskReactivateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskReactivateHeaders Reactivate(this ITaskOperations operations, string jobId, string taskId, TaskReactivateOptions taskReactivateOptions = default(TaskReactivateOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).ReactivateAsync(jobId, taskId, taskReactivateOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reactivates the specified task.
            /// </summary>
            /// <remarks>
            /// Reactivation makes a task eligible to be retried again up to its maximum
            /// retry count. This will fail for tasks that are not completed or that
            /// previously completed successfully (with an exit code of 0). Additionally,
            /// this will fail if the job has completed (or is terminating or deleting).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The id of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The id of the task to reactivate.
            /// </param>
            /// <param name='taskReactivateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskReactivateHeaders> ReactivateAsync(this ITaskOperations operations, string jobId, string taskId, TaskReactivateOptions taskReactivateOptions = default(TaskReactivateOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ReactivateWithHttpMessagesAsync(jobId, taskId, taskReactivateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='taskListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CloudTask> ListNext(this ITaskOperations operations, string nextPageLink, TaskListNextOptions taskListNextOptions = default(TaskListNextOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITaskOperations)s).ListNextAsync(nextPageLink, taskListNextOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='taskListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CloudTask>> ListNextAsync(this ITaskOperations operations, string nextPageLink, TaskListNextOptions taskListNextOptions = default(TaskListNextOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, taskListNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}