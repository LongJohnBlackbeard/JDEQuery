using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F17001 - .
/// </summary>
public class F17001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSLNID.
        /// </summary>
        public const string CSLNID = "CSLNID";

        /// <summary>
        /// CSCSFL.
        /// </summary>
        public const string CSCSFL = "CSCSFL";

        /// <summary>
        /// CSYN01.
        /// </summary>
        public const string CSYN01 = "CSYN01";

        /// <summary>
        /// CSYN02.
        /// </summary>
        public const string CSYN02 = "CSYN02";

        /// <summary>
        /// CSYN03.
        /// </summary>
        public const string CSYN03 = "CSYN03";

        /// <summary>
        /// CSYN04.
        /// </summary>
        public const string CSYN04 = "CSYN04";

        /// <summary>
        /// CSYN05.
        /// </summary>
        public const string CSYN05 = "CSYN05";

        /// <summary>
        /// CSWCICV.
        /// </summary>
        public const string CSWCICV = "CSWCICV";

        /// <summary>
        /// CSDWRCV.
        /// </summary>
        public const string CSDWRCV = "CSDWRCV";

        /// <summary>
        /// CSWWRCV.
        /// </summary>
        public const string CSWWRCV = "CSWWRCV";

        /// <summary>
        /// CSLSCCV.
        /// </summary>
        public const string CSLSCCV = "CSLSCCV";

        /// <summary>
        /// CSAT1.
        /// </summary>
        public const string CSAT1 = "CSAT1";

        /// <summary>
        /// CSWWRSV.
        /// </summary>
        public const string CSWWRSV = "CSWWRSV";

        /// <summary>
        /// CSAT1SV.
        /// </summary>
        public const string CSAT1SV = "CSAT1SV";

        /// <summary>
        /// CSRBUCL.
        /// </summary>
        public const string CSRBUCL = "CSRBUCL";

        /// <summary>
        /// CSRBUSL.
        /// </summary>
        public const string CSRBUSL = "CSRBUSL";

        /// <summary>
        /// CSRBUCN.
        /// </summary>
        public const string CSRBUCN = "CSRBUCN";

        /// <summary>
        /// CSCTYPS.
        /// </summary>
        public const string CSCTYPS = "CSCTYPS";

        /// <summary>
        /// CSCKPCU.
        /// </summary>
        public const string CSCKPCU = "CSCKPCU";

        /// <summary>
        /// CSCKPPR.
        /// </summary>
        public const string CSCKPPR = "CSCKPPR";

        /// <summary>
        /// CSAN81.
        /// </summary>
        public const string CSAN81 = "CSAN81";

        /// <summary>
        /// CSMBDS1.
        /// </summary>
        public const string CSMBDS1 = "CSMBDS1";

        /// <summary>
        /// CSAN82.
        /// </summary>
        public const string CSAN82 = "CSAN82";

        /// <summary>
        /// CSMBDS2.
        /// </summary>
        public const string CSMBDS2 = "CSMBDS2";

        /// <summary>
        /// CSCLETR.
        /// </summary>
        public const string CSCLETR = "CSCLETR";

        /// <summary>
        /// CSSOETR.
        /// </summary>
        public const string CSSOETR = "CSSOETR";

        /// <summary>
        /// CSAN83.
        /// </summary>
        public const string CSAN83 = "CSAN83";

        /// <summary>
        /// CSOSTP.
        /// </summary>
        public const string CSOSTP = "CSOSTP";

        /// <summary>
        /// CSTD01.
        /// </summary>
        public const string CSTD01 = "CSTD01";

        /// <summary>
        /// CSCRTU.
        /// </summary>
        public const string CSCRTU = "CSCRTU";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";

        /// <summary>
        /// CSENTBY.
        /// </summary>
        public const string CSENTBY = "CSENTBY";

        /// <summary>
        /// CSYN06.
        /// </summary>
        public const string CSYN06 = "CSYN06";

        /// <summary>
        /// CSYN07.
        /// </summary>
        public const string CSYN07 = "CSYN07";

        /// <summary>
        /// CSYN08.
        /// </summary>
        public const string CSYN08 = "CSYN08";

        /// <summary>
        /// CSYN09.
        /// </summary>
        public const string CSYN09 = "CSYN09";

        /// <summary>
        /// CSYN10.
        /// </summary>
        public const string CSYN10 = "CSYN10";

        /// <summary>
        /// CSYN11.
        /// </summary>
        public const string CSYN11 = "CSYN11";

        /// <summary>
        /// CSYN12.
        /// </summary>
        public const string CSYN12 = "CSYN12";

        /// <summary>
        /// CSYN13.
        /// </summary>
        public const string CSYN13 = "CSYN13";

        /// <summary>
        /// CSYN14.
        /// </summary>
        public const string CSYN14 = "CSYN14";

        /// <summary>
        /// CSYN15.
        /// </summary>
        public const string CSYN15 = "CSYN15";

        /// <summary>
        /// CSYN16.
        /// </summary>
        public const string CSYN16 = "CSYN16";

        /// <summary>
        /// CSYN17.
        /// </summary>
        public const string CSYN17 = "CSYN17";

        /// <summary>
        /// CSYN18.
        /// </summary>
        public const string CSYN18 = "CSYN18";

        /// <summary>
        /// CSYN19.
        /// </summary>
        public const string CSYN19 = "CSYN19";

        /// <summary>
        /// CSYN20.
        /// </summary>
        public const string CSYN20 = "CSYN20";

        /// <summary>
        /// CSYN21.
        /// </summary>
        public const string CSYN21 = "CSYN21";

        /// <summary>
        /// CSYN22.
        /// </summary>
        public const string CSYN22 = "CSYN22";

        /// <summary>
        /// CSYN23.
        /// </summary>
        public const string CSYN23 = "CSYN23";

        /// <summary>
        /// CSYN24.
        /// </summary>
        public const string CSYN24 = "CSYN24";

        /// <summary>
        /// CSYN25.
        /// </summary>
        public const string CSYN25 = "CSYN25";

        /// <summary>
        /// CSYN26.
        /// </summary>
        public const string CSYN26 = "CSYN26";

        /// <summary>
        /// CSYN27.
        /// </summary>
        public const string CSYN27 = "CSYN27";

        /// <summary>
        /// CSYN28.
        /// </summary>
        public const string CSYN28 = "CSYN28";

        /// <summary>
        /// CSYN29.
        /// </summary>
        public const string CSYN29 = "CSYN29";

        /// <summary>
        /// CSYN30.
        /// </summary>
        public const string CSYN30 = "CSYN30";
    }

    /// <inheritdoc />
    public override string TableName => "F17001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSLNID", "CSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CSCSFL", "CSCSFL", JdeDataType.String, 2),
        new JdeField("CSYN01", "CSYN01", JdeDataType.String, 2),
        new JdeField("CSYN02", "CSYN02", JdeDataType.String, 2),
        new JdeField("CSYN03", "CSYN03", JdeDataType.String, 2),
        new JdeField("CSYN04", "CSYN04", JdeDataType.String, 2),
        new JdeField("CSYN05", "CSYN05", JdeDataType.String, 2),
        new JdeField("CSWCICV", "CSWCICV", JdeDataType.String, 2),
        new JdeField("CSDWRCV", "CSDWRCV", JdeDataType.String, 2),
        new JdeField("CSWWRCV", "CSWWRCV", JdeDataType.String, 2),
        new JdeField("CSLSCCV", "CSLSCCV", JdeDataType.String, 2),
        new JdeField("CSAT1", "CSAT1", JdeDataType.String, 6),
        new JdeField("CSWWRSV", "CSWWRSV", JdeDataType.String, 2),
        new JdeField("CSAT1SV", "CSAT1SV", JdeDataType.String, 6),
        new JdeField("CSRBUCL", "CSRBUCL", JdeDataType.String, 2),
        new JdeField("CSRBUSL", "CSRBUSL", JdeDataType.String, 2),
        new JdeField("CSRBUCN", "CSRBUCN", JdeDataType.String, 2),
        new JdeField("CSCTYPS", "CSCTYPS", JdeDataType.String, 2),
        new JdeField("CSCKPCU", "CSCKPCU", JdeDataType.String, 2),
        new JdeField("CSCKPPR", "CSCKPPR", JdeDataType.String, 2),
        new JdeField("CSAN81", "CSAN81", JdeDataType.Numeric),
        new JdeField("CSMBDS1", "CSMBDS1", JdeDataType.String, 4),
        new JdeField("CSAN82", "CSAN82", JdeDataType.Numeric),
        new JdeField("CSMBDS2", "CSMBDS2", JdeDataType.String, 4),
        new JdeField("CSCLETR", "CSCLETR", JdeDataType.String, 2),
        new JdeField("CSSOETR", "CSSOETR", JdeDataType.String, 2),
        new JdeField("CSAN83", "CSAN83", JdeDataType.Numeric),
        new JdeField("CSOSTP", "CSOSTP", JdeDataType.String, 6),
        new JdeField("CSTD01", "CSTD01", JdeDataType.String, 2),
        new JdeField("CSCRTU", "CSCRTU", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric),
        new JdeField("CSENTBY", "CSENTBY", JdeDataType.String, 2),
        new JdeField("CSYN06", "CSYN06", JdeDataType.String, 2),
        new JdeField("CSYN07", "CSYN07", JdeDataType.String, 2),
        new JdeField("CSYN08", "CSYN08", JdeDataType.String, 2),
        new JdeField("CSYN09", "CSYN09", JdeDataType.String, 2),
        new JdeField("CSYN10", "CSYN10", JdeDataType.String, 2),
        new JdeField("CSYN11", "CSYN11", JdeDataType.String, 2),
        new JdeField("CSYN12", "CSYN12", JdeDataType.String, 2),
        new JdeField("CSYN13", "CSYN13", JdeDataType.String, 2),
        new JdeField("CSYN14", "CSYN14", JdeDataType.String, 2),
        new JdeField("CSYN15", "CSYN15", JdeDataType.String, 2),
        new JdeField("CSYN16", "CSYN16", JdeDataType.String, 2),
        new JdeField("CSYN17", "CSYN17", JdeDataType.String, 2),
        new JdeField("CSYN18", "CSYN18", JdeDataType.String, 2),
        new JdeField("CSYN19", "CSYN19", JdeDataType.String, 2),
        new JdeField("CSYN20", "CSYN20", JdeDataType.String, 2),
        new JdeField("CSYN21", "CSYN21", JdeDataType.String, 2),
        new JdeField("CSYN22", "CSYN22", JdeDataType.String, 2),
        new JdeField("CSYN23", "CSYN23", JdeDataType.String, 2),
        new JdeField("CSYN24", "CSYN24", JdeDataType.String, 2),
        new JdeField("CSYN25", "CSYN25", JdeDataType.String, 2),
        new JdeField("CSYN26", "CSYN26", JdeDataType.String, 2),
        new JdeField("CSYN27", "CSYN27", JdeDataType.String, 2),
        new JdeField("CSYN28", "CSYN28", JdeDataType.String, 2),
        new JdeField("CSYN29", "CSYN29", JdeDataType.String, 2),
        new JdeField("CSYN30", "CSYN30", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F17001_0", "Primary Key on CSLNID", new[] { "CSLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
