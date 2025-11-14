using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07107 - .
/// </summary>
public class F07107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JWAN8.
        /// </summary>
        public const string JWAN8 = "JWAN8";

        /// <summary>
        /// JWPDBA.
        /// </summary>
        public const string JWPDBA = "JWPDBA";

        /// <summary>
        /// JWWANO.
        /// </summary>
        public const string JWWANO = "JWWANO";

        /// <summary>
        /// JWSSN.
        /// </summary>
        public const string JWSSN = "JWSSN";

        /// <summary>
        /// JWWATY.
        /// </summary>
        public const string JWWATY = "JWWATY";

        /// <summary>
        /// JWWAP1.
        /// </summary>
        public const string JWWAP1 = "JWWAP1";

        /// <summary>
        /// JWWAP2.
        /// </summary>
        public const string JWWAP2 = "JWWAP2";

        /// <summary>
        /// JWWAFC.
        /// </summary>
        public const string JWWAFC = "JWWAFC";

        /// <summary>
        /// JWWAAL.
        /// </summary>
        public const string JWWAAL = "JWWAAL";

        /// <summary>
        /// JWWAAP.
        /// </summary>
        public const string JWWAAP = "JWWAAP";

        /// <summary>
        /// JWOAN8.
        /// </summary>
        public const string JWOAN8 = "JWOAN8";

        /// <summary>
        /// JWWADC.
        /// </summary>
        public const string JWWADC = "JWWADC";

        /// <summary>
        /// JWWAAA.
        /// </summary>
        public const string JWWAAA = "JWWAAA";

        /// <summary>
        /// JWTARA.
        /// </summary>
        public const string JWTARA = "JWTARA";

        /// <summary>
        /// JWRMK.
        /// </summary>
        public const string JWRMK = "JWRMK";

        /// <summary>
        /// JWHMCO.
        /// </summary>
        public const string JWHMCO = "JWHMCO";

        /// <summary>
        /// JWPTCP.
        /// </summary>
        public const string JWPTCP = "JWPTCP";

        /// <summary>
        /// JWWAPA.
        /// </summary>
        public const string JWWAPA = "JWWAPA";

        /// <summary>
        /// JWWAFN.
        /// </summary>
        public const string JWWAFN = "JWWAFN";

        /// <summary>
        /// JWWACN.
        /// </summary>
        public const string JWWACN = "JWWACN";

        /// <summary>
        /// JWWACD.
        /// </summary>
        public const string JWWACD = "JWWACD";

        /// <summary>
        /// JWWAAM.
        /// </summary>
        public const string JWWAAM = "JWWAAM";

        /// <summary>
        /// JWWASA.
        /// </summary>
        public const string JWWASA = "JWWASA";

        /// <summary>
        /// JWWASF.
        /// </summary>
        public const string JWWASF = "JWWASF";

        /// <summary>
        /// JWPFRQ.
        /// </summary>
        public const string JWPFRQ = "JWPFRQ";

        /// <summary>
        /// JWDGRP.
        /// </summary>
        public const string JWDGRP = "JWDGRP";

        /// <summary>
        /// JWWACM.
        /// </summary>
        public const string JWWACM = "JWWACM";

        /// <summary>
        /// JWWAEX.
        /// </summary>
        public const string JWWAEX = "JWWAEX";

        /// <summary>
        /// JWWAMW.
        /// </summary>
        public const string JWWAMW = "JWWAMW";

        /// <summary>
        /// JWWAPF.
        /// </summary>
        public const string JWWAPF = "JWWAPF";

        /// <summary>
        /// JWANN8.
        /// </summary>
        public const string JWANN8 = "JWANN8";

        /// <summary>
        /// JWPAN8.
        /// </summary>
        public const string JWPAN8 = "JWPAN8";

        /// <summary>
        /// JWAD.
        /// </summary>
        public const string JWAD = "JWAD";

        /// <summary>
        /// JWNP.
        /// </summary>
        public const string JWNP = "JWNP";

        /// <summary>
        /// JWWAMS.
        /// </summary>
        public const string JWWAMS = "JWWAMS";

        /// <summary>
        /// JWWADF.
        /// </summary>
        public const string JWWADF = "JWWADF";

        /// <summary>
        /// JWWADR.
        /// </summary>
        public const string JWWADR = "JWWADR";

        /// <summary>
        /// JWARRA.
        /// </summary>
        public const string JWARRA = "JWARRA";

        /// <summary>
        /// JWBAD.
        /// </summary>
        public const string JWBAD = "JWBAD";

        /// <summary>
        /// JWWAMA.
        /// </summary>
        public const string JWWAMA = "JWWAMA";

        /// <summary>
        /// JWWAFD.
        /// </summary>
        public const string JWWAFD = "JWWAFD";

        /// <summary>
        /// JWWATD.
        /// </summary>
        public const string JWWATD = "JWWATD";

        /// <summary>
        /// JWWAPN.
        /// </summary>
        public const string JWWAPN = "JWWAPN";

        /// <summary>
        /// JWWADM.
        /// </summary>
        public const string JWWADM = "JWWADM";

        /// <summary>
        /// JWWAIA.
        /// </summary>
        public const string JWWAIA = "JWWAIA";

        /// <summary>
        /// JWWAIN.
        /// </summary>
        public const string JWWAIN = "JWWAIN";

        /// <summary>
        /// JWWALF.
        /// </summary>
        public const string JWWALF = "JWWALF";

        /// <summary>
        /// JWWAEF.
        /// </summary>
        public const string JWWAEF = "JWWAEF";

        /// <summary>
        /// JWWAAF.
        /// </summary>
        public const string JWWAAF = "JWWAAF";

        /// <summary>
        /// JWWAMF.
        /// </summary>
        public const string JWWAMF = "JWWAMF";

        /// <summary>
        /// JWWAOC.
        /// </summary>
        public const string JWWAOC = "JWWAOC";

        /// <summary>
        /// JWWACF.
        /// </summary>
        public const string JWWACF = "JWWACF";

        /// <summary>
        /// JWWAPI.
        /// </summary>
        public const string JWWAPI = "JWWAPI";

        /// <summary>
        /// JWWAWA.
        /// </summary>
        public const string JWWAWA = "JWWAWA";

        /// <summary>
        /// JWWAAO.
        /// </summary>
        public const string JWWAAO = "JWWAAO";

        /// <summary>
        /// JWDESQ.
        /// </summary>
        public const string JWDESQ = "JWDESQ";

        /// <summary>
        /// JWUSER.
        /// </summary>
        public const string JWUSER = "JWUSER";

        /// <summary>
        /// JWPID.
        /// </summary>
        public const string JWPID = "JWPID";

        /// <summary>
        /// JWUPMJ.
        /// </summary>
        public const string JWUPMJ = "JWUPMJ";

        /// <summary>
        /// JWUPMT.
        /// </summary>
        public const string JWUPMT = "JWUPMT";

        /// <summary>
        /// JWJOBN.
        /// </summary>
        public const string JWJOBN = "JWJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F07107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JWAN8", "JWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JWPDBA", "JWPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JWWANO", "JWWANO", JdeDataType.Numeric, null, true, true),
        new JdeField("JWSSN", "JWSSN", JdeDataType.String, 40),
        new JdeField("JWWATY", "JWWATY", JdeDataType.String, 2),
        new JdeField("JWWAP1", "JWWAP1", JdeDataType.Numeric),
        new JdeField("JWWAP2", "JWWAP2", JdeDataType.Numeric),
        new JdeField("JWWAFC", "JWWAFC", JdeDataType.String, 2),
        new JdeField("JWWAAL", "JWWAAL", JdeDataType.Numeric),
        new JdeField("JWWAAP", "JWWAAP", JdeDataType.Numeric),
        new JdeField("JWOAN8", "JWOAN8", JdeDataType.Numeric),
        new JdeField("JWWADC", "JWWADC", JdeDataType.Numeric),
        new JdeField("JWWAAA", "JWWAAA", JdeDataType.Numeric),
        new JdeField("JWTARA", "JWTARA", JdeDataType.String, 20),
        new JdeField("JWRMK", "JWRMK", JdeDataType.String, 60),
        new JdeField("JWHMCO", "JWHMCO", JdeDataType.String, 10),
        new JdeField("JWPTCP", "JWPTCP", JdeDataType.String, 4),
        new JdeField("JWWAPA", "JWWAPA", JdeDataType.Numeric),
        new JdeField("JWWAFN", "JWWAFN", JdeDataType.String, 60),
        new JdeField("JWWACN", "JWWACN", JdeDataType.String, 60),
        new JdeField("JWWACD", "JWWACD", JdeDataType.Numeric),
        new JdeField("JWWAAM", "JWWAAM", JdeDataType.Numeric),
        new JdeField("JWWASA", "JWWASA", JdeDataType.Numeric),
        new JdeField("JWWASF", "JWWASF", JdeDataType.String, 2),
        new JdeField("JWPFRQ", "JWPFRQ", JdeDataType.String, 2),
        new JdeField("JWDGRP", "JWDGRP", JdeDataType.String, 4),
        new JdeField("JWWACM", "JWWACM", JdeDataType.String, 2),
        new JdeField("JWWAEX", "JWWAEX", JdeDataType.Numeric),
        new JdeField("JWWAMW", "JWWAMW", JdeDataType.Numeric),
        new JdeField("JWWAPF", "JWWAPF", JdeDataType.String, 2),
        new JdeField("JWANN8", "JWANN8", JdeDataType.Numeric),
        new JdeField("JWPAN8", "JWPAN8", JdeDataType.Numeric),
        new JdeField("JWAD", "JWAD", JdeDataType.Numeric),
        new JdeField("JWNP", "JWNP", JdeDataType.Numeric),
        new JdeField("JWWAMS", "JWWAMS", JdeDataType.String, 2),
        new JdeField("JWWADF", "JWWADF", JdeDataType.String, 2),
        new JdeField("JWWADR", "JWWADR", JdeDataType.Numeric),
        new JdeField("JWARRA", "JWARRA", JdeDataType.Numeric),
        new JdeField("JWBAD", "JWBAD", JdeDataType.Numeric),
        new JdeField("JWWAMA", "JWWAMA", JdeDataType.Numeric),
        new JdeField("JWWAFD", "JWWAFD", JdeDataType.Numeric),
        new JdeField("JWWATD", "JWWATD", JdeDataType.Numeric),
        new JdeField("JWWAPN", "JWWAPN", JdeDataType.Numeric),
        new JdeField("JWWADM", "JWWADM", JdeDataType.String, 2),
        new JdeField("JWWAIA", "JWWAIA", JdeDataType.Numeric),
        new JdeField("JWWAIN", "JWWAIN", JdeDataType.Numeric),
        new JdeField("JWWALF", "JWWALF", JdeDataType.Numeric),
        new JdeField("JWWAEF", "JWWAEF", JdeDataType.Numeric),
        new JdeField("JWWAAF", "JWWAAF", JdeDataType.Numeric),
        new JdeField("JWWAMF", "JWWAMF", JdeDataType.Numeric),
        new JdeField("JWWAOC", "JWWAOC", JdeDataType.Numeric),
        new JdeField("JWWACF", "JWWACF", JdeDataType.Numeric),
        new JdeField("JWWAPI", "JWWAPI", JdeDataType.Numeric),
        new JdeField("JWWAWA", "JWWAWA", JdeDataType.Numeric),
        new JdeField("JWWAAO", "JWWAAO", JdeDataType.Numeric),
        new JdeField("JWDESQ", "JWDESQ", JdeDataType.String, 2),
        new JdeField("JWUSER", "JWUSER", JdeDataType.String, 20),
        new JdeField("JWPID", "JWPID", JdeDataType.String, 20),
        new JdeField("JWUPMJ", "JWUPMJ", JdeDataType.Numeric),
        new JdeField("JWUPMT", "JWUPMT", JdeDataType.Numeric),
        new JdeField("JWJOBN", "JWJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07107_0", "Primary Key on JWAN8, JWPDBA, JWWANO", new[] { "JWAN8", "JWPDBA", "JWWANO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07107_2", "Index on JWWANO", new[] { "JWWANO" })
    };
}
