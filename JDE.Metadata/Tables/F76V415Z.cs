using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V415Z - .
/// </summary>
public class F76V415Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BIEDUS.
        /// </summary>
        public const string BIEDUS = "BIEDUS";

        /// <summary>
        /// BIEDBT.
        /// </summary>
        public const string BIEDBT = "BIEDBT";

        /// <summary>
        /// BIEDTN.
        /// </summary>
        public const string BIEDTN = "BIEDTN";

        /// <summary>
        /// BIVINV.
        /// </summary>
        public const string BIVINV = "BIVINV";

        /// <summary>
        /// BITORG.
        /// </summary>
        public const string BITORG = "BITORG";

        /// <summary>
        /// BIUSER.
        /// </summary>
        public const string BIUSER = "BIUSER";

        /// <summary>
        /// BIPID.
        /// </summary>
        public const string BIPID = "BIPID";

        /// <summary>
        /// BIJOBN.
        /// </summary>
        public const string BIJOBN = "BIJOBN";

        /// <summary>
        /// BIUPMJ.
        /// </summary>
        public const string BIUPMJ = "BIUPMJ";

        /// <summary>
        /// BIUPMT.
        /// </summary>
        public const string BIUPMT = "BIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V415Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BIEDUS", "BIEDUS", JdeDataType.String, 20, true, true),
        new JdeField("BIEDBT", "BIEDBT", JdeDataType.String, 30, true, true),
        new JdeField("BIEDTN", "BIEDTN", JdeDataType.String, 44, true, true),
        new JdeField("BIVINV", "BIVINV", JdeDataType.String, 50, true, true),
        new JdeField("BITORG", "BITORG", JdeDataType.String, 20),
        new JdeField("BIUSER", "BIUSER", JdeDataType.String, 20),
        new JdeField("BIPID", "BIPID", JdeDataType.String, 20),
        new JdeField("BIJOBN", "BIJOBN", JdeDataType.String, 20),
        new JdeField("BIUPMJ", "BIUPMJ", JdeDataType.Numeric),
        new JdeField("BIUPMT", "BIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V415Z_0", "Primary Key on BIEDUS, BIEDBT, BIEDTN, BIVINV", new[] { "BIEDUS", "BIEDBT", "BIEDTN", "BIVINV" }, isUnique: true, isPrimaryKey: true)
    };
}
