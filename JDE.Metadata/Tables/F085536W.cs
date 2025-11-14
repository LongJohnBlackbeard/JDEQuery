using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085536W - .
/// </summary>
public class F085536W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBEVET.
        /// </summary>
        public const string DBEVET = "DBEVET";

        /// <summary>
        /// DBAN8.
        /// </summary>
        public const string DBAN8 = "DBAN8";

        /// <summary>
        /// DBPAN8.
        /// </summary>
        public const string DBPAN8 = "DBPAN8";

        /// <summary>
        /// DBMLNM.
        /// </summary>
        public const string DBMLNM = "DBMLNM";

        /// <summary>
        /// DBDBEN.
        /// </summary>
        public const string DBDBEN = "DBDBEN";

        /// <summary>
        /// DBRELA.
        /// </summary>
        public const string DBRELA = "DBRELA";

        /// <summary>
        /// DBPLAN.
        /// </summary>
        public const string DBPLAN = "DBPLAN";

        /// <summary>
        /// DBAOPT.
        /// </summary>
        public const string DBAOPT = "DBAOPT";

        /// <summary>
        /// DBEFT.
        /// </summary>
        public const string DBEFT = "DBEFT";

        /// <summary>
        /// DBEFTE.
        /// </summary>
        public const string DBEFTE = "DBEFTE";

        /// <summary>
        /// DBEECD.
        /// </summary>
        public const string DBEECD = "DBEECD";

        /// <summary>
        /// DBEDTE.
        /// </summary>
        public const string DBEDTE = "DBEDTE";

        /// <summary>
        /// DBPCP#.
        /// </summary>
        public const string DBPCP_ = "DBPCP#";

        /// <summary>
        /// DBPERC.
        /// </summary>
        public const string DBPERC = "DBPERC";

        /// <summary>
        /// DBSECPERC.
        /// </summary>
        public const string DBSECPERC = "DBSECPERC";

        /// <summary>
        /// DBNEWPERC.
        /// </summary>
        public const string DBNEWPERC = "DBNEWPERC";

        /// <summary>
        /// DBNSECPERC.
        /// </summary>
        public const string DBNSECPERC = "DBNSECPERC";

        /// <summary>
        /// DBPCPVST.
        /// </summary>
        public const string DBPCPVST = "DBPCPVST";

        /// <summary>
        /// DBACFL.
        /// </summary>
        public const string DBACFL = "DBACFL";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBJOBN.
        /// </summary>
        public const string DBJOBN = "DBJOBN";

        /// <summary>
        /// DBUPMJ.
        /// </summary>
        public const string DBUPMJ = "DBUPMJ";

        /// <summary>
        /// DBUPMT.
        /// </summary>
        public const string DBUPMT = "DBUPMT";

        /// <summary>
        /// DBESIGN.
        /// </summary>
        public const string DBESIGN = "DBESIGN";

        /// <summary>
        /// DBMUMJ.
        /// </summary>
        public const string DBMUMJ = "DBMUMJ";

        /// <summary>
        /// DBMUMT.
        /// </summary>
        public const string DBMUMT = "DBMUMT";

        /// <summary>
        /// DBUPID.
        /// </summary>
        public const string DBUPID = "DBUPID";

        /// <summary>
        /// DBCCAI.
        /// </summary>
        public const string DBCCAI = "DBCCAI";
    }

    /// <inheritdoc />
    public override string TableName => "F085536W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBEVET", "DBEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("DBAN8", "DBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DBPAN8", "DBPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DBMLNM", "DBMLNM", JdeDataType.String, 80),
        new JdeField("DBDBEN", "DBDBEN", JdeDataType.String, 2, true, true),
        new JdeField("DBRELA", "DBRELA", JdeDataType.String, 2),
        new JdeField("DBPLAN", "DBPLAN", JdeDataType.String, 16, true, true),
        new JdeField("DBAOPT", "DBAOPT", JdeDataType.String, 6, true, true),
        new JdeField("DBEFT", "DBEFT", JdeDataType.Numeric),
        new JdeField("DBEFTE", "DBEFTE", JdeDataType.Numeric),
        new JdeField("DBEECD", "DBEECD", JdeDataType.String, 6),
        new JdeField("DBEDTE", "DBEDTE", JdeDataType.Numeric),
        new JdeField("DBPCP#", "DBPCP#", JdeDataType.String, 40),
        new JdeField("DBPERC", "DBPERC", JdeDataType.Numeric),
        new JdeField("DBSECPERC", "DBSECPERC", JdeDataType.Numeric),
        new JdeField("DBNEWPERC", "DBNEWPERC", JdeDataType.Numeric),
        new JdeField("DBNSECPERC", "DBNSECPERC", JdeDataType.Numeric),
        new JdeField("DBPCPVST", "DBPCPVST", JdeDataType.String, 2),
        new JdeField("DBACFL", "DBACFL", JdeDataType.String, 2),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBUPMT", "DBUPMT", JdeDataType.Numeric),
        new JdeField("DBESIGN", "DBESIGN", JdeDataType.String, 32),
        new JdeField("DBMUMJ", "DBMUMJ", JdeDataType.Numeric),
        new JdeField("DBMUMT", "DBMUMT", JdeDataType.Numeric),
        new JdeField("DBUPID", "DBUPID", JdeDataType.String, 20),
        new JdeField("DBCCAI", "DBCCAI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085536W_0", "Primary Key on DBEVET, DBAN8, DBPAN8, DBDBEN, DBPLAN, DBAOPT", new[] { "DBEVET", "DBAN8", "DBPAN8", "DBDBEN", "DBPLAN", "DBAOPT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F085536W_2", "Index on DBEVET, DBAN8, DBACFL", new[] { "DBEVET", "DBAN8", "DBACFL" }),
        new JdeIndex("F085536W_3", "Index on DBAN8, DBPAN8", new[] { "DBAN8", "DBPAN8" }),
        new JdeIndex("F085536W_4", "Index on DBAN8, DBPAN8, DBESIGN", new[] { "DBAN8", "DBPAN8", "DBESIGN" }),
        new JdeIndex("F085536W_5", "Index on DBPAN8, DBESIGN", new[] { "DBPAN8", "DBESIGN" })
    };
}
