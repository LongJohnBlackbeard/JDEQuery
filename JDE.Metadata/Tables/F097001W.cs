using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F097001W - .
/// </summary>
public class F097001W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBUKID.
        /// </summary>
        public const string CBUKID = "CBUKID";

        /// <summary>
        /// CBCO.
        /// </summary>
        public const string CBCO = "CBCO";

        /// <summary>
        /// CBCTRY.
        /// </summary>
        public const string CBCTRY = "CBCTRY";

        /// <summary>
        /// CBFY.
        /// </summary>
        public const string CBFY = "CBFY";

        /// <summary>
        /// CBAA.
        /// </summary>
        public const string CBAA = "CBAA";

        /// <summary>
        /// CBAA1.
        /// </summary>
        public const string CBAA1 = "CBAA1";
    }

    /// <inheritdoc />
    public override string TableName => "F097001W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20, true, true),
        new JdeField("CBUKID", "CBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CBCO", "CBCO", JdeDataType.String, 10, true, true),
        new JdeField("CBCTRY", "CBCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("CBFY", "CBFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CBAA", "CBAA", JdeDataType.Numeric),
        new JdeField("CBAA1", "CBAA1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F097001W_0", "Primary Key on CBUSER, CBUKID, CBCO, CBCTRY, CBFY", new[] { "CBUSER", "CBUKID", "CBCO", "CBCTRY", "CBFY" }, isUnique: true, isPrimaryKey: true)
    };
}
