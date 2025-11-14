using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA001 - .
/// </summary>
public class F90CA001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UAAN8.
        /// </summary>
        public const string UAAN8 = "UAAN8";

        /// <summary>
        /// UALDNN.
        /// </summary>
        public const string UALDNN = "UALDNN";

        /// <summary>
        /// UAEDATE.
        /// </summary>
        public const string UAEDATE = "UAEDATE";

        /// <summary>
        /// UAUSER.
        /// </summary>
        public const string UAUSER = "UAUSER";

        /// <summary>
        /// UAUDTTM.
        /// </summary>
        public const string UAUDTTM = "UAUDTTM";

        /// <summary>
        /// UAMKEY.
        /// </summary>
        public const string UAMKEY = "UAMKEY";

        /// <summary>
        /// UAENTDBY.
        /// </summary>
        public const string UAENTDBY = "UAENTDBY";

        /// <summary>
        /// UAPID.
        /// </summary>
        public const string UAPID = "UAPID";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UAAN8", "UAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UALDNN", "UALDNN", JdeDataType.String, 2),
        new JdeField("UAEDATE", "UAEDATE", JdeDataType.Date),
        new JdeField("UAUSER", "UAUSER", JdeDataType.String, 20),
        new JdeField("UAUDTTM", "UAUDTTM", JdeDataType.Date),
        new JdeField("UAMKEY", "UAMKEY", JdeDataType.String, 30),
        new JdeField("UAENTDBY", "UAENTDBY", JdeDataType.Numeric),
        new JdeField("UAPID", "UAPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA001_0", "Primary Key on UAAN8", new[] { "UAAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA001_2", "Index on UALDNN", new[] { "UALDNN" })
    };
}
