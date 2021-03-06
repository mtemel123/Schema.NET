namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: The reciprocal of TakeAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: Unlike ReceiveAction, TakeAction implies that ownership has been transfered.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class TakeAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TakeAction";
    }
}
