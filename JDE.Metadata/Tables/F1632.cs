using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1632 - .
/// </summary>
public class F1632 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBDRCD.
        /// </summary>
        public const string CBDRCD = "CBDRCD";

        /// <summary>
        /// CBMCU.
        /// </summary>
        public const string CBMCU = "CBMCU";

        /// <summary>
        /// CBCFY.
        /// </summary>
        public const string CBCFY = "CBCFY";

        /// <summary>
        /// CBLT.
        /// </summary>
        public const string CBLT = "CBLT";

        /// <summary>
        /// CBACTB.
        /// </summary>
        public const string CBACTB = "CBACTB";

        /// <summary>
        /// CBSBL.
        /// </summary>
        public const string CBSBL = "CBSBL";

        /// <summary>
        /// CBSBLT.
        /// </summary>
        public const string CBSBLT = "CBSBLT";

        /// <summary>
        /// CBABR1.
        /// </summary>
        public const string CBABR1 = "CBABR1";

        /// <summary>
        /// CBABT1.
        /// </summary>
        public const string CBABT1 = "CBABT1";

        /// <summary>
        /// CBABR2.
        /// </summary>
        public const string CBABR2 = "CBABR2";

        /// <summary>
        /// CBABT2.
        /// </summary>
        public const string CBABT2 = "CBABT2";

        /// <summary>
        /// CBABR3.
        /// </summary>
        public const string CBABR3 = "CBABR3";

        /// <summary>
        /// CBABT3.
        /// </summary>
        public const string CBABT3 = "CBABT3";

        /// <summary>
        /// CBABR4.
        /// </summary>
        public const string CBABR4 = "CBABR4";

        /// <summary>
        /// CBABT4.
        /// </summary>
        public const string CBABT4 = "CBABT4";

        /// <summary>
        /// CBITM.
        /// </summary>
        public const string CBITM = "CBITM";

        /// <summary>
        /// CBCRCX.
        /// </summary>
        public const string CBCRCX = "CBCRCX";

        /// <summary>
        /// CBUOM.
        /// </summary>
        public const string CBUOM = "CBUOM";

        /// <summary>
        /// CBCO.
        /// </summary>
        public const string CBCO = "CBCO";

        /// <summary>
        /// CBAN01.
        /// </summary>
        public const string CBAN01 = "CBAN01";

        /// <summary>
        /// CBAN02.
        /// </summary>
        public const string CBAN02 = "CBAN02";

        /// <summary>
        /// CBAN03.
        /// </summary>
        public const string CBAN03 = "CBAN03";

        /// <summary>
        /// CBAN04.
        /// </summary>
        public const string CBAN04 = "CBAN04";

        /// <summary>
        /// CBAN05.
        /// </summary>
        public const string CBAN05 = "CBAN05";

        /// <summary>
        /// CBAN06.
        /// </summary>
        public const string CBAN06 = "CBAN06";

        /// <summary>
        /// CBAN07.
        /// </summary>
        public const string CBAN07 = "CBAN07";

        /// <summary>
        /// CBAN08.
        /// </summary>
        public const string CBAN08 = "CBAN08";

        /// <summary>
        /// CBAN09.
        /// </summary>
        public const string CBAN09 = "CBAN09";

        /// <summary>
        /// CBAN10.
        /// </summary>
        public const string CBAN10 = "CBAN10";

        /// <summary>
        /// CBAN11.
        /// </summary>
        public const string CBAN11 = "CBAN11";

        /// <summary>
        /// CBAN12.
        /// </summary>
        public const string CBAN12 = "CBAN12";

        /// <summary>
        /// CBAN13.
        /// </summary>
        public const string CBAN13 = "CBAN13";

        /// <summary>
        /// CBAN14.
        /// </summary>
        public const string CBAN14 = "CBAN14";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBPID.
        /// </summary>
        public const string CBPID = "CBPID";

        /// <summary>
        /// CBUPMJ.
        /// </summary>
        public const string CBUPMJ = "CBUPMJ";

        /// <summary>
        /// CBUPMT.
        /// </summary>
        public const string CBUPMT = "CBUPMT";

        /// <summary>
        /// CBJOBN.
        /// </summary>
        public const string CBJOBN = "CBJOBN";

        /// <summary>
        /// CBWGHF.
        /// </summary>
        public const string CBWGHF = "CBWGHF";
    }

    /// <inheritdoc />
    public override string TableName => "F1632";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBDRCD", "CBDRCD", JdeDataType.String, 20, true, true),
        new JdeField("CBMCU", "CBMCU", JdeDataType.String, 24, true, true),
        new JdeField("CBCFY", "CBCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CBLT", "CBLT", JdeDataType.String, 4, true, true),
        new JdeField("CBACTB", "CBACTB", JdeDataType.String, 20, true, true),
        new JdeField("CBSBL", "CBSBL", JdeDataType.String, 16, true, true),
        new JdeField("CBSBLT", "CBSBLT", JdeDataType.String, 2, true, true),
        new JdeField("CBABR1", "CBABR1", JdeDataType.String, 24, true, true),
        new JdeField("CBABT1", "CBABT1", JdeDataType.String, 2, true, true),
        new JdeField("CBABR2", "CBABR2", JdeDataType.String, 24, true, true),
        new JdeField("CBABT2", "CBABT2", JdeDataType.String, 2, true, true),
        new JdeField("CBABR3", "CBABR3", JdeDataType.String, 24, true, true),
        new JdeField("CBABT3", "CBABT3", JdeDataType.String, 2, true, true),
        new JdeField("CBABR4", "CBABR4", JdeDataType.String, 24, true, true),
        new JdeField("CBABT4", "CBABT4", JdeDataType.String, 2, true, true),
        new JdeField("CBITM", "CBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CBCRCX", "CBCRCX", JdeDataType.String, 6),
        new JdeField("CBUOM", "CBUOM", JdeDataType.String, 4),
        new JdeField("CBCO", "CBCO", JdeDataType.String, 10),
        new JdeField("CBAN01", "CBAN01", JdeDataType.Numeric),
        new JdeField("CBAN02", "CBAN02", JdeDataType.Numeric),
        new JdeField("CBAN03", "CBAN03", JdeDataType.Numeric),
        new JdeField("CBAN04", "CBAN04", JdeDataType.Numeric),
        new JdeField("CBAN05", "CBAN05", JdeDataType.Numeric),
        new JdeField("CBAN06", "CBAN06", JdeDataType.Numeric),
        new JdeField("CBAN07", "CBAN07", JdeDataType.Numeric),
        new JdeField("CBAN08", "CBAN08", JdeDataType.Numeric),
        new JdeField("CBAN09", "CBAN09", JdeDataType.Numeric),
        new JdeField("CBAN10", "CBAN10", JdeDataType.Numeric),
        new JdeField("CBAN11", "CBAN11", JdeDataType.Numeric),
        new JdeField("CBAN12", "CBAN12", JdeDataType.Numeric),
        new JdeField("CBAN13", "CBAN13", JdeDataType.Numeric),
        new JdeField("CBAN14", "CBAN14", JdeDataType.Numeric),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBUPMJ", "CBUPMJ", JdeDataType.Numeric),
        new JdeField("CBUPMT", "CBUPMT", JdeDataType.Numeric),
        new JdeField("CBJOBN", "CBJOBN", JdeDataType.String, 20),
        new JdeField("CBWGHF", "CBWGHF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1632_0", "Primary Key on CBDRCD, CBMCU, CBCFY, CBLT, CBACTB, CBSBL, CBSBLT, CBABR1, CBABT1, CBABR2, CBABT2, CBABR3, CBABT3, CBABR4, CBABT4, CBITM", new[] { "CBDRCD", "CBMCU", "CBCFY", "CBLT", "CBACTB", "CBSBL", "CBSBLT", "CBABR1", "CBABT1", "CBABR2", "CBABT2", "CBABR3", "CBABT3", "CBABR4", "CBABT4", "CBITM" }, isUnique: true, isPrimaryKey: true)
    };
}
