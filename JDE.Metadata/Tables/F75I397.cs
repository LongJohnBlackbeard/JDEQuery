using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I397 - .
/// </summary>
public class F75I397 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCITM.
        /// </summary>
        public const string SCITM = "SCITM";

        /// <summary>
        /// SCLITM.
        /// </summary>
        public const string SCLITM = "SCLITM";

        /// <summary>
        /// SCDL01.
        /// </summary>
        public const string SCDL01 = "SCDL01";

        /// <summary>
        /// SCUOM.
        /// </summary>
        public const string SCUOM = "SCUOM";

        /// <summary>
        /// SCSTPP.
        /// </summary>
        public const string SCSTPP = "SCSTPP";

        /// <summary>
        /// SCSCRP.
        /// </summary>
        public const string SCSCRP = "SCSCRP";

        /// <summary>
        /// SCACQT.
        /// </summary>
        public const string SCACQT = "SCACQT";

        /// <summary>
        /// SCCPCN.
        /// </summary>
        public const string SCCPCN = "SCCPCN";

        /// <summary>
        /// SCSTRX.
        /// </summary>
        public const string SCSTRX = "SCSTRX";

        /// <summary>
        /// SCSTKT.
        /// </summary>
        public const string SCSTKT = "SCSTKT";

        /// <summary>
        /// SCFLG.
        /// </summary>
        public const string SCFLG = "SCFLG";

        /// <summary>
        /// SCYEXU.
        /// </summary>
        public const string SCYEXU = "SCYEXU";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCMATH01.
        /// </summary>
        public const string SCMATH01 = "SCMATH01";

        /// <summary>
        /// SCMATH02.
        /// </summary>
        public const string SCMATH02 = "SCMATH02";

        /// <summary>
        /// SCMATH03.
        /// </summary>
        public const string SCMATH03 = "SCMATH03";

        /// <summary>
        /// SCMATH04.
        /// </summary>
        public const string SCMATH04 = "SCMATH04";

        /// <summary>
        /// SCMATH05.
        /// </summary>
        public const string SCMATH05 = "SCMATH05";

        /// <summary>
        /// SCFUSTR4.
        /// </summary>
        public const string SCFUSTR4 = "SCFUSTR4";

        /// <summary>
        /// SCFUSTR5.
        /// </summary>
        public const string SCFUSTR5 = "SCFUSTR5";

        /// <summary>
        /// SCFUSTR6.
        /// </summary>
        public const string SCFUSTR6 = "SCFUSTR6";

        /// <summary>
        /// SCFUSTR7.
        /// </summary>
        public const string SCFUSTR7 = "SCFUSTR7";

        /// <summary>
        /// SCFUTTRANS1.
        /// </summary>
        public const string SCFUTTRANS1 = "SCFUTTRANS1";

        /// <summary>
        /// SCFUTTRANS4.
        /// </summary>
        public const string SCFUTTRANS4 = "SCFUTTRANS4";

        /// <summary>
        /// SCFUTTRANS7.
        /// </summary>
        public const string SCFUTTRANS7 = "SCFUTTRANS7";

        /// <summary>
        /// SCFUTDATE1.
        /// </summary>
        public const string SCFUTDATE1 = "SCFUTDATE1";

        /// <summary>
        /// SCFUTDATE2.
        /// </summary>
        public const string SCFUTDATE2 = "SCFUTDATE2";

        /// <summary>
        /// SCFUTDATE3.
        /// </summary>
        public const string SCFUTDATE3 = "SCFUTDATE3";
    }

    /// <inheritdoc />
    public override string TableName => "F75I397";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCITM", "SCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SCLITM", "SCLITM", JdeDataType.String, 50),
        new JdeField("SCDL01", "SCDL01", JdeDataType.String, 60),
        new JdeField("SCUOM", "SCUOM", JdeDataType.String, 4),
        new JdeField("SCSTPP", "SCSTPP", JdeDataType.Numeric),
        new JdeField("SCSCRP", "SCSCRP", JdeDataType.Numeric),
        new JdeField("SCACQT", "SCACQT", JdeDataType.Numeric),
        new JdeField("SCCPCN", "SCCPCN", JdeDataType.Numeric),
        new JdeField("SCSTRX", "SCSTRX", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSTKT", "SCSTKT", JdeDataType.String, 2),
        new JdeField("SCFLG", "SCFLG", JdeDataType.String, 2),
        new JdeField("SCYEXU", "SCYEXU", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCMATH01", "SCMATH01", JdeDataType.Numeric),
        new JdeField("SCMATH02", "SCMATH02", JdeDataType.Numeric),
        new JdeField("SCMATH03", "SCMATH03", JdeDataType.Numeric),
        new JdeField("SCMATH04", "SCMATH04", JdeDataType.Numeric),
        new JdeField("SCMATH05", "SCMATH05", JdeDataType.Numeric),
        new JdeField("SCFUSTR4", "SCFUSTR4", JdeDataType.String, 60),
        new JdeField("SCFUSTR5", "SCFUSTR5", JdeDataType.String, 60),
        new JdeField("SCFUSTR6", "SCFUSTR6", JdeDataType.String, 100),
        new JdeField("SCFUSTR7", "SCFUSTR7", JdeDataType.String, 100),
        new JdeField("SCFUTTRANS1", "SCFUTTRANS1", JdeDataType.String, 2),
        new JdeField("SCFUTTRANS4", "SCFUTTRANS4", JdeDataType.String, 2),
        new JdeField("SCFUTTRANS7", "SCFUTTRANS7", JdeDataType.String, 2),
        new JdeField("SCFUTDATE1", "SCFUTDATE1", JdeDataType.Numeric),
        new JdeField("SCFUTDATE2", "SCFUTDATE2", JdeDataType.Numeric),
        new JdeField("SCFUTDATE3", "SCFUTDATE3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I397_0", "Primary Key on SCITM, SCSTRX", new[] { "SCITM", "SCSTRX" }, isUnique: true, isPrimaryKey: true)
    };
}
