using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I220 - .
/// </summary>
public class F75I220 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCSTCD.
        /// </summary>
        public const string SCSTCD = "SCSTCD";

        /// <summary>
        /// SCI75IRETP.
        /// </summary>
        public const string SCI75IRETP = "SCI75IRETP";

        /// <summary>
        /// SCI75DFPD.
        /// </summary>
        public const string SCI75DFPD = "SCI75DFPD";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

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

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F75I220";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCSTCD", "SCSTCD", JdeDataType.String, 6, true, true),
        new JdeField("SCI75IRETP", "SCI75IRETP", JdeDataType.Numeric),
        new JdeField("SCI75DFPD", "SCI75DFPD", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I220_0", "Primary Key on SCSTCD", new[] { "SCSTCD" }, isUnique: true, isPrimaryKey: true)
    };
}
