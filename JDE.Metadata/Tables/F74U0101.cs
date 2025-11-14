using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0101 - .
/// </summary>
public class F74U0101 : JdeTable
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
        /// SCUKCTR.
        /// </summary>
        public const string SCUKCTR = "SCUKCTR";

        /// <summary>
        /// SCUKCOCA.
        /// </summary>
        public const string SCUKCOCA = "SCUKCOCA";

        /// <summary>
        /// SCUKCOCB.
        /// </summary>
        public const string SCUKCOCB = "SCUKCOCB";

        /// <summary>
        /// SCUKCOCC.
        /// </summary>
        public const string SCUKCOCC = "SCUKCOCC";

        /// <summary>
        /// SCUKCOCD.
        /// </summary>
        public const string SCUKCOCD = "SCUKCOCD";

        /// <summary>
        /// SCUKCOCE.
        /// </summary>
        public const string SCUKCOCE = "SCUKCOCE";

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
    public override string TableName => "F74U0101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCCO", "SCCO", JdeDataType.String, 10, true, true),
        new JdeField("SCUKCTR", "SCUKCTR", JdeDataType.String, 26),
        new JdeField("SCUKCOCA", "SCUKCOCA", JdeDataType.String, 2),
        new JdeField("SCUKCOCB", "SCUKCOCB", JdeDataType.String, 2),
        new JdeField("SCUKCOCC", "SCUKCOCC", JdeDataType.String, 60),
        new JdeField("SCUKCOCD", "SCUKCOCD", JdeDataType.Numeric),
        new JdeField("SCUKCOCE", "SCUKCOCE", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0101_0", "Primary Key on SCCO", new[] { "SCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
