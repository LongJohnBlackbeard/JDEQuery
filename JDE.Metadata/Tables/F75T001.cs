using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T001 - .
/// </summary>
public class F75T001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSCO.
        /// </summary>
        public const string DSCO = "DSCO";

        /// <summary>
        /// DS75TDSI.
        /// </summary>
        public const string DS75TDSI = "DS75TDSI";

        /// <summary>
        /// DS75TCUN.
        /// </summary>
        public const string DS75TCUN = "DS75TCUN";

        /// <summary>
        /// DS75TTID.
        /// </summary>
        public const string DS75TTID = "DS75TTID";

        /// <summary>
        /// DS75TTDT.
        /// </summary>
        public const string DS75TTDT = "DS75TTDT";

        /// <summary>
        /// DS75TMDU.
        /// </summary>
        public const string DS75TMDU = "DS75TMDU";

        /// <summary>
        /// DS75TDBM.
        /// </summary>
        public const string DS75TDBM = "DS75TDBM";

        /// <summary>
        /// DSCNTY.
        /// </summary>
        public const string DSCNTY = "DSCNTY";

        /// <summary>
        /// DS75TMPP.
        /// </summary>
        public const string DS75TMPP = "DS75TMPP";

        /// <summary>
        /// DS75TTRM.
        /// </summary>
        public const string DS75TTRM = "DS75TTRM";

        /// <summary>
        /// DSSITO.
        /// </summary>
        public const string DSSITO = "DSSITO";

        /// <summary>
        /// DS75TYMD.
        /// </summary>
        public const string DS75TYMD = "DS75TYMD";

        /// <summary>
        /// DSALPH.
        /// </summary>
        public const string DSALPH = "DSALPH";

        /// <summary>
        /// DSMLNM.
        /// </summary>
        public const string DSMLNM = "DSMLNM";

        /// <summary>
        /// DSDS01.
        /// </summary>
        public const string DSDS01 = "DSDS01";

        /// <summary>
        /// DSAR1.
        /// </summary>
        public const string DSAR1 = "DSAR1";

        /// <summary>
        /// DSPH1.
        /// </summary>
        public const string DSPH1 = "DSPH1";

        /// <summary>
        /// DSCNT2.
        /// </summary>
        public const string DSCNT2 = "DSCNT2";

        /// <summary>
        /// DSAN8.
        /// </summary>
        public const string DSAN8 = "DSAN8";

        /// <summary>
        /// DS75TCCC.
        /// </summary>
        public const string DS75TCCC = "DS75TCCC";

        /// <summary>
        /// DSAC01.
        /// </summary>
        public const string DSAC01 = "DSAC01";

        /// <summary>
        /// DSAC02.
        /// </summary>
        public const string DSAC02 = "DSAC02";

        /// <summary>
        /// DSAC03.
        /// </summary>
        public const string DSAC03 = "DSAC03";

        /// <summary>
        /// DSAC04.
        /// </summary>
        public const string DSAC04 = "DSAC04";

        /// <summary>
        /// DSAC05.
        /// </summary>
        public const string DSAC05 = "DSAC05";

        /// <summary>
        /// DSAC06.
        /// </summary>
        public const string DSAC06 = "DSAC06";

        /// <summary>
        /// DSAC07.
        /// </summary>
        public const string DSAC07 = "DSAC07";

        /// <summary>
        /// DSAC08.
        /// </summary>
        public const string DSAC08 = "DSAC08";

        /// <summary>
        /// DSAC09.
        /// </summary>
        public const string DSAC09 = "DSAC09";

        /// <summary>
        /// DSAC10.
        /// </summary>
        public const string DSAC10 = "DSAC10";

        /// <summary>
        /// DSFBDUBE.
        /// </summary>
        public const string DSFBDUBE = "DSFBDUBE";

        /// <summary>
        /// DSFBDUBEV.
        /// </summary>
        public const string DSFBDUBEV = "DSFBDUBEV";

        /// <summary>
        /// DSFCTNM.
        /// </summary>
        public const string DSFCTNM = "DSFCTNM";

        /// <summary>
        /// DS75TLGG.
        /// </summary>
        public const string DS75TLGG = "DS75TLGG";

        /// <summary>
        /// DS75TLPG.
        /// </summary>
        public const string DS75TLPG = "DS75TLPG";

        /// <summary>
        /// DS75TLRG.
        /// </summary>
        public const string DS75TLRG = "DS75TLRG";

        /// <summary>
        /// DS75TLSG.
        /// </summary>
        public const string DS75TLSG = "DS75TLSG";

        /// <summary>
        /// DSURC1.
        /// </summary>
        public const string DSURC1 = "DSURC1";

        /// <summary>
        /// DSURDT.
        /// </summary>
        public const string DSURDT = "DSURDT";

        /// <summary>
        /// DSURAT.
        /// </summary>
        public const string DSURAT = "DSURAT";

        /// <summary>
        /// DSURAB.
        /// </summary>
        public const string DSURAB = "DSURAB";

        /// <summary>
        /// DSURRF.
        /// </summary>
        public const string DSURRF = "DSURRF";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSTDAY.
        /// </summary>
        public const string DSTDAY = "DSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSCO", "DSCO", JdeDataType.String, 10, true, true),
        new JdeField("DS75TDSI", "DS75TDSI", JdeDataType.String, 10, true, true),
        new JdeField("DS75TCUN", "DS75TCUN", JdeDataType.String, 16),
        new JdeField("DS75TTID", "DS75TTID", JdeDataType.String, 18),
        new JdeField("DS75TTDT", "DS75TTDT", JdeDataType.String, 6),
        new JdeField("DS75TMDU", "DS75TMDU", JdeDataType.String, 4),
        new JdeField("DS75TDBM", "DS75TDBM", JdeDataType.String, 2),
        new JdeField("DSCNTY", "DSCNTY", JdeDataType.String, 6),
        new JdeField("DS75TMPP", "DS75TMPP", JdeDataType.Numeric),
        new JdeField("DS75TTRM", "DS75TTRM", JdeDataType.String, 6),
        new JdeField("DSSITO", "DSSITO", JdeDataType.String, 2),
        new JdeField("DS75TYMD", "DS75TYMD", JdeDataType.Numeric),
        new JdeField("DSALPH", "DSALPH", JdeDataType.String, 80),
        new JdeField("DSMLNM", "DSMLNM", JdeDataType.String, 80),
        new JdeField("DSDS01", "DSDS01", JdeDataType.String, 160),
        new JdeField("DSAR1", "DSAR1", JdeDataType.String, 12),
        new JdeField("DSPH1", "DSPH1", JdeDataType.String, 40),
        new JdeField("DSCNT2", "DSCNT2", JdeDataType.String, 50),
        new JdeField("DSAN8", "DSAN8", JdeDataType.Numeric),
        new JdeField("DS75TCCC", "DS75TCCC", JdeDataType.String, 2),
        new JdeField("DSAC01", "DSAC01", JdeDataType.String, 6),
        new JdeField("DSAC02", "DSAC02", JdeDataType.String, 6),
        new JdeField("DSAC03", "DSAC03", JdeDataType.String, 6),
        new JdeField("DSAC04", "DSAC04", JdeDataType.String, 6),
        new JdeField("DSAC05", "DSAC05", JdeDataType.String, 6),
        new JdeField("DSAC06", "DSAC06", JdeDataType.String, 6),
        new JdeField("DSAC07", "DSAC07", JdeDataType.String, 6),
        new JdeField("DSAC08", "DSAC08", JdeDataType.String, 6),
        new JdeField("DSAC09", "DSAC09", JdeDataType.String, 6),
        new JdeField("DSAC10", "DSAC10", JdeDataType.String, 6),
        new JdeField("DSFBDUBE", "DSFBDUBE", JdeDataType.String, 20),
        new JdeField("DSFBDUBEV", "DSFBDUBEV", JdeDataType.String, 20),
        new JdeField("DSFCTNM", "DSFCTNM", JdeDataType.String, 64),
        new JdeField("DS75TLGG", "DS75TLGG", JdeDataType.String, 2),
        new JdeField("DS75TLPG", "DS75TLPG", JdeDataType.String, 2),
        new JdeField("DS75TLRG", "DS75TLRG", JdeDataType.String, 2),
        new JdeField("DS75TLSG", "DS75TLSG", JdeDataType.String, 2),
        new JdeField("DSURC1", "DSURC1", JdeDataType.String, 6),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSURAB", "DSURAB", JdeDataType.Numeric),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSTDAY", "DSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T001_0", "Primary Key on DSCO, DS75TDSI", new[] { "DSCO", "DS75TDSI" }, isUnique: true, isPrimaryKey: true)
    };
}
