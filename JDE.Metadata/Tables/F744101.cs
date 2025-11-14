using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F744101 - .
/// </summary>
public class F744101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INLITM.
        /// </summary>
        public const string INLITM = "INLITM";

        /// <summary>
        /// INAN8.
        /// </summary>
        public const string INAN8 = "INAN8";

        /// <summary>
        /// INORIG.
        /// </summary>
        public const string INORIG = "INORIG";

        /// <summary>
        /// INORGO.
        /// </summary>
        public const string INORGO = "INORGO";

        /// <summary>
        /// INUSER.
        /// </summary>
        public const string INUSER = "INUSER";

        /// <summary>
        /// INPID.
        /// </summary>
        public const string INPID = "INPID";

        /// <summary>
        /// INJOBN.
        /// </summary>
        public const string INJOBN = "INJOBN";

        /// <summary>
        /// INUPMJ.
        /// </summary>
        public const string INUPMJ = "INUPMJ";

        /// <summary>
        /// INTDAY.
        /// </summary>
        public const string INTDAY = "INTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F744101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INLITM", "INLITM", JdeDataType.String, 50, true, true),
        new JdeField("INAN8", "INAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("INORIG", "INORIG", JdeDataType.String, 6),
        new JdeField("INORGO", "INORGO", JdeDataType.String, 6),
        new JdeField("INUSER", "INUSER", JdeDataType.String, 20),
        new JdeField("INPID", "INPID", JdeDataType.String, 20),
        new JdeField("INJOBN", "INJOBN", JdeDataType.String, 20),
        new JdeField("INUPMJ", "INUPMJ", JdeDataType.Numeric),
        new JdeField("INTDAY", "INTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F744101_0", "Primary Key on INLITM, INAN8", new[] { "INLITM", "INAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F744101_2", "Index on INAN8", new[] { "INAN8" })
    };
}
