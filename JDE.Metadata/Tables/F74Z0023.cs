using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Z0023 - .
/// </summary>
public class F74Z0023 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZTXA1.
        /// </summary>
        public const string CZTXA1 = "CZTXA1";

        /// <summary>
        /// CZ74ZTT.
        /// </summary>
        public const string CZ74ZTT = "CZ74ZTT";

        /// <summary>
        /// CZ74ZMC.
        /// </summary>
        public const string CZ74ZMC = "CZ74ZMC";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";

        /// <summary>
        /// CZFLAG.
        /// </summary>
        public const string CZFLAG = "CZFLAG";

        /// <summary>
        /// CZDATF01.
        /// </summary>
        public const string CZDATF01 = "CZDATF01";

        /// <summary>
        /// CZDEPFUT2.
        /// </summary>
        public const string CZDEPFUT2 = "CZDEPFUT2";

        /// <summary>
        /// CZACTFU1.
        /// </summary>
        public const string CZACTFU1 = "CZACTFU1";

        /// <summary>
        /// CZZ74VAT.
        /// </summary>
        public const string CZZ74VAT = "CZZ74VAT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Z0023";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZTXA1", "CZTXA1", JdeDataType.String, 20, true, true),
        new JdeField("CZ74ZTT", "CZ74ZTT", JdeDataType.String, 12),
        new JdeField("CZ74ZMC", "CZ74ZMC", JdeDataType.String, 12),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20),
        new JdeField("CZFLAG", "CZFLAG", JdeDataType.String, 2),
        new JdeField("CZDATF01", "CZDATF01", JdeDataType.Numeric),
        new JdeField("CZDEPFUT2", "CZDEPFUT2", JdeDataType.String, 60),
        new JdeField("CZACTFU1", "CZACTFU1", JdeDataType.String, 2),
        new JdeField("CZZ74VAT", "CZZ74VAT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Z0023_0", "Primary Key on CZTXA1", new[] { "CZTXA1" }, isUnique: true, isPrimaryKey: true)
    };
}
