using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I397B - .
/// </summary>
public class F75I397B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESITM.
        /// </summary>
        public const string ESITM = "ESITM";

        /// <summary>
        /// ESLITM.
        /// </summary>
        public const string ESLITM = "ESLITM";

        /// <summary>
        /// ESDL01.
        /// </summary>
        public const string ESDL01 = "ESDL01";

        /// <summary>
        /// ESMCU.
        /// </summary>
        public const string ESMCU = "ESMCU";

        /// <summary>
        /// ESDOCO.
        /// </summary>
        public const string ESDOCO = "ESDOCO";

        /// <summary>
        /// ESSTKT.
        /// </summary>
        public const string ESSTKT = "ESSTKT";

        /// <summary>
        /// ESSTRX.
        /// </summary>
        public const string ESSTRX = "ESSTRX";

        /// <summary>
        /// ESYEXU.
        /// </summary>
        public const string ESYEXU = "ESYEXU";

        /// <summary>
        /// ESYFUSTR1.
        /// </summary>
        public const string ESYFUSTR1 = "ESYFUSTR1";

        /// <summary>
        /// ESYFUSTR3.
        /// </summary>
        public const string ESYFUSTR3 = "ESYFUSTR3";

        /// <summary>
        /// ESYFUSTR4.
        /// </summary>
        public const string ESYFUSTR4 = "ESYFUSTR4";

        /// <summary>
        /// ESYFUSTR5.
        /// </summary>
        public const string ESYFUSTR5 = "ESYFUSTR5";

        /// <summary>
        /// ESYFUSTR2.
        /// </summary>
        public const string ESYFUSTR2 = "ESYFUSTR2";

        /// <summary>
        /// ESYFUTDT2.
        /// </summary>
        public const string ESYFUTDT2 = "ESYFUTDT2";

        /// <summary>
        /// ESYFUTDT1.
        /// </summary>
        public const string ESYFUTDT1 = "ESYFUTDT1";

        /// <summary>
        /// ESYFUTDT3.
        /// </summary>
        public const string ESYFUTDT3 = "ESYFUTDT3";

        /// <summary>
        /// ESYFUTDT4.
        /// </summary>
        public const string ESYFUTDT4 = "ESYFUTDT4";

        /// <summary>
        /// ESYFUTDT5.
        /// </summary>
        public const string ESYFUTDT5 = "ESYFUTDT5";

        /// <summary>
        /// ESYT04.
        /// </summary>
        public const string ESYT04 = "ESYT04";

        /// <summary>
        /// ESYT05.
        /// </summary>
        public const string ESYT05 = "ESYT05";

        /// <summary>
        /// ESYT06.
        /// </summary>
        public const string ESYT06 = "ESYT06";

        /// <summary>
        /// ESYT07.
        /// </summary>
        public const string ESYT07 = "ESYT07";

        /// <summary>
        /// ESYT08.
        /// </summary>
        public const string ESYT08 = "ESYT08";

        /// <summary>
        /// ESFUAM.
        /// </summary>
        public const string ESFUAM = "ESFUAM";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESJOBN.
        /// </summary>
        public const string ESJOBN = "ESJOBN";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESUPMT.
        /// </summary>
        public const string ESUPMT = "ESUPMT";

        /// <summary>
        /// ESMATH01.
        /// </summary>
        public const string ESMATH01 = "ESMATH01";

        /// <summary>
        /// ESMATH02.
        /// </summary>
        public const string ESMATH02 = "ESMATH02";

        /// <summary>
        /// ESMATH03.
        /// </summary>
        public const string ESMATH03 = "ESMATH03";

        /// <summary>
        /// ESMATH04.
        /// </summary>
        public const string ESMATH04 = "ESMATH04";

        /// <summary>
        /// ESMATH05.
        /// </summary>
        public const string ESMATH05 = "ESMATH05";

        /// <summary>
        /// ESYFUQTY2.
        /// </summary>
        public const string ESYFUQTY2 = "ESYFUQTY2";

        /// <summary>
        /// ESYFUQTY3.
        /// </summary>
        public const string ESYFUQTY3 = "ESYFUQTY3";

        /// <summary>
        /// ESYFUQTY4.
        /// </summary>
        public const string ESYFUQTY4 = "ESYFUQTY4";
    }

    /// <inheritdoc />
    public override string TableName => "F75I397B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESITM", "ESITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ESLITM", "ESLITM", JdeDataType.String, 50),
        new JdeField("ESDL01", "ESDL01", JdeDataType.String, 60),
        new JdeField("ESMCU", "ESMCU", JdeDataType.String, 24),
        new JdeField("ESDOCO", "ESDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ESSTKT", "ESSTKT", JdeDataType.String, 2),
        new JdeField("ESSTRX", "ESSTRX", JdeDataType.Numeric, null, true, true),
        new JdeField("ESYEXU", "ESYEXU", JdeDataType.Numeric),
        new JdeField("ESYFUSTR1", "ESYFUSTR1", JdeDataType.String, 60),
        new JdeField("ESYFUSTR3", "ESYFUSTR3", JdeDataType.String, 60),
        new JdeField("ESYFUSTR4", "ESYFUSTR4", JdeDataType.String, 60),
        new JdeField("ESYFUSTR5", "ESYFUSTR5", JdeDataType.String, 60),
        new JdeField("ESYFUSTR2", "ESYFUSTR2", JdeDataType.String, 60),
        new JdeField("ESYFUTDT2", "ESYFUTDT2", JdeDataType.Numeric),
        new JdeField("ESYFUTDT1", "ESYFUTDT1", JdeDataType.Numeric),
        new JdeField("ESYFUTDT3", "ESYFUTDT3", JdeDataType.Numeric),
        new JdeField("ESYFUTDT4", "ESYFUTDT4", JdeDataType.Numeric),
        new JdeField("ESYFUTDT5", "ESYFUTDT5", JdeDataType.Numeric),
        new JdeField("ESYT04", "ESYT04", JdeDataType.String, 2),
        new JdeField("ESYT05", "ESYT05", JdeDataType.String, 2),
        new JdeField("ESYT06", "ESYT06", JdeDataType.String, 2),
        new JdeField("ESYT07", "ESYT07", JdeDataType.String, 2),
        new JdeField("ESYT08", "ESYT08", JdeDataType.String, 2),
        new JdeField("ESFUAM", "ESFUAM", JdeDataType.Numeric),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESUPMT", "ESUPMT", JdeDataType.Numeric),
        new JdeField("ESMATH01", "ESMATH01", JdeDataType.Numeric),
        new JdeField("ESMATH02", "ESMATH02", JdeDataType.Numeric),
        new JdeField("ESMATH03", "ESMATH03", JdeDataType.Numeric),
        new JdeField("ESMATH04", "ESMATH04", JdeDataType.Numeric),
        new JdeField("ESMATH05", "ESMATH05", JdeDataType.Numeric),
        new JdeField("ESYFUQTY2", "ESYFUQTY2", JdeDataType.Numeric),
        new JdeField("ESYFUQTY3", "ESYFUQTY3", JdeDataType.Numeric),
        new JdeField("ESYFUQTY4", "ESYFUQTY4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I397B_0", "Primary Key on ESDOCO, ESSTRX, ESITM", new[] { "ESDOCO", "ESSTRX", "ESITM" }, isUnique: true, isPrimaryKey: true)
    };
}
