using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1531 - .
/// </summary>
public class F1531 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OMEPCL.
        /// </summary>
        public const string OMEPCL = "OMEPCL";

        /// <summary>
        /// OMCLAA.
        /// </summary>
        public const string OMCLAA = "OMCLAA";

        /// <summary>
        /// OMCPC.
        /// </summary>
        public const string OMCPC = "OMCPC";

        /// <summary>
        /// OMEFTB.
        /// </summary>
        public const string OMEFTB = "OMEFTB";

        /// <summary>
        /// OMEFTE.
        /// </summary>
        public const string OMEFTE = "OMEFTE";

        /// <summary>
        /// OMDL01.
        /// </summary>
        public const string OMDL01 = "OMDL01";

        /// <summary>
        /// OMLNID.
        /// </summary>
        public const string OMLNID = "OMLNID";

        /// <summary>
        /// OMUSER.
        /// </summary>
        public const string OMUSER = "OMUSER";

        /// <summary>
        /// OMUPMJ.
        /// </summary>
        public const string OMUPMJ = "OMUPMJ";

        /// <summary>
        /// OMPID.
        /// </summary>
        public const string OMPID = "OMPID";

        /// <summary>
        /// OMJOBN.
        /// </summary>
        public const string OMJOBN = "OMJOBN";

        /// <summary>
        /// OMUPMT.
        /// </summary>
        public const string OMUPMT = "OMUPMT";

        /// <summary>
        /// OMCRCD.
        /// </summary>
        public const string OMCRCD = "OMCRCD";

        /// <summary>
        /// OMCRRM.
        /// </summary>
        public const string OMCRRM = "OMCRRM";

        /// <summary>
        /// OMEPMCU.
        /// </summary>
        public const string OMEPMCU = "OMEPMCU";

        /// <summary>
        /// OMMCUSEC.
        /// </summary>
        public const string OMMCUSEC = "OMMCUSEC";

        /// <summary>
        /// OMAJPT.
        /// </summary>
        public const string OMAJPT = "OMAJPT";

        /// <summary>
        /// OMMCU.
        /// </summary>
        public const string OMMCU = "OMMCU";

        /// <summary>
        /// OMOBJ.
        /// </summary>
        public const string OMOBJ = "OMOBJ";

        /// <summary>
        /// OMSUB.
        /// </summary>
        public const string OMSUB = "OMSUB";

        /// <summary>
        /// OMADRN.
        /// </summary>
        public const string OMADRN = "OMADRN";

        /// <summary>
        /// OMENTJ.
        /// </summary>
        public const string OMENTJ = "OMENTJ";

        /// <summary>
        /// OMTORG.
        /// </summary>
        public const string OMTORG = "OMTORG";

        /// <summary>
        /// OMURCD.
        /// </summary>
        public const string OMURCD = "OMURCD";

        /// <summary>
        /// OMURDT.
        /// </summary>
        public const string OMURDT = "OMURDT";

        /// <summary>
        /// OMURAT.
        /// </summary>
        public const string OMURAT = "OMURAT";

        /// <summary>
        /// OMURAB.
        /// </summary>
        public const string OMURAB = "OMURAB";

        /// <summary>
        /// OMURRF.
        /// </summary>
        public const string OMURRF = "OMURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F1531";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OMEPCL", "OMEPCL", JdeDataType.String, 8, true, true),
        new JdeField("OMCLAA", "OMCLAA", JdeDataType.Numeric),
        new JdeField("OMCPC", "OMCPC", JdeDataType.String, 2),
        new JdeField("OMEFTB", "OMEFTB", JdeDataType.Numeric),
        new JdeField("OMEFTE", "OMEFTE", JdeDataType.Numeric),
        new JdeField("OMDL01", "OMDL01", JdeDataType.String, 60),
        new JdeField("OMLNID", "OMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OMUSER", "OMUSER", JdeDataType.String, 20),
        new JdeField("OMUPMJ", "OMUPMJ", JdeDataType.Numeric),
        new JdeField("OMPID", "OMPID", JdeDataType.String, 20),
        new JdeField("OMJOBN", "OMJOBN", JdeDataType.String, 20),
        new JdeField("OMUPMT", "OMUPMT", JdeDataType.Numeric),
        new JdeField("OMCRCD", "OMCRCD", JdeDataType.String, 6),
        new JdeField("OMCRRM", "OMCRRM", JdeDataType.String, 2),
        new JdeField("OMEPMCU", "OMEPMCU", JdeDataType.String, 24),
        new JdeField("OMMCUSEC", "OMMCUSEC", JdeDataType.String, 24),
        new JdeField("OMAJPT", "OMAJPT", JdeDataType.Numeric),
        new JdeField("OMMCU", "OMMCU", JdeDataType.String, 24),
        new JdeField("OMOBJ", "OMOBJ", JdeDataType.String, 12),
        new JdeField("OMSUB", "OMSUB", JdeDataType.String, 16),
        new JdeField("OMADRN", "OMADRN", JdeDataType.String, 60),
        new JdeField("OMENTJ", "OMENTJ", JdeDataType.Numeric),
        new JdeField("OMTORG", "OMTORG", JdeDataType.String, 20),
        new JdeField("OMURCD", "OMURCD", JdeDataType.String, 4),
        new JdeField("OMURDT", "OMURDT", JdeDataType.Numeric),
        new JdeField("OMURAT", "OMURAT", JdeDataType.Numeric),
        new JdeField("OMURAB", "OMURAB", JdeDataType.Numeric),
        new JdeField("OMURRF", "OMURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1531_0", "Primary Key on OMEPCL, OMLNID", new[] { "OMEPCL", "OMLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1531_2", "Index on OMEPCL, OMMCU, OMOBJ, OMSUB", new[] { "OMEPCL", "OMMCU", "OMOBJ", "OMSUB" }),
        new JdeIndex("F1531_3", "Index on OMEPCL", new[] { "OMEPCL" })
    };
}
