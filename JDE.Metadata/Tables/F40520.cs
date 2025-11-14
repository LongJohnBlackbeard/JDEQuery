using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40520 - .
/// </summary>
public class F40520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCAN8V.
        /// </summary>
        public const string SCAN8V = "SCAN8V";

        /// <summary>
        /// SCMCU.
        /// </summary>
        public const string SCMCU = "SCMCU";

        /// <summary>
        /// SCCMDCDE.
        /// </summary>
        public const string SCCMDCDE = "SCCMDCDE";

        /// <summary>
        /// SCCMDDFT.
        /// </summary>
        public const string SCCMDDFT = "SCCMDDFT";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCAN8V", "SCAN8V", JdeDataType.Numeric, null, true, true),
        new JdeField("SCMCU", "SCMCU", JdeDataType.String, 24, true, true),
        new JdeField("SCCMDCDE", "SCCMDCDE", JdeDataType.String, 30, true, true),
        new JdeField("SCCMDDFT", "SCCMDDFT", JdeDataType.String, 2),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40520_0", "Primary Key on SCAN8V, SCMCU, SCCMDCDE", new[] { "SCAN8V", "SCMCU", "SCCMDCDE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40520_2", "Index on SCAN8V, SCMCU, SCCMDDFT", new[] { "SCAN8V", "SCMCU", "SCCMDDFT" }),
        new JdeIndex("F40520_3", "Index on SCCMDCDE", new[] { "SCCMDCDE" })
    };
}
