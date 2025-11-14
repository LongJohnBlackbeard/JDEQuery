using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09310 - .
/// </summary>
public class F09310 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSRSTN.
        /// </summary>
        public const string RSRSTN = "RSRSTN";

        /// <summary>
        /// RSRSTD.
        /// </summary>
        public const string RSRSTD = "RSRSTD";

        /// <summary>
        /// RSRSTTY.
        /// </summary>
        public const string RSRSTTY = "RSRSTTY";

        /// <summary>
        /// RSGRPL1.
        /// </summary>
        public const string RSGRPL1 = "RSGRPL1";

        /// <summary>
        /// RSGRPLTB1.
        /// </summary>
        public const string RSGRPLTB1 = "RSGRPLTB1";

        /// <summary>
        /// RSGRPLDF1.
        /// </summary>
        public const string RSGRPLDF1 = "RSGRPLDF1";

        /// <summary>
        /// RSGRPL2.
        /// </summary>
        public const string RSGRPL2 = "RSGRPL2";

        /// <summary>
        /// RSGRPLTB2.
        /// </summary>
        public const string RSGRPLTB2 = "RSGRPLTB2";

        /// <summary>
        /// RSGRPLDF2.
        /// </summary>
        public const string RSGRPLDF2 = "RSGRPLDF2";

        /// <summary>
        /// RSGRPL3.
        /// </summary>
        public const string RSGRPL3 = "RSGRPL3";

        /// <summary>
        /// RSGRPLTB3.
        /// </summary>
        public const string RSGRPLTB3 = "RSGRPLTB3";

        /// <summary>
        /// RSGRPLDF3.
        /// </summary>
        public const string RSGRPLDF3 = "RSGRPLDF3";

        /// <summary>
        /// RSGRPL4.
        /// </summary>
        public const string RSGRPL4 = "RSGRPL4";

        /// <summary>
        /// RSGRPLTB4.
        /// </summary>
        public const string RSGRPLTB4 = "RSGRPLTB4";

        /// <summary>
        /// RSGRPLDF4.
        /// </summary>
        public const string RSGRPLDF4 = "RSGRPLDF4";

        /// <summary>
        /// RSGRPL5.
        /// </summary>
        public const string RSGRPL5 = "RSGRPL5";

        /// <summary>
        /// RSGRPLTB5.
        /// </summary>
        public const string RSGRPLTB5 = "RSGRPLTB5";

        /// <summary>
        /// RSGRPLDF5.
        /// </summary>
        public const string RSGRPLDF5 = "RSGRPLDF5";

        /// <summary>
        /// RSGRPL6.
        /// </summary>
        public const string RSGRPL6 = "RSGRPL6";

        /// <summary>
        /// RSGRPLTB6.
        /// </summary>
        public const string RSGRPLTB6 = "RSGRPLTB6";

        /// <summary>
        /// RSGRPLDF6.
        /// </summary>
        public const string RSGRPLDF6 = "RSGRPLDF6";

        /// <summary>
        /// RSGRPL7.
        /// </summary>
        public const string RSGRPL7 = "RSGRPL7";

        /// <summary>
        /// RSGRPLTB7.
        /// </summary>
        public const string RSGRPLTB7 = "RSGRPLTB7";

        /// <summary>
        /// RSGRPLDF7.
        /// </summary>
        public const string RSGRPLDF7 = "RSGRPLDF7";

        /// <summary>
        /// RSGRPL8.
        /// </summary>
        public const string RSGRPL8 = "RSGRPL8";

        /// <summary>
        /// RSGRPLTB8.
        /// </summary>
        public const string RSGRPLTB8 = "RSGRPLTB8";

        /// <summary>
        /// RSGRPLDF8.
        /// </summary>
        public const string RSGRPLDF8 = "RSGRPLDF8";

        /// <summary>
        /// RSGRPL9.
        /// </summary>
        public const string RSGRPL9 = "RSGRPL9";

        /// <summary>
        /// RSGRPLTB9.
        /// </summary>
        public const string RSGRPLTB9 = "RSGRPLTB9";

        /// <summary>
        /// RSGRPLDF9.
        /// </summary>
        public const string RSGRPLDF9 = "RSGRPLDF9";

        /// <summary>
        /// RSGRPL10.
        /// </summary>
        public const string RSGRPL10 = "RSGRPL10";

        /// <summary>
        /// RSGRPLTB10.
        /// </summary>
        public const string RSGRPLTB10 = "RSGRPLTB10";

        /// <summary>
        /// RSGRPLDF10.
        /// </summary>
        public const string RSGRPLDF10 = "RSGRPLDF10";

        /// <summary>
        /// RSLODR.
        /// </summary>
        public const string RSLODR = "RSLODR";

        /// <summary>
        /// RSGAIGF.
        /// </summary>
        public const string RSGAIGF = "RSGAIGF";

        /// <summary>
        /// RSCSTV.
        /// </summary>
        public const string RSCSTV = "RSCSTV";

        /// <summary>
        /// RSCNV.
        /// </summary>
        public const string RSCNV = "RSCNV";

        /// <summary>
        /// RSQRYE.
        /// </summary>
        public const string RSQRYE = "RSQRYE";

        /// <summary>
        /// RSSTMSG.
        /// </summary>
        public const string RSSTMSG = "RSSTMSG";

        /// <summary>
        /// RSFRCC1.
        /// </summary>
        public const string RSFRCC1 = "RSFRCC1";

        /// <summary>
        /// RSFRCC2.
        /// </summary>
        public const string RSFRCC2 = "RSFRCC2";

        /// <summary>
        /// RSFRCC3.
        /// </summary>
        public const string RSFRCC3 = "RSFRCC3";

        /// <summary>
        /// RSFRCC4.
        /// </summary>
        public const string RSFRCC4 = "RSFRCC4";

        /// <summary>
        /// RSFRCC5.
        /// </summary>
        public const string RSFRCC5 = "RSFRCC5";

        /// <summary>
        /// RSWOBNM.
        /// </summary>
        public const string RSWOBNM = "RSWOBNM";

        /// <summary>
        /// RSRDNU1.
        /// </summary>
        public const string RSRDNU1 = "RSRDNU1";

        /// <summary>
        /// RSRDNU2.
        /// </summary>
        public const string RSRDNU2 = "RSRDNU2";

        /// <summary>
        /// RSRDNU3.
        /// </summary>
        public const string RSRDNU3 = "RSRDNU3";

        /// <summary>
        /// RSRDST1.
        /// </summary>
        public const string RSRDST1 = "RSRDST1";

        /// <summary>
        /// RSRDST2.
        /// </summary>
        public const string RSRDST2 = "RSRDST2";

        /// <summary>
        /// RSRDST3.
        /// </summary>
        public const string RSRDST3 = "RSRDST3";

        /// <summary>
        /// RSRDCT1.
        /// </summary>
        public const string RSRDCT1 = "RSRDCT1";

        /// <summary>
        /// RSRDCT2.
        /// </summary>
        public const string RSRDCT2 = "RSRDCT2";

        /// <summary>
        /// RSRDCT3.
        /// </summary>
        public const string RSRDCT3 = "RSRDCT3";

        /// <summary>
        /// RSRDDT1.
        /// </summary>
        public const string RSRDDT1 = "RSRDDT1";

        /// <summary>
        /// RSRDDT2.
        /// </summary>
        public const string RSRDDT2 = "RSRDDT2";

        /// <summary>
        /// RSRDDT3.
        /// </summary>
        public const string RSRDDT3 = "RSRDDT3";

        /// <summary>
        /// RSCRTBY.
        /// </summary>
        public const string RSCRTBY = "RSCRTBY";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSRWCF.
        /// </summary>
        public const string RSRWCF = "RSRWCF";

        /// <summary>
        /// RSRWRSF.
        /// </summary>
        public const string RSRWRSF = "RSRWRSF";
    }

    /// <inheritdoc />
    public override string TableName => "F09310";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSRSTN", "RSRSTN", JdeDataType.String, 40, true, true),
        new JdeField("RSRSTD", "RSRSTD", JdeDataType.String, 160),
        new JdeField("RSRSTTY", "RSRSTTY", JdeDataType.String, 2),
        new JdeField("RSGRPL1", "RSGRPL1", JdeDataType.String, 20),
        new JdeField("RSGRPLTB1", "RSGRPLTB1", JdeDataType.String, 20),
        new JdeField("RSGRPLDF1", "RSGRPLDF1", JdeDataType.String, 2),
        new JdeField("RSGRPL2", "RSGRPL2", JdeDataType.String, 20),
        new JdeField("RSGRPLTB2", "RSGRPLTB2", JdeDataType.String, 20),
        new JdeField("RSGRPLDF2", "RSGRPLDF2", JdeDataType.String, 2),
        new JdeField("RSGRPL3", "RSGRPL3", JdeDataType.String, 20),
        new JdeField("RSGRPLTB3", "RSGRPLTB3", JdeDataType.String, 20),
        new JdeField("RSGRPLDF3", "RSGRPLDF3", JdeDataType.String, 2),
        new JdeField("RSGRPL4", "RSGRPL4", JdeDataType.String, 20),
        new JdeField("RSGRPLTB4", "RSGRPLTB4", JdeDataType.String, 20),
        new JdeField("RSGRPLDF4", "RSGRPLDF4", JdeDataType.String, 2),
        new JdeField("RSGRPL5", "RSGRPL5", JdeDataType.String, 20),
        new JdeField("RSGRPLTB5", "RSGRPLTB5", JdeDataType.String, 20),
        new JdeField("RSGRPLDF5", "RSGRPLDF5", JdeDataType.String, 2),
        new JdeField("RSGRPL6", "RSGRPL6", JdeDataType.String, 20),
        new JdeField("RSGRPLTB6", "RSGRPLTB6", JdeDataType.String, 20),
        new JdeField("RSGRPLDF6", "RSGRPLDF6", JdeDataType.String, 2),
        new JdeField("RSGRPL7", "RSGRPL7", JdeDataType.String, 20),
        new JdeField("RSGRPLTB7", "RSGRPLTB7", JdeDataType.String, 20),
        new JdeField("RSGRPLDF7", "RSGRPLDF7", JdeDataType.String, 2),
        new JdeField("RSGRPL8", "RSGRPL8", JdeDataType.String, 20),
        new JdeField("RSGRPLTB8", "RSGRPLTB8", JdeDataType.String, 20),
        new JdeField("RSGRPLDF8", "RSGRPLDF8", JdeDataType.String, 2),
        new JdeField("RSGRPL9", "RSGRPL9", JdeDataType.String, 20),
        new JdeField("RSGRPLTB9", "RSGRPLTB9", JdeDataType.String, 20),
        new JdeField("RSGRPLDF9", "RSGRPLDF9", JdeDataType.String, 2),
        new JdeField("RSGRPL10", "RSGRPL10", JdeDataType.String, 20),
        new JdeField("RSGRPLTB10", "RSGRPLTB10", JdeDataType.String, 20),
        new JdeField("RSGRPLDF10", "RSGRPLDF10", JdeDataType.String, 2),
        new JdeField("RSLODR", "RSLODR", JdeDataType.String, 2),
        new JdeField("RSGAIGF", "RSGAIGF", JdeDataType.String, 2),
        new JdeField("RSCSTV", "RSCSTV", JdeDataType.String, 160),
        new JdeField("RSCNV", "RSCNV", JdeDataType.Numeric),
        new JdeField("RSQRYE", "RSQRYE", JdeDataType.String, 2),
        new JdeField("RSSTMSG", "RSSTMSG", JdeDataType.String, 4),
        new JdeField("RSFRCC1", "RSFRCC1", JdeDataType.String, 20),
        new JdeField("RSFRCC2", "RSFRCC2", JdeDataType.String, 20),
        new JdeField("RSFRCC3", "RSFRCC3", JdeDataType.String, 20),
        new JdeField("RSFRCC4", "RSFRCC4", JdeDataType.String, 20),
        new JdeField("RSFRCC5", "RSFRCC5", JdeDataType.String, 20),
        new JdeField("RSWOBNM", "RSWOBNM", JdeDataType.String, 60),
        new JdeField("RSRDNU1", "RSRDNU1", JdeDataType.Numeric),
        new JdeField("RSRDNU2", "RSRDNU2", JdeDataType.Numeric),
        new JdeField("RSRDNU3", "RSRDNU3", JdeDataType.Numeric),
        new JdeField("RSRDST1", "RSRDST1", JdeDataType.String, 160),
        new JdeField("RSRDST2", "RSRDST2", JdeDataType.String, 160),
        new JdeField("RSRDST3", "RSRDST3", JdeDataType.String, 160),
        new JdeField("RSRDCT1", "RSRDCT1", JdeDataType.String, 2),
        new JdeField("RSRDCT2", "RSRDCT2", JdeDataType.String, 2),
        new JdeField("RSRDCT3", "RSRDCT3", JdeDataType.String, 2),
        new JdeField("RSRDDT1", "RSRDDT1", JdeDataType.Numeric),
        new JdeField("RSRDDT2", "RSRDDT2", JdeDataType.Numeric),
        new JdeField("RSRDDT3", "RSRDDT3", JdeDataType.Numeric),
        new JdeField("RSCRTBY", "RSCRTBY", JdeDataType.String, 20),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSRWCF", "RSRWCF", JdeDataType.String, 2),
        new JdeField("RSRWRSF", "RSRWRSF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09310_0", "Primary Key on RSRSTN", new[] { "RSRSTN" }, isUnique: true, isPrimaryKey: true)
    };
}
