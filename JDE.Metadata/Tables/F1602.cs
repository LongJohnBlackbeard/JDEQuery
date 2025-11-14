using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1602 - .
/// </summary>
public class F1602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBVWNM.
        /// </summary>
        public const string CBVWNM = "CBVWNM";

        /// <summary>
        /// CBACTB.
        /// </summary>
        public const string CBACTB = "CBACTB";

        /// <summary>
        /// CBAID.
        /// </summary>
        public const string CBAID = "CBAID";

        /// <summary>
        /// CBCFY.
        /// </summary>
        public const string CBCFY = "CBCFY";

        /// <summary>
        /// CBLT.
        /// </summary>
        public const string CBLT = "CBLT";

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
        /// CBCO.
        /// </summary>
        public const string CBCO = "CBCO";

        /// <summary>
        /// CBAPYC.
        /// </summary>
        public const string CBAPYC = "CBAPYC";

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
        /// CBNB01.
        /// </summary>
        public const string CBNB01 = "CBNB01";

        /// <summary>
        /// CBNB02.
        /// </summary>
        public const string CBNB02 = "CBNB02";

        /// <summary>
        /// CBNB03.
        /// </summary>
        public const string CBNB03 = "CBNB03";

        /// <summary>
        /// CBNB04.
        /// </summary>
        public const string CBNB04 = "CBNB04";

        /// <summary>
        /// CBNB05.
        /// </summary>
        public const string CBNB05 = "CBNB05";

        /// <summary>
        /// CBNB06.
        /// </summary>
        public const string CBNB06 = "CBNB06";

        /// <summary>
        /// CBNB07.
        /// </summary>
        public const string CBNB07 = "CBNB07";

        /// <summary>
        /// CBNB08.
        /// </summary>
        public const string CBNB08 = "CBNB08";

        /// <summary>
        /// CBNB09.
        /// </summary>
        public const string CBNB09 = "CBNB09";

        /// <summary>
        /// CBNB10.
        /// </summary>
        public const string CBNB10 = "CBNB10";

        /// <summary>
        /// CBNB11.
        /// </summary>
        public const string CBNB11 = "CBNB11";

        /// <summary>
        /// CBNB12.
        /// </summary>
        public const string CBNB12 = "CBNB12";

        /// <summary>
        /// CBNB13.
        /// </summary>
        public const string CBNB13 = "CBNB13";

        /// <summary>
        /// CBNB14.
        /// </summary>
        public const string CBNB14 = "CBNB14";

        /// <summary>
        /// CBASMF.
        /// </summary>
        public const string CBASMF = "CBASMF";

        /// <summary>
        /// CBAWTD.
        /// </summary>
        public const string CBAWTD = "CBAWTD";

        /// <summary>
        /// CBBORG.
        /// </summary>
        public const string CBBORG = "CBBORG";

        /// <summary>
        /// CBBREQ.
        /// </summary>
        public const string CBBREQ = "CBBREQ";

        /// <summary>
        /// CBBAPR.
        /// </summary>
        public const string CBBAPR = "CBBAPR";

        /// <summary>
        /// CBMCU.
        /// </summary>
        public const string CBMCU = "CBMCU";

        /// <summary>
        /// CBOBJ.
        /// </summary>
        public const string CBOBJ = "CBOBJ";

        /// <summary>
        /// CBSUB.
        /// </summary>
        public const string CBSUB = "CBSUB";

        /// <summary>
        /// CBCRCD.
        /// </summary>
        public const string CBCRCD = "CBCRCD";

        /// <summary>
        /// CBCRCX.
        /// </summary>
        public const string CBCRCX = "CBCRCX";

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
    }

    /// <inheritdoc />
    public override string TableName => "F1602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBVWNM", "CBVWNM", JdeDataType.Numeric, null, true, true),
        new JdeField("CBACTB", "CBACTB", JdeDataType.String, 20, true, true),
        new JdeField("CBAID", "CBAID", JdeDataType.String, 16, true, true),
        new JdeField("CBCFY", "CBCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CBLT", "CBLT", JdeDataType.String, 4, true, true),
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
        new JdeField("CBCO", "CBCO", JdeDataType.String, 10),
        new JdeField("CBAPYC", "CBAPYC", JdeDataType.Numeric),
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
        new JdeField("CBNB01", "CBNB01", JdeDataType.Numeric),
        new JdeField("CBNB02", "CBNB02", JdeDataType.Numeric),
        new JdeField("CBNB03", "CBNB03", JdeDataType.Numeric),
        new JdeField("CBNB04", "CBNB04", JdeDataType.Numeric),
        new JdeField("CBNB05", "CBNB05", JdeDataType.Numeric),
        new JdeField("CBNB06", "CBNB06", JdeDataType.Numeric),
        new JdeField("CBNB07", "CBNB07", JdeDataType.Numeric),
        new JdeField("CBNB08", "CBNB08", JdeDataType.Numeric),
        new JdeField("CBNB09", "CBNB09", JdeDataType.Numeric),
        new JdeField("CBNB10", "CBNB10", JdeDataType.Numeric),
        new JdeField("CBNB11", "CBNB11", JdeDataType.Numeric),
        new JdeField("CBNB12", "CBNB12", JdeDataType.Numeric),
        new JdeField("CBNB13", "CBNB13", JdeDataType.Numeric),
        new JdeField("CBNB14", "CBNB14", JdeDataType.Numeric),
        new JdeField("CBASMF", "CBASMF", JdeDataType.String, 2),
        new JdeField("CBAWTD", "CBAWTD", JdeDataType.Numeric),
        new JdeField("CBBORG", "CBBORG", JdeDataType.Numeric),
        new JdeField("CBBREQ", "CBBREQ", JdeDataType.Numeric),
        new JdeField("CBBAPR", "CBBAPR", JdeDataType.Numeric),
        new JdeField("CBMCU", "CBMCU", JdeDataType.String, 24),
        new JdeField("CBOBJ", "CBOBJ", JdeDataType.String, 12),
        new JdeField("CBSUB", "CBSUB", JdeDataType.String, 16),
        new JdeField("CBCRCD", "CBCRCD", JdeDataType.String, 6),
        new JdeField("CBCRCX", "CBCRCX", JdeDataType.String, 6),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBUPMJ", "CBUPMJ", JdeDataType.Numeric),
        new JdeField("CBUPMT", "CBUPMT", JdeDataType.Numeric),
        new JdeField("CBJOBN", "CBJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1602_0", "Primary Key on CBVWNM, CBACTB, CBAID, CBCFY, CBLT, CBSBL, CBSBLT, CBABR1, CBABT1, CBABR2, CBABT2, CBABR3, CBABT3, CBABR4, CBABT4, CBITM", new[] { "CBVWNM", "CBACTB", "CBAID", "CBCFY", "CBLT", "CBSBL", "CBSBLT", "CBABR1", "CBABT1", "CBABR2", "CBABT2", "CBABR3", "CBABT3", "CBABR4", "CBABT4", "CBITM" }, isUnique: true, isPrimaryKey: true)
    };
}
