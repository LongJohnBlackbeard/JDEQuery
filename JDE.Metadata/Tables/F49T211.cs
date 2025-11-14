using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T211 - .
/// </summary>
public class F49T211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPDOCO.
        /// </summary>
        public const string TPDOCO = "TPDOCO";

        /// <summary>
        /// TPDCTO.
        /// </summary>
        public const string TPDCTO = "TPDCTO";

        /// <summary>
        /// TPKCOO.
        /// </summary>
        public const string TPKCOO = "TPKCOO";

        /// <summary>
        /// TPLNID.
        /// </summary>
        public const string TPLNID = "TPLNID";

        /// <summary>
        /// TPOTDOMAIN.
        /// </summary>
        public const string TPOTDOMAIN = "TPOTDOMAIN";

        /// <summary>
        /// TPOTLOCDOM.
        /// </summary>
        public const string TPOTLOCDOM = "TPOTLOCDOM";

        /// <summary>
        /// TPOTITMDOM.
        /// </summary>
        public const string TPOTITMDOM = "TPOTITMDOM";

        /// <summary>
        /// TPOTMOTDOM.
        /// </summary>
        public const string TPOTMOTDOM = "TPOTMOTDOM";

        /// <summary>
        /// TPOTCARDOM.
        /// </summary>
        public const string TPOTCARDOM = "TPOTCARDOM";

        /// <summary>
        /// TPOTSTATE.
        /// </summary>
        public const string TPOTSTATE = "TPOTSTATE";

        /// <summary>
        /// TPOTBSHPN.
        /// </summary>
        public const string TPOTBSHPN = "TPOTBSHPN";

        /// <summary>
        /// TPOTSTPSEQ.
        /// </summary>
        public const string TPOTSTPSEQ = "TPOTSTPSEQ";

        /// <summary>
        /// TPOTSHPUNT.
        /// </summary>
        public const string TPOTSHPUNT = "TPOTSHPUNT";

        /// <summary>
        /// TPOTORDRLS.
        /// </summary>
        public const string TPOTORDRLS = "TPOTORDRLS";

        /// <summary>
        /// TPOTORDRLN.
        /// </summary>
        public const string TPOTORDRLN = "TPOTORDRLN";

        /// <summary>
        /// TPOTRSHUNT.
        /// </summary>
        public const string TPOTRSHUNT = "TPOTRSHUNT";

        /// <summary>
        /// TPOTORNXTN.
        /// </summary>
        public const string TPOTORNXTN = "TPOTORNXTN";

        /// <summary>
        /// TPSCAC.
        /// </summary>
        public const string TPSCAC = "TPSCAC";

        /// <summary>
        /// TPOTEQUIP.
        /// </summary>
        public const string TPOTEQUIP = "TPOTEQUIP";

        /// <summary>
        /// TPOTSSHPN.
        /// </summary>
        public const string TPOTSSHPN = "TPOTSSHPN";

        /// <summary>
        /// TPOTNEWORL.
        /// </summary>
        public const string TPOTNEWORL = "TPOTNEWORL";

        /// <summary>
        /// TPOTE1REF1.
        /// </summary>
        public const string TPOTE1REF1 = "TPOTE1REF1";

        /// <summary>
        /// TPOTE1REF2.
        /// </summary>
        public const string TPOTE1REF2 = "TPOTE1REF2";

        /// <summary>
        /// TPOTE1REF3.
        /// </summary>
        public const string TPOTE1REF3 = "TPOTE1REF3";

        /// <summary>
        /// TPOTCHAR1.
        /// </summary>
        public const string TPOTCHAR1 = "TPOTCHAR1";

        /// <summary>
        /// TPOTCHAR2.
        /// </summary>
        public const string TPOTCHAR2 = "TPOTCHAR2";

        /// <summary>
        /// TPOTCHAR3.
        /// </summary>
        public const string TPOTCHAR3 = "TPOTCHAR3";

        /// <summary>
        /// TPOTMATH1.
        /// </summary>
        public const string TPOTMATH1 = "TPOTMATH1";

        /// <summary>
        /// TPOTMATH2.
        /// </summary>
        public const string TPOTMATH2 = "TPOTMATH2";

        /// <summary>
        /// TPOTMATH3.
        /// </summary>
        public const string TPOTMATH3 = "TPOTMATH3";

        /// <summary>
        /// TPURCD.
        /// </summary>
        public const string TPURCD = "TPURCD";

        /// <summary>
        /// TPURDT.
        /// </summary>
        public const string TPURDT = "TPURDT";

        /// <summary>
        /// TPURRF.
        /// </summary>
        public const string TPURRF = "TPURRF";

        /// <summary>
        /// TPURAT.
        /// </summary>
        public const string TPURAT = "TPURAT";

        /// <summary>
        /// TPURAB.
        /// </summary>
        public const string TPURAB = "TPURAB";

        /// <summary>
        /// TPUSER.
        /// </summary>
        public const string TPUSER = "TPUSER";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";

        /// <summary>
        /// TPTORG.
        /// </summary>
        public const string TPTORG = "TPTORG";

        /// <summary>
        /// TPJOBN.
        /// </summary>
        public const string TPJOBN = "TPJOBN";

        /// <summary>
        /// TPUUPMJ.
        /// </summary>
        public const string TPUUPMJ = "TPUUPMJ";

        /// <summary>
        /// TPOTSCSTS.
        /// </summary>
        public const string TPOTSCSTS = "TPOTSCSTS";
    }

    /// <inheritdoc />
    public override string TableName => "F49T211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPDOCO", "TPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TPDCTO", "TPDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TPKCOO", "TPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TPLNID", "TPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TPOTDOMAIN", "TPOTDOMAIN", JdeDataType.String, 100),
        new JdeField("TPOTLOCDOM", "TPOTLOCDOM", JdeDataType.String, 100),
        new JdeField("TPOTITMDOM", "TPOTITMDOM", JdeDataType.String, 100),
        new JdeField("TPOTMOTDOM", "TPOTMOTDOM", JdeDataType.String, 100),
        new JdeField("TPOTCARDOM", "TPOTCARDOM", JdeDataType.String, 100),
        new JdeField("TPOTSTATE", "TPOTSTATE", JdeDataType.String, 4),
        new JdeField("TPOTBSHPN", "TPOTBSHPN", JdeDataType.String, 100),
        new JdeField("TPOTSTPSEQ", "TPOTSTPSEQ", JdeDataType.Numeric),
        new JdeField("TPOTSHPUNT", "TPOTSHPUNT", JdeDataType.String, 100),
        new JdeField("TPOTORDRLS", "TPOTORDRLS", JdeDataType.String, 100),
        new JdeField("TPOTORDRLN", "TPOTORDRLN", JdeDataType.String, 100),
        new JdeField("TPOTRSHUNT", "TPOTRSHUNT", JdeDataType.String, 100),
        new JdeField("TPOTORNXTN", "TPOTORNXTN", JdeDataType.Numeric),
        new JdeField("TPSCAC", "TPSCAC", JdeDataType.String, 8),
        new JdeField("TPOTEQUIP", "TPOTEQUIP", JdeDataType.String, 100),
        new JdeField("TPOTSSHPN", "TPOTSSHPN", JdeDataType.String, 100),
        new JdeField("TPOTNEWORL", "TPOTNEWORL", JdeDataType.String, 2),
        new JdeField("TPOTE1REF1", "TPOTE1REF1", JdeDataType.String, 100),
        new JdeField("TPOTE1REF2", "TPOTE1REF2", JdeDataType.String, 100),
        new JdeField("TPOTE1REF3", "TPOTE1REF3", JdeDataType.String, 100),
        new JdeField("TPOTCHAR1", "TPOTCHAR1", JdeDataType.String, 2),
        new JdeField("TPOTCHAR2", "TPOTCHAR2", JdeDataType.String, 2),
        new JdeField("TPOTCHAR3", "TPOTCHAR3", JdeDataType.String, 2),
        new JdeField("TPOTMATH1", "TPOTMATH1", JdeDataType.Numeric),
        new JdeField("TPOTMATH2", "TPOTMATH2", JdeDataType.Numeric),
        new JdeField("TPOTMATH3", "TPOTMATH3", JdeDataType.Numeric),
        new JdeField("TPURCD", "TPURCD", JdeDataType.String, 4),
        new JdeField("TPURDT", "TPURDT", JdeDataType.Numeric),
        new JdeField("TPURRF", "TPURRF", JdeDataType.String, 30),
        new JdeField("TPURAT", "TPURAT", JdeDataType.Numeric),
        new JdeField("TPURAB", "TPURAB", JdeDataType.Numeric),
        new JdeField("TPUSER", "TPUSER", JdeDataType.String, 20),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20),
        new JdeField("TPTORG", "TPTORG", JdeDataType.String, 20),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20),
        new JdeField("TPUUPMJ", "TPUUPMJ", JdeDataType.Date),
        new JdeField("TPOTSCSTS", "TPOTSCSTS", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T211_0", "Primary Key on TPDOCO, TPDCTO, TPKCOO, TPLNID", new[] { "TPDOCO", "TPDCTO", "TPKCOO", "TPLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T211_2", "Index on TPOTORDRLS", new[] { "TPOTORDRLS" }),
        new JdeIndex("F49T211_3", "Index on TPDOCO, TPDCTO, TPKCOO", new[] { "TPDOCO", "TPDCTO", "TPKCOO" }),
        new JdeIndex("F49T211_4", "Index on TPOTORDRLN", new[] { "TPOTORDRLN" }),
        new JdeIndex("F49T211_5", "Index on TPOTDOMAIN, TPOTBSHPN", new[] { "TPOTDOMAIN", "TPOTBSHPN" }),
        new JdeIndex("F49T211_6", "Index on TPOTBSHPN, TPOTDOMAIN, TPOTSTATE", new[] { "TPOTBSHPN", "TPOTDOMAIN", "TPOTSTATE" }),
        new JdeIndex("F49T211_7", "Index on TPOTBSHPN, TPOTORDRLS, TPOTORDRLN", new[] { "TPOTBSHPN", "TPOTORDRLS", "TPOTORDRLN" })
    };
}
