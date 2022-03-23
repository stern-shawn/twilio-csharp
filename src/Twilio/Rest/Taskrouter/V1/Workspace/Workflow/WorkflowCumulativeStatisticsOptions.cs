/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Workflow
{

    /// <summary>
    /// FetchWorkflowCumulativeStatisticsOptions
    /// </summary>
    public class FetchWorkflowCumulativeStatisticsOptions : IOptions<WorkflowCumulativeStatisticsResource>
    {
        /// <summary>
        /// The SID of the Workspace with the resource to fetch
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Returns the list of Tasks that are being controlled by the Workflow with the specified Sid value
        /// </summary>
        public string PathWorkflowSid { get; }
        /// <summary>
        /// Only include usage that occurred on or before this date
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Only calculate statistics since this many minutes in the past
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// Only calculate statistics from on or after this date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Only calculate cumulative statistics on this TaskChannel
        /// </summary>
        public string TaskChannel { get; set; }
        /// <summary>
        /// A comma separated list of values that describes the thresholds, in seconds, to calculate statistics on
        /// </summary>
        public string SplitByWaitTime { get; set; }

        /// <summary>
        /// Construct a new FetchWorkflowCumulativeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the resource to fetch </param>
        /// <param name="pathWorkflowSid"> Returns the list of Tasks that are being controlled by the Workflow with the
        ///                       specified Sid value </param>
        public FetchWorkflowCumulativeStatisticsOptions(string pathWorkspaceSid, string pathWorkflowSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkflowSid = pathWorkflowSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }

            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.ToString()));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            if (SplitByWaitTime != null)
            {
                p.Add(new KeyValuePair<string, string>("SplitByWaitTime", SplitByWaitTime));
            }

            return p;
        }
    }

}