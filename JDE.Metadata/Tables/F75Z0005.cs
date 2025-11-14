using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0005 - .
/// </summary>
public class F75Z0005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZDAN8.
        /// </summary>
        public const string ZDAN8 = "ZDAN8";

        /// <summary>
        /// ZDSSN.
        /// </summary>
        public const string ZDSSN = "ZDSSN";

        /// <summary>
        /// ZDTAXFNO.
        /// </summary>
        public const string ZDTAXFNO = "ZDTAXFNO";

        /// <summary>
        /// ZDEDTF.
        /// </summary>
        public const string ZDEDTF = "ZDEDTF";

        /// <summary>
        /// ZDEDTT.
        /// </summary>
        public const string ZDEDTT = "ZDEDTT";

        /// <summary>
        /// ZDSCLDER.
        /// </summary>
        public const string ZDSCLDER = "ZDSCLDER";

        /// <summary>
        /// ZDSCALE.
        /// </summary>
        public const string ZDSCALE = "ZDSCALE";

        /// <summary>
        /// ZDSPECTC.
        /// </summary>
        public const string ZDSPECTC = "ZDSPECTC";

        /// <summary>
        /// ZDSPECTRT.
        /// </summary>
        public const string ZDSPECTRT = "ZDSPECTRT";

        /// <summary>
        /// ZDSTDEBT.
        /// </summary>
        public const string ZDSTDEBT = "ZDSTDEBT";

        /// <summary>
        /// ZDCLDSUPF.
        /// </summary>
        public const string ZDCLDSUPF = "ZDCLDSUPF";

        /// <summary>
        /// ZDMAINJ.
        /// </summary>
        public const string ZDMAINJ = "ZDMAINJ";

        /// <summary>
        /// ZDINCLVL1.
        /// </summary>
        public const string ZDINCLVL1 = "ZDINCLVL1";

        /// <summary>
        /// ZDINCFLG1.
        /// </summary>
        public const string ZDINCFLG1 = "ZDINCFLG1";

        /// <summary>
        /// ZDINCLVL2.
        /// </summary>
        public const string ZDINCLVL2 = "ZDINCLVL2";

        /// <summary>
        /// ZDINCFLG2.
        /// </summary>
        public const string ZDINCFLG2 = "ZDINCFLG2";

        /// <summary>
        /// ZDINCLVL3.
        /// </summary>
        public const string ZDINCLVL3 = "ZDINCLVL3";

        /// <summary>
        /// ZDINCFLG3.
        /// </summary>
        public const string ZDINCFLG3 = "ZDINCFLG3";

        /// <summary>
        /// ZDHRSLVL.
        /// </summary>
        public const string ZDHRSLVL = "ZDHRSLVL";

        /// <summary>
        /// ZDHRSFLG.
        /// </summary>
        public const string ZDHRSFLG = "ZDHRSFLG";

        /// <summary>
        /// ZDWHDPAY.
        /// </summary>
        public const string ZDWHDPAY = "ZDWHDPAY";

        /// <summary>
        /// ZDEXTPAY.
        /// </summary>
        public const string ZDEXTPAY = "ZDEXTPAY";

        /// <summary>
        /// ZDSPFLG01.
        /// </summary>
        public const string ZDSPFLG01 = "ZDSPFLG01";

        /// <summary>
        /// ZDSPFLG02.
        /// </summary>
        public const string ZDSPFLG02 = "ZDSPFLG02";

        /// <summary>
        /// ZDERNPRX.
        /// </summary>
        public const string ZDERNPRX = "ZDERNPRX";

        /// <summary>
        /// ZDUPMJ.
        /// </summary>
        public const string ZDUPMJ = "ZDUPMJ";

        /// <summary>
        /// ZDUPMT.
        /// </summary>
        public const string ZDUPMT = "ZDUPMT";

        /// <summary>
        /// ZDPID.
        /// </summary>
        public const string ZDPID = "ZDPID";

        /// <summary>
        /// ZDJOBN.
        /// </summary>
        public const string ZDJOBN = "ZDJOBN";

        /// <summary>
        /// ZDUSER.
        /// </summary>
        public const string ZDUSER = "ZDUSER";

        /// <summary>
        /// ZDNZSLPO.
        /// </summary>
        public const string ZDNZSLPO = "ZDNZSLPO";

        /// <summary>
        /// ZDNZSLFAO.
        /// </summary>
        public const string ZDNZSLFAO = "ZDNZSLFAO";

        /// <summary>
        /// ZDNZSLARR.
        /// </summary>
        public const string ZDNZSLARR = "ZDNZSLARR";

        /// <summary>
        /// ZDNZSLEFD.
        /// </summary>
        public const string ZDNZSLEFD = "ZDNZSLEFD";

        /// <summary>
        /// ZDNZSLETD.
        /// </summary>
        public const string ZDNZSLETD = "ZDNZSLETD";

        /// <summary>
        /// ZDNZSLPP.
        /// </summary>
        public const string ZDNZSLPP = "ZDNZSLPP";

        /// <summary>
        /// ZDNZSLPA.
        /// </summary>
        public const string ZDNZSLPA = "ZDNZSLPA";

        /// <summary>
        /// ZDNZSLPFD.
        /// </summary>
        public const string ZDNZSLPFD = "ZDNZSLPFD";

        /// <summary>
        /// ZDNZSLPTD.
        /// </summary>
        public const string ZDNZSLPTD = "ZDNZSLPTD";

        /// <summary>
        /// ZDNZSLVP.
        /// </summary>
        public const string ZDNZSLVP = "ZDNZSLVP";

        /// <summary>
        /// ZDNZSLVA.
        /// </summary>
        public const string ZDNZSLVA = "ZDNZSLVA";

        /// <summary>
        /// ZDNZSLVFD.
        /// </summary>
        public const string ZDNZSLVFD = "ZDNZSLVFD";

        /// <summary>
        /// ZDNZSLVTD.
        /// </summary>
        public const string ZDNZSLVTD = "ZDNZSLVTD";

        /// <summary>
        /// ZDNZSLTH.
        /// </summary>
        public const string ZDNZSLTH = "ZDNZSLTH";

        /// <summary>
        /// ZDNZSLCIRT.
        /// </summary>
        public const string ZDNZSLCIRT = "ZDNZSLCIRT";

        /// <summary>
        /// ZDNZSLAD.
        /// </summary>
        public const string ZDNZSLAD = "ZDNZSLAD";

        /// <summary>
        /// ZDNZCF1.
        /// </summary>
        public const string ZDNZCF1 = "ZDNZCF1";

        /// <summary>
        /// ZDNZCF2.
        /// </summary>
        public const string ZDNZCF2 = "ZDNZCF2";

        /// <summary>
        /// ZDNZCF3.
        /// </summary>
        public const string ZDNZCF3 = "ZDNZCF3";

        /// <summary>
        /// ZDNZCF4.
        /// </summary>
        public const string ZDNZCF4 = "ZDNZCF4";

        /// <summary>
        /// ZDNZDF1.
        /// </summary>
        public const string ZDNZDF1 = "ZDNZDF1";

        /// <summary>
        /// ZDNZDF2.
        /// </summary>
        public const string ZDNZDF2 = "ZDNZDF2";

        /// <summary>
        /// ZDNZDF3.
        /// </summary>
        public const string ZDNZDF3 = "ZDNZDF3";

        /// <summary>
        /// ZDNZDF4.
        /// </summary>
        public const string ZDNZDF4 = "ZDNZDF4";

        /// <summary>
        /// ZDNZNF1.
        /// </summary>
        public const string ZDNZNF1 = "ZDNZNF1";

        /// <summary>
        /// ZDNZNF2.
        /// </summary>
        public const string ZDNZNF2 = "ZDNZNF2";

        /// <summary>
        /// ZDNZNF3.
        /// </summary>
        public const string ZDNZNF3 = "ZDNZNF3";

        /// <summary>
        /// ZDNZNF4.
        /// </summary>
        public const string ZDNZNF4 = "ZDNZNF4";

        /// <summary>
        /// ZDNZSF1.
        /// </summary>
        public const string ZDNZSF1 = "ZDNZSF1";

        /// <summary>
        /// ZDNZSF2.
        /// </summary>
        public const string ZDNZSF2 = "ZDNZSF2";

        /// <summary>
        /// ZDNZSF3.
        /// </summary>
        public const string ZDNZSF3 = "ZDNZSF3";

        /// <summary>
        /// ZDNZSF4.
        /// </summary>
        public const string ZDNZSF4 = "ZDNZSF4";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDAN8", "ZDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDSSN", "ZDSSN", JdeDataType.String, 40),
        new JdeField("ZDTAXFNO", "ZDTAXFNO", JdeDataType.String, 22),
        new JdeField("ZDEDTF", "ZDEDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDEDTT", "ZDEDTT", JdeDataType.Numeric),
        new JdeField("ZDSCLDER", "ZDSCLDER", JdeDataType.String, 6),
        new JdeField("ZDSCALE", "ZDSCALE", JdeDataType.String, 6),
        new JdeField("ZDSPECTC", "ZDSPECTC", JdeDataType.String, 2),
        new JdeField("ZDSPECTRT", "ZDSPECTRT", JdeDataType.Numeric),
        new JdeField("ZDSTDEBT", "ZDSTDEBT", JdeDataType.String, 2),
        new JdeField("ZDCLDSUPF", "ZDCLDSUPF", JdeDataType.String, 2),
        new JdeField("ZDMAINJ", "ZDMAINJ", JdeDataType.String, 2),
        new JdeField("ZDINCLVL1", "ZDINCLVL1", JdeDataType.Numeric),
        new JdeField("ZDINCFLG1", "ZDINCFLG1", JdeDataType.String, 2),
        new JdeField("ZDINCLVL2", "ZDINCLVL2", JdeDataType.Numeric),
        new JdeField("ZDINCFLG2", "ZDINCFLG2", JdeDataType.String, 2),
        new JdeField("ZDINCLVL3", "ZDINCLVL3", JdeDataType.Numeric),
        new JdeField("ZDINCFLG3", "ZDINCFLG3", JdeDataType.String, 2),
        new JdeField("ZDHRSLVL", "ZDHRSLVL", JdeDataType.Numeric),
        new JdeField("ZDHRSFLG", "ZDHRSFLG", JdeDataType.String, 2),
        new JdeField("ZDWHDPAY", "ZDWHDPAY", JdeDataType.String, 2),
        new JdeField("ZDEXTPAY", "ZDEXTPAY", JdeDataType.String, 2),
        new JdeField("ZDSPFLG01", "ZDSPFLG01", JdeDataType.String, 2),
        new JdeField("ZDSPFLG02", "ZDSPFLG02", JdeDataType.String, 2),
        new JdeField("ZDERNPRX", "ZDERNPRX", JdeDataType.String, 2),
        new JdeField("ZDUPMJ", "ZDUPMJ", JdeDataType.Numeric),
        new JdeField("ZDUPMT", "ZDUPMT", JdeDataType.Numeric),
        new JdeField("ZDPID", "ZDPID", JdeDataType.String, 20),
        new JdeField("ZDJOBN", "ZDJOBN", JdeDataType.String, 20),
        new JdeField("ZDUSER", "ZDUSER", JdeDataType.String, 20),
        new JdeField("ZDNZSLPO", "ZDNZSLPO", JdeDataType.Numeric),
        new JdeField("ZDNZSLFAO", "ZDNZSLFAO", JdeDataType.Numeric),
        new JdeField("ZDNZSLARR", "ZDNZSLARR", JdeDataType.Numeric),
        new JdeField("ZDNZSLEFD", "ZDNZSLEFD", JdeDataType.Numeric),
        new JdeField("ZDNZSLETD", "ZDNZSLETD", JdeDataType.Numeric),
        new JdeField("ZDNZSLPP", "ZDNZSLPP", JdeDataType.Numeric),
        new JdeField("ZDNZSLPA", "ZDNZSLPA", JdeDataType.Numeric),
        new JdeField("ZDNZSLPFD", "ZDNZSLPFD", JdeDataType.Numeric),
        new JdeField("ZDNZSLPTD", "ZDNZSLPTD", JdeDataType.Numeric),
        new JdeField("ZDNZSLVP", "ZDNZSLVP", JdeDataType.Numeric),
        new JdeField("ZDNZSLVA", "ZDNZSLVA", JdeDataType.Numeric),
        new JdeField("ZDNZSLVFD", "ZDNZSLVFD", JdeDataType.Numeric),
        new JdeField("ZDNZSLVTD", "ZDNZSLVTD", JdeDataType.Numeric),
        new JdeField("ZDNZSLTH", "ZDNZSLTH", JdeDataType.String, 2),
        new JdeField("ZDNZSLCIRT", "ZDNZSLCIRT", JdeDataType.String, 2),
        new JdeField("ZDNZSLAD", "ZDNZSLAD", JdeDataType.Numeric),
        new JdeField("ZDNZCF1", "ZDNZCF1", JdeDataType.String, 2),
        new JdeField("ZDNZCF2", "ZDNZCF2", JdeDataType.String, 2),
        new JdeField("ZDNZCF3", "ZDNZCF3", JdeDataType.String, 2),
        new JdeField("ZDNZCF4", "ZDNZCF4", JdeDataType.String, 2),
        new JdeField("ZDNZDF1", "ZDNZDF1", JdeDataType.Numeric),
        new JdeField("ZDNZDF2", "ZDNZDF2", JdeDataType.Numeric),
        new JdeField("ZDNZDF3", "ZDNZDF3", JdeDataType.Numeric),
        new JdeField("ZDNZDF4", "ZDNZDF4", JdeDataType.Numeric),
        new JdeField("ZDNZNF1", "ZDNZNF1", JdeDataType.Numeric),
        new JdeField("ZDNZNF2", "ZDNZNF2", JdeDataType.Numeric),
        new JdeField("ZDNZNF3", "ZDNZNF3", JdeDataType.Numeric),
        new JdeField("ZDNZNF4", "ZDNZNF4", JdeDataType.Numeric),
        new JdeField("ZDNZSF1", "ZDNZSF1", JdeDataType.String, 100),
        new JdeField("ZDNZSF2", "ZDNZSF2", JdeDataType.String, 100),
        new JdeField("ZDNZSF3", "ZDNZSF3", JdeDataType.String, 100),
        new JdeField("ZDNZSF4", "ZDNZSF4", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0005_0", "Primary Key on ZDAN8, ZDEDTF", new[] { "ZDAN8", "ZDEDTF" }, isUnique: true, isPrimaryKey: true)
    };
}
