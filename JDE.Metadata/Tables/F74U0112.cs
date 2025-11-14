using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0112 - .
/// </summary>
public class F74U0112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCUKDFLT.
        /// </summary>
        public const string SCUKDFLT = "SCUKDFLT";

        /// <summary>
        /// SCU74NCED.
        /// </summary>
        public const string SCU74NCED = "SCU74NCED";

        /// <summary>
        /// SCU74CEPD.
        /// </summary>
        public const string SCU74CEPD = "SCU74CEPD";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCUKDFLT", "SCUKDFLT", JdeDataType.String, 2, true, true),
        new JdeField("SCU74NCED", "SCU74NCED", JdeDataType.Numeric),
        new JdeField("SCU74CEPD", "SCU74CEPD", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0112_0", "Primary Key on SCUKDFLT", new[] { "SCUKDFLT" }, isUnique: true, isPrimaryKey: true)
    };
}
