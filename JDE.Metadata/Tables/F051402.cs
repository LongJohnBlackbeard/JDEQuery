using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051402 - .
/// </summary>
public class F051402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCCO.
        /// </summary>
        public const string SCCO = "SCCO";

        /// <summary>
        /// SCHMCU.
        /// </summary>
        public const string SCHMCU = "SCHMCU";

        /// <summary>
        /// SCMAXHITS.
        /// </summary>
        public const string SCMAXHITS = "SCMAXHITS";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCMKEY.
        /// </summary>
        public const string SCMKEY = "SCMKEY";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCCO", "SCCO", JdeDataType.String, 10, true, true),
        new JdeField("SCHMCU", "SCHMCU", JdeDataType.String, 24, true, true),
        new JdeField("SCMAXHITS", "SCMAXHITS", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCMKEY", "SCMKEY", JdeDataType.String, 30),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051402_0", "Primary Key on SCCO, SCHMCU", new[] { "SCCO", "SCHMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
