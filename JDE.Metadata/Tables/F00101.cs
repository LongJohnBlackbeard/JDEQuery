using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00101 - .
/// </summary>
public class F00101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCEUCOCTR.
        /// </summary>
        public const string CCEUCOCTR = "CCEUCOCTR";

        /// <summary>
        /// CCAN8.
        /// </summary>
        public const string CCAN8 = "CCAN8";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F00101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCEUCOCTR", "CCEUCOCTR", JdeDataType.String, 6, true, true),
        new JdeField("CCAN8", "CCAN8", JdeDataType.Numeric),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00101_0", "Primary Key on CCCO, CCEUCOCTR", new[] { "CCCO", "CCEUCOCTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00101_2", "Index on CCAN8", new[] { "CCAN8" })
    };
}
