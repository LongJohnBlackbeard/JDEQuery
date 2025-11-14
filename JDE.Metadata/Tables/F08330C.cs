using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08330C - .
/// </summary>
public class F08330C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCPLAN.
        /// </summary>
        public const string PCPLAN = "PCPLAN";

        /// <summary>
        /// PCAOPT.
        /// </summary>
        public const string PCAOPT = "PCAOPT";

        /// <summary>
        /// PCEFT.
        /// </summary>
        public const string PCEFT = "PCEFT";

        /// <summary>
        /// PCPCPVST.
        /// </summary>
        public const string PCPCPVST = "PCPCPVST";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08330C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PCPLAN", "PCPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PCAOPT", "PCAOPT", JdeDataType.String, 6, true, true),
        new JdeField("PCEFT", "PCEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("PCPCPVST", "PCPCPVST", JdeDataType.String, 2),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08330C_0", "Primary Key on PCAN8, PCPLAN, PCAOPT, PCEFT", new[] { "PCAN8", "PCPLAN", "PCAOPT", "PCEFT" }, isUnique: true, isPrimaryKey: true)
    };
}
