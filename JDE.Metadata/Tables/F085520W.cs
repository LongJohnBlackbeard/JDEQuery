using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085520W - .
/// </summary>
public class F085520W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APEVET.
        /// </summary>
        public const string APEVET = "APEVET";

        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APSBGR.
        /// </summary>
        public const string APSBGR = "APSBGR";

        /// <summary>
        /// APDL01.
        /// </summary>
        public const string APDL01 = "APDL01";

        /// <summary>
        /// APPCP#.
        /// </summary>
        public const string APPCP_ = "APPCP#";

        /// <summary>
        /// APPLAN.
        /// </summary>
        public const string APPLAN = "APPLAN";

        /// <summary>
        /// APSEQ#.
        /// </summary>
        public const string APSEQ_ = "APSEQ#";

        /// <summary>
        /// APAOPT.
        /// </summary>
        public const string APAOPT = "APAOPT";

        /// <summary>
        /// APDS50.
        /// </summary>
        public const string APDS50 = "APDS50";

        /// <summary>
        /// APDBEN.
        /// </summary>
        public const string APDBEN = "APDBEN";

        /// <summary>
        /// APPCPF.
        /// </summary>
        public const string APPCPF = "APPCPF";

        /// <summary>
        /// APEAOR.
        /// </summary>
        public const string APEAOR = "APEAOR";

        /// <summary>
        /// APFDBA.
        /// </summary>
        public const string APFDBA = "APFDBA";

        /// <summary>
        /// APSDBA.
        /// </summary>
        public const string APSDBA = "APSDBA";

        /// <summary>
        /// APPDDP.
        /// </summary>
        public const string APPDDP = "APPDDP";

        /// <summary>
        /// APPDCP.
        /// </summary>
        public const string APPDCP = "APPDCP";

        /// <summary>
        /// APPCOS.
        /// </summary>
        public const string APPCOS = "APPCOS";

        /// <summary>
        /// APPCRE.
        /// </summary>
        public const string APPCRE = "APPCRE";

        /// <summary>
        /// APERAM.
        /// </summary>
        public const string APERAM = "APERAM";

        /// <summary>
        /// APDRTM.
        /// </summary>
        public const string APDRTM = "APDRTM";

        /// <summary>
        /// APBRTM.
        /// </summary>
        public const string APBRTM = "APBRTM";

        /// <summary>
        /// APEFT.
        /// </summary>
        public const string APEFT = "APEFT";

        /// <summary>
        /// APEFTE.
        /// </summary>
        public const string APEFTE = "APEFTE";

        /// <summary>
        /// APMANP.
        /// </summary>
        public const string APMANP = "APMANP";

        /// <summary>
        /// APXDFP.
        /// </summary>
        public const string APXDFP = "APXDFP";

        /// <summary>
        /// APMINDEP.
        /// </summary>
        public const string APMINDEP = "APMINDEP";

        /// <summary>
        /// APMXDP.
        /// </summary>
        public const string APMXDP = "APMXDP";

        /// <summary>
        /// APSL01.
        /// </summary>
        public const string APSL01 = "APSL01";

        /// <summary>
        /// APEECD.
        /// </summary>
        public const string APEECD = "APEECD";

        /// <summary>
        /// APEEFC.
        /// </summary>
        public const string APEEFC = "APEEFC";

        /// <summary>
        /// APCATY.
        /// </summary>
        public const string APCATY = "APCATY";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPCPVST.
        /// </summary>
        public const string APPCPVST = "APPCPVST";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APESIGN.
        /// </summary>
        public const string APESIGN = "APESIGN";

        /// <summary>
        /// APMUMJ.
        /// </summary>
        public const string APMUMJ = "APMUMJ";

        /// <summary>
        /// APMUMT.
        /// </summary>
        public const string APMUMT = "APMUMT";

        /// <summary>
        /// APUPID.
        /// </summary>
        public const string APUPID = "APUPID";

        /// <summary>
        /// APSEQN.
        /// </summary>
        public const string APSEQN = "APSEQN";

        /// <summary>
        /// APDEFFLG.
        /// </summary>
        public const string APDEFFLG = "APDEFFLG";

        /// <summary>
        /// APPLNGRP.
        /// </summary>
        public const string APPLNGRP = "APPLNGRP";

        /// <summary>
        /// APSPLDES.
        /// </summary>
        public const string APSPLDES = "APSPLDES";

        /// <summary>
        /// APDCNF.
        /// </summary>
        public const string APDCNF = "APDCNF";

        /// <summary>
        /// APBCATCL.
        /// </summary>
        public const string APBCATCL = "APBCATCL";

        /// <summary>
        /// APSCTDES.
        /// </summary>
        public const string APSCTDES = "APSCTDES";

        /// <summary>
        /// APNPPLFL.
        /// </summary>
        public const string APNPPLFL = "APNPPLFL";

        /// <summary>
        /// APNOPT.
        /// </summary>
        public const string APNOPT = "APNOPT";

        /// <summary>
        /// APSIPG.
        /// </summary>
        public const string APSIPG = "APSIPG";

        /// <summary>
        /// APPLTY.
        /// </summary>
        public const string APPLTY = "APPLTY";

        /// <summary>
        /// APQLED.
        /// </summary>
        public const string APQLED = "APQLED";
    }

    /// <inheritdoc />
    public override string TableName => "F085520W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APEVET", "APEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("APSBGR", "APSBGR", JdeDataType.String, 20, true, true),
        new JdeField("APDL01", "APDL01", JdeDataType.String, 60),
        new JdeField("APPCP#", "APPCP#", JdeDataType.String, 40),
        new JdeField("APPLAN", "APPLAN", JdeDataType.String, 16, true, true),
        new JdeField("APSEQ#", "APSEQ#", JdeDataType.Numeric, null, true, true),
        new JdeField("APAOPT", "APAOPT", JdeDataType.String, 6, true, true),
        new JdeField("APDS50", "APDS50", JdeDataType.String, 100),
        new JdeField("APDBEN", "APDBEN", JdeDataType.String, 2),
        new JdeField("APPCPF", "APPCPF", JdeDataType.Numeric),
        new JdeField("APEAOR", "APEAOR", JdeDataType.String, 2),
        new JdeField("APFDBA", "APFDBA", JdeDataType.Numeric),
        new JdeField("APSDBA", "APSDBA", JdeDataType.Numeric),
        new JdeField("APPDDP", "APPDDP", JdeDataType.Numeric),
        new JdeField("APPDCP", "APPDCP", JdeDataType.Numeric),
        new JdeField("APPCOS", "APPCOS", JdeDataType.Numeric),
        new JdeField("APPCRE", "APPCRE", JdeDataType.Numeric),
        new JdeField("APERAM", "APERAM", JdeDataType.Numeric),
        new JdeField("APDRTM", "APDRTM", JdeDataType.Numeric),
        new JdeField("APBRTM", "APBRTM", JdeDataType.Numeric),
        new JdeField("APEFT", "APEFT", JdeDataType.Numeric),
        new JdeField("APEFTE", "APEFTE", JdeDataType.Numeric),
        new JdeField("APMANP", "APMANP", JdeDataType.String, 2),
        new JdeField("APXDFP", "APXDFP", JdeDataType.String, 2),
        new JdeField("APMINDEP", "APMINDEP", JdeDataType.Numeric),
        new JdeField("APMXDP", "APMXDP", JdeDataType.Numeric),
        new JdeField("APSL01", "APSL01", JdeDataType.String, 2),
        new JdeField("APEECD", "APEECD", JdeDataType.String, 6),
        new JdeField("APEEFC", "APEEFC", JdeDataType.Numeric),
        new JdeField("APCATY", "APCATY", JdeDataType.String, 2),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPCPVST", "APPCPVST", JdeDataType.String, 2),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APESIGN", "APESIGN", JdeDataType.String, 32),
        new JdeField("APMUMJ", "APMUMJ", JdeDataType.Numeric),
        new JdeField("APMUMT", "APMUMT", JdeDataType.Numeric),
        new JdeField("APUPID", "APUPID", JdeDataType.String, 20),
        new JdeField("APSEQN", "APSEQN", JdeDataType.Numeric),
        new JdeField("APDEFFLG", "APDEFFLG", JdeDataType.String, 2),
        new JdeField("APPLNGRP", "APPLNGRP", JdeDataType.String, 6),
        new JdeField("APSPLDES", "APSPLDES", JdeDataType.String, 30),
        new JdeField("APDCNF", "APDCNF", JdeDataType.String, 2),
        new JdeField("APBCATCL", "APBCATCL", JdeDataType.String, 6),
        new JdeField("APSCTDES", "APSCTDES", JdeDataType.String, 30),
        new JdeField("APNPPLFL", "APNPPLFL", JdeDataType.String, 2),
        new JdeField("APNOPT", "APNOPT", JdeDataType.Numeric),
        new JdeField("APSIPG", "APSIPG", JdeDataType.String, 2),
        new JdeField("APPLTY", "APPLTY", JdeDataType.String, 4),
        new JdeField("APQLED", "APQLED", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085520W_0", "Primary Key on APEVET, APAN8, APSBGR, APPLAN, APSEQ#, APAOPT", new[] { "APEVET", "APAN8", "APSBGR", "APPLAN", "APSEQ#", "APAOPT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F085520W_2", "Index on APEVET, APAN8, APSL01", new[] { "APEVET", "APAN8", "APSL01" }),
        new JdeIndex("F085520W_3", "Index on APEVET, APAN8, APSBGR, APPLAN, APAOPT", new[] { "APEVET", "APAN8", "APSBGR", "APPLAN", "APAOPT" }),
        new JdeIndex("F085520W_4", "Index on APEVET, APAN8, APSBGR, APSL01", new[] { "APEVET", "APAN8", "APSBGR", "APSL01" }),
        new JdeIndex("F085520W_5", "Index on APEVET, APAN8, APSBGR, APPLAN, APAOPT, APSL01", new[] { "APEVET", "APAN8", "APSBGR", "APPLAN", "APAOPT", "APSL01" })
    };
}
