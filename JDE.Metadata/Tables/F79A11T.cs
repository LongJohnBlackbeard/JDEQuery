using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A11T - .
/// </summary>
public class F79A11T : JdeTable
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
        /// GT79AGTXT.
        /// </summary>
        public const string GT79AGTXT = "GT79AGTXT";

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
    public override string TableName => "F79A11T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTUKID", "GTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GT79AGTXT", "GT79AGTXT", JdeDataType.String, 2000),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTJOBN", "GTJOBN", JdeDataType.String, 20),
        new JdeField("GTUPMJ", "GTUPMJ", JdeDataType.Numeric),
        new JdeField("GTTDAY", "GTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A11T_0", "Primary Key on GTUKID", new[] { "GTUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
