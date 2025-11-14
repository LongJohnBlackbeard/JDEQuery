using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1507 - .
/// </summary>
public class F1507 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NHMCUS.
        /// </summary>
        public const string NHMCUS = "NHMCUS";

        /// <summary>
        /// NHMCU.
        /// </summary>
        public const string NHMCU = "NHMCU";

        /// <summary>
        /// NHUNIT.
        /// </summary>
        public const string NHUNIT = "NHUNIT";

        /// <summary>
        /// NHFLOR.
        /// </summary>
        public const string NHFLOR = "NHFLOR";

        /// <summary>
        /// NHDL01.
        /// </summary>
        public const string NHDL01 = "NHDL01";

        /// <summary>
        /// NHDL02.
        /// </summary>
        public const string NHDL02 = "NHDL02";

        /// <summary>
        /// NHDL03.
        /// </summary>
        public const string NHDL03 = "NHDL03";

        /// <summary>
        /// NHDL04.
        /// </summary>
        public const string NHDL04 = "NHDL04";

        /// <summary>
        /// NHDL05.
        /// </summary>
        public const string NHDL05 = "NHDL05";

        /// <summary>
        /// NHUTTY.
        /// </summary>
        public const string NHUTTY = "NHUTTY";

        /// <summary>
        /// NHUTUS.
        /// </summary>
        public const string NHUTUS = "NHUTUS";

        /// <summary>
        /// NHMSUT.
        /// </summary>
        public const string NHMSUT = "NHMSUT";

        /// <summary>
        /// NHMSTU.
        /// </summary>
        public const string NHMSTU = "NHMSTU";

        /// <summary>
        /// NHRL01.
        /// </summary>
        public const string NHRL01 = "NHRL01";

        /// <summary>
        /// NHRL02.
        /// </summary>
        public const string NHRL02 = "NHRL02";

        /// <summary>
        /// NHRL03.
        /// </summary>
        public const string NHRL03 = "NHRL03";

        /// <summary>
        /// NHRL04.
        /// </summary>
        public const string NHRL04 = "NHRL04";

        /// <summary>
        /// NHRL05.
        /// </summary>
        public const string NHRL05 = "NHRL05";

        /// <summary>
        /// NHADDS.
        /// </summary>
        public const string NHADDS = "NHADDS";

        /// <summary>
        /// NHADDZ.
        /// </summary>
        public const string NHADDZ = "NHADDZ";

        /// <summary>
        /// NHCTR.
        /// </summary>
        public const string NHCTR = "NHCTR";

        /// <summary>
        /// NHUSER.
        /// </summary>
        public const string NHUSER = "NHUSER";

        /// <summary>
        /// NHUPMJ.
        /// </summary>
        public const string NHUPMJ = "NHUPMJ";

        /// <summary>
        /// NHPID.
        /// </summary>
        public const string NHPID = "NHPID";

        /// <summary>
        /// NHJOBN.
        /// </summary>
        public const string NHJOBN = "NHJOBN";

        /// <summary>
        /// NHPRRT.
        /// </summary>
        public const string NHPRRT = "NHPRRT";

        /// <summary>
        /// NHPORT.
        /// </summary>
        public const string NHPORT = "NHPORT";

        /// <summary>
        /// NHDV.
        /// </summary>
        public const string NHDV = "NHDV";

        /// <summary>
        /// NHMART.
        /// </summary>
        public const string NHMART = "NHMART";

        /// <summary>
        /// NHRERT.
        /// </summary>
        public const string NHRERT = "NHRERT";

        /// <summary>
        /// NHGLC.
        /// </summary>
        public const string NHGLC = "NHGLC";

        /// <summary>
        /// NHUST.
        /// </summary>
        public const string NHUST = "NHUST";

        /// <summary>
        /// NHAM01.
        /// </summary>
        public const string NHAM01 = "NHAM01";

        /// <summary>
        /// NHAM02.
        /// </summary>
        public const string NHAM02 = "NHAM02";

        /// <summary>
        /// NHAM03.
        /// </summary>
        public const string NHAM03 = "NHAM03";

        /// <summary>
        /// NHAM04.
        /// </summary>
        public const string NHAM04 = "NHAM04";

        /// <summary>
        /// NHAM05.
        /// </summary>
        public const string NHAM05 = "NHAM05";

        /// <summary>
        /// NHAM06.
        /// </summary>
        public const string NHAM06 = "NHAM06";

        /// <summary>
        /// NHAM07.
        /// </summary>
        public const string NHAM07 = "NHAM07";

        /// <summary>
        /// NHAM08.
        /// </summary>
        public const string NHAM08 = "NHAM08";

        /// <summary>
        /// NHAM09.
        /// </summary>
        public const string NHAM09 = "NHAM09";

        /// <summary>
        /// NHAM10.
        /// </summary>
        public const string NHAM10 = "NHAM10";

        /// <summary>
        /// NHAM11.
        /// </summary>
        public const string NHAM11 = "NHAM11";

        /// <summary>
        /// NHAM12.
        /// </summary>
        public const string NHAM12 = "NHAM12";

        /// <summary>
        /// NHAM13.
        /// </summary>
        public const string NHAM13 = "NHAM13";

        /// <summary>
        /// NHAM14.
        /// </summary>
        public const string NHAM14 = "NHAM14";

        /// <summary>
        /// NHAM15.
        /// </summary>
        public const string NHAM15 = "NHAM15";

        /// <summary>
        /// NHAM16.
        /// </summary>
        public const string NHAM16 = "NHAM16";

        /// <summary>
        /// NHAM17.
        /// </summary>
        public const string NHAM17 = "NHAM17";

        /// <summary>
        /// NHAM18.
        /// </summary>
        public const string NHAM18 = "NHAM18";

        /// <summary>
        /// NHAM19.
        /// </summary>
        public const string NHAM19 = "NHAM19";

        /// <summary>
        /// NHAM20.
        /// </summary>
        public const string NHAM20 = "NHAM20";

        /// <summary>
        /// NHCO.
        /// </summary>
        public const string NHCO = "NHCO";

        /// <summary>
        /// NHUST1.
        /// </summary>
        public const string NHUST1 = "NHUST1";

        /// <summary>
        /// NHUST2.
        /// </summary>
        public const string NHUST2 = "NHUST2";

        /// <summary>
        /// NHUST3.
        /// </summary>
        public const string NHUST3 = "NHUST3";

        /// <summary>
        /// NHUST4.
        /// </summary>
        public const string NHUST4 = "NHUST4";

        /// <summary>
        /// NHASTD.
        /// </summary>
        public const string NHASTD = "NHASTD";

        /// <summary>
        /// NHBFRQ.
        /// </summary>
        public const string NHBFRQ = "NHBFRQ";

        /// <summary>
        /// NHUPMT.
        /// </summary>
        public const string NHUPMT = "NHUPMT";

        /// <summary>
        /// NHNUMB.
        /// </summary>
        public const string NHNUMB = "NHNUMB";
    }

    /// <inheritdoc />
    public override string TableName => "F1507";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NHMCUS", "NHMCUS", JdeDataType.String, 24),
        new JdeField("NHMCU", "NHMCU", JdeDataType.String, 24, true, true),
        new JdeField("NHUNIT", "NHUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NHFLOR", "NHFLOR", JdeDataType.String, 8),
        new JdeField("NHDL01", "NHDL01", JdeDataType.String, 60),
        new JdeField("NHDL02", "NHDL02", JdeDataType.String, 60),
        new JdeField("NHDL03", "NHDL03", JdeDataType.String, 60),
        new JdeField("NHDL04", "NHDL04", JdeDataType.String, 60),
        new JdeField("NHDL05", "NHDL05", JdeDataType.String, 60),
        new JdeField("NHUTTY", "NHUTTY", JdeDataType.String, 10),
        new JdeField("NHUTUS", "NHUTUS", JdeDataType.String, 2),
        new JdeField("NHMSUT", "NHMSUT", JdeDataType.String, 2),
        new JdeField("NHMSTU", "NHMSTU", JdeDataType.String, 16),
        new JdeField("NHRL01", "NHRL01", JdeDataType.String, 6),
        new JdeField("NHRL02", "NHRL02", JdeDataType.String, 6),
        new JdeField("NHRL03", "NHRL03", JdeDataType.String, 6),
        new JdeField("NHRL04", "NHRL04", JdeDataType.String, 6),
        new JdeField("NHRL05", "NHRL05", JdeDataType.String, 6),
        new JdeField("NHADDS", "NHADDS", JdeDataType.String, 6),
        new JdeField("NHADDZ", "NHADDZ", JdeDataType.String, 24),
        new JdeField("NHCTR", "NHCTR", JdeDataType.String, 6),
        new JdeField("NHUSER", "NHUSER", JdeDataType.String, 20),
        new JdeField("NHUPMJ", "NHUPMJ", JdeDataType.Numeric),
        new JdeField("NHPID", "NHPID", JdeDataType.String, 20),
        new JdeField("NHJOBN", "NHJOBN", JdeDataType.String, 20),
        new JdeField("NHPRRT", "NHPRRT", JdeDataType.Numeric),
        new JdeField("NHPORT", "NHPORT", JdeDataType.Numeric),
        new JdeField("NHDV", "NHDV", JdeDataType.Numeric),
        new JdeField("NHMART", "NHMART", JdeDataType.Numeric),
        new JdeField("NHRERT", "NHRERT", JdeDataType.Numeric),
        new JdeField("NHGLC", "NHGLC", JdeDataType.String, 8),
        new JdeField("NHUST", "NHUST", JdeDataType.String, 2),
        new JdeField("NHAM01", "NHAM01", JdeDataType.String, 6),
        new JdeField("NHAM02", "NHAM02", JdeDataType.String, 6),
        new JdeField("NHAM03", "NHAM03", JdeDataType.String, 6),
        new JdeField("NHAM04", "NHAM04", JdeDataType.String, 6),
        new JdeField("NHAM05", "NHAM05", JdeDataType.String, 6),
        new JdeField("NHAM06", "NHAM06", JdeDataType.String, 6),
        new JdeField("NHAM07", "NHAM07", JdeDataType.String, 6),
        new JdeField("NHAM08", "NHAM08", JdeDataType.String, 6),
        new JdeField("NHAM09", "NHAM09", JdeDataType.String, 6),
        new JdeField("NHAM10", "NHAM10", JdeDataType.String, 6),
        new JdeField("NHAM11", "NHAM11", JdeDataType.String, 6),
        new JdeField("NHAM12", "NHAM12", JdeDataType.String, 6),
        new JdeField("NHAM13", "NHAM13", JdeDataType.String, 6),
        new JdeField("NHAM14", "NHAM14", JdeDataType.String, 6),
        new JdeField("NHAM15", "NHAM15", JdeDataType.String, 6),
        new JdeField("NHAM16", "NHAM16", JdeDataType.String, 6),
        new JdeField("NHAM17", "NHAM17", JdeDataType.String, 6),
        new JdeField("NHAM18", "NHAM18", JdeDataType.String, 6),
        new JdeField("NHAM19", "NHAM19", JdeDataType.String, 6),
        new JdeField("NHAM20", "NHAM20", JdeDataType.String, 6),
        new JdeField("NHCO", "NHCO", JdeDataType.String, 10),
        new JdeField("NHUST1", "NHUST1", JdeDataType.String, 2),
        new JdeField("NHUST2", "NHUST2", JdeDataType.String, 2),
        new JdeField("NHUST3", "NHUST3", JdeDataType.String, 4),
        new JdeField("NHUST4", "NHUST4", JdeDataType.String, 2),
        new JdeField("NHASTD", "NHASTD", JdeDataType.Numeric),
        new JdeField("NHBFRQ", "NHBFRQ", JdeDataType.String, 2),
        new JdeField("NHUPMT", "NHUPMT", JdeDataType.Numeric),
        new JdeField("NHNUMB", "NHNUMB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1507_0", "Primary Key on NHMCU, NHUNIT", new[] { "NHMCU", "NHUNIT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1507_2", "Index on NHMCU, NHUTTY", new[] { "NHMCU", "NHUTTY" }),
        new JdeIndex("F1507_3", "Index on NHMCUS, NHMCU, NHUTTY", new[] { "NHMCUS", "NHMCU", "NHUTTY" }),
        new JdeIndex("F1507_4", "Index on NHMCU, NHFLOR, NHUNIT", new[] { "NHMCU", "NHFLOR", "NHUNIT" }),
        new JdeIndex("F1507_5", "Index on NHNUMB", new[] { "NHNUMB" })
    };
}
