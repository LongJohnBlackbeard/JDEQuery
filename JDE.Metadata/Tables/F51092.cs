using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51092 - .
/// </summary>
public class F51092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MCVERSCC.
        /// </summary>
        public const string MCVERSCC = "MCVERSCC";

        /// <summary>
        /// MCCTY.
        /// </summary>
        public const string MCCTY = "MCCTY";

        /// <summary>
        /// MCSUB.
        /// </summary>
        public const string MCSUB = "MCSUB";

        /// <summary>
        /// MCMCU.
        /// </summary>
        public const string MCMCU = "MCMCU";

        /// <summary>
        /// MCSUB2.
        /// </summary>
        public const string MCSUB2 = "MCSUB2";

        /// <summary>
        /// MCDL01.
        /// </summary>
        public const string MCDL01 = "MCDL01";

        /// <summary>
        /// MCUSER.
        /// </summary>
        public const string MCUSER = "MCUSER";

        /// <summary>
        /// MCPID.
        /// </summary>
        public const string MCPID = "MCPID";

        /// <summary>
        /// MCJOBN.
        /// </summary>
        public const string MCJOBN = "MCJOBN";

        /// <summary>
        /// MCUPMJ.
        /// </summary>
        public const string MCUPMJ = "MCUPMJ";

        /// <summary>
        /// MCUPMT.
        /// </summary>
        public const string MCUPMT = "MCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F51092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MCVERSCC", "MCVERSCC", JdeDataType.String, 20, true, true),
        new JdeField("MCCTY", "MCCTY", JdeDataType.String, 6),
        new JdeField("MCSUB", "MCSUB", JdeDataType.String, 16),
        new JdeField("MCMCU", "MCMCU", JdeDataType.String, 24, true, true),
        new JdeField("MCSUB2", "MCSUB2", JdeDataType.String, 16, true, true),
        new JdeField("MCDL01", "MCDL01", JdeDataType.String, 60),
        new JdeField("MCUSER", "MCUSER", JdeDataType.String, 20),
        new JdeField("MCPID", "MCPID", JdeDataType.String, 20),
        new JdeField("MCJOBN", "MCJOBN", JdeDataType.String, 20),
        new JdeField("MCUPMJ", "MCUPMJ", JdeDataType.Numeric),
        new JdeField("MCUPMT", "MCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51092_0", "Primary Key on MCVERSCC, MCMCU, MCSUB2", new[] { "MCVERSCC", "MCMCU", "MCSUB2" }, isUnique: true, isPrimaryKey: true)
    };
}
