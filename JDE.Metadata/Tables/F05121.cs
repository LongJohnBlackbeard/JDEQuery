using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05121 - .
/// </summary>
public class F05121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCUCD.
        /// </summary>
        public const string CRCUCD = "CRCUCD";

        /// <summary>
        /// CRINEC.
        /// </summary>
        public const string CRINEC = "CRINEC";

        /// <summary>
        /// CRCMPE.
        /// </summary>
        public const string CRCMPE = "CRCMPE";

        /// <summary>
        /// CRCMPC.
        /// </summary>
        public const string CRCMPC = "CRCMPC";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCUCD", "CRCUCD", JdeDataType.String, 20, true, true),
        new JdeField("CRINEC", "CRINEC", JdeDataType.String, 20, true, true),
        new JdeField("CRCMPE", "CRCMPE", JdeDataType.String, 6, true, true),
        new JdeField("CRCMPC", "CRCMPC", JdeDataType.String, 20, true, true),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05121_0", "Primary Key on CRCUCD, CRINEC, CRCMPE, CRCMPC", new[] { "CRCUCD", "CRINEC", "CRCMPE", "CRCMPC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05121_3", "Index on CRCMPE, CRCMPC, CRCUCD, CRINEC", new[] { "CRCMPE", "CRCMPC", "CRCUCD", "CRINEC" })
    };
}
