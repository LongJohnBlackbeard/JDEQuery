using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4805 - .
/// </summary>
public class F4805 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WKSBSK.
        /// </summary>
        public const string WKSBSK = "WKSBSK";

        /// <summary>
        /// WKDESC.
        /// </summary>
        public const string WKDESC = "WKDESC";

        /// <summary>
        /// WKUSER.
        /// </summary>
        public const string WKUSER = "WKUSER";

        /// <summary>
        /// WKPID.
        /// </summary>
        public const string WKPID = "WKPID";

        /// <summary>
        /// WKJOBN.
        /// </summary>
        public const string WKJOBN = "WKJOBN";

        /// <summary>
        /// WKUPMJ.
        /// </summary>
        public const string WKUPMJ = "WKUPMJ";

        /// <summary>
        /// WKUPMT.
        /// </summary>
        public const string WKUPMT = "WKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4805";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WKSBSK", "WKSBSK", JdeDataType.String, 8, true, true),
        new JdeField("WKDESC", "WKDESC", JdeDataType.String, 60),
        new JdeField("WKUSER", "WKUSER", JdeDataType.String, 20),
        new JdeField("WKPID", "WKPID", JdeDataType.String, 20),
        new JdeField("WKJOBN", "WKJOBN", JdeDataType.String, 20),
        new JdeField("WKUPMJ", "WKUPMJ", JdeDataType.Numeric),
        new JdeField("WKUPMT", "WKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4805_0", "Primary Key on WKSBSK", new[] { "WKSBSK" }, isUnique: true, isPrimaryKey: true)
    };
}
