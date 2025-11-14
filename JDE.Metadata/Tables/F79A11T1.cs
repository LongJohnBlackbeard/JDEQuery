using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A11T1 - .
/// </summary>
public class F79A11T1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GTUKID.
        /// </summary>
        public const string GTUKID = "GTUKID";

        /// <summary>
        /// GT79ATCQ.
        /// </summary>
        public const string GT79ATCQ = "GT79ATCQ";

        /// <summary>
        /// GT79AGUM.
        /// </summary>
        public const string GT79AGUM = "GT79AGUM";

        /// <summary>
        /// GT79ATCV.
        /// </summary>
        public const string GT79ATCV = "GT79ATCV";

        /// <summary>
        /// GT79ATCRC.
        /// </summary>
        public const string GT79ATCRC = "GT79ATCRC";

        /// <summary>
        /// GTPID.
        /// </summary>
        public const string GTPID = "GTPID";

        /// <summary>
        /// GTUSER.
        /// </summary>
        public const string GTUSER = "GTUSER";

        /// <summary>
        /// GTJOBN.
        /// </summary>
        public const string GTJOBN = "GTJOBN";

        /// <summary>
        /// GTUPMJ.
        /// </summary>
        public const string GTUPMJ = "GTUPMJ";

        /// <summary>
        /// GTTDAY.
        /// </summary>
        public const string GTTDAY = "GTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A11T1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTUKID", "GTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GT79ATCQ", "GT79ATCQ", JdeDataType.Numeric),
        new JdeField("GT79AGUM", "GT79AGUM", JdeDataType.String, 30),
        new JdeField("GT79ATCV", "GT79ATCV", JdeDataType.Numeric),
        new JdeField("GT79ATCRC", "GT79ATCRC", JdeDataType.String, 6),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTJOBN", "GTJOBN", JdeDataType.String, 20),
        new JdeField("GTUPMJ", "GTUPMJ", JdeDataType.Numeric),
        new JdeField("GTTDAY", "GTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A11T1_0", "Primary Key on GTUKID", new[] { "GTUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
