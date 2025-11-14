using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C003T - .
/// </summary>
public class F75C003T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTC75RID.
        /// </summary>
        public const string RTC75RID = "RTC75RID";

        /// <summary>
        /// RTC75SEQN.
        /// </summary>
        public const string RTC75SEQN = "RTC75SEQN";

        /// <summary>
        /// RTC75CFIA.
        /// </summary>
        public const string RTC75CFIA = "RTC75CFIA";

        /// <summary>
        /// RTFUTMATH1.
        /// </summary>
        public const string RTFUTMATH1 = "RTFUTMATH1";

        /// <summary>
        /// RTFUTSTR1.
        /// </summary>
        public const string RTFUTSTR1 = "RTFUTSTR1";

        /// <summary>
        /// RTFUTDATE1.
        /// </summary>
        public const string RTFUTDATE1 = "RTFUTDATE1";

        /// <summary>
        /// RTFUTUO1.
        /// </summary>
        public const string RTFUTUO1 = "RTFUTUO1";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C003T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTC75RID", "RTC75RID", JdeDataType.String, 6, true, true),
        new JdeField("RTC75SEQN", "RTC75SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RTC75CFIA", "RTC75CFIA", JdeDataType.String, 2),
        new JdeField("RTFUTMATH1", "RTFUTMATH1", JdeDataType.Numeric),
        new JdeField("RTFUTSTR1", "RTFUTSTR1", JdeDataType.String, 100),
        new JdeField("RTFUTDATE1", "RTFUTDATE1", JdeDataType.Numeric),
        new JdeField("RTFUTUO1", "RTFUTUO1", JdeDataType.String, 2),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C003T_0", "Primary Key on RTC75RID, RTC75SEQN", new[] { "RTC75RID", "RTC75SEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
