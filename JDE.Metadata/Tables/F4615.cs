using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4615 - .
/// </summary>
public class F4615 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRUKID.
        /// </summary>
        public const string CRUKID = "CRUKID";

        /// <summary>
        /// CRSHPN.
        /// </summary>
        public const string CRSHPN = "CRSHPN";

        /// <summary>
        /// CRCROS.
        /// </summary>
        public const string CRCROS = "CRCROS";

        /// <summary>
        /// CRCRID.
        /// </summary>
        public const string CRCRID = "CRCRID";

        /// <summary>
        /// CREQTY.
        /// </summary>
        public const string CREQTY = "CREQTY";

        /// <summary>
        /// CREQTYI.
        /// </summary>
        public const string CREQTYI = "CREQTYI";

        /// <summary>
        /// CRITM.
        /// </summary>
        public const string CRITM = "CRITM";

        /// <summary>
        /// CRUOM.
        /// </summary>
        public const string CRUOM = "CRUOM";

        /// <summary>
        /// CRNPCS.
        /// </summary>
        public const string CRNPCS = "CRNPCS";

        /// <summary>
        /// CRSTPK.
        /// </summary>
        public const string CRSTPK = "CRSTPK";

        /// <summary>
        /// CRTQTY.
        /// </summary>
        public const string CRTQTY = "CRTQTY";

        /// <summary>
        /// CRWEIT.
        /// </summary>
        public const string CRWEIT = "CRWEIT";

        /// <summary>
        /// CRGWEI.
        /// </summary>
        public const string CRGWEI = "CRGWEI";

        /// <summary>
        /// CRUWUM.
        /// </summary>
        public const string CRUWUM = "CRUWUM";

        /// <summary>
        /// CRMCU.
        /// </summary>
        public const string CRMCU = "CRMCU";

        /// <summary>
        /// CRAN8.
        /// </summary>
        public const string CRAN8 = "CRAN8";

        /// <summary>
        /// CRSHAN.
        /// </summary>
        public const string CRSHAN = "CRSHAN";

        /// <summary>
        /// CRDVAN.
        /// </summary>
        public const string CRDVAN = "CRDVAN";

        /// <summary>
        /// CRCEQT.
        /// </summary>
        public const string CRCEQT = "CRCEQT";

        /// <summary>
        /// CRCTNP.
        /// </summary>
        public const string CRCTNP = "CRCTNP";

        /// <summary>
        /// CRCTNI.
        /// </summary>
        public const string CRCTNI = "CRCTNI";

        /// <summary>
        /// CRRCMS.
        /// </summary>
        public const string CRRCMS = "CRRCMS";

        /// <summary>
        /// CREKEY.
        /// </summary>
        public const string CREKEY = "CREKEY";

        /// <summary>
        /// CRURCD.
        /// </summary>
        public const string CRURCD = "CRURCD";

        /// <summary>
        /// CRURDT.
        /// </summary>
        public const string CRURDT = "CRURDT";

        /// <summary>
        /// CRURAT.
        /// </summary>
        public const string CRURAT = "CRURAT";

        /// <summary>
        /// CRURAB.
        /// </summary>
        public const string CRURAB = "CRURAB";

        /// <summary>
        /// CRURRF.
        /// </summary>
        public const string CRURRF = "CRURRF";

        /// <summary>
        /// CRC1FU.
        /// </summary>
        public const string CRC1FU = "CRC1FU";

        /// <summary>
        /// CRCFC1.
        /// </summary>
        public const string CRCFC1 = "CRCFC1";

        /// <summary>
        /// CRCFS1.
        /// </summary>
        public const string CRCFS1 = "CRCFS1";

        /// <summary>
        /// CRD1FU.
        /// </summary>
        public const string CRD1FU = "CRD1FU";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";

        /// <summary>
        /// CRMPGP.
        /// </summary>
        public const string CRMPGP = "CRMPGP";
    }

    /// <inheritdoc />
    public override string TableName => "F4615";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRUKID", "CRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRSHPN", "CRSHPN", JdeDataType.Numeric),
        new JdeField("CRCROS", "CRCROS", JdeDataType.Numeric),
        new JdeField("CRCRID", "CRCRID", JdeDataType.Numeric),
        new JdeField("CREQTY", "CREQTY", JdeDataType.String, 10),
        new JdeField("CREQTYI", "CREQTYI", JdeDataType.String, 10),
        new JdeField("CRITM", "CRITM", JdeDataType.Numeric),
        new JdeField("CRUOM", "CRUOM", JdeDataType.String, 4),
        new JdeField("CRNPCS", "CRNPCS", JdeDataType.Numeric),
        new JdeField("CRSTPK", "CRSTPK", JdeDataType.Numeric),
        new JdeField("CRTQTY", "CRTQTY", JdeDataType.Numeric),
        new JdeField("CRWEIT", "CRWEIT", JdeDataType.Numeric),
        new JdeField("CRGWEI", "CRGWEI", JdeDataType.Numeric),
        new JdeField("CRUWUM", "CRUWUM", JdeDataType.String, 4),
        new JdeField("CRMCU", "CRMCU", JdeDataType.String, 24),
        new JdeField("CRAN8", "CRAN8", JdeDataType.Numeric),
        new JdeField("CRSHAN", "CRSHAN", JdeDataType.Numeric),
        new JdeField("CRDVAN", "CRDVAN", JdeDataType.Numeric),
        new JdeField("CRCEQT", "CRCEQT", JdeDataType.String, 50),
        new JdeField("CRCTNP", "CRCTNP", JdeDataType.String, 2),
        new JdeField("CRCTNI", "CRCTNI", JdeDataType.Numeric),
        new JdeField("CRRCMS", "CRRCMS", JdeDataType.String, 4),
        new JdeField("CREKEY", "CREKEY", JdeDataType.String, 8),
        new JdeField("CRURCD", "CRURCD", JdeDataType.String, 4),
        new JdeField("CRURDT", "CRURDT", JdeDataType.Numeric),
        new JdeField("CRURAT", "CRURAT", JdeDataType.Numeric),
        new JdeField("CRURAB", "CRURAB", JdeDataType.Numeric),
        new JdeField("CRURRF", "CRURRF", JdeDataType.String, 30),
        new JdeField("CRC1FU", "CRC1FU", JdeDataType.String, 2),
        new JdeField("CRCFC1", "CRCFC1", JdeDataType.String, 6),
        new JdeField("CRCFS1", "CRCFS1", JdeDataType.Numeric),
        new JdeField("CRD1FU", "CRD1FU", JdeDataType.Numeric),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric),
        new JdeField("CRMPGP", "CRMPGP", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4615_0", "Primary Key on CRUKID", new[] { "CRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4615_2", "Unique Index on CRSHPN, CRCROS, CRCRID, CREQTY, CREQTYI, CRITM, CRUOM, CRAN8, CRSHAN, CRDVAN", new[] { "CRSHPN", "CRCROS", "CRCRID", "CREQTY", "CREQTYI", "CRITM", "CRUOM", "CRAN8", "CRSHAN", "CRDVAN" }, isUnique: true),
        new JdeIndex("F4615_6", "Index on CRSHPN, CRITM, CRUOM, CRAN8, CRSHAN, CRDVAN", new[] { "CRSHPN", "CRITM", "CRUOM", "CRAN8", "CRSHAN", "CRDVAN" }),
        new JdeIndex("F4615_7", "Index on CRSHPN, CRCRID", new[] { "CRSHPN", "CRCRID" }),
        new JdeIndex("F4615_8", "Index on CRSHPN, CRCRID, CREQTY, CRAN8, CRSHAN, CRDVAN", new[] { "CRSHPN", "CRCRID", "CREQTY", "CRAN8", "CRSHAN", "CRDVAN" }),
        new JdeIndex("F4615_9", "Index on CRSHPN, CRMPGP, CRUOM, CRAN8, CRSHAN, CRDVAN", new[] { "CRSHPN", "CRMPGP", "CRUOM", "CRAN8", "CRSHAN", "CRDVAN" })
    };
}
