using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H004 - .
/// </summary>
public class F76H004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNTXA1.
        /// </summary>
        public const string TNTXA1 = "TNTXA1";

        /// <summary>
        /// TNUSER.
        /// </summary>
        public const string TNUSER = "TNUSER";

        /// <summary>
        /// TNH76RETA.
        /// </summary>
        public const string TNH76RETA = "TNH76RETA";

        /// <summary>
        /// TNPID.
        /// </summary>
        public const string TNPID = "TNPID";

        /// <summary>
        /// TNJOBN.
        /// </summary>
        public const string TNJOBN = "TNJOBN";

        /// <summary>
        /// TNUPMJ.
        /// </summary>
        public const string TNUPMJ = "TNUPMJ";

        /// <summary>
        /// TNUPMT.
        /// </summary>
        public const string TNUPMT = "TNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNTXA1", "TNTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TNUSER", "TNUSER", JdeDataType.String, 20),
        new JdeField("TNH76RETA", "TNH76RETA", JdeDataType.String, 20),
        new JdeField("TNPID", "TNPID", JdeDataType.String, 20),
        new JdeField("TNJOBN", "TNJOBN", JdeDataType.String, 20),
        new JdeField("TNUPMJ", "TNUPMJ", JdeDataType.Numeric),
        new JdeField("TNUPMT", "TNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H004_0", "Primary Key on TNTXA1", new[] { "TNTXA1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H004_3", "Index on TNH76RETA, TNTXA1", new[] { "TNH76RETA", "TNTXA1" })
    };
}
