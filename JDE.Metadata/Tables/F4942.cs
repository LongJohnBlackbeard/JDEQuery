using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4942 - .
/// </summary>
public class F4942 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISSHPN.
        /// </summary>
        public const string ISSHPN = "ISSHPN";

        /// <summary>
        /// ISRSSN.
        /// </summary>
        public const string ISRSSN = "ISRSSN";

        /// <summary>
        /// ISDOCO.
        /// </summary>
        public const string ISDOCO = "ISDOCO";

        /// <summary>
        /// ISDCTO.
        /// </summary>
        public const string ISDCTO = "ISDCTO";

        /// <summary>
        /// ISKCOO.
        /// </summary>
        public const string ISKCOO = "ISKCOO";

        /// <summary>
        /// ISLNID.
        /// </summary>
        public const string ISLNID = "ISLNID";

        /// <summary>
        /// ISWGTS.
        /// </summary>
        public const string ISWGTS = "ISWGTS";

        /// <summary>
        /// ISWTUM.
        /// </summary>
        public const string ISWTUM = "ISWTUM";

        /// <summary>
        /// ISSCVL.
        /// </summary>
        public const string ISSCVL = "ISSCVL";

        /// <summary>
        /// ISVLUM.
        /// </summary>
        public const string ISVLUM = "ISVLUM";

        /// <summary>
        /// ISITM.
        /// </summary>
        public const string ISITM = "ISITM";

        /// <summary>
        /// ISSOQS.
        /// </summary>
        public const string ISSOQS = "ISSOQS";

        /// <summary>
        /// ISUOM.
        /// </summary>
        public const string ISUOM = "ISUOM";

        /// <summary>
        /// ISPRP1.
        /// </summary>
        public const string ISPRP1 = "ISPRP1";

        /// <summary>
        /// ISNMFC.
        /// </summary>
        public const string ISNMFC = "ISNMFC";

        /// <summary>
        /// ISDSGP.
        /// </summary>
        public const string ISDSGP = "ISDSGP";

        /// <summary>
        /// ISHZDC.
        /// </summary>
        public const string ISHZDC = "ISHZDC";

        /// <summary>
        /// ISFRT1.
        /// </summary>
        public const string ISFRT1 = "ISFRT1";

        /// <summary>
        /// ISFRT2.
        /// </summary>
        public const string ISFRT2 = "ISFRT2";

        /// <summary>
        /// ISAEXP.
        /// </summary>
        public const string ISAEXP = "ISAEXP";

        /// <summary>
        /// ISFEA.
        /// </summary>
        public const string ISFEA = "ISFEA";

        /// <summary>
        /// ISCRCD.
        /// </summary>
        public const string ISCRCD = "ISCRCD";

        /// <summary>
        /// ISECST.
        /// </summary>
        public const string ISECST = "ISECST";

        /// <summary>
        /// ISURCD.
        /// </summary>
        public const string ISURCD = "ISURCD";

        /// <summary>
        /// ISURDT.
        /// </summary>
        public const string ISURDT = "ISURDT";

        /// <summary>
        /// ISURAT.
        /// </summary>
        public const string ISURAT = "ISURAT";

        /// <summary>
        /// ISURAB.
        /// </summary>
        public const string ISURAB = "ISURAB";

        /// <summary>
        /// ISURRF.
        /// </summary>
        public const string ISURRF = "ISURRF";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISTDAY.
        /// </summary>
        public const string ISTDAY = "ISTDAY";

        /// <summary>
        /// ISCUMS.
        /// </summary>
        public const string ISCUMS = "ISCUMS";
    }

    /// <inheritdoc />
    public override string TableName => "F4942";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISSHPN", "ISSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("ISRSSN", "ISRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("ISDOCO", "ISDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ISDCTO", "ISDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ISKCOO", "ISKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ISLNID", "ISLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ISWGTS", "ISWGTS", JdeDataType.Numeric),
        new JdeField("ISWTUM", "ISWTUM", JdeDataType.String, 4),
        new JdeField("ISSCVL", "ISSCVL", JdeDataType.Numeric),
        new JdeField("ISVLUM", "ISVLUM", JdeDataType.String, 4),
        new JdeField("ISITM", "ISITM", JdeDataType.Numeric),
        new JdeField("ISSOQS", "ISSOQS", JdeDataType.Numeric),
        new JdeField("ISUOM", "ISUOM", JdeDataType.String, 4),
        new JdeField("ISPRP1", "ISPRP1", JdeDataType.String, 6),
        new JdeField("ISNMFC", "ISNMFC", JdeDataType.String, 8),
        new JdeField("ISDSGP", "ISDSGP", JdeDataType.String, 6),
        new JdeField("ISHZDC", "ISHZDC", JdeDataType.String, 6),
        new JdeField("ISFRT1", "ISFRT1", JdeDataType.String, 12),
        new JdeField("ISFRT2", "ISFRT2", JdeDataType.String, 12),
        new JdeField("ISAEXP", "ISAEXP", JdeDataType.Numeric),
        new JdeField("ISFEA", "ISFEA", JdeDataType.Numeric),
        new JdeField("ISCRCD", "ISCRCD", JdeDataType.String, 6),
        new JdeField("ISECST", "ISECST", JdeDataType.Numeric),
        new JdeField("ISURCD", "ISURCD", JdeDataType.String, 4),
        new JdeField("ISURDT", "ISURDT", JdeDataType.Numeric),
        new JdeField("ISURAT", "ISURAT", JdeDataType.Numeric),
        new JdeField("ISURAB", "ISURAB", JdeDataType.Numeric),
        new JdeField("ISURRF", "ISURRF", JdeDataType.String, 30),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISTDAY", "ISTDAY", JdeDataType.Numeric),
        new JdeField("ISCUMS", "ISCUMS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4942_0", "Primary Key on ISSHPN, ISRSSN, ISDOCO, ISDCTO, ISKCOO, ISLNID", new[] { "ISSHPN", "ISRSSN", "ISDOCO", "ISDCTO", "ISKCOO", "ISLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4942_3", "Index on ISSHPN, ISRSSN, ISDOCO, ISDCTO, ISKCOO", new[] { "ISSHPN", "ISRSSN", "ISDOCO", "ISDCTO", "ISKCOO" }),
        new JdeIndex("F4942_4", "Index on ISDOCO, ISDCTO, ISKCOO, ISLNID", new[] { "ISDOCO", "ISDCTO", "ISKCOO", "ISLNID" }),
        new JdeIndex("F4942_5", "Index on ISSHPN, ISITM", new[] { "ISSHPN", "ISITM" }),
        new JdeIndex("F4942_6", "Index on ISDOCO, ISDCTO", new[] { "ISDOCO", "ISDCTO" })
    };
}
