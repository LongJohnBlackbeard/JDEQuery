using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760473A - .
/// </summary>
public class F760473A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// E5HDC.
        /// </summary>
        public const string E5HDC = "E5HDC";

        /// <summary>
        /// E5CKC.
        /// </summary>
        public const string E5CKC = "E5CKC";

        /// <summary>
        /// E5RC.
        /// </summary>
        public const string E5RC = "E5RC";

        /// <summary>
        /// E5DCT.
        /// </summary>
        public const string E5DCT = "E5DCT";

        /// <summary>
        /// E5DOC.
        /// </summary>
        public const string E5DOC = "E5DOC";

        /// <summary>
        /// E5KCO.
        /// </summary>
        public const string E5KCO = "E5KCO";

        /// <summary>
        /// E5SFX.
        /// </summary>
        public const string E5SFX = "E5SFX";

        /// <summary>
        /// E5AN8.
        /// </summary>
        public const string E5AN8 = "E5AN8";

        /// <summary>
        /// E5AG.
        /// </summary>
        public const string E5AG = "E5AG";

        /// <summary>
        /// E5ACR.
        /// </summary>
        public const string E5ACR = "E5ACR";

        /// <summary>
        /// E5CRR.
        /// </summary>
        public const string E5CRR = "E5CRR";

        /// <summary>
        /// E5RMK.
        /// </summary>
        public const string E5RMK = "E5RMK";

        /// <summary>
        /// E5A001.
        /// </summary>
        public const string E5A001 = "E5A001";

        /// <summary>
        /// E5A002.
        /// </summary>
        public const string E5A002 = "E5A002";

        /// <summary>
        /// E5A003.
        /// </summary>
        public const string E5A003 = "E5A003";

        /// <summary>
        /// E5A004.
        /// </summary>
        public const string E5A004 = "E5A004";

        /// <summary>
        /// E5A005.
        /// </summary>
        public const string E5A005 = "E5A005";

        /// <summary>
        /// E5A006.
        /// </summary>
        public const string E5A006 = "E5A006";

        /// <summary>
        /// E5A007.
        /// </summary>
        public const string E5A007 = "E5A007";

        /// <summary>
        /// E5A008.
        /// </summary>
        public const string E5A008 = "E5A008";

        /// <summary>
        /// E5A009.
        /// </summary>
        public const string E5A009 = "E5A009";

        /// <summary>
        /// E5A010.
        /// </summary>
        public const string E5A010 = "E5A010";

        /// <summary>
        /// E5A011.
        /// </summary>
        public const string E5A011 = "E5A011";

        /// <summary>
        /// E5A012.
        /// </summary>
        public const string E5A012 = "E5A012";

        /// <summary>
        /// E5A013.
        /// </summary>
        public const string E5A013 = "E5A013";

        /// <summary>
        /// E5A014.
        /// </summary>
        public const string E5A014 = "E5A014";

        /// <summary>
        /// E5A015.
        /// </summary>
        public const string E5A015 = "E5A015";

        /// <summary>
        /// E5URAB.
        /// </summary>
        public const string E5URAB = "E5URAB";

        /// <summary>
        /// E5URAT.
        /// </summary>
        public const string E5URAT = "E5URAT";

        /// <summary>
        /// E5URDT.
        /// </summary>
        public const string E5URDT = "E5URDT";

        /// <summary>
        /// E5URC1.
        /// </summary>
        public const string E5URC1 = "E5URC1";

        /// <summary>
        /// E5URRF.
        /// </summary>
        public const string E5URRF = "E5URRF";

        /// <summary>
        /// E5ACCWH.
        /// </summary>
        public const string E5ACCWH = "E5ACCWH";
    }

    /// <inheritdoc />
    public override string TableName => "F760473A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("E5HDC", "E5HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("E5CKC", "E5CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("E5RC", "E5RC", JdeDataType.String, 2, true, true),
        new JdeField("E5DCT", "E5DCT", JdeDataType.String, 4, true, true),
        new JdeField("E5DOC", "E5DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("E5KCO", "E5KCO", JdeDataType.String, 10, true, true),
        new JdeField("E5SFX", "E5SFX", JdeDataType.String, 6, true, true),
        new JdeField("E5AN8", "E5AN8", JdeDataType.Numeric),
        new JdeField("E5AG", "E5AG", JdeDataType.Numeric),
        new JdeField("E5ACR", "E5ACR", JdeDataType.Numeric),
        new JdeField("E5CRR", "E5CRR", JdeDataType.Numeric),
        new JdeField("E5RMK", "E5RMK", JdeDataType.String, 60),
        new JdeField("E5A001", "E5A001", JdeDataType.String, 6),
        new JdeField("E5A002", "E5A002", JdeDataType.String, 6),
        new JdeField("E5A003", "E5A003", JdeDataType.String, 6),
        new JdeField("E5A004", "E5A004", JdeDataType.String, 6),
        new JdeField("E5A005", "E5A005", JdeDataType.String, 6),
        new JdeField("E5A006", "E5A006", JdeDataType.String, 6),
        new JdeField("E5A007", "E5A007", JdeDataType.String, 6),
        new JdeField("E5A008", "E5A008", JdeDataType.String, 6),
        new JdeField("E5A009", "E5A009", JdeDataType.String, 6),
        new JdeField("E5A010", "E5A010", JdeDataType.String, 6),
        new JdeField("E5A011", "E5A011", JdeDataType.String, 6),
        new JdeField("E5A012", "E5A012", JdeDataType.String, 6),
        new JdeField("E5A013", "E5A013", JdeDataType.String, 6),
        new JdeField("E5A014", "E5A014", JdeDataType.String, 6),
        new JdeField("E5A015", "E5A015", JdeDataType.String, 6),
        new JdeField("E5URAB", "E5URAB", JdeDataType.Numeric),
        new JdeField("E5URAT", "E5URAT", JdeDataType.Numeric),
        new JdeField("E5URDT", "E5URDT", JdeDataType.Numeric),
        new JdeField("E5URC1", "E5URC1", JdeDataType.String, 6),
        new JdeField("E5URRF", "E5URRF", JdeDataType.String, 30),
        new JdeField("E5ACCWH", "E5ACCWH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760473A_0", "Primary Key on E5HDC, E5CKC, E5RC, E5DCT, E5DOC, E5KCO, E5SFX", new[] { "E5HDC", "E5CKC", "E5RC", "E5DCT", "E5DOC", "E5KCO", "E5SFX" }, isUnique: true, isPrimaryKey: true)
    };
}
