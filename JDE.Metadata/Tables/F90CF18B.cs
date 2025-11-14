using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF18B - .
/// </summary>
public class F90CF18B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICSCRINSID.
        /// </summary>
        public const string ICSCRINSID = "ICSCRINSID";

        /// <summary>
        /// ICEFFSEQ.
        /// </summary>
        public const string ICEFFSEQ = "ICEFFSEQ";

        /// <summary>
        /// ICQSTPTHID.
        /// </summary>
        public const string ICQSTPTHID = "ICQSTPTHID";

        /// <summary>
        /// ICPARPTHID.
        /// </summary>
        public const string ICPARPTHID = "ICPARPTHID";

        /// <summary>
        /// ICQUSTID.
        /// </summary>
        public const string ICQUSTID = "ICQUSTID";

        /// <summary>
        /// ICCMMNT.
        /// </summary>
        public const string ICCMMNT = "ICCMMNT";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICMKEY.
        /// </summary>
        public const string ICMKEY = "ICMKEY";

        /// <summary>
        /// ICUDTTM.
        /// </summary>
        public const string ICUDTTM = "ICUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF18B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICSCRINSID", "ICSCRINSID", JdeDataType.Numeric, null, true, true),
        new JdeField("ICEFFSEQ", "ICEFFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ICQSTPTHID", "ICQSTPTHID", JdeDataType.Numeric),
        new JdeField("ICPARPTHID", "ICPARPTHID", JdeDataType.Numeric),
        new JdeField("ICQUSTID", "ICQUSTID", JdeDataType.Numeric),
        new JdeField("ICCMMNT", "ICCMMNT", JdeDataType.String, 1024),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICMKEY", "ICMKEY", JdeDataType.String, 30),
        new JdeField("ICUDTTM", "ICUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF18B_0", "Primary Key on ICSCRINSID, ICEFFSEQ", new[] { "ICSCRINSID", "ICEFFSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
