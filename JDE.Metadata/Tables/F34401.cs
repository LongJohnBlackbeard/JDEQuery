using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34401 - .
/// </summary>
public class F34401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PNKCO.
        /// </summary>
        public const string PNKCO = "PNKCO";

        /// <summary>
        /// PNPNS.
        /// </summary>
        public const string PNPNS = "PNPNS";

        /// <summary>
        /// PNPMPN.
        /// </summary>
        public const string PNPMPN = "PNPMPN";

        /// <summary>
        /// PNDL01.
        /// </summary>
        public const string PNDL01 = "PNDL01";

        /// <summary>
        /// PNLITM.
        /// </summary>
        public const string PNLITM = "PNLITM";

        /// <summary>
        /// PNAITM.
        /// </summary>
        public const string PNAITM = "PNAITM";

        /// <summary>
        /// PNITM.
        /// </summary>
        public const string PNITM = "PNITM";

        /// <summary>
        /// PNPRODT.
        /// </summary>
        public const string PNPRODT = "PNPRODT";

        /// <summary>
        /// PNPRODS.
        /// </summary>
        public const string PNPRODS = "PNPRODS";

        /// <summary>
        /// PNPNDTCRTD.
        /// </summary>
        public const string PNPNDTCRTD = "PNPNDTCRTD";

        /// <summary>
        /// PNPNDTCLSD.
        /// </summary>
        public const string PNPNDTCLSD = "PNPNDTCLSD";

        /// <summary>
        /// PNAN8.
        /// </summary>
        public const string PNAN8 = "PNAN8";

        /// <summary>
        /// PNCENTYR.
        /// </summary>
        public const string PNCENTYR = "PNCENTYR";

        /// <summary>
        /// PNMONTH.
        /// </summary>
        public const string PNMONTH = "PNMONTH";

        /// <summary>
        /// PNSLMCU.
        /// </summary>
        public const string PNSLMCU = "PNSLMCU";

        /// <summary>
        /// PNMFGMCU.
        /// </summary>
        public const string PNMFGMCU = "PNMFGMCU";

        /// <summary>
        /// PNPNCCD1.
        /// </summary>
        public const string PNPNCCD1 = "PNPNCCD1";

        /// <summary>
        /// PNPNCCD2.
        /// </summary>
        public const string PNPNCCD2 = "PNPNCCD2";

        /// <summary>
        /// PNPNCCD3.
        /// </summary>
        public const string PNPNCCD3 = "PNPNCCD3";

        /// <summary>
        /// PNPNCCD4.
        /// </summary>
        public const string PNPNCCD4 = "PNPNCCD4";

        /// <summary>
        /// PNPNCCD5.
        /// </summary>
        public const string PNPNCCD5 = "PNPNCCD5";

        /// <summary>
        /// PNPNCCD6.
        /// </summary>
        public const string PNPNCCD6 = "PNPNCCD6";

        /// <summary>
        /// PNPNCCD7.
        /// </summary>
        public const string PNPNCCD7 = "PNPNCCD7";

        /// <summary>
        /// PNPNCCD8.
        /// </summary>
        public const string PNPNCCD8 = "PNPNCCD8";

        /// <summary>
        /// PNPNCCD9.
        /// </summary>
        public const string PNPNCCD9 = "PNPNCCD9";

        /// <summary>
        /// PNPNCCD10.
        /// </summary>
        public const string PNPNCCD10 = "PNPNCCD10";

        /// <summary>
        /// PNDMDFLG.
        /// </summary>
        public const string PNDMDFLG = "PNDMDFLG";

        /// <summary>
        /// PNFFU3.
        /// </summary>
        public const string PNFFU3 = "PNFFU3";

        /// <summary>
        /// PNFFU4.
        /// </summary>
        public const string PNFFU4 = "PNFFU4";

        /// <summary>
        /// PNTFUDJ.
        /// </summary>
        public const string PNTFUDJ = "PNTFUDJ";

        /// <summary>
        /// PNURCD.
        /// </summary>
        public const string PNURCD = "PNURCD";

        /// <summary>
        /// PNURDT.
        /// </summary>
        public const string PNURDT = "PNURDT";

        /// <summary>
        /// PNURAT.
        /// </summary>
        public const string PNURAT = "PNURAT";

        /// <summary>
        /// PNURRF.
        /// </summary>
        public const string PNURRF = "PNURRF";

        /// <summary>
        /// PNURAB.
        /// </summary>
        public const string PNURAB = "PNURAB";

        /// <summary>
        /// PNPID.
        /// </summary>
        public const string PNPID = "PNPID";

        /// <summary>
        /// PNUSER.
        /// </summary>
        public const string PNUSER = "PNUSER";

        /// <summary>
        /// PNJOBN.
        /// </summary>
        public const string PNJOBN = "PNJOBN";

        /// <summary>
        /// PNUPMJ.
        /// </summary>
        public const string PNUPMJ = "PNUPMJ";

        /// <summary>
        /// PNTDAY.
        /// </summary>
        public const string PNTDAY = "PNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F34401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PNKCO", "PNKCO", JdeDataType.String, 10, true, true),
        new JdeField("PNPNS", "PNPNS", JdeDataType.Numeric, null, true, true),
        new JdeField("PNPMPN", "PNPMPN", JdeDataType.String, 60),
        new JdeField("PNDL01", "PNDL01", JdeDataType.String, 60),
        new JdeField("PNLITM", "PNLITM", JdeDataType.String, 50),
        new JdeField("PNAITM", "PNAITM", JdeDataType.String, 50),
        new JdeField("PNITM", "PNITM", JdeDataType.Numeric),
        new JdeField("PNPRODT", "PNPRODT", JdeDataType.String, 8),
        new JdeField("PNPRODS", "PNPRODS", JdeDataType.String, 2),
        new JdeField("PNPNDTCRTD", "PNPNDTCRTD", JdeDataType.Numeric),
        new JdeField("PNPNDTCLSD", "PNPNDTCLSD", JdeDataType.Numeric),
        new JdeField("PNAN8", "PNAN8", JdeDataType.Numeric),
        new JdeField("PNCENTYR", "PNCENTYR", JdeDataType.Numeric),
        new JdeField("PNMONTH", "PNMONTH", JdeDataType.String, 4),
        new JdeField("PNSLMCU", "PNSLMCU", JdeDataType.String, 24),
        new JdeField("PNMFGMCU", "PNMFGMCU", JdeDataType.String, 24),
        new JdeField("PNPNCCD1", "PNPNCCD1", JdeDataType.String, 24),
        new JdeField("PNPNCCD2", "PNPNCCD2", JdeDataType.String, 24),
        new JdeField("PNPNCCD3", "PNPNCCD3", JdeDataType.String, 24),
        new JdeField("PNPNCCD4", "PNPNCCD4", JdeDataType.String, 24),
        new JdeField("PNPNCCD5", "PNPNCCD5", JdeDataType.String, 24),
        new JdeField("PNPNCCD6", "PNPNCCD6", JdeDataType.String, 24),
        new JdeField("PNPNCCD7", "PNPNCCD7", JdeDataType.String, 24),
        new JdeField("PNPNCCD8", "PNPNCCD8", JdeDataType.String, 24),
        new JdeField("PNPNCCD9", "PNPNCCD9", JdeDataType.String, 24),
        new JdeField("PNPNCCD10", "PNPNCCD10", JdeDataType.String, 24),
        new JdeField("PNDMDFLG", "PNDMDFLG", JdeDataType.String, 2),
        new JdeField("PNFFU3", "PNFFU3", JdeDataType.String, 20),
        new JdeField("PNFFU4", "PNFFU4", JdeDataType.Numeric),
        new JdeField("PNTFUDJ", "PNTFUDJ", JdeDataType.Numeric),
        new JdeField("PNURCD", "PNURCD", JdeDataType.String, 4),
        new JdeField("PNURDT", "PNURDT", JdeDataType.Numeric),
        new JdeField("PNURAT", "PNURAT", JdeDataType.Numeric),
        new JdeField("PNURRF", "PNURRF", JdeDataType.String, 30),
        new JdeField("PNURAB", "PNURAB", JdeDataType.Numeric),
        new JdeField("PNPID", "PNPID", JdeDataType.String, 20),
        new JdeField("PNUSER", "PNUSER", JdeDataType.String, 20),
        new JdeField("PNJOBN", "PNJOBN", JdeDataType.String, 20),
        new JdeField("PNUPMJ", "PNUPMJ", JdeDataType.Numeric),
        new JdeField("PNTDAY", "PNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34401_0", "Primary Key on PNKCO, PNPNS", new[] { "PNKCO", "PNPNS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34401_2", "Index on PNPMPN", new[] { "PNPMPN" })
    };
}
