using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S80 - .
/// </summary>
public class F48S80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDSEGMID.
        /// </summary>
        public const string SDSEGMID = "SDSEGMID";

        /// <summary>
        /// SDEFTB.
        /// </summary>
        public const string SDEFTB = "SDEFTB";

        /// <summary>
        /// SDBUCA.
        /// </summary>
        public const string SDBUCA = "SDBUCA";

        /// <summary>
        /// SDDL01.
        /// </summary>
        public const string SDDL01 = "SDDL01";

        /// <summary>
        /// SDBSOU.
        /// </summary>
        public const string SDBSOU = "SDBSOU";

        /// <summary>
        /// SDSEQ.
        /// </summary>
        public const string SDSEQ = "SDSEQ";

        /// <summary>
        /// SDFCCM.
        /// </summary>
        public const string SDFCCM = "SDFCCM";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDSEGMID", "SDSEGMID", JdeDataType.String, 6, true, true),
        new JdeField("SDEFTB", "SDEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("SDBUCA", "SDBUCA", JdeDataType.String, 10, true, true),
        new JdeField("SDDL01", "SDDL01", JdeDataType.String, 60),
        new JdeField("SDBSOU", "SDBSOU", JdeDataType.String, 2),
        new JdeField("SDSEQ", "SDSEQ", JdeDataType.Numeric),
        new JdeField("SDFCCM", "SDFCCM", JdeDataType.String, 2),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S80_0", "Primary Key on SDSEGMID, SDEFTB, SDBUCA", new[] { "SDSEGMID", "SDEFTB", "SDBUCA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S80_2", "Index on SDSEGMID, SYS_NC00013$, SDBUCA", new[] { "SDSEGMID", "SYS_NC00013$", "SDBUCA" }),
        new JdeIndex("F48S80_3", "Index on SDSEGMID, SYS_NC00013$, SDSEQ, SDBUCA", new[] { "SDSEGMID", "SYS_NC00013$", "SDSEQ", "SDBUCA" })
    };
}
