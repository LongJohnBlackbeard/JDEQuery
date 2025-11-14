using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760414A - .
/// </summary>
public class F760414A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V1PYID.
        /// </summary>
        public const string V1PYID = "V1PYID";

        /// <summary>
        /// V1RC5.
        /// </summary>
        public const string V1RC5 = "V1RC5";

        /// <summary>
        /// V1DCTM.
        /// </summary>
        public const string V1DCTM = "V1DCTM";

        /// <summary>
        /// V1KCO.
        /// </summary>
        public const string V1KCO = "V1KCO";

        /// <summary>
        /// V1DOC.
        /// </summary>
        public const string V1DOC = "V1DOC";

        /// <summary>
        /// V1DCT.
        /// </summary>
        public const string V1DCT = "V1DCT";

        /// <summary>
        /// V1SFX.
        /// </summary>
        public const string V1SFX = "V1SFX";

        /// <summary>
        /// V1SFXE.
        /// </summary>
        public const string V1SFXE = "V1SFXE";

        /// <summary>
        /// V1APTT.
        /// </summary>
        public const string V1APTT = "V1APTT";

        /// <summary>
        /// V1AIRJ.
        /// </summary>
        public const string V1AIRJ = "V1AIRJ";

        /// <summary>
        /// V1ATPS.
        /// </summary>
        public const string V1ATPS = "V1ATPS";

        /// <summary>
        /// V1AAGR.
        /// </summary>
        public const string V1AAGR = "V1AAGR";

        /// <summary>
        /// V1A001.
        /// </summary>
        public const string V1A001 = "V1A001";

        /// <summary>
        /// V1A002.
        /// </summary>
        public const string V1A002 = "V1A002";

        /// <summary>
        /// V1A003.
        /// </summary>
        public const string V1A003 = "V1A003";

        /// <summary>
        /// V1A004.
        /// </summary>
        public const string V1A004 = "V1A004";

        /// <summary>
        /// V1A005.
        /// </summary>
        public const string V1A005 = "V1A005";

        /// <summary>
        /// V1A006.
        /// </summary>
        public const string V1A006 = "V1A006";

        /// <summary>
        /// V1A007.
        /// </summary>
        public const string V1A007 = "V1A007";

        /// <summary>
        /// V1A008.
        /// </summary>
        public const string V1A008 = "V1A008";

        /// <summary>
        /// V1A009.
        /// </summary>
        public const string V1A009 = "V1A009";

        /// <summary>
        /// V1A010.
        /// </summary>
        public const string V1A010 = "V1A010";

        /// <summary>
        /// V1A011.
        /// </summary>
        public const string V1A011 = "V1A011";

        /// <summary>
        /// V1A012.
        /// </summary>
        public const string V1A012 = "V1A012";

        /// <summary>
        /// V1A013.
        /// </summary>
        public const string V1A013 = "V1A013";

        /// <summary>
        /// V1A014.
        /// </summary>
        public const string V1A014 = "V1A014";

        /// <summary>
        /// V1A015.
        /// </summary>
        public const string V1A015 = "V1A015";

        /// <summary>
        /// V1AOP.
        /// </summary>
        public const string V1AOP = "V1AOP";

        /// <summary>
        /// V1ARED.
        /// </summary>
        public const string V1ARED = "V1ARED";

        /// <summary>
        /// V1URAB.
        /// </summary>
        public const string V1URAB = "V1URAB";

        /// <summary>
        /// V1URAT.
        /// </summary>
        public const string V1URAT = "V1URAT";

        /// <summary>
        /// V1URDT.
        /// </summary>
        public const string V1URDT = "V1URDT";

        /// <summary>
        /// V1URC1.
        /// </summary>
        public const string V1URC1 = "V1URC1";

        /// <summary>
        /// V1URRF.
        /// </summary>
        public const string V1URRF = "V1URRF";

        /// <summary>
        /// V1A76WCLN.
        /// </summary>
        public const string V1A76WCLN = "V1A76WCLN";
    }

    /// <inheritdoc />
    public override string TableName => "F760414A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V1PYID", "V1PYID", JdeDataType.Numeric, null, true, true),
        new JdeField("V1RC5", "V1RC5", JdeDataType.Numeric, null, true, true),
        new JdeField("V1DCTM", "V1DCTM", JdeDataType.String, 4),
        new JdeField("V1KCO", "V1KCO", JdeDataType.String, 10),
        new JdeField("V1DOC", "V1DOC", JdeDataType.Numeric),
        new JdeField("V1DCT", "V1DCT", JdeDataType.String, 4),
        new JdeField("V1SFX", "V1SFX", JdeDataType.String, 6),
        new JdeField("V1SFXE", "V1SFXE", JdeDataType.Numeric),
        new JdeField("V1APTT", "V1APTT", JdeDataType.String, 2),
        new JdeField("V1AIRJ", "V1AIRJ", JdeDataType.Numeric),
        new JdeField("V1ATPS", "V1ATPS", JdeDataType.String, 4),
        new JdeField("V1AAGR", "V1AAGR", JdeDataType.Numeric),
        new JdeField("V1A001", "V1A001", JdeDataType.String, 6),
        new JdeField("V1A002", "V1A002", JdeDataType.String, 6),
        new JdeField("V1A003", "V1A003", JdeDataType.String, 6),
        new JdeField("V1A004", "V1A004", JdeDataType.String, 6),
        new JdeField("V1A005", "V1A005", JdeDataType.String, 6),
        new JdeField("V1A006", "V1A006", JdeDataType.String, 6),
        new JdeField("V1A007", "V1A007", JdeDataType.String, 6),
        new JdeField("V1A008", "V1A008", JdeDataType.String, 6),
        new JdeField("V1A009", "V1A009", JdeDataType.String, 6),
        new JdeField("V1A010", "V1A010", JdeDataType.String, 6),
        new JdeField("V1A011", "V1A011", JdeDataType.String, 6),
        new JdeField("V1A012", "V1A012", JdeDataType.String, 6),
        new JdeField("V1A013", "V1A013", JdeDataType.String, 6),
        new JdeField("V1A014", "V1A014", JdeDataType.String, 6),
        new JdeField("V1A015", "V1A015", JdeDataType.String, 6),
        new JdeField("V1AOP", "V1AOP", JdeDataType.Numeric),
        new JdeField("V1ARED", "V1ARED", JdeDataType.String, 2),
        new JdeField("V1URAB", "V1URAB", JdeDataType.Numeric),
        new JdeField("V1URAT", "V1URAT", JdeDataType.Numeric),
        new JdeField("V1URDT", "V1URDT", JdeDataType.Numeric),
        new JdeField("V1URC1", "V1URC1", JdeDataType.String, 6),
        new JdeField("V1URRF", "V1URRF", JdeDataType.String, 30),
        new JdeField("V1A76WCLN", "V1A76WCLN", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760414A_0", "Primary Key on V1PYID, V1RC5", new[] { "V1PYID", "V1RC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F760414A_2", "Index on V1KCO, V1URRF", new[] { "V1KCO", "V1URRF" })
    };
}
