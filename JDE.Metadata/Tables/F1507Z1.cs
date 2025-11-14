using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1507Z1 - .
/// </summary>
public class F1507Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UMEDUS.
        /// </summary>
        public const string UMEDUS = "UMEDUS";

        /// <summary>
        /// UMEDBT.
        /// </summary>
        public const string UMEDBT = "UMEDBT";

        /// <summary>
        /// UMEDTN.
        /// </summary>
        public const string UMEDTN = "UMEDTN";

        /// <summary>
        /// UMEDLN.
        /// </summary>
        public const string UMEDLN = "UMEDLN";

        /// <summary>
        /// UMEDCT.
        /// </summary>
        public const string UMEDCT = "UMEDCT";

        /// <summary>
        /// UMTYTN.
        /// </summary>
        public const string UMTYTN = "UMTYTN";

        /// <summary>
        /// UMEDFT.
        /// </summary>
        public const string UMEDFT = "UMEDFT";

        /// <summary>
        /// UMEDDT.
        /// </summary>
        public const string UMEDDT = "UMEDDT";

        /// <summary>
        /// UMDRIN.
        /// </summary>
        public const string UMDRIN = "UMDRIN";

        /// <summary>
        /// UMEDDL.
        /// </summary>
        public const string UMEDDL = "UMEDDL";

        /// <summary>
        /// UMEDSP.
        /// </summary>
        public const string UMEDSP = "UMEDSP";

        /// <summary>
        /// UMPNID.
        /// </summary>
        public const string UMPNID = "UMPNID";

        /// <summary>
        /// UMTNAC.
        /// </summary>
        public const string UMTNAC = "UMTNAC";

        /// <summary>
        /// UMUSER.
        /// </summary>
        public const string UMUSER = "UMUSER";

        /// <summary>
        /// UMPID.
        /// </summary>
        public const string UMPID = "UMPID";

        /// <summary>
        /// UMJOBN.
        /// </summary>
        public const string UMJOBN = "UMJOBN";

        /// <summary>
        /// UMUPMJ.
        /// </summary>
        public const string UMUPMJ = "UMUPMJ";

        /// <summary>
        /// UMTDAY.
        /// </summary>
        public const string UMTDAY = "UMTDAY";

        /// <summary>
        /// UMMCUS.
        /// </summary>
        public const string UMMCUS = "UMMCUS";

        /// <summary>
        /// UMMCU.
        /// </summary>
        public const string UMMCU = "UMMCU";

        /// <summary>
        /// UMUNIT.
        /// </summary>
        public const string UMUNIT = "UMUNIT";

        /// <summary>
        /// UMFLOR.
        /// </summary>
        public const string UMFLOR = "UMFLOR";

        /// <summary>
        /// UMDL01.
        /// </summary>
        public const string UMDL01 = "UMDL01";

        /// <summary>
        /// UMDL02.
        /// </summary>
        public const string UMDL02 = "UMDL02";

        /// <summary>
        /// UMDL03.
        /// </summary>
        public const string UMDL03 = "UMDL03";

        /// <summary>
        /// UMDL04.
        /// </summary>
        public const string UMDL04 = "UMDL04";

        /// <summary>
        /// UMDL05.
        /// </summary>
        public const string UMDL05 = "UMDL05";

        /// <summary>
        /// UMUTTY.
        /// </summary>
        public const string UMUTTY = "UMUTTY";

        /// <summary>
        /// UMUTUS.
        /// </summary>
        public const string UMUTUS = "UMUTUS";

        /// <summary>
        /// UMMSUT.
        /// </summary>
        public const string UMMSUT = "UMMSUT";

        /// <summary>
        /// UMMSTU.
        /// </summary>
        public const string UMMSTU = "UMMSTU";

        /// <summary>
        /// UMRL01.
        /// </summary>
        public const string UMRL01 = "UMRL01";

        /// <summary>
        /// UMRL02.
        /// </summary>
        public const string UMRL02 = "UMRL02";

        /// <summary>
        /// UMRL03.
        /// </summary>
        public const string UMRL03 = "UMRL03";

        /// <summary>
        /// UMRL04.
        /// </summary>
        public const string UMRL04 = "UMRL04";

        /// <summary>
        /// UMRL05.
        /// </summary>
        public const string UMRL05 = "UMRL05";

        /// <summary>
        /// UMADDS.
        /// </summary>
        public const string UMADDS = "UMADDS";

        /// <summary>
        /// UMADDZ.
        /// </summary>
        public const string UMADDZ = "UMADDZ";

        /// <summary>
        /// UMCTR.
        /// </summary>
        public const string UMCTR = "UMCTR";

        /// <summary>
        /// UMPRRT.
        /// </summary>
        public const string UMPRRT = "UMPRRT";

        /// <summary>
        /// UMPORT.
        /// </summary>
        public const string UMPORT = "UMPORT";

        /// <summary>
        /// UMDV.
        /// </summary>
        public const string UMDV = "UMDV";

        /// <summary>
        /// UMMART.
        /// </summary>
        public const string UMMART = "UMMART";

        /// <summary>
        /// UMRERT.
        /// </summary>
        public const string UMRERT = "UMRERT";

        /// <summary>
        /// UMGLC.
        /// </summary>
        public const string UMGLC = "UMGLC";

        /// <summary>
        /// UMUST.
        /// </summary>
        public const string UMUST = "UMUST";

        /// <summary>
        /// UMAM01.
        /// </summary>
        public const string UMAM01 = "UMAM01";

        /// <summary>
        /// UMAM02.
        /// </summary>
        public const string UMAM02 = "UMAM02";

        /// <summary>
        /// UMAM03.
        /// </summary>
        public const string UMAM03 = "UMAM03";

        /// <summary>
        /// UMAM04.
        /// </summary>
        public const string UMAM04 = "UMAM04";

        /// <summary>
        /// UMAM05.
        /// </summary>
        public const string UMAM05 = "UMAM05";

        /// <summary>
        /// UMAM06.
        /// </summary>
        public const string UMAM06 = "UMAM06";

        /// <summary>
        /// UMAM07.
        /// </summary>
        public const string UMAM07 = "UMAM07";

        /// <summary>
        /// UMAM08.
        /// </summary>
        public const string UMAM08 = "UMAM08";

        /// <summary>
        /// UMAM09.
        /// </summary>
        public const string UMAM09 = "UMAM09";

        /// <summary>
        /// UMAM10.
        /// </summary>
        public const string UMAM10 = "UMAM10";

        /// <summary>
        /// UMAM11.
        /// </summary>
        public const string UMAM11 = "UMAM11";

        /// <summary>
        /// UMAM12.
        /// </summary>
        public const string UMAM12 = "UMAM12";

        /// <summary>
        /// UMAM13.
        /// </summary>
        public const string UMAM13 = "UMAM13";

        /// <summary>
        /// UMAM14.
        /// </summary>
        public const string UMAM14 = "UMAM14";

        /// <summary>
        /// UMAM15.
        /// </summary>
        public const string UMAM15 = "UMAM15";

        /// <summary>
        /// UMAM16.
        /// </summary>
        public const string UMAM16 = "UMAM16";

        /// <summary>
        /// UMAM17.
        /// </summary>
        public const string UMAM17 = "UMAM17";

        /// <summary>
        /// UMAM18.
        /// </summary>
        public const string UMAM18 = "UMAM18";

        /// <summary>
        /// UMAM19.
        /// </summary>
        public const string UMAM19 = "UMAM19";

        /// <summary>
        /// UMAM20.
        /// </summary>
        public const string UMAM20 = "UMAM20";

        /// <summary>
        /// UMCO.
        /// </summary>
        public const string UMCO = "UMCO";

        /// <summary>
        /// UMUST1.
        /// </summary>
        public const string UMUST1 = "UMUST1";

        /// <summary>
        /// UMUST2.
        /// </summary>
        public const string UMUST2 = "UMUST2";

        /// <summary>
        /// UMUST3.
        /// </summary>
        public const string UMUST3 = "UMUST3";

        /// <summary>
        /// UMUST4.
        /// </summary>
        public const string UMUST4 = "UMUST4";

        /// <summary>
        /// UMASTD.
        /// </summary>
        public const string UMASTD = "UMASTD";

        /// <summary>
        /// UMBFRQ.
        /// </summary>
        public const string UMBFRQ = "UMBFRQ";

        /// <summary>
        /// UMNUMB.
        /// </summary>
        public const string UMNUMB = "UMNUMB";
    }

    /// <inheritdoc />
    public override string TableName => "F1507Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UMEDUS", "UMEDUS", JdeDataType.String, 20, true, true),
        new JdeField("UMEDBT", "UMEDBT", JdeDataType.String, 30, true, true),
        new JdeField("UMEDTN", "UMEDTN", JdeDataType.String, 44, true, true),
        new JdeField("UMEDLN", "UMEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("UMEDCT", "UMEDCT", JdeDataType.String, 4),
        new JdeField("UMTYTN", "UMTYTN", JdeDataType.String, 16),
        new JdeField("UMEDFT", "UMEDFT", JdeDataType.String, 20),
        new JdeField("UMEDDT", "UMEDDT", JdeDataType.Numeric),
        new JdeField("UMDRIN", "UMDRIN", JdeDataType.String, 2),
        new JdeField("UMEDDL", "UMEDDL", JdeDataType.Numeric),
        new JdeField("UMEDSP", "UMEDSP", JdeDataType.String, 2),
        new JdeField("UMPNID", "UMPNID", JdeDataType.String, 30),
        new JdeField("UMTNAC", "UMTNAC", JdeDataType.String, 4),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMJOBN", "UMJOBN", JdeDataType.String, 20),
        new JdeField("UMUPMJ", "UMUPMJ", JdeDataType.Numeric),
        new JdeField("UMTDAY", "UMTDAY", JdeDataType.Numeric),
        new JdeField("UMMCUS", "UMMCUS", JdeDataType.String, 24),
        new JdeField("UMMCU", "UMMCU", JdeDataType.String, 24),
        new JdeField("UMUNIT", "UMUNIT", JdeDataType.String, 16),
        new JdeField("UMFLOR", "UMFLOR", JdeDataType.String, 8),
        new JdeField("UMDL01", "UMDL01", JdeDataType.String, 60),
        new JdeField("UMDL02", "UMDL02", JdeDataType.String, 60),
        new JdeField("UMDL03", "UMDL03", JdeDataType.String, 60),
        new JdeField("UMDL04", "UMDL04", JdeDataType.String, 60),
        new JdeField("UMDL05", "UMDL05", JdeDataType.String, 60),
        new JdeField("UMUTTY", "UMUTTY", JdeDataType.String, 10),
        new JdeField("UMUTUS", "UMUTUS", JdeDataType.String, 2),
        new JdeField("UMMSUT", "UMMSUT", JdeDataType.String, 2),
        new JdeField("UMMSTU", "UMMSTU", JdeDataType.String, 16),
        new JdeField("UMRL01", "UMRL01", JdeDataType.String, 6),
        new JdeField("UMRL02", "UMRL02", JdeDataType.String, 6),
        new JdeField("UMRL03", "UMRL03", JdeDataType.String, 6),
        new JdeField("UMRL04", "UMRL04", JdeDataType.String, 6),
        new JdeField("UMRL05", "UMRL05", JdeDataType.String, 6),
        new JdeField("UMADDS", "UMADDS", JdeDataType.String, 6),
        new JdeField("UMADDZ", "UMADDZ", JdeDataType.String, 24),
        new JdeField("UMCTR", "UMCTR", JdeDataType.String, 6),
        new JdeField("UMPRRT", "UMPRRT", JdeDataType.Numeric),
        new JdeField("UMPORT", "UMPORT", JdeDataType.Numeric),
        new JdeField("UMDV", "UMDV", JdeDataType.Numeric),
        new JdeField("UMMART", "UMMART", JdeDataType.Numeric),
        new JdeField("UMRERT", "UMRERT", JdeDataType.Numeric),
        new JdeField("UMGLC", "UMGLC", JdeDataType.String, 8),
        new JdeField("UMUST", "UMUST", JdeDataType.String, 2),
        new JdeField("UMAM01", "UMAM01", JdeDataType.String, 6),
        new JdeField("UMAM02", "UMAM02", JdeDataType.String, 6),
        new JdeField("UMAM03", "UMAM03", JdeDataType.String, 6),
        new JdeField("UMAM04", "UMAM04", JdeDataType.String, 6),
        new JdeField("UMAM05", "UMAM05", JdeDataType.String, 6),
        new JdeField("UMAM06", "UMAM06", JdeDataType.String, 6),
        new JdeField("UMAM07", "UMAM07", JdeDataType.String, 6),
        new JdeField("UMAM08", "UMAM08", JdeDataType.String, 6),
        new JdeField("UMAM09", "UMAM09", JdeDataType.String, 6),
        new JdeField("UMAM10", "UMAM10", JdeDataType.String, 6),
        new JdeField("UMAM11", "UMAM11", JdeDataType.String, 6),
        new JdeField("UMAM12", "UMAM12", JdeDataType.String, 6),
        new JdeField("UMAM13", "UMAM13", JdeDataType.String, 6),
        new JdeField("UMAM14", "UMAM14", JdeDataType.String, 6),
        new JdeField("UMAM15", "UMAM15", JdeDataType.String, 6),
        new JdeField("UMAM16", "UMAM16", JdeDataType.String, 6),
        new JdeField("UMAM17", "UMAM17", JdeDataType.String, 6),
        new JdeField("UMAM18", "UMAM18", JdeDataType.String, 6),
        new JdeField("UMAM19", "UMAM19", JdeDataType.String, 6),
        new JdeField("UMAM20", "UMAM20", JdeDataType.String, 6),
        new JdeField("UMCO", "UMCO", JdeDataType.String, 10),
        new JdeField("UMUST1", "UMUST1", JdeDataType.String, 2),
        new JdeField("UMUST2", "UMUST2", JdeDataType.String, 2),
        new JdeField("UMUST3", "UMUST3", JdeDataType.String, 4),
        new JdeField("UMUST4", "UMUST4", JdeDataType.String, 2),
        new JdeField("UMASTD", "UMASTD", JdeDataType.Numeric),
        new JdeField("UMBFRQ", "UMBFRQ", JdeDataType.String, 2),
        new JdeField("UMNUMB", "UMNUMB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1507Z1_0", "Primary Key on UMEDUS, UMEDBT, UMEDTN, UMEDLN", new[] { "UMEDUS", "UMEDBT", "UMEDTN", "UMEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
