using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760411A - .
/// </summary>
public class F760411A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B2DOC.
        /// </summary>
        public const string B2DOC = "B2DOC";

        /// <summary>
        /// B2DCT.
        /// </summary>
        public const string B2DCT = "B2DCT";

        /// <summary>
        /// B2KCO.
        /// </summary>
        public const string B2KCO = "B2KCO";

        /// <summary>
        /// B2SFX.
        /// </summary>
        public const string B2SFX = "B2SFX";

        /// <summary>
        /// B2SFXE.
        /// </summary>
        public const string B2SFXE = "B2SFXE";

        /// <summary>
        /// B2AINC.
        /// </summary>
        public const string B2AINC = "B2AINC";

        /// <summary>
        /// B2AADJ.
        /// </summary>
        public const string B2AADJ = "B2AADJ";

        /// <summary>
        /// B2AADN.
        /// </summary>
        public const string B2AADN = "B2AADN";

        /// <summary>
        /// B2ADGI.
        /// </summary>
        public const string B2ADGI = "B2ADGI";

        /// <summary>
        /// B2APFC.
        /// </summary>
        public const string B2APFC = "B2APFC";

        /// <summary>
        /// B2ARED.
        /// </summary>
        public const string B2ARED = "B2ARED";

        /// <summary>
        /// B2A001.
        /// </summary>
        public const string B2A001 = "B2A001";

        /// <summary>
        /// B2A002.
        /// </summary>
        public const string B2A002 = "B2A002";

        /// <summary>
        /// B2A003.
        /// </summary>
        public const string B2A003 = "B2A003";

        /// <summary>
        /// B2A004.
        /// </summary>
        public const string B2A004 = "B2A004";

        /// <summary>
        /// B2A005.
        /// </summary>
        public const string B2A005 = "B2A005";

        /// <summary>
        /// B2A006.
        /// </summary>
        public const string B2A006 = "B2A006";

        /// <summary>
        /// B2A007.
        /// </summary>
        public const string B2A007 = "B2A007";

        /// <summary>
        /// B2A008.
        /// </summary>
        public const string B2A008 = "B2A008";

        /// <summary>
        /// B2A009.
        /// </summary>
        public const string B2A009 = "B2A009";

        /// <summary>
        /// B2A010.
        /// </summary>
        public const string B2A010 = "B2A010";

        /// <summary>
        /// B2A011.
        /// </summary>
        public const string B2A011 = "B2A011";

        /// <summary>
        /// B2A012.
        /// </summary>
        public const string B2A012 = "B2A012";

        /// <summary>
        /// B2A013.
        /// </summary>
        public const string B2A013 = "B2A013";

        /// <summary>
        /// B2A014.
        /// </summary>
        public const string B2A014 = "B2A014";

        /// <summary>
        /// B2A015.
        /// </summary>
        public const string B2A015 = "B2A015";

        /// <summary>
        /// B2URAB.
        /// </summary>
        public const string B2URAB = "B2URAB";

        /// <summary>
        /// B2URAT.
        /// </summary>
        public const string B2URAT = "B2URAT";

        /// <summary>
        /// B2URDT.
        /// </summary>
        public const string B2URDT = "B2URDT";

        /// <summary>
        /// B2URC1.
        /// </summary>
        public const string B2URC1 = "B2URC1";

        /// <summary>
        /// B2URRF.
        /// </summary>
        public const string B2URRF = "B2URRF";

        /// <summary>
        /// B2AGRP.
        /// </summary>
        public const string B2AGRP = "B2AGRP";

        /// <summary>
        /// B2ADGI1.
        /// </summary>
        public const string B2ADGI1 = "B2ADGI1";
    }

    /// <inheritdoc />
    public override string TableName => "F760411A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B2DOC", "B2DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("B2DCT", "B2DCT", JdeDataType.String, 4, true, true),
        new JdeField("B2KCO", "B2KCO", JdeDataType.String, 10, true, true),
        new JdeField("B2SFX", "B2SFX", JdeDataType.String, 6, true, true),
        new JdeField("B2SFXE", "B2SFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("B2AINC", "B2AINC", JdeDataType.String, 2),
        new JdeField("B2AADJ", "B2AADJ", JdeDataType.Numeric),
        new JdeField("B2AADN", "B2AADN", JdeDataType.String, 16),
        new JdeField("B2ADGI", "B2ADGI", JdeDataType.String, 4),
        new JdeField("B2APFC", "B2APFC", JdeDataType.Numeric),
        new JdeField("B2ARED", "B2ARED", JdeDataType.String, 2),
        new JdeField("B2A001", "B2A001", JdeDataType.String, 6),
        new JdeField("B2A002", "B2A002", JdeDataType.String, 6),
        new JdeField("B2A003", "B2A003", JdeDataType.String, 6),
        new JdeField("B2A004", "B2A004", JdeDataType.String, 6),
        new JdeField("B2A005", "B2A005", JdeDataType.String, 6),
        new JdeField("B2A006", "B2A006", JdeDataType.String, 6),
        new JdeField("B2A007", "B2A007", JdeDataType.String, 6),
        new JdeField("B2A008", "B2A008", JdeDataType.String, 6),
        new JdeField("B2A009", "B2A009", JdeDataType.String, 6),
        new JdeField("B2A010", "B2A010", JdeDataType.String, 6),
        new JdeField("B2A011", "B2A011", JdeDataType.String, 6),
        new JdeField("B2A012", "B2A012", JdeDataType.String, 6),
        new JdeField("B2A013", "B2A013", JdeDataType.String, 6),
        new JdeField("B2A014", "B2A014", JdeDataType.String, 6),
        new JdeField("B2A015", "B2A015", JdeDataType.String, 6),
        new JdeField("B2URAB", "B2URAB", JdeDataType.Numeric),
        new JdeField("B2URAT", "B2URAT", JdeDataType.Numeric),
        new JdeField("B2URDT", "B2URDT", JdeDataType.Numeric),
        new JdeField("B2URC1", "B2URC1", JdeDataType.String, 6),
        new JdeField("B2URRF", "B2URRF", JdeDataType.String, 30),
        new JdeField("B2AGRP", "B2AGRP", JdeDataType.String, 2),
        new JdeField("B2ADGI1", "B2ADGI1", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760411A_0", "Primary Key on B2DOC, B2DCT, B2KCO, B2SFX, B2SFXE", new[] { "B2DOC", "B2DCT", "B2KCO", "B2SFX", "B2SFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
