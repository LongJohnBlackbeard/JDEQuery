using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186409 - .
/// </summary>
public class F186409 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CILRSORID.
        /// </summary>
        public const string CILRSORID = "CILRSORID";

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
    public override string TableName => "F186409";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CILRSORID", "CILRSORID", JdeDataType.Numeric, null, true, true),
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
        new JdeIndex("F186409_0", "Primary Key on CILRSORID, CIPTCT", new[] { "CILRSORID", "CIPTCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186409_2", "Index on CILRSORID", new[] { "CILRSORID" })
    };
}
