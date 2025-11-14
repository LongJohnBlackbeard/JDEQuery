using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0402 - .
/// </summary>
public class F74U0402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SBCO.
        /// </summary>
        public const string SBCO = "SBCO";

        /// <summary>
        /// SB74UCISF.
        /// </summary>
        public const string SB74UCISF = "SB74UCISF";

        /// <summary>
        /// SB74UVSS.
        /// </summary>
        public const string SB74UVSS = "SB74UVSS";

        /// <summary>
        /// SB74UPCC6.
        /// </summary>
        public const string SB74UPCC6 = "SB74UPCC6";

        /// <summary>
        /// SB74UPCC7.
        /// </summary>
        public const string SB74UPCC7 = "SB74UPCC7";

        /// <summary>
        /// SBURAT.
        /// </summary>
        public const string SBURAT = "SBURAT";

        /// <summary>
        /// SBURCD.
        /// </summary>
        public const string SBURCD = "SBURCD";

        /// <summary>
        /// SBURDT.
        /// </summary>
        public const string SBURDT = "SBURDT";

        /// <summary>
        /// SBURAB.
        /// </summary>
        public const string SBURAB = "SBURAB";

        /// <summary>
        /// SBURRF.
        /// </summary>
        public const string SBURRF = "SBURRF";

        /// <summary>
        /// SBPID.
        /// </summary>
        public const string SBPID = "SBPID";

        /// <summary>
        /// SBJOBN.
        /// </summary>
        public const string SBJOBN = "SBJOBN";

        /// <summary>
        /// SBUSER.
        /// </summary>
        public const string SBUSER = "SBUSER";

        /// <summary>
        /// SBUPMJ.
        /// </summary>
        public const string SBUPMJ = "SBUPMJ";

        /// <summary>
        /// SBUPMT.
        /// </summary>
        public const string SBUPMT = "SBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SBCO", "SBCO", JdeDataType.String, 10, true, true),
        new JdeField("SB74UCISF", "SB74UCISF", JdeDataType.String, 2),
        new JdeField("SB74UVSS", "SB74UVSS", JdeDataType.String, 2),
        new JdeField("SB74UPCC6", "SB74UPCC6", JdeDataType.String, 6),
        new JdeField("SB74UPCC7", "SB74UPCC7", JdeDataType.String, 6),
        new JdeField("SBURAT", "SBURAT", JdeDataType.Numeric),
        new JdeField("SBURCD", "SBURCD", JdeDataType.String, 4),
        new JdeField("SBURDT", "SBURDT", JdeDataType.Numeric),
        new JdeField("SBURAB", "SBURAB", JdeDataType.Numeric),
        new JdeField("SBURRF", "SBURRF", JdeDataType.String, 30),
        new JdeField("SBPID", "SBPID", JdeDataType.String, 20),
        new JdeField("SBJOBN", "SBJOBN", JdeDataType.String, 20),
        new JdeField("SBUSER", "SBUSER", JdeDataType.String, 20),
        new JdeField("SBUPMJ", "SBUPMJ", JdeDataType.Numeric),
        new JdeField("SBUPMT", "SBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0402_0", "Primary Key on SBCO", new[] { "SBCO" }, isUnique: true, isPrimaryKey: true)
    };
}
