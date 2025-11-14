using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49195 - .
/// </summary>
public class F49195 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DUDSET.
        /// </summary>
        public const string DUDSET = "DUDSET";

        /// <summary>
        /// DUDCCD.
        /// </summary>
        public const string DUDCCD = "DUDCCD";

        /// <summary>
        /// DUUSER.
        /// </summary>
        public const string DUUSER = "DUUSER";

        /// <summary>
        /// DUPID.
        /// </summary>
        public const string DUPID = "DUPID";

        /// <summary>
        /// DUJOBN.
        /// </summary>
        public const string DUJOBN = "DUJOBN";

        /// <summary>
        /// DUUPMJ.
        /// </summary>
        public const string DUUPMJ = "DUUPMJ";

        /// <summary>
        /// DUTDAY.
        /// </summary>
        public const string DUTDAY = "DUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49195";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DUDSET", "DUDSET", JdeDataType.String, 6, true, true),
        new JdeField("DUDCCD", "DUDCCD", JdeDataType.String, 8, true, true),
        new JdeField("DUUSER", "DUUSER", JdeDataType.String, 20),
        new JdeField("DUPID", "DUPID", JdeDataType.String, 20),
        new JdeField("DUJOBN", "DUJOBN", JdeDataType.String, 20),
        new JdeField("DUUPMJ", "DUUPMJ", JdeDataType.Numeric),
        new JdeField("DUTDAY", "DUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49195_0", "Primary Key on DUDCCD, DUDSET", new[] { "DUDCCD", "DUDSET" }, isUnique: true, isPrimaryKey: true)
    };
}
