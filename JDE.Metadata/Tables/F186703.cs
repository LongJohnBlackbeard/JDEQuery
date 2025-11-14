using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186703 - .
/// </summary>
public class F186703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CILRSRRID.
        /// </summary>
        public const string CILRSRRID = "CILRSRRID";

        /// <summary>
        /// CIPTCT.
        /// </summary>
        public const string CIPTCT = "CIPTCT";

        /// <summary>
        /// CIUSER.
        /// </summary>
        public const string CIUSER = "CIUSER";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";

        /// <summary>
        /// CIJOBN.
        /// </summary>
        public const string CIJOBN = "CIJOBN";

        /// <summary>
        /// CIUPMJ.
        /// </summary>
        public const string CIUPMJ = "CIUPMJ";

        /// <summary>
        /// CITDAY.
        /// </summary>
        public const string CITDAY = "CITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CILRSRRID", "CILRSRRID", JdeDataType.Numeric, null, true, true),
        new JdeField("CIPTCT", "CIPTCT", JdeDataType.String, 2, true, true),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric),
        new JdeField("CITDAY", "CITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186703_0", "Primary Key on CILRSRRID, CIPTCT", new[] { "CILRSRRID", "CIPTCT" }, isUnique: true, isPrimaryKey: true)
    };
}
