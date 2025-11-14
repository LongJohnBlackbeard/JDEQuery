using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C020 - .
/// </summary>
public class F76C020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PC76CTAXC.
        /// </summary>
        public const string PC76CTAXC = "PC76CTAXC";

        /// <summary>
        /// PCC76DDCT.
        /// </summary>
        public const string PCC76DDCT = "PCC76DDCT";

        /// <summary>
        /// PCC76NATP.
        /// </summary>
        public const string PCC76NATP = "PCC76NATP";

        /// <summary>
        /// PCC76FTPR.
        /// </summary>
        public const string PCC76FTPR = "PCC76FTPR";

        /// <summary>
        /// PCC76SDSC.
        /// </summary>
        public const string PCC76SDSC = "PCC76SDSC";

        /// <summary>
        /// PCC76EDTX.
        /// </summary>
        public const string PCC76EDTX = "PCC76EDTX";

        /// <summary>
        /// PCC76CLCD.
        /// </summary>
        public const string PCC76CLCD = "PCC76CLCD";

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

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PC76CTAXC", "PC76CTAXC", JdeDataType.String, 2, true, true),
        new JdeField("PCC76DDCT", "PCC76DDCT", JdeDataType.Numeric),
        new JdeField("PCC76NATP", "PCC76NATP", JdeDataType.String, 2),
        new JdeField("PCC76FTPR", "PCC76FTPR", JdeDataType.String, 2),
        new JdeField("PCC76SDSC", "PCC76SDSC", JdeDataType.String, 40),
        new JdeField("PCC76EDTX", "PCC76EDTX", JdeDataType.String, 2),
        new JdeField("PCC76CLCD", "PCC76CLCD", JdeDataType.String, 2),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C020_0", "Primary Key on PC76CTAXC", new[] { "PC76CTAXC" }, isUnique: true, isPrimaryKey: true)
    };
}
