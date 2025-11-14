using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09616 - .
/// </summary>
public class F09616 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GNBSTN.
        /// </summary>
        public const string GNBSTN = "GNBSTN";

        /// <summary>
        /// GNGLBA.
        /// </summary>
        public const string GNGLBA = "GNGLBA";

        /// <summary>
        /// GNSTMD.
        /// </summary>
        public const string GNSTMD = "GNSTMD";

        /// <summary>
        /// GNBKSTID.
        /// </summary>
        public const string GNBKSTID = "GNBKSTID";

        /// <summary>
        /// GNBSSEQ.
        /// </summary>
        public const string GNBSSEQ = "GNBSSEQ";

        /// <summary>
        /// GNRECCODE.
        /// </summary>
        public const string GNRECCODE = "GNRECCODE";

        /// <summary>
        /// GNDTEJ.
        /// </summary>
        public const string GNDTEJ = "GNDTEJ";

        /// <summary>
        /// GNBGBL.
        /// </summary>
        public const string GNBGBL = "GNBGBL";

        /// <summary>
        /// GNTDEB.
        /// </summary>
        public const string GNTDEB = "GNTDEB";

        /// <summary>
        /// GNTCRE.
        /// </summary>
        public const string GNTCRE = "GNTCRE";

        /// <summary>
        /// GNENBL.
        /// </summary>
        public const string GNENBL = "GNENBL";

        /// <summary>
        /// GNNTRN.
        /// </summary>
        public const string GNNTRN = "GNNTRN";

        /// <summary>
        /// GNCSTSPFLG.
        /// </summary>
        public const string GNCSTSPFLG = "GNCSTSPFLG";

        /// <summary>
        /// GNICU.
        /// </summary>
        public const string GNICU = "GNICU";

        /// <summary>
        /// GNBAN.
        /// </summary>
        public const string GNBAN = "GNBAN";

        /// <summary>
        /// GNEFI.
        /// </summary>
        public const string GNEFI = "GNEFI";

        /// <summary>
        /// GNDESC04.
        /// </summary>
        public const string GNDESC04 = "GNDESC04";

        /// <summary>
        /// GNBACRCD.
        /// </summary>
        public const string GNBACRCD = "GNBACRCD";

        /// <summary>
        /// GNCAVAA.
        /// </summary>
        public const string GNCAVAA = "GNCAVAA";

        /// <summary>
        /// GNBSODF.
        /// </summary>
        public const string GNBSODF = "GNBSODF";

        /// <summary>
        /// GNBSTDF.
        /// </summary>
        public const string GNBSTDF = "GNBSTDF";

        /// <summary>
        /// GNUSER.
        /// </summary>
        public const string GNUSER = "GNUSER";

        /// <summary>
        /// GNPID.
        /// </summary>
        public const string GNPID = "GNPID";

        /// <summary>
        /// GNJOBN.
        /// </summary>
        public const string GNJOBN = "GNJOBN";

        /// <summary>
        /// GNUPMT.
        /// </summary>
        public const string GNUPMT = "GNUPMT";

        /// <summary>
        /// GNUPMJ.
        /// </summary>
        public const string GNUPMJ = "GNUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09616";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GNBSTN", "GNBSTN", JdeDataType.Numeric),
        new JdeField("GNGLBA", "GNGLBA", JdeDataType.String, 16),
        new JdeField("GNSTMD", "GNSTMD", JdeDataType.Numeric),
        new JdeField("GNBKSTID", "GNBKSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("GNBSSEQ", "GNBSSEQ", JdeDataType.Numeric),
        new JdeField("GNRECCODE", "GNRECCODE", JdeDataType.String, 2),
        new JdeField("GNDTEJ", "GNDTEJ", JdeDataType.Numeric),
        new JdeField("GNBGBL", "GNBGBL", JdeDataType.Numeric),
        new JdeField("GNTDEB", "GNTDEB", JdeDataType.Numeric),
        new JdeField("GNTCRE", "GNTCRE", JdeDataType.Numeric),
        new JdeField("GNENBL", "GNENBL", JdeDataType.Numeric),
        new JdeField("GNNTRN", "GNNTRN", JdeDataType.Numeric),
        new JdeField("GNCSTSPFLG", "GNCSTSPFLG", JdeDataType.String, 2),
        new JdeField("GNICU", "GNICU", JdeDataType.Numeric),
        new JdeField("GNBAN", "GNBAN", JdeDataType.String, 58),
        new JdeField("GNEFI", "GNEFI", JdeDataType.String, 12),
        new JdeField("GNDESC04", "GNDESC04", JdeDataType.String, 90),
        new JdeField("GNBACRCD", "GNBACRCD", JdeDataType.String, 6),
        new JdeField("GNCAVAA", "GNCAVAA", JdeDataType.Numeric),
        new JdeField("GNBSODF", "GNBSODF", JdeDataType.Numeric),
        new JdeField("GNBSTDF", "GNBSTDF", JdeDataType.Numeric),
        new JdeField("GNUSER", "GNUSER", JdeDataType.String, 20),
        new JdeField("GNPID", "GNPID", JdeDataType.String, 20),
        new JdeField("GNJOBN", "GNJOBN", JdeDataType.String, 20),
        new JdeField("GNUPMT", "GNUPMT", JdeDataType.Numeric),
        new JdeField("GNUPMJ", "GNUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09616_0", "Primary Key on GNBKSTID", new[] { "GNBKSTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09616_2", "Unique Index on GNBSTN, GNGLBA, SYS_NC00027$", new[] { "GNBSTN", "GNGLBA", "SYS_NC00027$" }, isUnique: true),
        new JdeIndex("F09616_3", "Index on GNGLBA, SYS_NC00027$", new[] { "GNGLBA", "SYS_NC00027$" }),
        new JdeIndex("F09616_4", "Index on GNRECCODE, GNBSTN, GNGLBA, GNSTMD", new[] { "GNRECCODE", "GNBSTN", "GNGLBA", "GNSTMD" })
    };
}
